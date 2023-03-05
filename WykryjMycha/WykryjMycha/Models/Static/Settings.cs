namespace WykryjMycha
{
    internal class Settings
    {
        private static Settings _instance;

        // Pattern Matcher
        internal const float DefaultMaxSearchDistance = 25f;
        internal const float DefaultMaxAllowedRotation = 30f;
        internal const float DefaultMaxMergeDistance = 30f;

        internal float maxSearchDistance = DefaultMaxSearchDistance;
        internal float maxAllowedRotation = DefaultMaxAllowedRotation;
        internal float maxMergeDistance = DefaultMaxMergeDistance;

        // Data Collector
        internal const int DefaultTakeEveryXSample = 100;

        internal int takeEveryXSample = DefaultTakeEveryXSample;

        // Characteristic Points Finder
        internal const float DefaultMinCharacteriticPointsDistance = 10f;
        internal const float DefaultCharacteriticPointsAngleLimitDegrees = 40f;
        internal const float DefaultReferencePointMinDistance = 4f;

        internal float minCharacteriticPointsDistance = DefaultMinCharacteriticPointsDistance;
        internal float characteriticPointsAngleLimitDegrees = DefaultCharacteriticPointsAngleLimitDegrees;
        internal float referencePointMinDistance = DefaultReferencePointMinDistance;

        // Program Settings
        //   Drawing
        internal const int DefaultDrawingTimeout = 1000;
        internal int drawingTimeout = DefaultDrawingTimeout;

        private Settings() { }

        internal static Settings GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }
    }
}
