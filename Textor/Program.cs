using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length >= 2)
            {
                Application.Run(new MainForm(arguments[1]));
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
