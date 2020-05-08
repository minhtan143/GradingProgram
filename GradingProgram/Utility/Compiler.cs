using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace GradingProgram
{
    public class Compiler
    {
        public static string pathLib = Path.Combine(Directory.GetCurrentDirectory(), "..\\..");

        public static CompilerResult FileCompiler(FileInfo[] files, int timeOut)
        {
            FileInfo file = files.Single(x => !x.Name.Contains(".exe"));

            CompilerResult compilerResult = new CompilerResult();

            compilerResult.OutputFile = new FileInfo(file.FullName.Substring(0, file.FullName.LastIndexOf('.')) + ".exe");
            if (compilerResult.OutputFile.Exists)
                File.Delete(compilerResult.OutputFile.FullName);

            ProcessStartInfo StartInfo = new ProcessStartInfo();
            StartInfo.FileName = pathLib + @"\Utility\MinGW64\bin\g++.exe";
            StartInfo.Arguments = file.FullName + " -o " + compilerResult.OutputFile;
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.ErrorDialog = false;
            StartInfo.RedirectStandardInput = false;
            StartInfo.RedirectStandardError = true;
            StartInfo.RedirectStandardOutput = false;

            try
            {
                using (Process process = Process.Start(StartInfo))
                {
                    long peakWorkingSet = 0;

                    do
                    {
                        process.Refresh();
                        peakWorkingSet = process.PeakWorkingSet64;

                        if (process.TotalProcessorTime.TotalMilliseconds > timeOut)
                        {
                            compilerResult.Error = "Compiler time limit";
                            process.Kill();
                        }
                    }
                    while (!process.HasExited);

                    compilerResult.ExitCode = process.ExitCode;
                    compilerResult.CompilerTime = (int)process.TotalProcessorTime.TotalMilliseconds;
                    compilerResult.UsedMemory = peakWorkingSet;

                    if (!File.Exists(compilerResult.OutputFile.FullName))
                        compilerResult.OutputFile = null;

                    if (process.StandardError != null)
                        compilerResult.Error = process.StandardError.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                compilerResult.Error = ex.Message;
            }

            return compilerResult;
        }

        private static CompilerResult JavaFileCompiler(FileInfo cppFile, int timeOut)
        {
            CompilerResult compilerResult = new CompilerResult();
            return compilerResult;
        }
    }
}
