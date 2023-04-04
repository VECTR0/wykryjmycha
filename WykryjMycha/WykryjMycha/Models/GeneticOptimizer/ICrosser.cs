namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface ICrosser<T> where T : IChromosome
    {
        public (T, T) Cross(T father, T mother);
    }
}
