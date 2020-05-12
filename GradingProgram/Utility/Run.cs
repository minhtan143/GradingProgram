using System;
using System.Diagnostics;

namespace GradingProgram
{
    public class Run
    {
        public static RunResult RunExeFile(string exeFile, string input, int timeLimit, long memoryLimit)
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
                long peakWorkingSet = 0;
                double totalMilliseconds = 0;
                memoryLimit = memoryLimit * 1024 * 1024;

                using (Process process = Process.Start(StartInfo))
                {
                    if (!String.IsNullOrEmpty(input))
                        process.StandardInput.WriteLine(input);

                    while (!process.HasExited) 
                    {
                        try
                        {
                            process.Refresh();
                            peakWorkingSet = process.PeakWorkingSet64;
                            if (peakWorkingSet > memoryLimit)
                            {
                                process.Kill();
                                runResult.Result = RunResultEnum.MemoryLimit;
                                break;
                            }
                            totalMilliseconds = process.UserProcessorTime.TotalMilliseconds;
                            if (totalMilliseconds > timeLimit)
                            {
                                process.Kill();
                                runResult.Result = RunResultEnum.TimeLimit;
                            }
                        }
                        catch { }
                    }

                    runResult.ExitCode = process.ExitCode;
                    runResult.UsedMemory = peakWorkingSet < 1024 * 1024 ? 1 : peakWorkingSet / (1024 * 1024);
                    runResult.RunTime = totalMilliseconds < 1 ? 1 : (int)totalMilliseconds;

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
