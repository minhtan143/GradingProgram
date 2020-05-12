using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace GradingProgram
{
    public class Compiler
    {
        public static DataTable SettingCompiler { get; set; }

        public static CompilerResult FileCompiler(FileInfo[] files, string fileName, int timeLimit)
        {
            CompilerResult compilerResult = new CompilerResult();
            if (files.Length == 0)
                return compilerResult;

            FileInfo file;
            for (int i = 0; i < SettingCompiler.Rows.Count; i++)
            {
                file = files.SingleOrDefault(x => x.Name == fileName + SettingCompiler.Rows[i].ItemArray[0].ToString());

                if (file != null)
                {
                    if (SettingCompiler.Rows[i].ItemArray[0].ToString() == ".exe" || SettingCompiler.Rows[i].ItemArray[0].ToString() == ".class")
                    {
                        compilerResult.OutputFile = file;
                        return compilerResult;
                    }

                    string commands = SettingCompiler.Rows[i].ItemArray[1].ToString();
                    if (commands.Contains(';'))
                        commands = commands.Substring(0, commands.IndexOf(';'));
                    commands = commands.Replace("%PATH%", file.DirectoryName + @"\");
                    commands = commands.Replace("%NAME%", fileName);
                    commands = commands.Replace("%EXT%", SettingCompiler.Rows[i].ItemArray[0].ToString());

                    string[] command = commands.Split('|');

                    if (SettingCompiler.Rows[i].ItemArray[0].ToString() == ".java")
                        compilerResult.OutputFile = new FileInfo(file.FullName.Substring(0, file.FullName.LastIndexOf('.')) + ".class");
                    else compilerResult.OutputFile = new FileInfo(file.FullName.Substring(0, file.FullName.LastIndexOf('.')) + ".exe");
                    if (compilerResult.OutputFile.Exists)
                        File.Delete(compilerResult.OutputFile.FullName);

                    ProcessStartInfo StartInfo = new ProcessStartInfo();
                    if (command.Length > 2)
                        StartInfo.WorkingDirectory = command[2];

                    StartInfo.FileName = command[0].Trim();
                    StartInfo.Arguments = command[1].Trim();
                    StartInfo.UseShellExecute = false;
                    StartInfo.CreateNoWindow = true;
                    StartInfo.ErrorDialog = false;
                    StartInfo.RedirectStandardInput = false;
                    StartInfo.RedirectStandardError = true;
                    StartInfo.RedirectStandardOutput = false;

                    try
                    {
                        long peakWorkingSet = 0;
                        double totalMilliseconds = 0;

                        using (Process process = Process.Start(StartInfo))
                        {
                            while (!process.HasExited)
                            {
                                try
                                {
                                    process.Refresh();
                                    peakWorkingSet = process.PeakWorkingSet64;
                                    totalMilliseconds = process.UserProcessorTime.TotalMilliseconds;
                                    if (totalMilliseconds > timeLimit)
                                    {
                                        process.Kill();
                                        new Exception("Compiler time limit");
                                    }
                                }
                                catch { }
                            }

                            compilerResult.ExitCode = process.ExitCode;
                            compilerResult.UsedMemory = peakWorkingSet < 1024 * 1024 ? 1 : peakWorkingSet / (1024 * 1024);
                            compilerResult.CompilerTime = totalMilliseconds < 1 ? 1 : (int)totalMilliseconds;

                            if (process.StandardError != null)
                                compilerResult.Error = process.StandardError.ReadToEnd();

                            compilerResult.OutputFile.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        compilerResult.Error = ex.Message;
                        compilerResult.OutputFile = null;
                    }
                    break;
                }
            }
            return compilerResult;
        }
    }
}
