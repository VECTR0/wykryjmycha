namespace WykryjMycha
{
    internal static class StrokesBasedTester
    {
        internal static void Run(StrokeDatabase strokeDatabase, IMetric metric, Settings settings)
        {
            Logger.Log = "=== TESTING ===";
            DateTime start = DateTime.Now;
            float result = RunHeadless(strokeDatabase, metric, settings);
            DateTime end = DateTime.Now;
            Logger.Log = $"Process time = {end.Subtract(start)}";

            Logger.Log = $"Run {strokeDatabase.GetStrokes().Where(x => !x.isPattern).Count()} tests";
            Logger.Log = $"Success rate {Math.Round(result * 100)}%";
            Logger.Log = "===         ===";
        }

        internal static float RunHeadless(StrokeDatabase strokeDatabase, IMetric metric, Settings settings)
        {
            var strokes = strokeDatabase.GetStrokes();

            var patternDatabase = new PatternDatabase();
            foreach (var stroke in strokes.Where(x => x.isPattern))
            {
                var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                var pattern = new Pattern() { name = stroke.name, points = characteristicPoints };
                patternDatabase.AddPattern(pattern);
            }

            var patternMatcher = new PatternMatcher();
            int correct = 0;
            int incorrect = 0;
            foreach (var stroke in strokes.Where(x => !x.isPattern))
            {
                var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                var possible = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetPossible(metric);
                var best = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetBest(metric);

                if (best != null && best.name.ToLower() == stroke.name.ToLower())
                    correct++;
                else
                    incorrect++;
            }

            return correct / (correct + incorrect);
        }
    }
}
