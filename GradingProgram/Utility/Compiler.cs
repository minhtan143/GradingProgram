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
            compilerResult.Error = "File not found";

            foreach (DataRow row in SettingCompiler.Rows)
            {
                FileInfo file = files.SingleOrDefault(x => x.Name.ToLower() == fileName.ToLower() + row.ItemArray[0].ToString().ToLower());

                if (file != null)
                {
                    foreach (DataRow row1 in SettingCompiler.Rows)
                    {
                        if (file.FullName.Substring(file.FullName.LastIndexOf('.')).ToLower() == row1.ItemArray[0].ToString().ToLower())
                        {
                            string commands = row1.ItemArray[1].ToString();
                            if (commands.Contains(';'))
                                commands = commands.Substring(0, commands.IndexOf(';'));

                            if (String.IsNullOrEmpty(commands))
                            {
                                compilerResult.OutputFile = file;
                                return compilerResult;
                            }

                            commands = commands.Replace("%PATH%", file.DirectoryName + @"\");
                            commands = commands.Replace("%NAME%", fileName);
                            commands = commands.Replace("%EXT%", row1.ItemArray[0].ToString());

                            string[] command = commands.Split('|');

                            switch (row1.ItemArray[0].ToString().ToLower())
                            {
                                case ".java": compilerResult.OutputFile = new FileInfo(file.FullName.Substring(0, file.FullName.LastIndexOf('.')) + ".class"); break;
                                default: compilerResult.OutputFile = new FileInfo(file.FullName.Substring(0, file.FullName.LastIndexOf('.')) + ".exe"); break;
                            }
                            
                            if (compilerResult.OutputFile.Exists)
                                File.Delete(compilerResult.OutputFile.FullName);

                            ProcessStartInfo StartInfo = new ProcessStartInfo();
                            if (command.Length > 1)
                                StartInfo.WorkingDirectory = file.DirectoryName;

                            StartInfo.FileName = "cmd.exe";
                            StartInfo.UseShellExecute = false;
                            StartInfo.CreateNoWindow = true;
                            StartInfo.ErrorDialog = false;
                            StartInfo.RedirectStandardInput = true;
                            StartInfo.RedirectStandardError = true;
                            StartInfo.RedirectStandardOutput = false;

                            try
                            {
                                using (Process process = Process.Start(StartInfo))
                                {
                                    process.StandardInput.WriteLine(command[0]);
                                    process.StandardInput.WriteLine("exit");

                                    if (!process.WaitForExit(timeLimit))
                                    {
                                        process.Kill();
                                        new Exception("Compiler time limit");
                                    }

                                    compilerResult.ExitCode = process.ExitCode;
                                    compilerResult.CompilerTime = (int)(process.ExitTime - process.StartTime).TotalMilliseconds;

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
                            if (compilerResult.OutputFile != null && compilerResult.OutputFile.Exists)
                                break;
                        }
                    }
                    break;
                }
            }
            return compilerResult;
        }
    }
}
