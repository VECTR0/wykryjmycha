using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class RouletteSelector : ISelector<SettingsChromosome>
    {
        public SettingsChromosome[] Select(SettingsChromosome[] specimens, int amountToTake)
        {
            throw new NotImplementedException();
        }
    }
}
