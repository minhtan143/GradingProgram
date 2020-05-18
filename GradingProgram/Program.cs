using System;
using System.Windows.Forms;

namespace GradingProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var a = BLCandidate.GetCandidate(70);
            Application.Run(new frmMain());
        }
    }
}
