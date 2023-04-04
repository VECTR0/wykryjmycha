namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class SwappingCrosser : ICrosser<SettingsChromosome>
    {
        private readonly int maxMaskValue;

        private readonly Random _random;
        public SwappingCrosser(Random random)
        {
            _random = random;
            maxMaskValue = 1 << (Settings.NumberOfParameters - 1);
        }

        public (SettingsChromosome, SettingsChromosome) Cross(SettingsChromosome father, SettingsChromosome mother)
        {
            // we skip first and last one, because we don't want to have results which are exact copies of parents
            int swappedTraitsMask = _random.Next(1, maxMaskValue);
            SettingsChromosome son = new SettingsChromosome();
            SettingsChromosome daughter = new SettingsChromosome();

            for (int i = 0; i < Settings.NumberOfParameters; i++)
            {
                if (GetBit(swappedTraitsMask, i))
                {
                    son.SetParameter(i, father.GetParameter(i));
                    daughter.SetParameter(i, mother.GetParameter(i));
                }
                else
                {
                    son.SetParameter(i, mother.GetParameter(i));
                    daughter.SetParameter(i, father.GetParameter(i));
                }
            }

            return (son, daughter);
        }

        private static bool GetBit(int mask, int bitNumber)
        {
            return (mask & (1 << bitNumber - 1)) != 0;
        }
    }
}
