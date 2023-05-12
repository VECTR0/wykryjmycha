namespace WykryjMycha.Models.GeneticOptimiser
{
    internal class SettingsOptimizer : GeneticOptimizer<SettingsChromosome>
    {
        public SettingsOptimizer(IPopulationGenerator<SettingsChromosome> pg, IQualityMetric<SettingsChromosome> qm, ISelector<SettingsChromosome> se, ISuccessor<SettingsChromosome> su) : base(pg, qm, se, su) { }

        public void SetSettings(Settings newSettings)
        {
            Settings globalSettings = Settings.GetInstance();

            for (int i = 0; i < globalSettings.NumberOfParameters; i++)
            {
                globalSettings.SetParameter(i, newSettings.GetParameter(i));
            }
        }
    }
}
