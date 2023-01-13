using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public class PatternMatcher
    {
        private const float MAX_SEARCH_DISTANCE = 50f;

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

        public static float? PatternsSimmilarity(List<Vector2> unknownPatternPoints, List<Vector2> knownPatternPoints, float maxSearchDistance = MAX_SEARCH_DISTANCE)
        {
            float unsimmilarity = 0;
            if (unknownPatternPoints.Count != knownPatternPoints.Count) return null;
            for (int i = 0; i < unknownPatternPoints.Count; i++)
            {
                var a = unknownPatternPoints[i];

                int closestIndex = -1;
                float closestDistance = 1E6F;
                for (int j = 0; j < knownPatternPoints.Count; j++)
                {
                    var b = knownPatternPoints[j];
                    var distance = (b - a).Length();
                    if (distance < closestDistance)
                    {
                        closestIndex = j;
                        closestDistance = distance;
                    }
                }
                unsimmilarity += closestDistance;
                if (i != closestIndex && closestDistance < maxSearchDistance) return null;
            }
            return -unsimmilarity;
        }
    }
}
