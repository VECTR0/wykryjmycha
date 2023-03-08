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
        internal event EventHandler changed;
        private List<Stroke> _strokes;
        public StrokeDatabase()
        {
            _strokes = new List<Stroke>();
        }

        internal void AddStroke(Stroke stroke)
        {
            if (stroke == null) return;
            _strokes.Add(stroke);
            changed?.Invoke(this, EventArgs.Empty);
        }

        internal void DeleteStroke(int index)
        {
            if (_strokes.Count == 0 || index < 0 || index >= _strokes.Count) return;
            _strokes.RemoveAt(index);
            changed?.Invoke(this, EventArgs.Empty);
        }

        public List<Stroke> GetStrokes()
        {
            return _strokes;
        }

        internal bool Import(string filename, bool clear = true)
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
                if(clear) _strokes.Clear();
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
    }
}
