using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    static class Logger // TODO: singleton
    {
        internal static MainForm _mainFormInstance;

        public static string Log { get { return _mainFormInstance?.GetConsoleTextBox().Text; } set { _mainFormInstance?.GetConsoleTextBox().AppendText(DateTime.Now.ToString("HH:mm:ss > ") + value + Environment.NewLine); } }
    }
}
