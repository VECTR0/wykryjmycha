namespace WykryjMycha
{
    public class Settings
    {
        internal const int NumberOfParameters = 4;

        // Pattern Matcher
        internal const float DefaultMaxSearchDistance = 25f;
        internal const float DefaultMaxAllowedRotation = 30f;
        internal const float DefaultMaxMergeDistance = 84.32f;

        private float _maxSearchDistance;
        private float _maxAllowedRotation;
        private float _maxMergeDistance;

        public float MaxSearchDistance { get => _maxSearchDistance; set => _maxSearchDistance = Math.Clamp(value, 0f, 100f); }
        public float MaxAllowedRotation { get => _maxAllowedRotation; set => _maxAllowedRotation = Math.Clamp(value, 0f, 100f); }
        public float MaxMergeDistance { get => _maxMergeDistance; set => _maxMergeDistance = Math.Clamp(value, 0f, 100f); }

        // Characteristic Points Finder
        internal const float DefaultMinCharacteriticPointsDistance = 43.96f;
        internal const float DefaultCharacteriticPointsAngleLimitDegrees = 0.67f;
        internal const float DefaultReferencePointMinDistance = 52.79f;

        private float _minCharacteriticPointsDistance;
        private float _characteriticPointsAngleLimitDegrees;
        private float _referencePointMinDistance;

        public float MinCharacteriticPointsDistance { get => _minCharacteriticPointsDistance; set => _minCharacteriticPointsDistance = Math.Clamp(value, 0f, 100f); }
        public float CharacteriticPointsAngleLimitDegrees { get => _characteriticPointsAngleLimitDegrees; set => _characteriticPointsAngleLimitDegrees = Math.Clamp(value, 0f, 100f); }
        public float ReferencePointMinDistance { get => _referencePointMinDistance; set => _referencePointMinDistance = Math.Clamp(value, 0f, 100f); }


        internal const float DefaultMetricAngleWeight = 2.0f;
        internal const float DefaultMetricDistanceWeight = 0.8f;

        private float _metricAngleWeight;
        private float _metricDistanceWeight;

        public float MetricAngleWeight { get => _metricAngleWeight; set => _metricAngleWeight = Math.Clamp(value, 0f, 100f); }
        public float MetricDistanceWeight { get => _metricDistanceWeight; set => _metricDistanceWeight = Math.Clamp(value, 0f, 100f); }


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
            MetricAngleWeight = DefaultMetricAngleWeight;
            MetricDistanceWeight = DefaultMetricDistanceWeight;
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

        internal float GetParameter(int i)
        {
            switch (i)
            {
                case 0: return MaxMergeDistance;
                case 1: return MinCharacteriticPointsDistance;
                case 2: return CharacteriticPointsAngleLimitDegrees;
                case 3: return ReferencePointMinDistance;
                case 4: return MetricAngleWeight;
                case 5: return MetricDistanceWeight;
                default:
                    throw new ArgumentException("Wanted to reach inexisting parameter");
            }
        }

        internal void SetParameter(int i, float value)
        {
            switch (i)
            {
                case 0: 
                    MaxMergeDistance = value;
                    break;
                case 1: 
                    MinCharacteriticPointsDistance = value;
                    break;
                case 2: 
                    CharacteriticPointsAngleLimitDegrees = value;
                    break;
                case 3: 
                    ReferencePointMinDistance = value;
                    break;
                case 4:
                    MetricAngleWeight = value;
                    break;
                case 5:
                    MetricDistanceWeight = value;
                    break;
                default:
                    throw new ArgumentException("Wanted to reach inexisting parameter");
            }
        }
    }
}
