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
    public partial class PatternEditor : Form
    {
        internal readonly MainWindow mainFormInstance;

        public PatternEditor(MainWindow mainFormInstance)
        {
            InitializeComponent();
            this.mainFormInstance = mainFormInstance;
        }

        private void lstPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedPattern();
        }

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSavePattern_Click(object sender, EventArgs e)
        {

        }

        private void ShowSelectedPattern()
        {
            ClearDrawingBoard();
            if (lstPatterns.SelectedIndex == -1) return;
        }

        private void ClearDrawingBoard()
        {
            var oldImage = picPattern.Image;
            picPattern.Image = new Bitmap(picPattern.Width, picPattern.Height);
            oldImage?.Dispose();
        }
    }
}
