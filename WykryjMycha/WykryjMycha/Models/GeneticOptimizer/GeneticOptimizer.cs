namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class GeneticOptimizer<T> where T : IChromosome
    {
        private IPopulationGenerator<T> populationGenerator;
        private IQualityMetric<T> qualityMetric;
        private ISelector<T> selector;
        private ISuccessor<T> successor;

        public GeneticOptimizer(IPopulationGenerator<T> pg, IQualityMetric<T> qm, ISelector<T> se, ISuccessor<T> su)
        {
            populationGenerator = pg;
            qualityMetric = qm;
            selector = se;
            successor = su;
        }

        public T Run(int maxIterations, int populationAmount, int selectedAmount)
        {
            T[] population = populationGenerator.Generate(populationAmount);

            for (int i = 0; i < maxIterations; i++)
            {
                T? chosenOne = EvaluatePopulationQuality(population);
                if (chosenOne != null) return chosenOne;
                T[] selectedSpecimes = selector.Select(population, selectedAmount);
                population = successor.CreateNextGeneration(selectedSpecimes, populationAmount);
            }

            return SelectBestOne(population);
        }

        private T? EvaluatePopulationQuality(T[] population)
        {
            Parallel.ForEach(population, qualityMetric.EvaluateQuality);

            T bestOne = SelectBestOne(population);

            return bestOne.Quality >= qualityMetric.TargetQuality ? bestOne : default;
        }

        private static T SelectBestOne(T[] population)
        {
            int maxIndex = 0;

            for (int i = 1; i < population.Length; i++)
            {
                if (population[i].Quality > population[maxIndex].Quality)
                    maxIndex = i;
            }

            return population[maxIndex];
        }
    }
}
