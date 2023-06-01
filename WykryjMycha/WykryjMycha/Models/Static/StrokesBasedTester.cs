namespace WykryjMycha
{
    internal static class StrokesBasedTester
    {
        internal static void Run(StrokeDatabase strokeDatabase, IMetric metric, Settings settings, bool displayDebugLogsForEachStroke = false)
        {
            Logger.Log = "=== TESTING ===";
            Logger.Log = "Testing data";
            DateTime start = DateTime.Now;
            float result = RunHeadless(strokeDatabase.TestStrokes, strokeDatabase.PatternStrokes, metric, settings, displayDebugLogsForEachStroke);
            DateTime end = DateTime.Now;
            Logger.Log = $"Process time = {end.Subtract(start)}";
            Logger.Log = $"Run {strokeDatabase.TestStrokes.Count()} tests";
            Logger.Log = $"Success rate {result * 100.0f:0.00}%";

            Logger.Log = "Whole dataset";
            start = DateTime.Now;
            result = RunHeadless(strokeDatabase.TrainStrokes.Concat(strokeDatabase.TestStrokes), strokeDatabase.PatternStrokes, metric, settings, displayDebugLogsForEachStroke);
            end = DateTime.Now;
            Logger.Log = $"Process time = {end.Subtract(start)}";
            Logger.Log = $"Run {strokeDatabase.TrainStrokes.Count() + strokeDatabase.TestStrokes.Count()} tests";
            Logger.Log = $"Success rate {result * 100.0f:0.00}%";
            Logger.Log = "===         ===";
        }

        internal static float RunHeadless(IEnumerable<Stroke> inputs, IEnumerable<Stroke> patterns, IMetric metric, Settings settings, bool displayDebugLogs=false)
        {
            var patternDatabase = new PatternDatabase();
            foreach (var stroke in patterns)
            {
                lock (stroke)
                {
                    var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                    var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                    var pattern = new Pattern() { name = stroke.name, points = characteristicPoints };
                    patternDatabase.AddPattern(pattern);
                }
            }

            var patternMatcher = new PatternMatcher();
            int correct = 0;
            int incorrect = 0;
            foreach (var stroke in inputs)
            {
                lock (stroke)
                {
                    var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                    var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                    var best = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetBest(metric);

                    if (best != null && best.name.ToLower() == stroke.name.ToLower())
                        correct++;
                    else
                        incorrect++;

                    if (!displayDebugLogs) continue;

                    if (best != null) Logger.Log = $"Found {best.name} for {stroke.name}";
                    else Logger.Log = $"Found none for {stroke.name}";
                }
            }

            return (float)correct / (correct + incorrect);
        }
    }
}
