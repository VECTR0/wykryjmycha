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

        private void picTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 0 || e.Y < 0 || e.X > picTest.Width || e.Y > picTest.Height) _mouseDown = false;
            if (_mouseDown)
            {
                _points?.Add(new Vector2(e.X, e.Y));
                DrawUtils.DrawPoint(e.X, e.Y, picTest);
            }
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {
            DrawUtils.ClearPictureBox(picTest);
        }

        private void picTest_Paint(object sender, PaintEventArgs e) { }

        private void picTest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                DrawUtils.ClearPictureBox(picTest);
                _points = new List<Vector2>();
                _points?.Add(new Vector2(e.X, e.Y));
                DrawUtils.DrawPoint(e.X, e.Y, picTest);
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
                DrawUtils.ClearPictureBox(picTest);
            }
        }

        private void picTest_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            if (_points == null) return;
            var bbox = MathUtils.GetBoundingBox(_points);
            var bboxSize = (bbox.Item2 - bbox.Item1);
            if (Math.Max(bboxSize.X, bboxSize.Y) < 75)
            {
                mainFormInstance.Log = $"Stroke too small, area: {bboxSize}";
                return;
            }
            _points = MathUtils.NormalizePoints(_points);
            DrawUtils.ClearPictureBox(picTest);
            DrawUtils.DrawPoints(_points, Brushes.Black, picTest, 1.5f);
            _characteristicPoints = CharacteristicPointsFinder.GetCharacteristicPoints(_points!);
            DrawUtils.DrawCircles(_characteristicPoints!, Pens.Red, picTest, 6);
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
    }
}
