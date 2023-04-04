namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class PopulationGenerator : IPopulationGenerator<SettingsChromosome>
    {
        private readonly Random _random;
        public PopulationGenerator(Random random)
        {
            _random = random;
        }

        public SettingsChromosome[] Generate(int howMany)
        {
            SettingsChromosome[] population = new SettingsChromosome[howMany];

            for (int i = 0; i < howMany; i++)
            {
                population[i] = new SettingsChromosome();
                population[i].GenerateValues(_random);
            }

            return population;
        }
    }
}
