namespace WykryjMycha
{
    internal class SettingsController
    {
        internal MainForm settingsView;
        public Settings _settings;

        private NumericUpDown maxMergeDistance;
        private NumericUpDown minCharacteriticPointsDistance;
        private NumericUpDown characteriticPointsAngleLimitDegrees;
        private NumericUpDown referencePointMinDistance;
        private NumericUpDown numMetricAngleWeight;
        private NumericUpDown numMetricDistanceWeight;

        private NumericUpDown numMaxItertions;
        private NumericUpDown numPopulationSize;
        private NumericUpDown numSelectedSize;
        private NumericUpDown numMutationProbability;
        private NumericUpDown numTargetQuality;


        internal SettingsController(MainForm instance, Settings settings)
        {
            this.settingsView = instance;
            this._settings = settings;
        }

        internal void Initialize(NumericUpDown maxSearchDistance, NumericUpDown maxAllowedRotation, NumericUpDown maxMergeDistance, NumericUpDown minCharacteriticPointsDistance, NumericUpDown characteriticPointsAngleLimitDegrees, NumericUpDown referencePointMinDistance, NumericUpDown numDrawingTimeout, NumericUpDown numMetricAngleWeight, NumericUpDown numMetricDistanceWeight,
            NumericUpDown numMaxItertions, NumericUpDown numPopulationSize, NumericUpDown numSelectedSize, NumericUpDown numMutationProbability, NumericUpDown numTargetQuality
            )
        {
            maxMergeDistance.Value = (decimal)Settings.DefaultMaxMergeDistance;
            minCharacteriticPointsDistance.Value = (decimal)Settings.DefaultMinCharacteriticPointsDistance;
            characteriticPointsAngleLimitDegrees.Value = (decimal)Settings.DefaultCharacteriticPointsAngleLimitDegrees;
            referencePointMinDistance.Value = (decimal)Settings.DefaultReferencePointMinDistance;
            numDrawingTimeout.Value = Settings.DefaultDrawingTimeout;
            numMetricAngleWeight.Value = (decimal)Settings.DefaultMetricAngleWeight;
            numMetricDistanceWeight.Value = (decimal)Settings.DefaultMetricDistanceWeight;
            numMaxItertions.Value = (decimal)Settings.DefaultMaxItertions;
            numPopulationSize.Value = (decimal)Settings.DefaultPopulationSize;
            numSelectedSize.Value = (decimal)Settings.DefaultSelectedSize;
            numMutationProbability.Value = (decimal)Settings.DefaultMutationProbability;
            numTargetQuality.Value = (decimal)Settings.DefaultTargetQuality;

            // parameters changeable by genetic optimiser
            this.maxMergeDistance = maxMergeDistance;
            this.minCharacteriticPointsDistance = minCharacteriticPointsDistance;
            this.characteriticPointsAngleLimitDegrees = characteriticPointsAngleLimitDegrees;
            this.referencePointMinDistance = referencePointMinDistance;
            this.numMetricAngleWeight = numMetricAngleWeight;
            this.numMetricDistanceWeight = numMetricDistanceWeight;

            this.numMaxItertions = numMaxItertions;
            this.numPopulationSize = numPopulationSize;
            this.numSelectedSize = numSelectedSize;
            this.numMutationProbability = numMutationProbability;
            this.numTargetQuality = numTargetQuality;
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

        internal void SetMaxIterations(int value)
        {
            _settings.MaxItertions = value;
        }

        internal void SetPopulationSize(int value)
        {
            _settings.PopulationSize = value;
        }

        internal void SetSelectedSize(int value)
        {
            _settings.SelectedSize = value;
        }

        internal void SetMutationProbability(float value)
        {
            _settings.MutationProbability = value;
        }

        internal void SetTargetQuality(float value)
        {
            _settings.TargetQuality = value;
        }
    }
}
