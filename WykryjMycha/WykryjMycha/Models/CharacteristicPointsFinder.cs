using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class CharacteristicPointsFinder
    {

        internal static List<Vector2>? GetCharacteristicPoints(List<Vector2> input, float minDistance = Settings.DefaultMinCharacteriticPointsDistance, float angleLimitDeg = Settings.DefaultCharacteriticPointsAngleLimitDegrees)
        {
            if (input == null) return null;

            Vector2 lastCharacteristicPoint = input[0];
            List<Vector2> result = new List<Vector2> { lastCharacteristicPoint };

            for (int i = 1; i < input.Count - 1; i++)
            {
                int nextIdx = i + 1;
                bool reachedTheEnd = false;
                while (Vector2.Distance(input[i], input[nextIdx]) < Settings.referencePointMinDistance)
                {
                    if (++nextIdx >= input.Count - 1)
                    {
                        reachedTheEnd = true;
                        break;
                    }
                }
                if (reachedTheEnd) break;

                Vector2 a = lastCharacteristicPoint - input[i];
                Vector2 b = input[nextIdx] - input[i];

                if (Vector2.Distance(lastCharacteristicPoint, input[i]) >= minDistance && CalculateAngle(a, b) >= angleLimitDeg)
                {
                    lastCharacteristicPoint = input[i];
                    result.Add(lastCharacteristicPoint);
                }
            }

            // only if this addition would be significant, add last point
            if (Vector2.Distance(lastCharacteristicPoint, input[^1]) >= minDistance)
            {
                result.Add(input[^1]);
            }

            return result;
        }

        private static double CalculateAngle(Vector2 a, Vector2 b)
        {
            double theta1 = Math.Atan2(a.Y, a.X);
            double theta2 = Math.Atan2(b.Y, b.X);

            double diff = (180 / Math.PI) * Math.Abs(theta1 - theta2);
            return Math.Abs(180 - diff);
        }



        // alternative method (but not yet fully tested)
        private const float DOUGLAS_PEUCKER_EPSILON = 2f;

        //var simplifiedPoints = new List<Vector2>();
        //DouglasPeucker(input, DOUGLAS_PEUCKER_EPSILON, 0, input.Count - 1, ref simplifiedPoints);
        //input = simplifiedPoints;

        private static void DouglasPeucker(List<Vector2> points, float epsilon, int startIdx, int endIdx, ref List<Vector2> result)
        {
            // Add the first point only on the initial iteration
            if (result.Count == 0)
            {
                result.Add(points[startIdx]);
            }

            //Find the point with the maximum distance
            float distMax = 0f;
            int index = 0;

            for (int i = startIdx; i < endIdx - 1; i++)
            {
                float dist = MathUtils.DistanceFromLine(points[i], points[startIdx], points[endIdx]);
                if (dist > distMax)
                {
                    index = i;
                    distMax = dist;
                }
            }

            // If max distance is greater than the epsilon, recursively simplify
            if (distMax > epsilon)
            {
                DouglasPeucker(points, epsilon, startIdx, index, ref result);
                DouglasPeucker(points, epsilon, index, endIdx, ref result);
            }
            else
            {
                result.Add(points[endIdx]);
            }
        }
    }
}
