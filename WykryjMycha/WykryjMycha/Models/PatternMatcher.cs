namespace WykryjMycha
{
    internal class PatternMatcher
    {
        public PatternMatchingResults MatchPattern(List<Point> points, PatternDatabase database, Settings settings)
        {
            var results = new PatternMatchingResults();
            foreach (Pattern pattern in database.GetPatterns())
            {
                var pointsCopy = new List<Point>(points);
                var patternPointsCopy = new List<Point>(pattern.points);
                var result = PatternsSimmilarity(pointsCopy, patternPointsCopy, pattern, settings);
                results.Add(result);

                if (!result.success)
                {
                    pattern.steps.Add(new Step()
                    {
                        name = result.status,
                        points = new List<Point>(points),
                        pattern = new List<Point>(pattern.points),
                    });
                }
            }
            return results;
        }

        public static float AlignPoints(List<Point> points, List<Point> pattern, float normalizedSize = 150f)
        {
            var offset = normalizedSize;
            var angle = (float)Math.Atan2(points[0].Y - offset, points[0].X - offset);
            var targetAngle = (float)Math.Atan2(pattern[0].Y - offset, pattern[0].X - offset);
            var deltaAngle = targetAngle - angle;
            MathUtils.RotatePoints(points, new Point(normalizedSize, normalizedSize), deltaAngle);
            return MathUtils.GetSmallestAbsoluteAngle(deltaAngle);
        }

        public static int NearestIndex(Point point, List<Point> other, int range = 10, int startingIndex = 0, int countToCheck = 3)
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

        public static void MergeCheck(List<Point> toMerge, List<Point> reference, int startingIndex, Settings settings)
        {
            var weights = new List<float>();
            for (int i = 0; i < toMerge.Count; i++) weights.Add(1f);
            for (int i = startingIndex; i < toMerge.Count && i - 1 < reference.Count; i++)
            {
                if (i > 0)
                {
                    var distanceToPrevious = Point.Distance(toMerge[i], reference[i - 1]);
                    var distanceToCurrent = 0f;
                    var distanceToPreviousToMerge = Point.Distance(toMerge[i], toMerge[i - 1]);
                    if (i < reference.Count) distanceToCurrent = Point.Distance(toMerge[i], reference[i]);
                    else distanceToCurrent = float.PositiveInfinity;
                    if (i == startingIndex + 1 && distanceToPrevious < distanceToCurrent && distanceToPreviousToMerge < settings.maxMergeDistance)
                    {
                        var removed = toMerge[i];
                        var removedWeight = weights[i];
                        toMerge.RemoveAt(i);
                        weights.RemoveAt(i);
                        toMerge[i - 1] = (toMerge[i - 1] * weights[i-1] + removed*removedWeight) / (removedWeight+ weights[i - 1]);
                        weights[i - 1] += removedWeight;
                        i--;
                    }
                    else if (i > startingIndex + 1)
                    {
                        return;
                    }
                }
            }
        }

        public static PatternMatchingResult PatternsSimmilarity(List<Point> points, List<Point> pattern, Pattern patternObject, Settings settings)
        {
            PatternMatchingResult result = new PatternMatchingResult(patternObject.name);
            patternObject.steps = new List<Step>()
            {
                new Step(){
                    name = "init",
                    points = new List<Point>(points),
                    pattern = new List<Point>(pattern),
                }
            };
            var initialAlignRotation = AlignPoints(points, pattern);
            patternObject.steps.Add(new Step()
            {
                name = $"align {initialAlignRotation}",
                points = new List<Point>(points),
                pattern = new List<Point>(pattern),
            });
            if (initialAlignRotation > 40 / 180f * 3.14f) return result.Fail($"initial rotation limit exceeded {initialAlignRotation}");//TODO move to settings
            result.maxTranslationDistance = 0;
            result.maxRotationAngle = 0;
            result.avgRotationAngle = 0;
            int rotations = 0;
            float sumedRotation = 0;
            for (int i = 0; i < points.Count; i++) // TODO: check last points
            {
                MergeCheck(points, pattern, i, settings);
                MergeCheck(pattern, points, i, settings);
                patternObject.steps.Add(new Step()
                {
                    name = $"{i} Merge",
                    points = new List<Point>(points),
                    pattern = new List<Point>(pattern),
                });
                if (i >= points.Count || i >= pattern.Count) return result.Fail("stroke-pattern point count mismatch");
                float distance = Point.Distance(points[i], pattern[i]);
                result.maxTranslationDistance = Math.Max(result.maxTranslationDistance, distance);
                MathUtils.TranslatePoints(points, pattern[i] - points[i]);
                patternObject.steps.Add(new Step()
                {
                    name = $"Translation",
                    points = new List<Point>(points),
                    pattern = new List<Point>(pattern),
                });
                MergeCheck(points, pattern, i + 1, settings);
                MergeCheck(pattern, points, i + 1, settings); // conditional?
                patternObject.steps.Add(new Step()
                {
                    name = $"{i + 1} Merge",
                    points = new List<Point>(points),
                    pattern = new List<Point>(pattern),
                });
                if (i + 1 < points.Count && i + 1 < pattern.Count)
                {
                    var current = points[i + 1] - points[i];
                    var target = pattern[i + 1] - points[i];
                    float angle = (float)Math.Atan2(current.Y, current.X);
                    float targetAngle = (float)Math.Atan2(target.Y, target.X);
                    float deltaAngle = targetAngle - angle;
                    float absDeltaAngle = MathUtils.GetSmallestAbsoluteAngle(deltaAngle);
                    result.maxRotationAngle = Math.Max(result.maxRotationAngle, absDeltaAngle);
                    MathUtils.RotatePoints(points, points[i], deltaAngle);
                    patternObject.steps.Add(new Step()
                    {
                        name = $"Rotation",
                        points = new List<Point>(points),
                        pattern = new List<Point>(pattern),
                    });
                    sumedRotation += absDeltaAngle;
                    result.avgRotationAngle = sumedRotation / ++rotations;
                }
            }
            if (points.Count != pattern.Count) return result.Fail("stroke-pattern point count mismatch");
            return result.Succeed();
        }
    }
}
