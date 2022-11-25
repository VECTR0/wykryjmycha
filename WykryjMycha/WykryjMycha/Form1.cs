namespace WykryjMycha;

public partial class MainWindow : System.Windows.Forms.Form
{
    private DataCollector dc;

    public string Log { get { return txtConsole.Text; } set { txtConsole.AppendText(DateTime.Now.ToString("HH:mm:ss > ") + value + Environment.NewLine); } }

    public MainWindow()
    {
        CheckForIllegalCrossThreadCalls = false;
        DoubleBuffered = true;

        dc = new DataCollector();

        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dc.eventHandler += (s, e) =>
        {
            lblMouseInfo.Text = String.Format("{0} {1,4}:{2,4} {3,3}:{4,3} {5,6} {6,6}", e.message, e.x, e.y, e.dx, e.dy, e.angle, e.deltaTime);
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