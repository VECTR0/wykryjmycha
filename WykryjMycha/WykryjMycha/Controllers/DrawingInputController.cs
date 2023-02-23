﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class DrawingInputController
    {
        private bool _mouseDown = false;
        private List<Vector2> _points;
        
        internal DrawingInputController(PatternDatabase patternDatabase, ...)
        {
            _points = new List<Vector2>();
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

        internal void HandleDrawingMouseDown(MouseEventArgs e, PictureBox pic)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                DrawUtils.ClearPictureBox(pic);
                _points = new List<Vector2>();
                _points?.Add(new Vector2(e.X, e.Y));
                DrawUtils.DrawPoint(e.X, e.Y, pic);
            }
        }
        internal void HandleDrawingMouseLeave()
        {
            _mouseDown = false;
        }

        internal void HandleDrawingMouseClick(MouseEventArgs e, PictureBox pic)
        {
            if (e.Button == MouseButtons.Right)
            {
                DrawUtils.ClearPictureBox(pic);
            }
        }

        internal void HandleDrawingMouseUp(MouseEventArgs e, PictureBox pic)
        {
            _mouseDown = false;
            ProcessDrawnPattern(_points);

            _points = MathUtils.NormalizePoints(_points);
            DrawUtils.ClearPictureBox(pic);
            DrawUtils.DrawPoints(_points, Brushes.Black, pic, 1.5f);
            //var _characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(_points!);
            //DrawUtils.DrawCircles(_characteristicPoints!, Pens.Red, picDrawing, 6);
            //Logger.Log = mainFormInstance.matcher.MatchPattern(_characteristicPoints!) ?? "No match";
        }

        internal void AddNewPattern(TextBox txt)
        {
            if (txt.Text.Length == 0)
            {
                MessageBox.Show("Pattern name too short");
                return;
            }
            var newPatternName = txt.Text;
            PatternDatabase.AddPattern(new Pattern() { name = newPatternName, points = _points });
            Logger.Log = $"Added pattern '{newPatternName}' to known patterns";
            mainFormInstance.editor.UpdatePatternsList();
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
                return;
            }
        }
    }
}
