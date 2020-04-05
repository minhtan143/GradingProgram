using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProject
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
            MessageBox.Show(Compiler.BuildCppFile(new System.IO.FileInfo(@"F:\aaaaaaaa\aa.cpp"), 3000).UsedMemory.ToString());
            MessageBox.Show(Compiler.BuildCppFile(new System.IO.FileInfo(@"F:\aaaaaaaa\a.cpp"), 3000).UsedMemory.ToString());
            Application.Run(new Form1());
        }
    }
}
