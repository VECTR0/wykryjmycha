using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternEditorController
    {
        internal MainForm editorView;
        private PatternDatabase _patternDatabase;
        private int _selectedEditorPattern = -1;

        internal PatternEditorController(MainForm editorView, PatternDatabase patternDatabase)
        {
            this.editorView = editorView;
            _patternDatabase = patternDatabase;
            editorView.SetEditorPatterns(_patternDatabase.GetPatterns());
        }

        internal void HandleEditorPatternSelected(int index)
        {
            _selectedEditorPattern = index;
            editorView.RenderPattern(_patternDatabase.GetPatterns()[_selectedEditorPattern]);
        }

        internal void DeletePattern()
        {
            _patternDatabase.DeletePattern(_selectedEditorPattern);
            editorView.SetEditorPatterns(_patternDatabase.GetPatterns());
        }
    }
}
