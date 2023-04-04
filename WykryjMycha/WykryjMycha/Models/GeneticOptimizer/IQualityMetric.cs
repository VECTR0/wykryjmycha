namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface IQualityMetric<T> where T : IChromosome
    {
        public void EvaluateQuality(T specimen);

        public float TargetQuality { get; init; }
    }
}
