namespace WykryjMycha
{
    internal class CharacteristicPointsFinder
    {
        internal static List<Point>? GetCharacteristicPoints(List<Point> input, Settings settings, float minDistance = Settings.DefaultMinCharacteriticPointsDistance, float angleLimitDeg = Settings.DefaultCharacteriticPointsAngleLimitDegrees)
        {
            if (input == null) return null;

            Point lastCharacteristicPoint = input[0];
            List<Point> result = new List<Point> { lastCharacteristicPoint };

            for (int i = 1; i < input.Count - 1; i++)
            {
                int nextIdx = i + 1;
                bool reachedTheEnd = false;
                while (Point.Distance(input[i], input[nextIdx]) < settings.referencePointMinDistance)
                {
                    if (++nextIdx >= input.Count - 1)
                    {
                        reachedTheEnd = true;
                        break;
                    }
                }
                if (reachedTheEnd) break;

                Point a = lastCharacteristicPoint - input[i];
                Point b = input[nextIdx] - input[i];

                if (Point.Distance(lastCharacteristicPoint, input[i]) >= minDistance && CalculateAngle(a, b) >= angleLimitDeg)
                {
                    lastCharacteristicPoint = input[i];
                    result.Add(lastCharacteristicPoint);
                }
            }

            // only if this addition would be significant, add last point
            if (Point.Distance(lastCharacteristicPoint, input[^1]) >= minDistance)
            {
                result.Add(input[^1]);
            }

            return result;
        }

        private static double CalculateAngle(Point a, Point b)
        {
            double theta1 = Math.Atan2(a.Y, a.X);
            double theta2 = Math.Atan2(b.Y, b.X);

            double diff = (180 / Math.PI) * Math.Abs(theta1 - theta2);
            return Math.Abs(180 - diff);
        }



        // alternative method (but not yet fully tested)
        private const float DOUGLAS_PEUCKER_EPSILON = 2f;

        //var simplifiedPoints = new List<Point>();
        //DouglasPeucker(input, DOUGLAS_PEUCKER_EPSILON, 0, input.Count - 1, ref simplifiedPoints);
        //input = simplifiedPoints;

        private static void DouglasPeucker(List<Point> points, float epsilon, int startIdx, int endIdx, ref List<Point> result)
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
