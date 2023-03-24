namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class PopulationGenerator : IPopulationGenerator<SettingsChromosome>
    {
        public SettingsChromosome[] Generate(int howMany)
        {
            SettingsChromosome[] population = new SettingsChromosome[howMany];
            Random random = new Random();

            for (int i = 0; i < howMany; i++)
            {
                population[i] = new SettingsChromosome();
                population[i].GenerateValues(random);
            }

            return population;
        }
    }
}
