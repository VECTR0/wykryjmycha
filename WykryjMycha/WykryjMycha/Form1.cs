using System.Text.RegularExpressions;

namespace WykryjMycha;

public partial class MainWindow : System.Windows.Forms.Form
{
    public PatternMatcher matcher;
    public PatternEditor editor;
    private DataCollector _collector;
    private PatternDetector _detector;
    private DebugWindow _debugWindow;
    private readonly GesturePattern[] patterns =
    {
        new GesturePattern {
            name = "V", directions = new MouseDirection[]
                {
                    MouseDirection.DownRight,
                    MouseDirection.UpRight
                }
        },
        new GesturePattern {
            name = "UpRightBox", directions = new MouseDirection[]
                {
                    MouseDirection.Up,
                    MouseDirection.Right,
                    MouseDirection.Down,
                    MouseDirection.Left,
                }
        },
        new GesturePattern {
            name = "DownRightBox", directions = new MouseDirection[]
                {
                    MouseDirection.Down,
                    MouseDirection.Right,
                    MouseDirection.Up,
                    MouseDirection.Left,
                }
        }
    };

    public TextBox GetConsoleTextBox()
    {
        return txtConsole;
    }

    public MainWindow()
    {
        CheckForIllegalCrossThreadCalls = false;
        DoubleBuffered = true;

        Logger._mainFormInstance = this;
        matcher = new PatternMatcher();
        _collector = new DataCollector();
        _detector = new PatternDetector(patterns, this);
        _debugWindow = new DebugWindow(this);
        _debugWindow.Show();
        editor = new PatternEditor(this);
        editor.Show();
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _collector.eventHandler += (s, e) =>
        {
            e = _detector.ProcessMovementEvent(e);
            lblMouseInfo.Text = String.Format("{0} x,y = ({1,4},{2,4}) dx,dy = ({3,3},{4,3}) angle = {5,6} deltatime = {6,6} Direction = {7} Pattern = {8}", e.message, e.x, e.y, e.dx, e.dy, e.angle, e.deltaTime, e.direction, e.patternName);
        };
        Log = "initialised module";
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _collector.Start();
        _detector.Start();
        Log = "started module";
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _collector.Stop();
        Log = "stopped module";
    }
}