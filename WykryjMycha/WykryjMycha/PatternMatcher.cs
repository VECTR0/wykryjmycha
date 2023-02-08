using System.Numerics;

namespace WykryjMycha
{
    public class PatternMatcher
    {
        private const float MAX_SEARCH_DISTANCE = 25f;
        private const float MAX_ALLOWED_ROTATION = 30f;

        private readonly List<Pattern> _patterns = new List<Pattern>();
        public void AddPattern(Pattern pattern)
        {
            _patterns.Add(pattern);
        }

        public void DeletePattern(int index)
        {
            if (_patterns.Count == 0 || index < 0 || index >= _patterns.Count) return;
            _patterns.RemoveAt(index);
        }

        public List<Pattern> GetPatterns()
        {
            return _patterns;
        }

        public string? MatchPattern(List<Vector2> points)
        {
            points = new List<Vector2>(points);
            var possiblePatterns = new List<Tuple<string, float>>();
            foreach (Pattern pattern in _patterns)
            {
                
                var patternPointsCopy = new List<Vector2>(pattern.points);
                //var simmilarity = PatternsSimmilarity(points, patternPointsCopy);
                var simmilarity = NewPatternsSimmilarityMethod(points, patternPointsCopy);
                if (simmilarity != null)
                {
                    possiblePatterns.Add(new Tuple<string, float>(pattern.name, (float)simmilarity));
                    System.Diagnostics.Debug.WriteLine($"Added {pattern.name} {simmilarity}");
                }
            }
            possiblePatterns.Sort(delegate (Tuple<string, float> x, Tuple<string, float> y)
            {
                return x.Item2.CompareTo(y.Item2);
            });
            if (possiblePatterns.Count == 0) return null;
            else return possiblePatterns[0].Item1;
        }

        public static float? PatternsSimmilarity(List<Vector2> unknownPatternPoints, List<Vector2> knownPatternPoints, float maxAvgDiff = MAX_SEARCH_DISTANCE)
        {
            if (unknownPatternPoints.Count != knownPatternPoints.Count) return null;
            var rotation = AlignPoints(unknownPatternPoints, knownPatternPoints);
            if (rotation > MAX_ALLOWED_ROTATION / 180f * Math.PI) return null;
            float unsimmilarity = 0;
            for (int i = 0; i < unknownPatternPoints.Count; i++)
            {
                unsimmilarity += Vector2.Distance(knownPatternPoints[i], unknownPatternPoints[i]);
            }
            unsimmilarity /= knownPatternPoints.Count;
            return unsimmilarity < maxAvgDiff ? -unsimmilarity : null;
        }

        public static Vector2 GetCentroid(List<Vector2> points)
        {
            Vector2 centroid = new Vector2();
            foreach (var vector in points)
            {
                centroid += vector;
            }
            centroid /= points.Count;
            return centroid;
        }

        public static Tuple<Vector2, Vector2> GetBoundingBox(List<Vector2> points)
        {
            var min = new Vector2(999, 999);
            var max = new Vector2(-999, -999);
            foreach (var point in points)
            {
                min = Vector2.Min(min, point);
                max = Vector2.Max(max, point);
            }
            return new Tuple<Vector2, Vector2>(min, max);
        }

        public static List<Vector2> NormalizePoints(List<Vector2> points)
        {
            var bbox = GetBoundingBox(points);
            float scale = 1f / Math.Max(bbox.Item2.X - bbox.Item1.X, bbox.Item2.Y - bbox.Item1.Y);
            scale *= 150f;
            var centroid = GetCentroid(points);
            var offset = new Vector2(150, 150);
            for (int i = 0; i < points.Count; i++)
            {
                points[i] -= centroid;
                points[i] *= scale;
                points[i] += offset;
            }
            return points;
        }

