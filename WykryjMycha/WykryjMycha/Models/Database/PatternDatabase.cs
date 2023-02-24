using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternDatabase
    {
        internal event EventHandler changed;
        private readonly List<Pattern> _patterns = PatternDatabase.GetPatternList();

        public void AddPattern(Pattern pattern)
        {
            _patterns.Add(pattern);
            changed?.Invoke(this, EventArgs.Empty);
            PatternWriter.Write(pattern.points, pattern.name);
        }

        public void DeletePattern(int index)
        {
            if (_patterns.Count == 0 || index < 0 || index >= _patterns.Count) return;
            _patterns.RemoveAt(index);
            changed?.Invoke(this, EventArgs.Empty);
        }

        public List<Pattern> GetPatterns()
        {
            return _patterns;
        }

        internal static List<Pattern> GetPatternList()
        {
            List<Pattern> list = new List<Pattern>();

            try
            {
                foreach (string file in Directory.EnumerateFiles("patterns/", "*.json"))
                {
                    PatternReader patternReader = new PatternReader(file);

                    list.Add(new Pattern() { name = patternReader.patternName, points = patternReader.points });
                }
            }catch(Exception ex) { }

            return list;
        }
    }
}
