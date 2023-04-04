namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class RouletteSelector : ISelector<SettingsChromosome>
    {
        private readonly Random _random;
        public RouletteSelector(Random random)
        {
            _random = random;
        }

        // without repetition
        public SettingsChromosome[] Select(SettingsChromosome[] specimens, int amountToTake)
        {
            List<SettingsChromosome> population = specimens.ToList();
            SettingsChromosome[] selected = new SettingsChromosome[amountToTake];

            float sumQuality = population.Sum(x => x.Quality);

            for (int i = 0; i < amountToTake; i++)
            {
                float targetAccumulatedQuality = sumQuality * _random.NextSingle();

                float currentAccumulatedQuality = 0;
                for (int j = 0; j < population.Count; j++)
                {
                    currentAccumulatedQuality += population[j].Quality;

                    if (currentAccumulatedQuality >= targetAccumulatedQuality)
                    {
                        selected[i] = population[j];
                        sumQuality -= population[j].Quality;
                        population.RemoveAt(j);
                        break;
                    }
                }
            }

            return selected;
        }
    }
}
