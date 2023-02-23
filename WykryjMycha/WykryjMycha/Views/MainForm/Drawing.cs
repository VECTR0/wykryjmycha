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
    }
}
