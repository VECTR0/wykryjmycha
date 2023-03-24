using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class SwappingCrosser : ICrosser<SettingsChromosome>
    {
        public (SettingsChromosome, SettingsChromosome) Cross(SettingsChromosome father, SettingsChromosome mother)
        {
            throw new NotImplementedException();
        }
    }
}
