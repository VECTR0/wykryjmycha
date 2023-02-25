namespace WykryjMycha
{
    internal class SettingsController
    {
        internal void Initialize(NumericUpDown maxSearchDistance, NumericUpDown maxAllowedRotation, NumericUpDown maxMergeDistance, NumericUpDown minCharacteriticPointsDistance, NumericUpDown characteriticPointsAngleLimitDegrees, NumericUpDown referencePointMinDistance, NumericUpDown numDrawingTimeout)
        {
            maxSearchDistance.Value = (decimal)Settings.DefaultMaxSearchDistance;
            maxAllowedRotation.Value = (decimal)Settings.maxAllowedRotation;
            maxMergeDistance.Value = (decimal)Settings.DefaultMaxMergeDistance;
            minCharacteriticPointsDistance.Value = (decimal)Settings.DefaultMinCharacteriticPointsDistance;
            characteriticPointsAngleLimitDegrees.Value = (decimal)Settings.DefaultCharacteriticPointsAngleLimitDegrees;
            referencePointMinDistance.Value = (decimal)Settings.DefaultReferencePointMinDistance;
            numDrawingTimeout.Value = Settings.DefaultDrawingTimeout;
        }

        internal void SetMaxSearchDistance(decimal value)
        {
            Settings.maxSearchDistance = (float)value;
        }

        internal void SetMaxAllowedRotation(decimal value)
        {
            Settings.maxAllowedRotation = (float)value;
        }

        internal void SetMaxMergeDistance(decimal value)
        {
            Settings.maxMergeDistance = (float)value;
        }

        internal void SetMinDistance(decimal value)
        {
            Settings.minCharacteriticPointsDistance = (float)value;
        }

        internal void SetAngleLimitDegree(decimal value)
        {
            Settings.characteriticPointsAngleLimitDegrees = (float)value;
        }

        internal void SetAngleReferencePointMinimalDistance(decimal value)
        {
            Settings.referencePointMinDistance = (float)value;
        }

        internal void SetDrawingTimeout(int value)
        {
            Settings.drawingTimeout = value;
        }
    }
}
