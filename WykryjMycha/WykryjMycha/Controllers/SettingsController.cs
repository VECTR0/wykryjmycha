namespace WykryjMycha
{
    internal class SettingsController
    {
        internal MainForm settingsView;
        private Settings _settings;

        private NumericUpDown maxMergeDistance;
        private NumericUpDown minCharacteriticPointsDistance;
        private NumericUpDown characteriticPointsAngleLimitDegrees;
        private NumericUpDown referencePointMinDistance;
        private NumericUpDown numberOfParameters;
        private NumericUpDown numMetricAngleWeight;
        private NumericUpDown numMetricDistanceWeight;


        internal SettingsController(MainForm instance, Settings settings)
        {
            this.settingsView = instance;
            this._settings = settings;
        }

        internal void Initialize(NumericUpDown maxSearchDistance, NumericUpDown maxAllowedRotation, NumericUpDown maxMergeDistance, NumericUpDown minCharacteriticPointsDistance, NumericUpDown characteriticPointsAngleLimitDegrees, NumericUpDown referencePointMinDistance, NumericUpDown numDrawingTimeout, NumericUpDown numberOfParameters, NumericUpDown numMetricAngleWeight, NumericUpDown numMetricDistanceWeight)
        {
            maxMergeDistance.Value = (decimal)Settings.DefaultMaxMergeDistance;
            minCharacteriticPointsDistance.Value = (decimal)Settings.DefaultMinCharacteriticPointsDistance;
            characteriticPointsAngleLimitDegrees.Value = (decimal)Settings.DefaultCharacteriticPointsAngleLimitDegrees;
            referencePointMinDistance.Value = (decimal)Settings.DefaultReferencePointMinDistance;
            numDrawingTimeout.Value = Settings.DefaultDrawingTimeout;
            numMetricAngleWeight.Value = (decimal)Settings.DefaultMetricAngleWeight;
            numMetricDistanceWeight.Value = (decimal)Settings.DefaultMetricDistanceWeight;
            //numberOfParameters.Value = (decimal)Settings.DefaultNumberOfParameters;

            // parameters changeable by genetic optimiser
            this.maxMergeDistance = maxMergeDistance;
            this.minCharacteriticPointsDistance = minCharacteriticPointsDistance;
            this.characteriticPointsAngleLimitDegrees = characteriticPointsAngleLimitDegrees;
            this.referencePointMinDistance = referencePointMinDistance;
            this.numberOfParameters = numberOfParameters;
            this.numMetricAngleWeight = numMetricAngleWeight;
            this.numMetricDistanceWeight = numMetricDistanceWeight;
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

        internal void SetNumberOfParameters(int value)
        {
            _settings.NumberOfParameters = value;
        }

        internal void DisplayUpdatedSettings()
        {
            maxMergeDistance.Value = (decimal)_settings.MaxMergeDistance;
            minCharacteriticPointsDistance.Value = (decimal)_settings.MinCharacteriticPointsDistance;
            characteriticPointsAngleLimitDegrees.Value = (decimal)_settings.CharacteriticPointsAngleLimitDegrees;
            referencePointMinDistance.Value = (decimal)_settings.ReferencePointMinDistance;
            numMetricAngleWeight.Value = (decimal)_settings.MetricAngleWeight;
            numMetricDistanceWeight.Value = (decimal)_settings.MetricDistanceWeight;
        }

        internal void SetMetricAngleWeight(int value)
        {
            _settings.MetricAngleWeight = value;
        }

        internal void SetMetricDistanceWeight(int value)
        {
            _settings.MetricDistanceWeight = value;
        }
    }
}
