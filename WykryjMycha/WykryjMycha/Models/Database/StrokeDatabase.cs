using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public List<Stroke> GetStrokes()
        {
            return _strokes;
        }
    }
}
