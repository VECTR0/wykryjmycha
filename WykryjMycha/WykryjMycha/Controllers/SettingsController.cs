namespace WykryjMycha
{
    internal class SettingsController
    {
        internal MainForm settingsView;
        private Settings _settings;

        internal SettingsController(MainForm instance, Settings settings)
        {
            this.settingsView = instance;
            this._settings = settings;
        }

        internal void Initialize(NumericUpDown maxSearchDistance, NumericUpDown maxAllowedRotation, NumericUpDown maxMergeDistance, NumericUpDown minCharacteriticPointsDistance, NumericUpDown characteriticPointsAngleLimitDegrees, NumericUpDown referencePointMinDistance, NumericUpDown numDrawingTimeout)
        {
            maxSearchDistance.Value = (decimal)Settings.DefaultMaxSearchDistance;
            maxAllowedRotation.Value = (decimal)Settings.DefaultMaxAllowedRotation;
            maxMergeDistance.Value = (decimal)Settings.DefaultMaxMergeDistance;
            minCharacteriticPointsDistance.Value = (decimal)Settings.DefaultMinCharacteriticPointsDistance;
            characteriticPointsAngleLimitDegrees.Value = (decimal)Settings.DefaultCharacteriticPointsAngleLimitDegrees;
            referencePointMinDistance.Value = (decimal)Settings.DefaultReferencePointMinDistance;
            numDrawingTimeout.Value = Settings.DefaultDrawingTimeout;
        }

        internal void SetMaxSearchDistance(decimal value)
        {
            _settings.MaxSearchDistance = (float)value;
        }

        internal void SetMaxAllowedRotation(decimal value)
        {
            _settings.MaxAllowedRotation = (float)value;
        }

        internal void SetMaxMergeDistance(decimal value)
        {
            _settings.MaxMergeDistance = (float)value;
        }

        internal void SetMinDistance(decimal value)
        {
            _settings.MinCharacteriticPointsDistance = (float)value;
        }

        internal void SetAngleLimitDegree(decimal value)
        {
            _settings.CharacteriticPointsAngleLimitDegrees = (float)value;
        }

        internal void SetAngleReferencePointMinimalDistance(decimal value)
        {
            _settings.ReferencePointMinDistance = (float)value;
        }

        internal void SetDrawingTimeout(int value)
        {
            _settings.DrawingTimeout = value;
        }
    }
}
