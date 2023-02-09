using EventHook.Hooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WykryjMycha
{
    public partial class DebugWindow : Form
    {
        internal readonly MainWindow mainFormInstance;
        private bool _mouseDown = false;
        private List<Vector2>? _points;
        private List<Vector2>? _characteristicPoints;

        public DebugWindow(MainWindow mainFormInstance)
        {
            this.mainFormInstance = mainFormInstance;
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void DrawPoint(int x, int y)
        {
            using Graphics g = Graphics.FromImage(picTest.Image);
            _points?.Add(new Vector2(x, y));
            g.DrawRectangle(Pens.Black, x, y, 1, 1);
            picTest.Invalidate();
        }

        private void DrawPoints(List<Vector2> points, Brush brush, float size = 3)
        {
            using Graphics g = Graphics.FromImage(picTest.Image);
            points.ForEach(p =>
            {
                g.FillEllipse(brush, p.X - size / 2, (float)(p.Y - size / 2), size * 2, size * 2);
            });
            picTest.Invalidate();
        }

        private void DrawLines(List<Vector2> points, Pen pen)
        {
            using Graphics g = Graphics.FromImage(picTest.Image);
            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(pen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            picTest.Invalidate();
        }

        private void DrawCircles(List<Vector2> points, Pen pen, float size = 3)
        {
            using Graphics g = Graphics.FromImage(picTest.Image);
            points.ForEach(p =>
            {
                g.DrawEllipse(pen, p.X - size / 2, (float)(p.Y - size / 2), size * 2, size * 2);
            });
            picTest.Invalidate();
        }

        private void picTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 0 || e.Y < 0 || e.X > picTest.Width || e.Y > picTest.Height) _mouseDown = false;
            if (_mouseDown) DrawPoint(e.X, e.Y);
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {
            ClearDrawingBoard();
        }

        private void picTest_Paint(object sender, PaintEventArgs e) { }

        private void picTest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                ClearDrawingBoard();
                _points = new List<Vector2>();
                DrawPoint(e.X, e.Y);
            }
        }

        private void picTest_MouseLeave(object sender, EventArgs e)
        {
            _mouseDown = false;
        }

        private void picTest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ClearDrawingBoard();
            }
        }

        private void picTest_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            if (_points == null) return;
            var bbox = PatternMatcher.GetBoundingBox(_points);
            var bboxSize = (bbox.Item2 - bbox.Item1);
            if (Math.Max(bboxSize.X, bboxSize.Y) < 75)
            {
                mainFormInstance.Log = $"Stroke too small, area: {bboxSize}";
                return;
            }
            _points = PatternMatcher.NormalizePoints(_points);
            ClearDrawingBoard();
            DrawPoints(_points, Brushes.Black, 1.5f);
            _characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(_points!);
            DrawCircles(_characteristicPoints!, Pens.Red, 6);
            mainFormInstance.Log = mainFormInstance.matcher.MatchPattern(_characteristicPoints!) ?? "No match";
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            if (txtPatternName.Text.Length == 0)
            {
                MessageBox.Show("Pattern name too short");
                return;
            }
            var newPatternName = txtPatternName.Text;
            mainFormInstance.matcher.AddPattern(new Pattern() { name = newPatternName, points = _characteristicPoints! }); // TODO: add preprocesing and characteristic points extraction
            txtPatternName.Text = "";
            mainFormInstance.Log = $"Added pattern '{newPatternName}' to known patterns";
            mainFormInstance.editor.UpdatePatternsList();
        }

        private void ClearDrawingBoard()
        {
            var oldImage = picTest.Image;
            picTest.Image = new Bitmap(picTest.Width, picTest.Height);
            oldImage?.Dispose();
        }
    }
}
