using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ClearDrawingBoard();
            if (lstPatterns.SelectedIndex == -1) return;
            DrawPattern(mainFormInstance.matcher.GetPatterns()[lstPatterns.SelectedIndex]);
        }

        private void DrawPattern(Pattern pattern)
        {
            using Graphics g = Graphics.FromImage(picPattern.Image);
            float size = 10f;
            for(int i = 0; i < pattern.points.Count - 1; i++)
            {
                var current = pattern.points[i];
                var next = pattern.points[i+1];
                g.DrawLine(Pens.Red, current.X, current.Y, next.X, next.Y);
            }
            for (int i = 0; i < pattern.points.Count; i++)
            {
                var p = pattern.points[i];
                Brush brush = i == 0 ? Brushes.Orange : Brushes.Red;
                g.FillEllipse(brush, p.X - size / 2, p.Y - size / 2f, size, size);
            }
            picPattern.Invalidate();
        }
        private void ClearDrawingBoard()
        {
            var oldImage = picPattern.Image;
            picPattern.Image = new Bitmap(picPattern.Width, picPattern.Height);
            oldImage?.Dispose();
        }
    }
}
