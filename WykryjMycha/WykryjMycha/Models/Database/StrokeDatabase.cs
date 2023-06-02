using System.Text.Json;

namespace WykryjMycha
{
    internal class StrokeDatabase
    {
        internal event EventHandler Changed;
        private readonly List<Stroke> _strokes;
        internal List<Stroke> TrainStrokes { get; private set; } = null;
        internal List<Stroke> TestStrokes { get; private set; } = null;
        internal List<Stroke> PatternStrokes { get; private set; } = null;

        public StrokeDatabase()
        {
            _strokes = new List<Stroke>();
        }

        internal void AddStroke(Stroke stroke, bool silentMode = false)
        {
            if (stroke == null) return;
            _strokes.Add(stroke);

            if (!silentMode)
                Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void DeleteStroke(int index)
        {
            if (_strokes.Count == 0 || index < 0 || index >= _strokes.Count) return;
            _strokes.RemoveAt(index);
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public List<Stroke> GetStrokes()
        {
            return _strokes;
        }

        internal bool Import(string filename, bool clearExisting = true)
        {
            var serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new PointJsonConverter() }
            };
            var json = File.ReadAllText(filename);
            try
            {
                var strokes = JsonSerializer.Deserialize<List<Stroke>>(json, serializeOptions);
                if(clearExisting) _strokes.Clear();
                foreach(var stroke in strokes)
                {
                    AddStroke(stroke, true);
                }
            }
            catch
            {
                return false;
            }

            Changed?.Invoke(this, EventArgs.Empty);

            return true;
        }

        internal bool Export(string filename)
        {
            var serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new PointJsonConverter() }
            };
            try
            {
                var json = JsonSerializer.Serialize(_strokes, serializeOptions);
                File.WriteAllText(filename, json);
            }
            catch {
                return false;
            }
            return true;
        }

        internal void DeleteAllStrokes()
        {
            _strokes.Clear();
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void SplitData()
        {
            int trainSize = (int)Math.Round(Settings.DataGroupSize * Settings.DataTrainRatio);
            int testSize = (int)Math.Round(Settings.DataGroupSize * (1.0f - Settings.DataTrainRatio));

            var random = new Random(Settings.DataSplitSeed != 0 ? Settings.DataSplitSeed : new Random().Next());
            (TrainStrokes, TestStrokes) = _strokes.GroupBy(x => x.name).Where(group => group.Count() > 1)
                .Select(group => group.Take(Settings.DataGroupSize))
                .Select(subgroup => subgroup.OrderBy(_ => random.Next()))
                .Select(subgroup => (Train: subgroup.Take(trainSize), Test: subgroup.Skip(trainSize).Take(testSize)))
                .Aggregate((Train: (IEnumerable<Stroke>)new List<Stroke>(), Test: (IEnumerable<Stroke>)new List<Stroke>()), (acc, val) => (Train: acc.Train.Concat(val.Train), Test: acc.Test.Concat(val.Test)), x => (Train: x.Train.ToList(), Test: x.Test.ToList()));
        }

        internal void SetPattens()
        {
            PatternStrokes = _strokes.Where(x => char.IsUpper(x.name[0])).ToList();
        }
    }
}
