namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class Mutator : IMutator<SettingsChromosome>
    {
        private readonly Random _random;
        public float Probability { get; init; }

        public Mutator(float probability, Random random)
        {
            Probability = probability;
            _random = random;
        }

        public void Mutate(SettingsChromosome specimen)
        {
            for (int i = 0; i < Settings.NumberOfParameters; i++)
            {
                if (_random.NextSingle() < Probability)
                {
                    specimen.SetParameter(i, CalculateChanged(specimen.GetParameter(i)));
                }
            }
        }

        private float CalculateChanged(float value)
        {
            float fill;

            if (_random.NextSingle() < 0.5f)
            {
                fill = - 0.5f * _random.NextSingle() * value;
            }
            else
            {
                fill = 0.5f * _random.NextSingle() * (100f - value);
            }

            return value + fill;
        }
    }
}
