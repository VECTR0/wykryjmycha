using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    partial class MainForm
    {
        private DrawingInputController _drawingInputController;

        internal void ResetDrawingTimer()
        {
            tmrDrawing.Stop();
            tmrDrawing.Start();
        }

        internal void StartDrawingTimer(int interval)
        {
            tmrDrawing.Interval = interval;
            tmrDrawing.Start();
        }
        internal void StopDrawingTimer()
        {
            tmrDrawing.Stop();
        }

        private void tmrDrawing_Tick(object sender, EventArgs e)
        {
            _drawingInputController.FinishedStroke();
            tmrDrawing.Stop();
        }

        internal void ClearDrawingBoard()
        {
            DrawUtils.ClearPictureBox(picDrawing);
        }

        internal void RenderDrawingStroke(List<Vector2> points)
        {
            DrawUtils.DrawPoints(points, Brushes.Black, picDrawing, 1.5f);
        }

        internal void RenderStrokeCharacteristicPoints(List<Vector2> characteristicPoints)
        {
            DrawUtils.DrawCircles(characteristicPoints, Pens.Red, picDrawing, 6);
        }

        private void picDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            _drawingInputController.HandleDrawingMouseMove(e.X, e.Y, picDrawing);
        }

        private void picDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            _drawingInputController.HandleDrawingMouseDown(e, picDrawing);
        }

        private void picDrawing_MouseLeave(object sender, EventArgs e)
        {
            _drawingInputController.HandleDrawingMouseLeave();
        }

        private void picDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            _drawingInputController.HandleDrawingMouseClick(e, picDrawing);
        }

        private void picDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            _drawingInputController.HandleDrawingMouseUp(e, picDrawing);    
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            _drawingInputController.AddNewPattern(txtNewPatternName);
        }
        private void btnAddStroke_Click(object sender, EventArgs e)
        {
            _drawingInputController.AddNewStroke(txtNewPatternName);
        }
    }
}
