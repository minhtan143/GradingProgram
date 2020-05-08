using System;
using System.Diagnostics;

namespace GradingProgram
{
    public class Run
    {
        public static RunResult RunExeFile(string exeFile, string input, int timeLimit, int memoryLimit)
        {
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
                memoryLimit = memoryLimit * 1024 * 1024;
                using (Process process = Process.Start(StartInfo))
                {
                    if (!String.IsNullOrEmpty(input))
                        process.StandardInput.Write(input);

                    long peakWorkingSet = 0;

                    do
                    {
                        process.Refresh();
                        peakWorkingSet = process.PeakWorkingSet64;
                        if (peakWorkingSet > memoryLimit)
                        {
                            process.Kill();
                            runResult.Result = RunResultEnum.MemoryLimit;
                        }

                        if (process.TotalProcessorTime.TotalMilliseconds > timeLimit)
                        {
                            process.Kill();
                            runResult.Result = RunResultEnum.TimeLimit;
                        }
                    }
                    while (!process.HasExited);

                    runResult.ExitCode = process.ExitCode;
                    runResult.RunTime = (int)process.TotalProcessorTime.TotalMilliseconds;
                    runResult.UsedMemory = (int)(peakWorkingSet / (1024 * 1024));

                    if (process.StandardOutput != null)
                        runResult.Output = process.StandardOutput.ReadToEnd();
                    if (process.StandardError != null)
                        runResult.Error = process.StandardError.ReadToEnd();
                }
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
