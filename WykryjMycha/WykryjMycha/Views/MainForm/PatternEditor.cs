namespace WykryjMycha
{
    partial class MainForm
    {
        private PatternEditorController _patternEditorController;

        internal void RenderPattern(Pattern pattern, int selectedPoint)
        {
            DrawUtils.ClearPictureBox(picPattern);
            DrawUtils.DrawPattern(pattern.points, picPattern, selectedPoint);
        }

        internal void ClearEditorPatternsList() => lstEditorPatterns.Items.Clear();

        internal void SetEditorPatterns(List<Pattern> patterns)
        {
            ClearEditorPatternsList();
            foreach (var pattern in patterns)
                lstEditorPatterns.Items.Add(pattern.name);
            if (lstEditorPatterns.SelectedIndex == -1) return;
            RenderPattern(patterns[lstEditorPatterns.SelectedIndex], -1);
        }

        private void lstEditorPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            _patternEditorController.HandleEditorPatternSelected(lstEditorPatterns.SelectedIndex);
        }

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            _patternEditorController.DeletePattern();
        }

        private void picPattern_MouseDown(object sender, MouseEventArgs e)
        {
            _patternEditorController.HandleEditorMouseDown(e.X, e.Y);
        }

        private void picPattern_MouseMove(object sender, MouseEventArgs e)
        {

            _patternEditorController.HandleEditorMouseMove(e.X, e.Y);
        }

        private void picPattern_MouseUp(object sender, MouseEventArgs e)
        {
            _patternEditorController.HandleEditorMouseUp(e.X, e.Y);
        }

        private void btnExportPatterns_Click(object sender, EventArgs e)
        {
            _patternEditorController.ExportPatternDatabase();
        }

        private void btnImportPatterns_Click(object sender, EventArgs e)
        {
            _patternEditorController.ImportPatternDatabase();
        }

        internal void SetAngleWeight(decimal value)
        {
            numAngleWeight.Value = value;
        }
        internal void SetDistanceWeight(decimal value)
        {
            numDistanceWeight.Value = value;
        }

        private void btnSaveWeights_Click(object sender, EventArgs e)
        {
            _patternEditorController.AngleWeightChanged((float)numAngleWeight.Value);
            _patternEditorController.DistanceWeightChanged((float)numDistanceWeight.Value);
        }
    }
}
