namespace WykryjMycha
{
    internal class TestingController
    {
        internal MainForm testingView;
        private StrokeDatabase _strokeDatabase;
        private Tester _tester;
        private int _selectedStroke = -1;
        internal TestingController(MainForm instance, StrokeDatabase strokeDatabase, Tester tester)
        {
            testingView = instance;
            _strokeDatabase = strokeDatabase;
            _strokeDatabase.Changed += StrokesDatabaseChanged;
            _tester = tester;

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
            _tester.Run(_strokeDatabase, Settings.GetInstance(), new AverageMetric()); //TODO: randomize settings
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
