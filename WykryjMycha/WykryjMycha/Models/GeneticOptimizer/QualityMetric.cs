namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class QualityMetric : IQualityMetric<SettingsChromosome>
    {
        private StrokeDatabase _strokeDatabase;
        private IMetric _metric;

        public float TargetQuality { get; init; }

        public QualityMetric(float targetQuality, StrokeDatabase strokeDatabase, IMetric metric)
        {
            TargetQuality = targetQuality;
            _strokeDatabase = strokeDatabase;
            _metric = metric;
        }

        public void EvaluateQuality(SettingsChromosome specimen)
        {
            specimen.Quality = StrokesBasedTester.RunHeadless(_strokeDatabase, _metric.New(specimen), specimen);
        }
    }
}
