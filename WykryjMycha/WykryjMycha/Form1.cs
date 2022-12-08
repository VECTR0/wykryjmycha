namespace WykryjMycha;

public partial class MainWindow : System.Windows.Forms.Form
{
    private DataCollector dc;
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

    public string Log { get { return txtConsole.Text; } set { txtConsole.AppendText(DateTime.Now.ToString("HH:mm:ss > ") + value + Environment.NewLine); } }

    public MainWindow()
    {
        CheckForIllegalCrossThreadCalls = false;
        DoubleBuffered = true;

        dc = new DataCollector(patterns, this);

        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dc.eventHandler += (s, e) =>
        {
            lblMouseInfo.Text = String.Format("{0} x,y = ({1,4},{2,4}) dx,dy = ({3,3},{4,3}) angle = {5,6} deltatime = {6,6} Direction = {7} Pattern = {8}", e.message, e.x, e.y, e.dx, e.dy, e.angle, e.deltaTime, e.direction, e.patternName);
        };
        Log = "initialised module";
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        dc.Start();
        Log = "started module";
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        dc.Stop();
        Log = "stopped module";
    }
}