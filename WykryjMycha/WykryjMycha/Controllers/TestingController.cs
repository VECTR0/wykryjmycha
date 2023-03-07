using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class TestingController
    {
        internal MainForm testingView;
        private StrokeDatabase _strokeDatabase;
        private Tester _tester;

        internal TestingController(MainForm instance, StrokeDatabase strokeDatabase, Tester tester)
        {
            testingView = instance;
            _strokeDatabase = strokeDatabase;
            _strokeDatabase.changed += StrokesDatabaseChanged;
            _tester = tester;

            testingView.SetStrokesCount(_strokeDatabase.GetStrokes().Count);
            testingView.SetStrokesList(_strokeDatabase.GetStrokes());
        }

        private void StrokesDatabaseChanged(object? sender, EventArgs e)
        {
            testingView.SetStrokesCount(_strokeDatabase.GetStrokes().Count);
            testingView.SetStrokesList(_strokeDatabase.GetStrokes());
        }

        internal void RunTests()
        {
            _tester.Run(_strokeDatabase, Settings.GetInstance(), new AverageMetric()); //TODO: randomize settings
        }

        internal void HandleStrokeSelected(int selectedIndex)
        {
            if (selectedIndex < 0 || selectedIndex >= _strokeDatabase.GetStrokes().Count) return;

            testingView.ClearPicStroke();
            testingView.RenderStroke(_strokeDatabase.GetStrokes()[selectedIndex]);
        }
    }
}
