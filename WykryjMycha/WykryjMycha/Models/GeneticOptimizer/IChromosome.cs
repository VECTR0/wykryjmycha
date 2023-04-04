namespace WykryjMycha.Models.GeneticOptimiser
{
    internal interface IChromosome
    {
        public void GenerateValues(Random random);
        public float Quality { get; set; }
    }
}
