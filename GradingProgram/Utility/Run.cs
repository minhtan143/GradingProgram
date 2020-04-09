using System;
using System.Diagnostics;

namespace GradingProgram
{
    public class Run
    {
        public static RunResult RunExeFile(string exeFile, string input, int timeOut, int memoryLimit)
        {
            Process process = new Process();
            ProcessStartInfo StartInfo = new ProcessStartInfo();

            StartInfo.FileName = exeFile;
            StartInfo.Arguments = "";
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.ErrorDialog = false;
            StartInfo.RedirectStandardInput = true;
            StartInfo.RedirectStandardError = true;
            StartInfo.RedirectStandardOutput = true;

            RunResult runResult = new RunResult();
            try
            {
                process = Process.Start(StartInfo);

                if (!String.IsNullOrEmpty(input))
                    process.StandardInput.Write(input);

                if (process.WaitForExit(timeOut))
                {
                    runResult.Result = RunResultEnum.Successful;
                    runResult.RunTime = (process.ExitTime - process.StartTime).Milliseconds;

                    runResult.UsedMemory = GC.GetTotalMemory(false);
                    //Calculate memory usage
                    string pro = Process.GetCurrentProcess().ProcessName;
                    var counter = new PerformanceCounter("Process", "Working Set - Private", pro);
                    //runResult.UsedMemory = counter.NextValue() / 1024;
                    runResult.ExitCode = process.ExitCode;
                }
                else
                {
                    if (!process.HasExited)
                        process.Kill();
                    else
                        runResult.ExitCode = process.ExitCode;
                    runResult.Result = RunResultEnum.RunTimeError;
                }

                if (process.StandardOutput != null)
                    runResult.Output = process.StandardOutput.ReadToEnd();
                if (process.StandardError != null)
                    runResult.Error = process.StandardError.ReadToEnd();
            }
            catch (Exception ex)
            {
                runResult.Result = RunResultEnum.RunError;
                runResult.Error = ex.Message;
            }

            return runResult;
        }

        public static RunResult RunClassFile(string classFile, string input, int timeOut, int memoryLimit)
        {
            RunResult runResult = new RunResult();
            return runResult;
        }
    }
}
