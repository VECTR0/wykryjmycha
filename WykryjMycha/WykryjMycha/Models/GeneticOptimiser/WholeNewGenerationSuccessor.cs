using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class WholeNewGenerationSuccessor : ISuccessor<SettingsChromosome>
    {
        private ICrosser<SettingsChromosome> _crosser;
        private IMutator<SettingsChromosome> _mutator;

        public WholeNewGenerationSuccessor(ICrosser<SettingsChromosome> crosser, IMutator<SettingsChromosome> mutator)
        {
            _crosser = crosser;
            _mutator = mutator;
        }

        public SettingsChromosome[] CreateNextGeneration(SettingsChromosome[] chosenOnes)
        {
            throw new NotImplementedException();
        }
    }
}
