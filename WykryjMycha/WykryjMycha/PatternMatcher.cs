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
                if(simmilarity != null) possiblePatterns.Add(new Tuple<string, float>(pattern.name, (float)simmilarity));
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
    }
}
