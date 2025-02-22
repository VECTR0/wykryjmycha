﻿namespace WykryjMycha
{
    internal class AverageMetric : IMetric
    {
        public float GetValue(PatternMatchingResult result)
        {
            return result.avgRotationAngle;
        }

        public IMetric New(Settings settings) => new AverageMetric();
    }
}
