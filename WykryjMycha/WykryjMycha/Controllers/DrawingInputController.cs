using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WykryjMycha
{
    internal class DrawingInputController
    {
        internal MainForm drawingView;
        private bool _mouseDown = false;
        private List<Vector2> _points, _characteristicPoints;
        private bool _pointsValid = false;
        private PatternDatabase _patternDatabase;
        private PatternMatcher _patternMatcher;
        private CharacteristicPointsFinder _characteristicPointsFinder;
        private bool _strokesStarted = false;

        internal DrawingInputController(MainForm instance, PatternDatabase patternDatabase, PatternMatcher patternMatcher, CharacteristicPointsFinder characteristicPointsFinder)
        {
            drawingView = instance;
            _points = new List<Vector2>();
            _patternDatabase = patternDatabase;
            _patternMatcher = patternMatcher;
            _characteristicPointsFinder = characteristicPointsFinder;
            drawingView.ClearDrawingBoard();
        }

        internal void FinishedStroke()
        {
            _strokesStarted = false;
            _pointsValid = true;
            ProcessDrawnPattern(_points);

            _points = MathUtils.NormalizePoints(_points);
            drawingView.ClearDrawingBoard();
            drawingView.RenderDrawingStroke(_points);
            _characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(_points!);
            drawingView.RenderStrokeCharacteristicPoints(_characteristicPoints);
            Logger.Log = _patternMatcher.MatchPattern(_characteristicPoints, _patternDatabase) ?? "No match";
        }

        private void ResetTimer(System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Start();
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
                    _points = new List<Vector2>();
                }
                _mouseDown = true;

                _points?.Add(new Vector2(e.X, e.Y));
                DrawUtils.DrawPoint(e.X, e.Y, pic);
            }
        }

        internal void HandleDrawingMouseMove(int x, int y, PictureBox pic)
        {
            if (x < 0 || y < 0 || x > pic.Width || x > pic.Height) _mouseDown = false;
            if (_mouseDown)
            {
                _points?.Add(new Vector2(x, y));
                DrawUtils.DrawPoint(x, y, pic);
            }
        }

        internal void HandleDrawingMouseUp(MouseEventArgs e, PictureBox pic)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = false;
                drawingView.StartDrawingTimer();
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
            _patternDatabase.AddPattern(new Pattern() { name = newPatternName, points = _characteristicPoints });
            Logger.Log = $"Added pattern '{newPatternName}' to known patterns";
            txt.Text = "";
        }

        internal void ProcessDrawnPattern(List<Vector2> points)
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
    }
}
