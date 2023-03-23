namespace WykryjMycha
{
    internal class PatternDatabase
    {
        internal event EventHandler changed;
        private readonly List<Pattern> _patterns = new List<Pattern>();

        public void AddPattern(Pattern pattern)
        {
            _patterns.Add(pattern);
            changed?.Invoke(this, EventArgs.Empty);
        }

        public void DeletePattern(int index)
        {
            if (_patterns.Count == 0 || index < 0 || index >= _patterns.Count) return;
            PatternWriter.Delete(_patterns[index].name);
            _patterns.RemoveAt(index);
            changed?.Invoke(this, EventArgs.Empty);
        }

        public List<Pattern> GetPatterns()
        {
            return _patterns;
        }

        internal void Export(string directory = "") //TODO finish
        {
            foreach (var pattern in _patterns)
            {
                PatternWriter.Write(pattern.points, pattern.name);
            }
        }

        internal void Import(string directory = "", bool clear = false) //TODO finish
        {
            if(clear) _patterns.Clear();
            bool toImport;
            foreach(var pattern in GetPatternList())
            {
                toImport = true;
                if (_patterns.Count > 0)
                {
                    foreach (var actual in _patterns.ToList())
                    {
                        if (actual.name == pattern.name)
                        {
                            Logger.Log = $"Skipped '{pattern.name}' - already imported";
                            toImport = false;
                            break;
                        }
                    }

                }
                if (toImport)
                {
                    AddPattern(pattern);
                }
            }
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
            }catch(Exception ex) 
            {
                
            }

            return list;
        }
    }
}
