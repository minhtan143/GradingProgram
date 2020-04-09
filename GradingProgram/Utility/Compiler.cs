using System;
using System.Diagnostics;
using System.IO;

namespace GradingProgram
{
    public class Compiler
    {
        public static string pathLib = Path.Combine(Directory.GetCurrentDirectory(), "..\\..");

        public static RunResult BuildCppFile(FileInfo cppFile, int timeOut)
        {
            Process process = new Process();
            ProcessStartInfo StartInfo = new ProcessStartInfo();
            RunResult runResult = new RunResult();

            runResult.OutputFile = cppFile.FullName.Substring(0, cppFile.FullName.LastIndexOf('.')) + ".exe";

            StartInfo.FileName = pathLib + @"\Utility\MinGW64\bin\g++.exe";
            StartInfo.Arguments = cppFile.FullName + " -o " + runResult.OutputFile;
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.ErrorDialog = false;
            StartInfo.RedirectStandardInput = false;
            StartInfo.RedirectStandardError = true;
            StartInfo.RedirectStandardOutput = false;

            try
            {
                process = Process.Start(StartInfo);
                if (process.WaitForExit(timeOut))
                {
                    runResult.Result = RunResultEnum.Successful;
                    runResult.RunTime = (process.ExitTime - process.StartTime).Milliseconds;
                    runResult.ExitCode = process.ExitCode;
                }
                else
                {
                    if (!process.HasExited)
                        process.Kill();
                    else
                        runResult.ExitCode = process.ExitCode;
                    runResult.Result = RunResultEnum.BuildTimeError;
                }

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

        public static RunResult BuildPythonFile()
        {
            RunResult runResult = new RunResult();
            return runResult;
        }

        public static RunResult BuildJavaFile()
        {
            RunResult runResult = new RunResult();
            return runResult;
        }

        public static RunResult BuildPascalFile()
        {
            RunResult runResult = new RunResult();
            return runResult;
        }
    }
}
