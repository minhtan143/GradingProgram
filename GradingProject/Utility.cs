using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GradingProject
{
    public class Utility
    {
        public static List<TestCase> ScanTestCases(DirectoryInfo directoryInfo)
        {
            List<TestCase> testCases = new List<TestCase>();
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                TestCase testCase = new TestCase();
                testCase.Name = dir.Name;

                FileInfo[] fileInps = dir.GetFiles("*.inp");
                if (fileInps.Length == 0)
                    new Exception("Can't input file.");
                else if (fileInps.Length > 1)
                    new Exception("There are too many file inputs.");
                testCase.Input = fileInps.First().OpenText().ReadToEnd();

                FileInfo[] fileOuts = dir.GetFiles("*.out");
                if (fileOuts.Length == 0)
                    new Exception("Can't output file.");
                else if (fileOuts.Length > 1)
                    new Exception("There are too many file outputs.");
                testCase.Input = fileOuts.First().OpenText().ReadToEnd();

                testCases.Add(testCase);
            }
            return testCases.OrderBy(x => x.Name).ToList();
        }
    }

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
                //process.MaxWorkingSet = new IntPtr(memoryLimit);
                if (!String.IsNullOrEmpty(input))
                    process.StandardInput.Write(input);

                if (process.WaitForExit(timeOut))
                {
                    runResult.Result = RunResultEnum.Successful;
                    runResult.RunTime = (process.ExitTime - process.StartTime).Milliseconds;
                    //runResult.UsedMemory = process.PeakWorkingSet64;
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

    public enum RunResultEnum { Successful, BuildError, RunError, BuildTimeError, RunTimeError, MemoryLimit, CorrectAnswer, WrongAnswer }

    public class RunResult
    {
        public RunResultEnum Result { get; set; }

        public int ExitCode { get; set; }

        public int RunTime { get; set; }

        public long UsedMemory { get; set; }

        public string Output { get; set; }

        public string Error { get; set; }

        public string OutputFile { get; set; }
    }
}
