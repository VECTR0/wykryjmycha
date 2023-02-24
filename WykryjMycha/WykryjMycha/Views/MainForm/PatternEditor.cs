using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    partial class MainForm
    {
        private PatternEditorController _patternEditorController;

        internal void RenderPattern(Pattern pattern)
        {
            DrawUtils.ClearPictureBox(picPattern);
            DrawUtils.DrawPattern(pattern.points, picPattern);
        }

        internal void ClearEditorPatternsList() => lstEditorPatterns.Items.Clear();

        internal void SetEditorPatterns(List<Pattern> patterns)
        {
            ClearEditorPatternsList();
            foreach (var pattern in patterns)
                lstEditorPatterns.Items.Add(pattern.name);
            if (lstEditorPatterns.SelectedIndex == -1) return;
            RenderPattern(patterns[lstEditorPatterns.SelectedIndex]);
        }

        private void lstEditorPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            _patternEditorController.HandleEditorPatternSelected(lstEditorPatterns.SelectedIndex);
        }

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            _patternEditorController.DeletePattern();
        }
    }
}
