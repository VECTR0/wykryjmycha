using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class VisualiserController
    {
        internal MainForm visualiserView;
        private PatternDatabase _patternDatabase;
        private int _selectedStepPattern = -1;

        internal VisualiserController(MainForm visualiserView, PatternDatabase patternDatabase)
        {
            this.visualiserView = visualiserView;
            _patternDatabase = patternDatabase;
            visualiserView.SetStepPatterns(_patternDatabase.GetPatterns());
        }

        internal void HandleStepsScroll(int value)
        {
            if (_selectedStepPattern == -1) return;
            var pattern = _patternDatabase.GetPatterns()[_selectedStepPattern];
            visualiserView.RenderSteps(pattern, value);
        }

        internal void HandleStepPatternSelected(int index)
        {
            _selectedStepPattern = index;
            if (_selectedStepPattern >= 0)
                visualiserView.SetupTrbSteps(_patternDatabase.GetPatterns()[_selectedStepPattern]);
        }
    }
}
