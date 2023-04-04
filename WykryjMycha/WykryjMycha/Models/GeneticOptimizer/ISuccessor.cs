namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface ISuccessor<T> where T : IChromosome
    {
        public T[] CreateNextGeneration(T[] chosenOnes, int populationAmount);
    }
}
