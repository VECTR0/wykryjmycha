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
            Settings settings = Settings.GetInstance();
            StrokeDatabase strokeDatabase = new StrokeDatabase();
            Tester tester = new Tester();
            _drawingInputController = new DrawingInputController(this, patternDatabase, patternMatcher, characteristicPointsFinder, settings, strokeDatabase);
            _visualiserController = new VisualiserController(this, patternDatabase);
            _patternEditorController = new PatternEditorController(this, patternDatabase);
            _settingsController = new SettingsController(this, settings);
            _settingsController.Initialize(maxSearchDistance, maxAllowedRotation, maxMergeDistance, minDistance, angleLimitDegree, angleRefPointMinDist, numDrawingTimeout);
            _testingController = new TestingController(this, strokeDatabase, tester);
        }

        public TextBox GetConsoleTextBox() => txtConsole;
    }
}
