using System.Text.RegularExpressions;

namespace WykryjMycha
{
    internal class DrawingInputController
    {
        internal MainForm drawingView;
        private bool _mouseDown = false;
        private List<Point> _points, _characteristicPoints, _rawPoints;
        private bool _pointsValid = false;
        private PatternDatabase _patternDatabase;
        private PatternMatcher _patternMatcher;
        private CharacteristicPointsFinder _characteristicPointsFinder;
        private Settings _settings;
        private StrokeDatabase _strokeDatabase;
        private bool _strokesStarted = false;

        internal DrawingInputController(MainForm instance, PatternDatabase patternDatabase, PatternMatcher patternMatcher, CharacteristicPointsFinder characteristicPointsFinder, Settings settings, StrokeDatabase strokeDatabase)
        {
            drawingView = instance;
            _points = new List<Point>();
            _patternDatabase = patternDatabase;
            _patternMatcher = patternMatcher;
            _characteristicPointsFinder = characteristicPointsFinder;
            _settings = settings;
            drawingView.ClearDrawingBoard();
            _strokeDatabase = strokeDatabase;
        }

        internal void FinishedStroke()
        {
            _strokesStarted = false;
            _pointsValid = true;
            ProcessDrawnPattern(_points);
            _rawPoints = new List<Point>(_points);

            _points = MathUtils.NormalizePoints(_points);
            drawingView.ClearDrawingBoard();
            drawingView.RenderDrawingStroke(_points);
            _characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(_points!, _settings);
            drawingView.RenderStrokeCharacteristicPoints(_characteristicPoints);
            var results = _patternMatcher.MatchPattern(_characteristicPoints, _patternDatabase, _settings);
            var metric = new AverageMetric();
            Logger.Log = "Possible matches:";
            foreach (var result in results.GetPossible(metric))
            {
                Logger.Log = $"\t{result.name} {metric.GetValue(result)}";
            }
            var best = results.GetBest(metric);
            if(best == null) Logger.Log = $"found none";
            else Logger.Log = $"found: {best.name}";
        }

        internal void HandleDrawingMouseDown(MouseEventArgs e, PictureBox pic)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                if (_strokesStarted)
                {
                    drawingView.StopDrawingTimer();
                }
                else
                {
                    _strokesStarted = true;
                    DrawUtils.ClearPictureBox(pic);
                    _points = new List<Point>();
                }
                _mouseDown = true;

                _points?.Add(new Point(e.X, e.Y, PointOrigin.PenDown));
                DrawUtils.DrawPoint(e.X, e.Y, pic);
            }
        }

        internal void HandleDrawingMouseMove(int x, int y, PictureBox pic)
        {
            if (x < 0 || y < 0 || x > pic.Width || x > pic.Height) _mouseDown = false;
            if (_mouseDown)
            {
                _points?.Add(new Point(x, y));
                DrawUtils.DrawPoint(x, y, pic);
            }
        }

        internal void HandleDrawingMouseUp(MouseEventArgs e, PictureBox pic)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = false;
                drawingView.StartDrawingTimer(_settings.drawingTimeout);
                _points?.Add(new Point(e.X, e.Y, PointOrigin.PenUp));
            }
        }

        internal void HandleDrawingMouseLeave()
        {
            _mouseDown = false;
        }

        internal void HandleDrawingMouseClick(MouseEventArgs e, PictureBox pic)
        {
            if (!_mouseDown && e.Button == MouseButtons.Right)
            {
                DrawUtils.ClearPictureBox(pic);
                drawingView.StopDrawingTimer();
                _strokesStarted = false;
            }
        }

        internal void AddNewPattern(TextBox txt)
        {
            if (!_pointsValid)
            {
                MessageBox.Show("Stroke invalid");
                return;
            }
            if (txt.Text.Length == 0)
            {
                MessageBox.Show("Pattern name too short");
                return;
            }
            var newPatternName = txt.Text;
            if (!Regex.IsMatch(newPatternName, @"^[a-zA-Z0-9_]+$"))
            {
                Logger.Log = $"Name '{newPatternName}' contains illegal characters! Only letters, numbers and underscores are permitted";
                return;
            }
            _patternDatabase.AddPattern(new Pattern() { name = newPatternName, points = _characteristicPoints });
            Logger.Log = $"Added pattern '{newPatternName}' to known patterns";
            txt.Text = "";
        }

        internal void ProcessDrawnPattern(List<Point> points)
        {
            if (points == null) return;
            var bbox = MathUtils.GetBoundingBox(_points);
            var bboxSize = (bbox.Item2 - bbox.Item1);
            if (Math.Max(bboxSize.X, bboxSize.Y) < 75)
            {
                Logger.Log = $"Stroke too small, area: {bboxSize}";
                _pointsValid = false;
                return;
            }
        }

        internal void AddNewStroke(TextBox txt)
        {
            if (_rawPoints == null)
            {
                MessageBox.Show("Stroke invalid");
                return;
            }
            if (txt.Text.Length == 0)
            {
                MessageBox.Show("Stroke name too short");
                return;
            }
            var newStrokeName = txt.Text;

            var isPattern = Regex.IsMatch(newStrokeName, @"^[A-Z]");
            _strokeDatabase.AddStroke(new Stroke() { name = newStrokeName, points = _rawPoints, isPattern = isPattern});
            Logger.Log = $"Added stroke '{newStrokeName}' to strokes database isPattern {isPattern}";
            txt.Text = "";
        }
    }
}