        public static float DistanceFromLine(Vector2 x, Vector2 a, Vector2 b)
        {
            var x0 = x.X;
            var y0 = x.Y;
            var x1 = a.X;
            var y1 = a.Y;
            var x2 = b.X;
            var y2 = b.Y;
            return (float)(Math.Abs((x2 - x1) * (y1 - y0) - (x1 - x0) * (y2 - y1)) /
                Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }

        public static float DistanceFromSegment(Vector2 x, Vector2 a, Vector2 b)
        {
            var ab = b - a;
            var ax = x - a;
            var proj = Vector2.Dot(ax, ab);
            var d = proj / ab.LengthSquared();
            if (d < 0) return ax.Length();
            else if (d > 0) return (b - x).Length();
            else return DistanceFromLine(x, a, b); 
        }

        public static List<Vector2> RotatePoints(List<Vector2> points, Vector2 rotationPoint, float angle)
        {
            float s = (float)Math.Sin(angle);
            float c = (float)Math.Cos(angle);
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                p.X -= rotationPoint.X;
                p.Y -= rotationPoint.Y;

                float xnew = p.X * c - p.Y * s;
                float ynew = p.X * s + p.Y * c;

                p.X = xnew + rotationPoint.X;
                p.Y = ynew + rotationPoint.Y;
                points[i] = p;
            }
            return points;
        }

        public static float AlignPoints(List<Vector2> points, List<Vector2> pattern)
        {
            var offset = 150f;
            var angle = (float)Math.Atan2(points[0].Y- offset, points[0].X - offset);
            var targetAngle = (float)Math.Atan2(pattern[0].Y - offset, pattern[0].X - offset);
            var deltaAngle = targetAngle - angle;
            RotatePoints(points, new Vector2(150,150), deltaAngle);
            float absDeltaAngle = (float)(Math.Abs(deltaAngle) > Math.PI ? Math.Abs(deltaAngle) - Math.PI : Math.Abs(deltaAngle));
            return absDeltaAngle;
        }

        public static int NearestIndex(Vector2 point, List<Vector2> other, int range = 10, int startingIndex = 0, int countToCheck = 3)
        {
            var index = -1;
            var smallestDistance = 99999.0;
            for(int i = startingIndex; i < other.Count; i++)
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

        public static void MergeCheck(List<Vector2> toMerge, List<Vector2> reference, int startingIndex)
        {
            for (int i = startingIndex; i < toMerge.Count && i < reference.Count; i++)
            {
                if (i > 0)
                {
                    var distanceToPrevious = Vector2.Distance(toMerge[i], reference[i - 1]);
                    var distanceToCurrent = Vector2.Distance(toMerge[i], reference[i]);
                    if (i > 0 && distanceToPrevious < distanceToCurrent && distanceToPrevious < 20) // TODO: add constant
                    {
                        var removed = toMerge[i];
                        toMerge.RemoveAt(i);
                        toMerge[i - 1] = (toMerge[i - 1] + removed) / 2;
                        i--;
                    }
                    else return;
                }
            }
        }

        public static void TranslatePoints(List<Vector2> points, Vector2 delta)
        {
            for(int i = 0; i < points.Count; i++)
            {
                points[i] += delta;
            }
        }

        public static float? NewPatternsSimmilarityMethod(List<Vector2> points, List<Vector2> pattern)
        {
            var initialAlignRotation = AlignPoints(points, pattern);
            if (initialAlignRotation > 40 / 180f * 3.14f) return null;
            float maxTranslationDistance = 0;
            float maxRotationAngle = 0;
            for (int i = 0; i < points.Count - 1; i++) // TODO: check last points
            {
                MergeCheck(points, pattern, i);
                MergeCheck(pattern, points, i);
                if (i > points.Count || i > pattern.Count) return null;
                float distance = Vector2.Distance(points[i], pattern[i]);
                maxTranslationDistance = Math.Max(maxTranslationDistance, distance);
                TranslatePoints(points, pattern[i] - points[i]);
                MergeCheck(points, pattern, i + 1);
                MergeCheck(pattern, points, i + 1);
                if (i + 1 >= points.Count || i + 1 >= pattern.Count) return null;
                var current = points[i + 1] - points[i];
                var target = pattern[i + 1] - points[i];
                float angle = (float)Math.Atan2(current.Y, current.X);
                float targetAngle = (float)Math.Atan2(target.Y, target.X);
                float deltaAngle = targetAngle - angle;
                float absDeltaAngle = (float)(Math.Abs(deltaAngle) > Math.PI ? Math.Abs(deltaAngle) - Math.PI : Math.Abs(deltaAngle));
                maxRotationAngle = Math.Max(maxRotationAngle, absDeltaAngle);
                RotatePoints(points, points[i], deltaAngle);
            }
            if(points.Count != pattern.Count) return null;
            return maxRotationAngle;
        }
    }
}
