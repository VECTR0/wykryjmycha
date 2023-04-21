namespace WykryjMycha
{
    internal class AngleDistanceMetric : IMetric
    {
        private float angleWeight = 1f;
        private float distanceWeight = 1f;

        public float GetValue(PatternMatchingResult result)
        {
            return angleWeight * result.MaxRotationAngleNormalized + distanceWeight * result.MaxTranslationDistanceNormalized;
        }

        public void Initialize(Settings settings)
        {
            angleWeight = settings.MetricAngleWeight;
            distanceWeight = settings.MetricDistanceWeight;
        }
    }
}
