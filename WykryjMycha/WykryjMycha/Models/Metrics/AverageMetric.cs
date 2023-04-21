namespace WykryjMycha
{
    internal class AverageMetric : IMetric
    {
        public float GetValue(PatternMatchingResult result)
        {
            return result.avgRotationAngle;
        }

        public void Initialize(Settings settings) { }
    }
}
