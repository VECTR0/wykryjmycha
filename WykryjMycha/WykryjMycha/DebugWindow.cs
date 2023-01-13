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
        private bool _mouseDown = false;
        private List<Vector2> ?_points;


        public DebugWindow()
        {
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

        private void DrawPoints(List<Vector2> points)
        {
            using Graphics g = Graphics.FromImage(picTest.Image);
            points.ForEach(p => {
                g.DrawEllipse(Pens.Red, p.X-4, p.Y-4, 8, 8);
                g.DrawEllipse(Pens.Red, p.X-3, p.Y-3, 6, 6);
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
            picTest.Image = new Bitmap(picTest.Width, picTest.Height);
        }

        private void picTest_Paint(object sender, PaintEventArgs e) { }

        private void picTest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                picTest.Image = new Bitmap(picTest.Width, picTest.Height);
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
                picTest.Image = new Bitmap(picTest.Width, picTest.Height);
            }
        }

        private void picTest_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            DrawPoints(CharacteristicPointsFinder.GetCharacteristicPoints(_points!));
        }
    }
}
