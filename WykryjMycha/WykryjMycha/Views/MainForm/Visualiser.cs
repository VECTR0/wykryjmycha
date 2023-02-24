using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    partial class MainForm
    {
        private VisualiserController _visualiserController;

        internal void ClearStepPatternsList() => lstStepPatterns.Items.Clear();
        internal void SetStepPatterns(List<Pattern> patterns)
        {
            ClearStepPatternsList();
            foreach (var pattern in patterns)
                lstStepPatterns.Items.Add(pattern.name);
            ClearPicSteps();
            if (lstStepPatterns.SelectedIndex == -1) return;
            DrawUtils.DrawPattern(patterns[lstStepPatterns.SelectedIndex].points, picSteps);
        }

        internal void ClearPicSteps() => DrawUtils.ClearPictureBox(picSteps);

        internal void RenderSteps(Pattern pattern, int step)
        {
            DrawUtils.ClearPictureBox(picSteps);
            DrawUtils.DrawPattern(pattern.steps[step].pattern, picSteps, 5);

            if (pattern.steps == null) return;
            using Graphics g = Graphics.FromImage(picSteps.Image);
            float size = 4f;
            var points = pattern.steps[step].points;
            g.DrawString(pattern.steps[step].name, Font, Brushes.Black, 0, 0);
            for (int i = 0; i < points.Count - 1; i++)
            {
                var current = points[i];
                var next = points[i + 1];
                g.DrawLine(Pens.Green, current.X, current.Y, next.X, next.Y);
            }
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                Brush brush = i == 0 ? Brushes.Cyan : Brushes.Green;
                g.FillEllipse(brush, p.X - size / 2, p.Y - size / 2f, size, size);
            }
            picSteps.Invalidate();
        }

        internal void SetupTrbSteps(Pattern pattern)
        {
            if (pattern.steps == null) return;
            trbSteps.Maximum = pattern.steps.Count - 1;
            trbSteps.Minimum = 0;
            trbSteps.Value = 0;
            RenderSteps(pattern, trbSteps.Value);
        }

        private void trbSteps_Scroll(object sender, EventArgs e)
        {
            _visualiserController.HandleStepsScroll(trbSteps.Value);
        }

        private void lstStepPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            _visualiserController.HandleStepPatternSelected(lstStepPatterns.SelectedIndex);
        }
    }
}
