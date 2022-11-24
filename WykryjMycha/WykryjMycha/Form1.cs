namespace WykryjMycha;

public partial class frmMain : System.Windows.Forms.Form
{
    private DataCollector dc;

    public string Log { get { return txtConsole.Text; } set { txtConsole.AppendText(DateTime.Now.ToString("HH:mm:ss > ") + value + Environment.NewLine); } }

    public frmMain()
    {
        CheckForIllegalCrossThreadCalls = false;
        DoubleBuffered = true;
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dc = new DataCollector();
        dc.eventHandler += (s, e) =>
        {
            lblMouseInfo.Text = $"{e.message} {e.x}:{e.y}";
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