using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternMatcher
    {
        public PatternMatchingResults MatchPattern(List<Vector2> points, PatternDatabase database, Settings settings)
        {
            var results = new PatternMatchingResults();
            foreach (Pattern pattern in database.GetPatterns())
            {
                var pointsCopy = new List<Vector2>(points);
                var patternPointsCopy = new List<Vector2>(pattern.points);
                var result = PatternsSimmilarity(pointsCopy, patternPointsCopy, pattern, settings);
                results.Add(result);

                if (!result.success)
                {
                    pattern.steps.Add(new Step()
                    {
                        name = result.status,
                        points = new List<Vector2>(points),
                        pattern = new List<Vector2>(pattern.points),
                    });
                }
            }
            return results;
        }

        public static float AlignPoints(List<Vector2> points, List<Vector2> pattern, float normalizedSize = 150f)
        {
            var offset = normalizedSize;
            var angle = (float)Math.Atan2(points[0].Y - offset, points[0].X - offset);
            var targetAngle = (float)Math.Atan2(pattern[0].Y - offset, pattern[0].X - offset);
            var deltaAngle = targetAngle - angle;
            MathUtils.RotatePoints(points, new Vector2(normalizedSize, normalizedSize), deltaAngle);
            float absDeltaAngle = (float)(Math.Abs(deltaAngle) > Math.PI ? Math.Abs(deltaAngle) - Math.PI : Math.Abs(deltaAngle));
            return absDeltaAngle;
        }

        public static int NearestIndex(Vector2 point, List<Vector2> other, int range = 10, int startingIndex = 0, int countToCheck = 3)
        {
            var index = -1;
            var smallestDistance = 99999.0;
            for (int i = startingIndex; i < other.Count; i++)
            {
                var distance = (other[i] - point).Length();
                if (distance < smallestDistance && distance < range)
                {
                    smallestDistance = distance;
                    index = i;
                }
            }

            return index;
        }

        public static void MergeCheck(List<Vector2> toMerge, List<Vector2> reference, int startingIndex, Settings settings)
        {
            for (int i = startingIndex; i < toMerge.Count && i - 1 < reference.Count; i++)
            {
                if (i > 0)
                {
                    var distanceToPrevious = Vector2.Distance(toMerge[i], reference[i - 1]);
                    var distanceToCurrent = 0f;
                    if (i < reference.Count) distanceToCurrent = Vector2.Distance(toMerge[i], reference[i]);
                    else distanceToCurrent = float.PositiveInfinity;
                    if (i == startingIndex + 1 && distanceToPrevious < distanceToCurrent && distanceToPrevious < settings.maxMergeDistance)
                    {
                        var removed = toMerge[i];
                        toMerge.RemoveAt(i);
                        toMerge[i - 1] = (toMerge[i - 1] + removed) / 2;
                        i--;
                    }
                    else if (i > startingIndex + 1)
                    {
                        return;
                    }
                }
            }
        }

        public static PatternMatchingResult PatternsSimmilarity(List<Vector2> points, List<Vector2> pattern, Pattern patternObject, Settings settings)
        {
            PatternMatchingResult result = new PatternMatchingResult(patternObject.name);
            patternObject.steps = new List<Step>()
            {
                new Step(){
                    name = "init",
                    points = new List<Vector2>(points),
                    pattern = new List<Vector2>(pattern),
                }
            };
            var initialAlignRotation = AlignPoints(points, pattern);
            patternObject.steps.Add(new Step()
            {
                name = $"align {initialAlignRotation}",
                points = new List<Vector2>(points),
                pattern = new List<Vector2>(pattern),
            });
            if (initialAlignRotation > 40 / 180f * 3.14f) return result.Fail($"initial rotation limit exceeded {initialAlignRotation}");//TODO move to settings
            result.maxTranslationDistance = 0;
            result.maxRotationAngle = 0;
            for (int i = 0; i < points.Count; i++) // TODO: check last points
            {
                MergeCheck(points, pattern, i, settings);
                MergeCheck(pattern, points, i, settings);
                patternObject.steps.Add(new Step()
                {
                    name = $"{i} Merge",
                    points = new List<Vector2>(points),
                    pattern = new List<Vector2>(pattern),
                });
                if (i >= points.Count || i >= pattern.Count) return result.Fail("stroke-pattern point count mismatch");
                float distance = Vector2.Distance(points[i], pattern[i]);
                result.maxTranslationDistance = Math.Max(result.maxTranslationDistance, distance);
                MathUtils.TranslatePoints(points, pattern[i] - points[i]);
                patternObject.steps.Add(new Step()
                {
                    name = $"Translation",
                    points = new List<Vector2>(points),
                    pattern = new List<Vector2>(pattern),
                });
                MergeCheck(points, pattern, i + 1, settings);
                MergeCheck(pattern, points, i + 1, settings); // conditional?
                patternObject.steps.Add(new Step()
                {
                    name = $"{i + 1} Merge",
                    points = new List<Vector2>(points),
                    pattern = new List<Vector2>(pattern),
                });
                if (i + 1 < points.Count && i + 1 < pattern.Count)
                {
                    var current = points[i + 1] - points[i];
                    var target = pattern[i + 1] - points[i];
                    float angle = (float)Math.Atan2(current.Y, current.X);
                    float targetAngle = (float)Math.Atan2(target.Y, target.X);
                    float deltaAngle = targetAngle - angle;
                    float absDeltaAngle = (float)(Math.Abs(deltaAngle) > Math.PI ? Math.Abs(deltaAngle) - Math.PI : Math.Abs(deltaAngle));
                    result.maxRotationAngle = Math.Max(result.maxRotationAngle, absDeltaAngle);
                    MathUtils.RotatePoints(points, points[i], deltaAngle);
                    patternObject.steps.Add(new Step()
                    {
                        name = $"Rotation",
                        points = new List<Vector2>(points),
                        pattern = new List<Vector2>(pattern),
                    });
                }
            }
            if (points.Count != pattern.Count) return result.Fail("stroke-pattern point count mismatch");
            return result.Succeed();
        }
    }
}
