namespace WykryjMycha
{
    public class Settings
    {
        internal const int DefaultNumberOfParameters = 6;
        private int _NumberOfParameters;

        public int NumberOfParameters { get => _NumberOfParameters; set => _NumberOfParameters = (int)Math.Clamp(value, 1f, 6f); }

        // Pattern Matcher
        internal const float DefaultMaxMergeDistance = 39.30f;

        private float _maxMergeDistance;

        public float MaxMergeDistance { get => _maxMergeDistance; set => _maxMergeDistance = Math.Clamp(value, 0f, 100f); }

        // Characteristic Points Finder
        internal const float DefaultMinCharacteriticPointsDistance = 25.56f;
        internal const float DefaultCharacteriticPointsAngleLimitDegrees = 82.56f;
        internal const float DefaultReferencePointMinDistance = 21.31f;

        private float _minCharacteriticPointsDistance;
        private float _characteriticPointsAngleLimitDegrees;
        private float _referencePointMinDistance;

        public float MinCharacteriticPointsDistance { get => _minCharacteriticPointsDistance; set => _minCharacteriticPointsDistance = Math.Clamp(value, 0f, 100f); }
        public float CharacteriticPointsAngleLimitDegrees { get => _characteriticPointsAngleLimitDegrees; set => _characteriticPointsAngleLimitDegrees = Math.Clamp(value, 0f, 100f); }
        public float ReferencePointMinDistance { get => _referencePointMinDistance; set => _referencePointMinDistance = Math.Clamp(value, 0f, 100f); }


        internal const float DefaultMetricDistanceWeight = 1.63f;
        internal const float DefaultMetricAngleWeight = 4.33f;

        private float _metricAngleWeight;
        private float _metricDistanceWeight;

        public float MetricAngleWeight { get => _metricAngleWeight * 0.1f; set => _metricAngleWeight = Math.Clamp(value, 0f, 100f); }
        public float MetricDistanceWeight { get => _metricDistanceWeight * 0.1f; set => _metricDistanceWeight = Math.Clamp(value, 0f, 100f); }

        // if seed is 0, randomize seed
        public static int DataSplitSeed = 5;
        //public static int DataGroupSize = 7;
        //public static float DataTrainRatio = 0.714285f;
        public static int DataGroupSize = 50;
        public static float DataTrainRatio = 0.8f;
        // Interface Settings
        //   Drawing
        internal const int DefaultDrawingTimeout = 1000;
        internal int DrawingTimeout { get; set; }


        //genetic
        internal const int DefaultMaxItertions = 50;
        internal const int DefaultPopulationSize = 600;
        internal const int DefaultSelectedSize = 100;
        internal const float DefaultMutationProbability = 0.02f;
        internal const float DefaultTargetQuality = 0.85f;
        private int _maxItertions = DefaultMaxItertions;
        private int _populationSize = DefaultPopulationSize;
        private int _selectedSize = DefaultSelectedSize;
        private float _mutationProbability = DefaultMutationProbability;
        private float _targetQuality = DefaultTargetQuality;
        public int MaxItertions { get => _maxItertions; set => _maxItertions = (int)Math.Clamp(value, 0f, 1000f); }
        public int PopulationSize { get => _populationSize; set => _populationSize = (int)Math.Clamp(value, 0f, 1000f); }
        public int SelectedSize { get => _selectedSize; set => _selectedSize = (int)Math.Clamp(value, 0f, 1000f); }
        public float MutationProbability { get => _mutationProbability; set => _mutationProbability = (float)Math.Clamp(value, 0f, 1); }
        public float TargetQuality { get => _targetQuality; set => _targetQuality = (float)Math.Clamp(value, 0f, 1); }

        private static Settings _instance;

        protected Settings()
        {
            NumberOfParameters = DefaultNumberOfParameters;
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
                case 0: return _maxMergeDistance;
                case 1: return _minCharacteriticPointsDistance;
                case 2: return _characteriticPointsAngleLimitDegrees;
                case 3: return _referencePointMinDistance;
                case 4: return _metricAngleWeight;
                case 5: return _metricDistanceWeight;
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
