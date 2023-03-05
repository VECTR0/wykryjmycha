using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WykryjMycha;

namespace WykryjMycha
{
    partial class MainForm
    {
        private TestingController _testingController;

        internal void SetStrokesCount(int count)
        {
            lblStrokesCount.Text = "Strokes Count: " + count;
        }

        internal void SetStrokesList(List<Stroke> strokes)
        {
            lstStrokes.Items.Clear();
            foreach (Stroke stroke in strokes)
            {
                lstStrokes.Items.Add(stroke.name);
            }
        }

        internal void RenderStroke(Stroke stroke)
        {
            DrawUtils.DrawStroke(stroke, picStroke);
        }

        internal void ClearPicStroke()
        {
            DrawUtils.ClearPictureBox(picStroke);
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            _testingController.RunTests();
        }

        private void lstStrokes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _testingController.HandleStrokeSelected(lstStrokes.SelectedIndex);
        }
    }
}
