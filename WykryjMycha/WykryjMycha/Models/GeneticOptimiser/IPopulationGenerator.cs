namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface IPopulationGenerator<T> where T : IChromosome
    {
        public T[] Generate(int howMany);
    }
}
