namespace WykryjMycha
{
    internal static class Settings
    {
        // Pattern Matcher
        internal const float DefaultMaxSearchDistance = 25f;
        internal const float DefaultMaxAllowedRotation = 30f;
        internal const float DefaultMaxMergeDistance = 30f;

        internal static float maxSearchDistance = DefaultMaxSearchDistance;
        internal static float maxAllowedRotation = DefaultMaxAllowedRotation;
        internal static float maxMergeDistance = DefaultMaxMergeDistance;

        // Data Collector
        internal const int DefaultTakeEveryXSample = 100;

        internal static int takeEveryXSample = DefaultTakeEveryXSample;

        // Characteristic Points Finder
        internal const float DefaultMinCharacteriticPointsDistance = 10f;
        internal const float DefaultCharacteriticPointsAngleLimitDegrees = 40f;
        internal const float DefaultReferencePointMinDistance = 4f;

        internal static float minCharacteriticPointsDistance = DefaultMinCharacteriticPointsDistance;
        internal static float characteriticPointsAngleLimitDegrees = DefaultCharacteriticPointsAngleLimitDegrees;
        internal static float referencePointMinDistance = DefaultReferencePointMinDistance;
    }
}
