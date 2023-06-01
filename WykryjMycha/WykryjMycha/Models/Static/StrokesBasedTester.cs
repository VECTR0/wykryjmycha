namespace WykryjMycha
{
    internal static class StrokesBasedTester
    {
        internal static void Run(StrokeDatabase strokeDatabase, IMetric metric, Settings settings, bool displayDebugLogsForEachStroke = false)
        {
            Logger.Log = "=== TESTING ===";
            DateTime start = DateTime.Now;
            float result = RunHeadless(strokeDatabase, metric, settings, displayDebugLogsForEachStroke);
            DateTime end = DateTime.Now;
            Logger.Log = $"Process time = {end.Subtract(start)}";

            Logger.Log = $"Run {strokeDatabase.GetStrokes().Where(x => !x.isPattern).Count()} tests";
            Logger.Log = $"Success rate {result * 100.0f:0.00}%";
            Logger.Log = "===         ===";
        }

        internal static float RunHeadless(StrokeDatabase strokeDatabase, IMetric metric, Settings settings, bool displayDebugLogs=false)
        {
            var strokes = strokeDatabase.GetStrokes();

            var patternDatabase = new PatternDatabase();
            foreach (var stroke in strokes.Where(x => x.isPattern))
            {
                lock (stroke)
                {
                    var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(stroke.NormalizedPoints, settings);
                    var pattern = new Pattern() { name = stroke.name, points = characteristicPoints };
                    patternDatabase.AddPattern(pattern);
                }
            }

            var patternMatcher = new PatternMatcher();
            int correct = 0;
            int incorrect = 0;
            foreach (var stroke in strokes.Where(x => !x.isPattern))
            {
                lock (stroke)
                {
                    var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(stroke.NormalizedPoints, settings);
                    var best = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetBest(metric);

                    if (best != null && string.Equals(best.nameLowercase, stroke.NameLowercase))
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
