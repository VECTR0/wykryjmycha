namespace WykryjMycha
{
    partial class MainForm
    {
        private SettingsController _settingsController;

        private void maxSearchDistance_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMaxSearchDistance(maxSearchDistance.Value);
        }

        private void maxAllowedRotation_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMaxAllowedRotation(maxAllowedRotation.Value);
        }

        private void maxMergeDistance_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMaxMergeDistance(maxMergeDistance.Value);
        }

        private void minDistance_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetMinDistance(minDistance.Value);
        }

        private void angleLimitDegree_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetAngleLimitDegree(angleLimitDegree.Value);
        }

        private void angleRefPointMinDist_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetAngleReferencePointMinimalDistance(angleRefPointMinDist.Value);
        }

        private void numDrawingTimeout_ValueChanged(object sender, EventArgs e)
        {
            _settingsController.SetDrawingTimeout((int)numDrawingTimeout.Value);
        }
    }
}
