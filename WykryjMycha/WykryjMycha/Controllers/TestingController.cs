using WykryjMycha.Models.GeneticOptimiser;

namespace WykryjMycha
{
    internal class TestingController
    {
        internal MainForm testingView;
        private StrokeDatabase _strokeDatabase;
        private SettingsController _settingsController;
        private int _selectedStroke = -1;
        internal TestingController(MainForm instance, StrokeDatabase strokeDatabase, SettingsController settingsController)
        {
            testingView = instance;
            _strokeDatabase = strokeDatabase;
            _strokeDatabase.Changed += StrokesDatabaseChanged;
            _settingsController = settingsController;

            testingView.SetStrokesList(_strokeDatabase.GetStrokes());
        }

        private void StrokesDatabaseChanged(object? sender, EventArgs e)
        {
            _selectedStroke = -1;
            testingView.SetStrokesList(_strokeDatabase.GetStrokes());
            testingView.ClearPicStroke();
        }

        internal void RunTests()
        {
            StrokesBasedTester.Run(_strokeDatabase, new AngleDistanceMetric(), Settings.GetInstance(), true);
        }

        internal void OptimiseParameters()
        {
            // TODO: move these parameters to GUI
            int maxIterations = 5;
            int populationAmount = 600;
            int selectedAmount = 100;
            float mutationProbability = 0.02f;
            float targetQuality = 0.85f;

            Random random = new Random();
            IMetric matcherMetric = new AngleDistanceMetric();
            IPopulationGenerator<SettingsChromosome> populationGenerator = new PopulationGenerator(random);
            IQualityMetric<SettingsChromosome> qualityMetric = new QualityMetric(targetQuality, _strokeDatabase, matcherMetric);
            ISelector<SettingsChromosome> selector = new RouletteSelector(random);
            ICrosser<SettingsChromosome> crosser = new SwappingCrosser(random);
            IMutator<SettingsChromosome> mutator = new Mutator(mutationProbability, random);
            ISuccessor<SettingsChromosome> successor = new WholeNewGenerationSuccessor(crosser, mutator, random);

            SettingsOptimizer settingsOptimiser = new SettingsOptimizer(populationGenerator, qualityMetric, selector, successor);
            var suboptimalSettings = settingsOptimiser.Run(maxIterations, populationAmount, selectedAmount);
            Logger.Log = "Finished parameters optimalisation! Check new settings";
            settingsOptimiser.SetSettings(suboptimalSettings);
            Logger.Log = $"MetricAngleWeight = {Settings.GetInstance().MetricAngleWeight:0.00}, MetricDistanceWeight = {Settings.GetInstance().MetricDistanceWeight:0.00}";
            _settingsController.DisplayUpdatedSettings();
        }

        internal void HandleStrokeSelected(int selectedIndex)
        {
            if (selectedIndex < 0 || selectedIndex >= _strokeDatabase.GetStrokes().Count) return;
            _selectedStroke = selectedIndex;
            testingView.ClearPicStroke();
            testingView.RenderStroke(_strokeDatabase.GetStrokes()[selectedIndex]);
        }

        internal void ExportStrokes(string filename)
        {
            _strokeDatabase.Export(filename);
        }

        internal void ImportStrokes(string filename, bool clearExisting)
        {
            _strokeDatabase.Import(filename, clearExisting);
        }

        internal void DeleteStroke()
        {
            _strokeDatabase.DeleteStroke(_selectedStroke);
            testingView.SetStrokesList(_strokeDatabase.GetStrokes());
        }

        internal void DeleteAllStrokes()
        {
            _strokeDatabase.DeleteAllStrokes();
        }
    }
}
