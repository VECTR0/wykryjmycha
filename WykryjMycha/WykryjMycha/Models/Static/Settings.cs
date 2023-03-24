namespace WykryjMycha
{
    internal class Settings
    {
        // Pattern Matcher
        internal const float DefaultMaxSearchDistance = 25f;
        internal const float DefaultMaxAllowedRotation = 30f;
        internal const float DefaultMaxMergeDistance = 30f;

        private float _maxSearchDistance;
        private float _maxAllowedRotation;
        private float _maxMergeDistance;

        public float MaxSearchDistance { get => _maxSearchDistance; set => _maxSearchDistance = Math.Clamp(value, 0f, 100f); }
        public float MaxAllowedRotation { get => _maxAllowedRotation; set => _maxAllowedRotation = Math.Clamp(value, 0f, 100f); }
        public float MaxMergeDistance { get => _maxMergeDistance; set => _maxMergeDistance = Math.Clamp(value, 0f, 100f); }

        // Characteristic Points Finder
        internal const float DefaultMinCharacteriticPointsDistance = 10f;
        internal const float DefaultCharacteriticPointsAngleLimitDegrees = 40f;
        internal const float DefaultReferencePointMinDistance = 4f;

        private float _minCharacteriticPointsDistance;
        private float _characteriticPointsAngleLimitDegrees;
        private float _referencePointMinDistance;

        public float MinCharacteriticPointsDistance { get => _minCharacteriticPointsDistance; set => _minCharacteriticPointsDistance = Math.Clamp(value, 0f, 100f); }
        public float CharacteriticPointsAngleLimitDegrees { get => _characteriticPointsAngleLimitDegrees; set => _characteriticPointsAngleLimitDegrees = Math.Clamp(value, 0f, 100f); }
        public float ReferencePointMinDistance { get => _referencePointMinDistance; set => _referencePointMinDistance = Math.Clamp(value, 0f, 100f); }


        // Interface Settings
        //   Drawing
        internal const int DefaultDrawingTimeout = 1000;
        internal int DrawingTimeout { get; set; }


        private static Settings _instance;

        protected Settings()
        {
            MaxSearchDistance = DefaultMaxSearchDistance;
            MaxAllowedRotation = DefaultMaxAllowedRotation;
            MaxMergeDistance = DefaultMaxMergeDistance;
            MinCharacteriticPointsDistance = DefaultMinCharacteriticPointsDistance;
            CharacteriticPointsAngleLimitDegrees = DefaultCharacteriticPointsAngleLimitDegrees;
            ReferencePointMinDistance = DefaultReferencePointMinDistance;
            DrawingTimeout = DefaultDrawingTimeout;
        }

        internal static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }
    }
}
