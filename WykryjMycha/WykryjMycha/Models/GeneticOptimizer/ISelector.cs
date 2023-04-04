namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface ISelector<T> where T : IChromosome
    {
        public T[] Select(T[] specimens, int amountToTake);
    }
}
