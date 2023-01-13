using System.Numerics;

namespace WykryjMycha
{
    internal static class CharacteristicPointsFinder
    {
        private const float MIN_DISTANCE = 10f;
        private const float ANGLE_LIMIT_DEG = 40f;

        internal static List<Vector2> GetCharacteristicPoints(List<Vector2> input)
        {
            Vector2 lastCharacteristicPoint = input[0];
            List<Vector2> result = new List<Vector2> { lastCharacteristicPoint };
            
            for (int i = 1; i < input.Count - 5; i++)
            {
                Vector2 a = lastCharacteristicPoint - input[i];
                Vector2 b = input[i + 5] - input[i];

                if (Vector2.Distance(lastCharacteristicPoint, input[i]) >= MIN_DISTANCE && CalculateAngle(a, b) >= ANGLE_LIMIT_DEG)
                {
                    lastCharacteristicPoint = input[i];
                    result.Add(lastCharacteristicPoint);
                }
            }

            // only if this addition would be significant, add last point
            if (Vector2.Distance(lastCharacteristicPoint, input[^1]) >= MIN_DISTANCE)
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
            return Math.Min(diff, Math.Abs(180 - diff));
        }
    }
}
