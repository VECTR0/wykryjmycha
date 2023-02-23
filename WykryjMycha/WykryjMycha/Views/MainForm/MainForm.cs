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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;

            Logger._mainFormInstance = this;
            PatternDatabase patternDatabase = new PatternDatabase();
            PatternMatcher patternMatcher = new PatternMatcher();
            CharacteristicPointsFinder characteristicPointsFinder = new CharacteristicPointsFinder();   

            _drawingInputController = new DrawingInputController(patternDatabase, patternMatcher, characteristicPointsFinder);
        }

        public TextBox GetConsoleTextBox() => txtNewPatternName;
    }
}
