namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class WholeNewGenerationSuccessor : ISuccessor<SettingsChromosome>
    {
        private ICrosser<SettingsChromosome> _crosser;
        private IMutator<SettingsChromosome> _mutator;
        private Random _random;

        public WholeNewGenerationSuccessor(ICrosser<SettingsChromosome> crosser, IMutator<SettingsChromosome> mutator, Random random)
        {
            _crosser = crosser;
            _mutator = mutator;
            _random = random;
        }

        public SettingsChromosome[] CreateNextGeneration(SettingsChromosome[] chosenOnes, int populationAmount)
        {
            SettingsChromosome[] children = new SettingsChromosome[populationAmount];

            for (int i = 0; i < populationAmount; i += 2)
            {
                // select parents
                int fatherIdx = _random.Next(chosenOnes.Length);
                int motherIdx = _random.Next(chosenOnes.Length);

                while (fatherIdx == motherIdx)
                {
                    motherIdx = _random.Next(chosenOnes.Length);
                }

                // crossing the parents
                (children[i], children[(i + 1) % populationAmount]) = _crosser.Cross(chosenOnes[fatherIdx], chosenOnes[motherIdx]);

                // try to mutate (but it wont always happen)
                _mutator.Mutate(children[i]);
                _mutator.Mutate(children[(i + 1) % populationAmount]);
            }

            return children;
        }
    }
}
