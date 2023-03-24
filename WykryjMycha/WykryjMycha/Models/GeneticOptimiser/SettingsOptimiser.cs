namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class SettingsOptimiser : GeneticOptimiser<SettingsChromosome>
    {
        public SettingsOptimiser(IPopulationGenerator<SettingsChromosome> pg, IQualityMetric<SettingsChromosome> qm, ISelector<SettingsChromosome> se, ISuccessor<SettingsChromosome> su) : base(pg, qm, se, su) { }

        public void SetSettings(Settings newSettings)
        {
            Settings globalSettings = Settings.GetInstance();

            globalSettings.MaxMergeDistance = newSettings.MaxMergeDistance;
            globalSettings.MinCharacteriticPointsDistance = newSettings.MinCharacteriticPointsDistance;
            globalSettings.CharacteriticPointsAngleLimitDegrees = newSettings.CharacteriticPointsAngleLimitDegrees;
            globalSettings.ReferencePointMinDistance = newSettings.ReferencePointMinDistance;
        }
    }
}
