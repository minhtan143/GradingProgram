using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class Run
    {
        public static RunResult RunExecutableFile(string pathFile, string input, int timeLimit, long memoryLimit)
        {
            switch (pathFile.Substring(pathFile.LastIndexOf('.')).ToLower())
            {
                case ".exe": return RunFile(pathFile, "", input, timeLimit, memoryLimit);
                case ".class": return RunFile(@"Utility\VC\bin\javac.exe", pathFile, input, timeLimit, memoryLimit);
                case ".py": return RunFile(pathFile, "", input, timeLimit, memoryLimit);
                default: return new RunResult() { Result = RunResultEnum.RunError, Error = "Malformed" };
            }
        }

        public static RunResult RunFile(string fileName, string arguments, string input, int timeLimit, long memoryLimit)
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo();

            StartInfo.FileName = fileName;
            StartInfo.Arguments = arguments;
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
                memoryLimit = memoryLimit * 1024 * 1024;

                using (Process process = Process.Start(StartInfo))
                {
                    if (!String.IsNullOrEmpty(input))
                        process.StandardInput.WriteLine(input);

                    Task.Run(() => 
                    {
                        if (!process.WaitForExit(timeLimit))
                        {
                            process.Kill();
                            runResult.Result = RunResultEnum.TimeLimit;
                        }
                    });

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
                        }
                        catch { }
                    }

                    runResult.ExitCode = process.ExitCode;
                    runResult.UsedMemory = peakWorkingSet < 1024 * 1024 ? 1 : peakWorkingSet / (1024 * 1024);
                    runResult.RunTime = (process.ExitTime - process.StartTime).TotalMilliseconds < 1 ? 1 : (int)(process.ExitTime - process.StartTime).TotalMilliseconds;

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
    }
}
