using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class Tester
    {

        internal Tester() {
        
        }

        internal void Run(StrokeDatabase strokeDatabase, Settings settings) // TODO add settings randomization
        {
            Logger.Log = "=== TESTING ===";
            var strokes = strokeDatabase.GetStrokes();
            var inputStrokes = new List<Stroke>();
            var patternStrokes = new List<Stroke>();
            foreach(var stroke in strokes)
            {
                if(stroke.isPattern)patternStrokes.Add(stroke); // TODO leave some unknown patterns
                else inputStrokes.Add(stroke);
            }

            var patternMatcher = new PatternMatcher();

            var patternDatabase = new PatternDatabase();

            var incorrect = 0;
           
            foreach(var stroke in patternStrokes) {
                var normalizedPoints = MathUtils.NormalizePoints(stroke.points);
                var characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(normalizedPoints!, settings);
                string name = patternMatcher.MatchPattern(characteristicPoints, patternDatabase, settings) ?? "No match";
                if(name != null) // TODO cross check patter and stroke
                {
                    if(name == stroke.name.ToLower()) {

                    }
                    else
                    {
                        incorrect++;
                    }
                }else
                {
                    incorrect++;
                }
               
            }
            Logger.Log = $"Run {patternDatabase.GetPatterns().Count} tests";
            Logger.Log = $"{incorrect} incorrect";
            Logger.Log = $"Quality {1-1.0*incorrect/patternDatabase.GetPatterns().Count}";
            Logger.Log = "===         ===";
        }
    }
}
