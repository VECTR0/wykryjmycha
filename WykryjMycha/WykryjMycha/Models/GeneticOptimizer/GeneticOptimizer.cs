using System.Diagnostics;

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
            CustomStopwatch stopwatch = new CustomStopwatch();
            stopwatch.Start();

            Logger.Log = "=== GENERATING NEW PARAMETERS ===";

            T[] population = populationGenerator.Generate(populationAmount);
            Logger.Log = $"Generated population in {stopwatch.MeasureAndStart()}";

            for (int i = 0; i < maxIterations; i++)
            {
                T? chosenOne = EvaluatePopulationQuality(population);
                Logger.Log = $"Evaluated quality of generation no. {i} in {stopwatch.MeasureAndStart()}";
                if (chosenOne != null) return chosenOne;
                T[] selectedSpecimes = selector.Select(population, selectedAmount);
                Logger.Log = $"Selected elite of generation no. {i} in {stopwatch.MeasureAndStart()}";
                population = successor.CreateNextGeneration(selectedSpecimes, populationAmount);
                Logger.Log = $"Created new generation - no. {i + 1} - in {stopwatch.MeasureAndStart()}";
            }

            return SelectBestOne(population);
        }

        private T? EvaluatePopulationQuality(T[] population)
        {
            Parallel.ForEach(population, qualityMetric.EvaluateQuality);

            T bestOne = SelectBestOne(population);

            Logger.Log = $"Best quality is {100 * bestOne.Quality}%";

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
