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
        }

        public void UpdatePatternsList()
        {
            visualiserView.ClearStepPatternsList();
            foreach (var pattern in _patternDatabase.GetPatterns())
            {
                 visualiserView.AddStepPattern(pattern.name);
            }
            ShowSelectedPattern();
        }

        private void SetupStepsViewer(Pattern pattern, TrackBar trb)
        {
            if (pattern.steps == null) return;
            trb.Maximum = pattern.steps.Count - 1;
            trb.Minimum = 0;
            RenderSteps(pattern, trb.Value);
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
        }
    }
}
