namespace WykryjMycha
{
    public class AngleMetric : IMetric
    {
        public float GetValue(PatternMatchingResult result)
        {
            return result.maxRotationAngle;
        }

        public IMetric New(Settings settings) => new AngleMetric();
    }
}
