namespace WykryjMycha
{
    static class Logger // TODO: singleton
    {
        internal static MainForm _mainFormInstance;
        internal static bool debugMode = true;

        public static string Log { get { return _mainFormInstance?.GetConsoleTextBox().Text; } set { _mainFormInstance?.GetConsoleTextBox().AppendText(DateTime.Now.ToString("HH:mm:ss > ") + value + Environment.NewLine); } }

        public static string DebugLog { get { return _mainFormInstance?.GetConsoleTextBox().Text; } set { if(debugMode)_mainFormInstance?.GetConsoleTextBox().AppendText(DateTime.Now.ToString("HH:mm:ss [DEBUG]> ") + value + Environment.NewLine); } }
    }
}
