using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class Mutator : IMutator<SettingsChromosome>
    {
        public float Probability { get; init; }

        public Mutator(float probability)
        {
            Probability = probability;
        }

        public SettingsChromosome Mutate(SettingsChromosome specimen)
        {
            throw new NotImplementedException();
        }
    }
}
