using System.Numerics;

namespace WykryjMycha
{
    public class PatternMatcher
    {
        private const float MAX_SEARCH_DISTANCE = 25f;

        private readonly List<Pattern> _patterns = new List<Pattern>();
        public void AddPattern(Pattern pattern)
        {
            _patterns.Add(pattern);
        }

        public string? MatchPattern(List<Vector2> points)
        {
            var possiblePatterns = new List<Tuple<string, float>>();
            foreach (Pattern pattern in _patterns)
            {
                var simmilarity = PatternsSimmilarity(points, pattern.points);
                if (simmilarity != null) possiblePatterns.Add(new Tuple<string, float>(pattern.name, (float)simmilarity));
            }
            possiblePatterns.Sort();
            possiblePatterns.Reverse();
            if (possiblePatterns.Count == 0) return null;
            else return possiblePatterns[0].Item1;
        }

        public static float? PatternsSimmilarity(List<Vector2> unknownPatternPoints, List<Vector2> knownPatternPoints, float maxAvgDiff = MAX_SEARCH_DISTANCE)
        {
            if (unknownPatternPoints.Count != knownPatternPoints.Count) return null;
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
    }
}
