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

        private void btnImportStrokes_Click(object sender, EventArgs e)
        {
            var result = ofdStrokes.ShowDialog();
            if (result == DialogResult.OK)
            {
                DialogResult msgResult = MessageBox.Show("Clear currently loaded strokes","Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                _testingController.ImportStrokes(ofdStrokes.FileName, DialogResult == DialogResult.Yes);
            }
        }

        private void btnExportStrokes_Click(object sender, EventArgs e)
        {
            var result = sfdStrokes.ShowDialog();
            if (result == DialogResult.OK)
            {
                _testingController.ExportStrokes(sfdStrokes.FileName);
            }
        }

        private void btnDeleteStroke_Click(object sender, EventArgs e)
        {
            _testingController.DeleteStroke();
        }
        private void btnClearStrokes_Click(object sender, EventArgs e)
        {
            _testingController.DeleteAllStrokes();
        }
    }
}
