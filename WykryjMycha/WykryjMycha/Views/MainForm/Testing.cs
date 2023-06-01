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
                var msgResult = MessageBox.Show("Clear currently loaded strokes","Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                _testingController.ImportStrokes(ofdStrokes.FileName, msgResult == DialogResult.Yes);
            }
        }

        private void btnExportStrokes_Click(object sender, EventArgs e)
        {
            var result = sfdStrokes.ShowDialog();
            if (result == DialogResult.OK) _testingController.ExportStrokes(sfdStrokes.FileName);
        }

        private void btnDeleteStroke_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Do you want to delete selected stroke?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msgResult == DialogResult.Yes) _testingController.DeleteStroke();
        }
        private void btnClearStrokes_Click(object sender, EventArgs e)
        {
            var msgResult = MessageBox.Show("Do you want to delete ALL strokes?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult == DialogResult.Yes) _testingController.DeleteAllStrokes();
        }

        private void btnOptimise_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(_testingController.OptimiseParameters);
        }



        private void numMaxItertions_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMaxIterations((int)numMaxItertions.Value);
        }

        private void numPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetPopulationSize((int)numPopulationSize.Value);
        }

        private void numSelectedSize_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetSelectedSize((int)numSelectedSize.Value);
        }

        private void numMutationProbability_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMutationProbability((float)numMutationProbability.Value);
        }

        private void numTargetQuality_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetTargetQuality((float)numTargetQuality.Value);
        }
    }
}
