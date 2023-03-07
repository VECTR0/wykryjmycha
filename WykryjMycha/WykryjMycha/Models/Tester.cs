using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class Tester
    {
        internal Tester()
        {

        }

        internal void Run(StrokeDatabase strokeDatabase, Settings settings, IMetric metric) // TODO add settings randomization
        {
            Logger.Log = "=== TESTING ===";
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
            var correct = 0;
            var incorrect = 0;
            foreach (var stroke in strokes.Where(x => !x.isPattern))
            {
                var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                var possible = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetPossible(metric);
                var best = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings).GetBest(metric);
                if (best != null) Logger.Log = $"Found {best.name} for {stroke.name}";
                else Logger.Log = $"Found none for {stroke.name}";
                if (best != null && best.name.ToLower() == stroke.name.ToLower()) correct++;
                else incorrect++;
            }
            Logger.Log = $"Run {(correct + incorrect)} tests";
            Logger.Log = $"{incorrect} incorrect";
            Logger.Log = $"Success rate {Math.Round((1 - 1.0 * incorrect / (correct + incorrect)) * 100)}%";
            Logger.Log = "===         ===";
        }
    }
}
