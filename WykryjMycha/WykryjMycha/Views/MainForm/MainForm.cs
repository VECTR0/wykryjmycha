namespace WykryjMycha
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;

            Logger._mainFormInstance = this;
            PatternDatabase patternDatabase = new PatternDatabase();
            PatternMatcher patternMatcher = new PatternMatcher();
            CharacteristicPointsFinder characteristicPointsFinder = new CharacteristicPointsFinder();   

            _drawingInputController = new DrawingInputController(this, patternDatabase, patternMatcher, characteristicPointsFinder);
            _visualiserController = new VisualiserController(this, patternDatabase);
            _patternEditorController = new PatternEditorController(this, patternDatabase);
            _settingsController = new SettingsController();
            _settingsController.Initialize(maxSearchDistance, maxAllowedRotation, maxMergeDistance, minDistance, angleLimitDegree, angleRefPointMinDist, numDrawingTimeout);
        }

        public TextBox GetConsoleTextBox() => txtConsole;
    }
}
