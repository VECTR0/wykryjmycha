namespace WykryjMycha
{
    internal class AngleDistanceMetric : IMetric
    {
        private readonly float angleWeight = 1f;
        private readonly float distanceWeight = 1f;

        public AngleDistanceMetric() { }
        public AngleDistanceMetric(Settings settings)
        {
            angleWeight = settings.MetricAngleWeight;
            distanceWeight = settings.MetricDistanceWeight;
        }

        public float GetValue(PatternMatchingResult result)
        {
            return angleWeight * result.MaxRotationAngleNormalized + distanceWeight * result.MaxTranslationDistanceNormalized;
        }

        public IMetric New(Settings settings)
        { 
            return new AngleDistanceMetric(settings);
        }
    }
}
