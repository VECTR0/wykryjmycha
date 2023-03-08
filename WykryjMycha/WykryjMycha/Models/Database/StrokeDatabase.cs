using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class StrokeDatabase
    {
        internal event EventHandler Changed;
        private readonly List<Stroke> _strokes;
        public StrokeDatabase()
        {
            _strokes = new List<Stroke>();
        }

        internal void AddStroke(Stroke stroke)
        {
            if (stroke == null) return;
            _strokes.Add(stroke);
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
                Converters = { new Vector2JsonConverter() }
            };
            var json = File.ReadAllText(filename);
            try
            {
                var strokes = JsonSerializer.Deserialize<List<Stroke>>(json, serializeOptions);
                if(clearExisting) _strokes.Clear();
                foreach(var stroke in strokes)
                {
                    AddStroke(stroke);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        internal bool Export(string filename)
        {
            var serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new Vector2JsonConverter() }
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
    }
}
