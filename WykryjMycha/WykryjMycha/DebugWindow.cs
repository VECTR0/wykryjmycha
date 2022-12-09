using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WykryjMycha
{
    public partial class DebugWindow : Form
    {
        private bool _mouseDown = false;

        public DebugWindow()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void picTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                using Graphics g = Graphics.FromImage(picTest.Image);
                g.DrawRectangle(Pens.Black, e.X, e.Y, 1, 1);
            }
            picTest.Invalidate();
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {
            picTest.Image = new Bitmap(picTest.Width, picTest.Height);
        }

        private void picTest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, 10, 10, 2, 2);
        }

        private void picTest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDown = true;
                picTest.Image = new Bitmap(picTest.Width, picTest.Height);
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
        }
    }
}
