using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    partial class MainForm
    {
        private GeneticController _geneticController;

        private void btnStopGenetic_Click(object sender, EventArgs e)
        {
            _testingController.ForceStop();
        }
    }
}
