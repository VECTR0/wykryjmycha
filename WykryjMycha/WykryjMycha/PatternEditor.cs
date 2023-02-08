using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WykryjMycha
{
    public partial class PatternEditor : Form
    {
        internal readonly MainWindow mainFormInstance;

        public PatternEditor(MainWindow mainFormInstance)
        {
            InitializeComponent();
            this.mainFormInstance = mainFormInstance;
        }

        private void lstPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedPattern();
            if(lstPatterns.SelectedIndex >= 0)SetupStepsViewer(mainFormInstance.matcher.GetPatterns()[lstPatterns.SelectedIndex]);
        }

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            int index = lstPatterns.SelectedIndex;
            lstPatterns.Items.RemoveAt(lstPatterns.SelectedIndex);
            mainFormInstance.matcher.DeletePattern(index);
        }

        private void btnSavePattern_Click(object sender, EventArgs e)
        {

        }

        public void UpdatePatternsList()
        {
            lstPatterns.Items.Clear();
            foreach (var pattern in mainFormInstance.matcher.GetPatterns())
            {
                lstPatterns.Items.Add(pattern.name);
            }
            ShowSelectedPattern();
        }

        private void ShowSelectedPattern()
        {
            ClearPictureBox(picPattern);
            if (lstPatterns.SelectedIndex == -1) return;
            DrawPattern(mainFormInstance.matcher.GetPatterns()[lstPatterns.SelectedIndex].points, picPattern);
        }

        private void DrawPattern(List<Vector2> points, PictureBox pic, float size = 10f)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            for (int i = 0; i < points.Count - 1; i++)
            {
                var current = points[i];
                var next = points[i + 1];
                g.DrawLine(Pens.Red, current.X, current.Y, next.X, next.Y);
            }
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                Brush brush = i == 0 ? Brushes.Orange : Brushes.Red;
                g.FillEllipse(brush, p.X - size / 2, p.Y - size / 2f, size, size);
            }
            pic.Invalidate();
        }
        private void ClearPictureBox(PictureBox pic)
        {
            var oldImage = pic.Image;
            pic.Image = new Bitmap(pic.Width, pic.Height);
            oldImage?.Dispose();
        }

        private void trbSteps_Scroll(object sender, EventArgs e)
        {
            if (lstPatterns.SelectedIndex == -1) return;
            var pattern = mainFormInstance.matcher.GetPatterns()[lstPatterns.SelectedIndex];
            RenderSteps(pattern, trbSteps.Value);
        }

        private void SetupStepsViewer(Pattern pattern)
        {
            if (pattern.steps == null) return;
            trbSteps.Maximum = pattern.steps.Count - 1;
            trbSteps.Minimum = 0;
            RenderSteps(pattern, trbSteps.Value);
        }

        private void RenderSteps(Pattern pattern, int step)
        {
            ClearPictureBox(picSteps);
            DrawPattern(pattern.steps[step].pattern, picSteps, 5);

            if (pattern.steps == null) return;
            using Graphics g = Graphics.FromImage(picSteps.Image);
            float size = 4f;
            var points = pattern.steps[step].points;
            g.DrawString(pattern.steps[step].name, this.Font, Brushes.Black, 0, 0);
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
    }
}
