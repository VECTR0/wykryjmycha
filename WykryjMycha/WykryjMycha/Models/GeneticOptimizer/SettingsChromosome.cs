namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class SettingsChromosome : Settings, IChromosome
    {
        public void GenerateValues(Random random)
        {
            MaxMergeDistance = 100f * random.NextSingle();
            MinCharacteriticPointsDistance = 100f * random.NextSingle();
            CharacteriticPointsAngleLimitDegrees = 100f * random.NextSingle();
            ReferencePointMinDistance = 100f * random.NextSingle();
            MetricAngleWeight = 100f * random.NextSingle();
            MetricDistanceWeight = 100f * random.NextSingle();
        }

        public float Quality { get; set; }
    }
}
