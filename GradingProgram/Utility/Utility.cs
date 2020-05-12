using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GradingProgram
{
    public enum Compare { CStringCase, CStringIgnoreCase, CNumber, CArrayNumber, CCustom };

    public class Utility
    {
        public static List<TestCase> ScanTestCases(string path)
        {
            List<TestCase> testCases = new List<TestCase>();
            foreach (DirectoryInfo dir in new DirectoryInfo(path).GetDirectories())
            {
                TestCase testCase = new TestCase();
                testCase.Name = dir.Name;

                FileInfo[] fileInps = dir.GetFiles(dir.Name + ".inp");
                if (fileInps.Length > 0)
                    testCase.Input = fileInps.First().OpenText().ReadToEnd();

                FileInfo[] fileOuts = dir.GetFiles(dir.Name + ".out");
                if (fileOuts.Length > 0)
                    testCase.Input = fileOuts.First().OpenText().ReadToEnd();

                testCases.Add(testCase);
            }
            return testCases;
        }

        public static void WriteToSetting(DataTable data)
        {
            StringWriter writer = new StringWriter();
            data.WriteXml(writer, XmlWriteMode.WriteSchema);
            Properties.Settings.Default.SettingCompiler = writer.ToString();
            Properties.Settings.Default.Save();
        }

        public static DataTable ReadFromSetting()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.SettingCompiler))
                return DefaultSettingCompiler();

            DataTable data = new DataTable();
            StringReader reader = new StringReader(Properties.Settings.Default.SettingCompiler);
            data.ReadXml(reader);
            return data;
        }

        public static DataTable DefaultSettingCompiler()
        {
            DataTable data = new DataTable("SettingCompiler");
            data.Columns.Add("FileType");
            data.Columns.Add("Setting");

            data.Rows.Add(".cpp", @"Utility\MinGW64\bin\g++.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".pas", @"Utility\Pascal\fpc.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".c", @"Utility\MinGW64\bin\gcc.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".java", @"Utility\VC\bin\javac.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".py", @"Utility\venv\Scripts\python.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".pp", @"Utility\Pascal\fpc.exe | %PATH%%NAME%%EXT% -o %PATH%%NAME%.exe");
            data.Rows.Add(".exe", ";Nếu không muốn dịch lại khi đã có file .exe, chuyển loại file này lên đầu");
            data.Rows.Add(".class", ";Nếu không muốn dịch lại khi đã có file .class, chuyển loại file này lên đầu");

            WriteToSetting(data);
            return data;
        }

        public static void WriteToBinaryFile(string filePath, Dictionary<string, Compare> objectToWrite)
        {
            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static Dictionary<string, Compare> ReadFromBinaryFile(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (Dictionary<string, Compare>)binaryFormatter.Deserialize(stream);
            }
        }

        public static void Grading(int examId, Dictionary<string, Compare> settingGrading, int timeLimit)
        {
            Compiler.SettingCompiler = ReadFromSetting();
            List<ExamDetail> questions = BLExamDetail.GetExamDetails(x => x.ExamID == examId, y => y).ToList();
            DirectoryInfo dirExam = new DirectoryInfo(BLExam.GetExam(examId).Folder);
            DirectoryInfo[] dirCandidates = dirExam.GetDirectories();

            frmExaminationProcess fep = new frmExaminationProcess();
            fep.Show();

            FileInfo file1 = new FileInfo(dirExam.FullName + "\\Output1.txt");
            FileInfo file2 = new FileInfo(dirExam.FullName + "\\Output2.txt");

            fep.progressBar.Maximum = dirCandidates.Length * questions.Count;
            fep.progressBar.Value = 0;

            foreach (DirectoryInfo dirCandidate in dirCandidates)
            {
                fep.CandidateName = dirCandidate.Name;

                Candidate candidate = new Candidate();
                if (BLCandidate.Exists(dirCandidate.Name))
                    candidate = BLCandidate.GetCandidate(dirCandidate.Name);
                else
                {
                    candidate.Code = dirCandidate.Name;
                    BLCandidate.Add(candidate);
                }

                foreach (ExamDetail question in questions)
                {
                    fep.progressBar.PerformStep();
                    fep.QuestionName = question.FileName;

                    CompilerResult compilerResult = Compiler.FileCompiler(dirCandidate.GetFiles(), question.FileName, timeLimit);
                    List<TestCase> testCases = BLTestCase.GetTestCases(question.QuestionID).ToList();

                    foreach (TestCase testCase in testCases)
                    {
                        fep.TestCaseName = testCase.Name;

                        Result result = new Result();
                        result.ExamID = examId;
                        result.CandidateID = candidate.ID;
                        result.TestCaseID = testCase.ID;

                        if (compilerResult.OutputFile != null && compilerResult.OutputFile.Exists)
                        {
                            RunResult runResult = Run.RunExeFile(compilerResult.OutputFile.FullName, testCase.Input, testCase.TimeLimit.Value, testCase.MemoryLimit.Value);

                            result.RunTime = runResult.RunTime;
                            result.UsedMemory = runResult.UsedMemory;
                            result.Output = runResult.Output;

                            if (runResult.Result != RunResultEnum.Successful)
                                result.Notification = runResult.Result.ToString();
                            else
                            {
                                StreamWriter writer;
                                writer = new StreamWriter(file1.FullName);
                                writer.Write(testCase.Output);
                                writer.Close();
                                writer = new StreamWriter(file2.FullName);
                                writer.Write(runResult.Output);
                                writer.Close();

                                Compare compare = Compare.CStringCase;
                                settingGrading.TryGetValue(question.FileName, out compare);
                                if (Comparer(file1.FullName, file2.FullName, compare, dirExam + "\\" + question.FileName + ".exe"))
                                {
                                    result.Notification = RunResultEnum.CorrectAnswer.ToString();
                                    result.Mark = testCase.Mark;
                                }
                                else result.Notification = RunResultEnum.WrongAnswer.ToString();
                            }
                        }
                        else
                        {
                            result.Notification = compilerResult.Error;
                        }

                        BLResult.AddOrUpdate(result);

                        fep.rtbNotifications.Text += dirCandidate.Name + " - " + question.FileName + " - " + testCase.Name + "\t:" + result.Notification + "\n";
                    }
                }
            }

            file1.Delete();
            file2.Delete();
            fep.Close();
        }

        public static void Grading(int examId, int candidateId, FileInfo[] files, Dictionary<string, Compare> settingGrading, int timeLimit)
        {
            Compiler.SettingCompiler = ReadFromSetting();
            List<ExamDetail> questions = BLExamDetail.GetExamDetails(x => x.ExamID == examId, y => y).ToList();
            Exam exam = BLExam.GetExam(examId);
            Candidate candidate = BLCandidate.GetCandidate(candidateId);

            frmExaminationProcess fep = new frmExaminationProcess();
            fep.Show();

            FileInfo file1 = new FileInfo(exam.Folder + "\\Output1.txt");
            FileInfo file2 = new FileInfo(exam.Folder + "\\Output2.txt");

            fep.progressBar.Maximum = files.Length;
            fep.progressBar.Value = 0;
            fep.CandidateName = candidate.Name;

            foreach (FileInfo file in files)
            {
                ExamDetail question = questions.SingleOrDefault(x => x.FileName == file.Name.Remove(file.Name.LastIndexOf('.')));
                fep.progressBar.PerformStep();
                fep.QuestionName = question.FileName;

                if (question == null || !file.Exists)
                    continue;

                CompilerResult compilerResult = Compiler.FileCompiler(new FileInfo[] { file }, question.FileName, timeLimit);
                List<TestCase> testCases = BLTestCase.GetTestCases(question.QuestionID).ToList();

                foreach (TestCase testCase in testCases)
                {
                    fep.TestCaseName = testCase.Name;

                    Result result = new Result();
                    result.ExamID = examId;
                    result.CandidateID = candidate.ID;
                    result.TestCaseID = testCase.ID;

                    if (compilerResult.OutputFile != null && compilerResult.OutputFile.Exists)
                    {
                        RunResult runResult = Run.RunExeFile(compilerResult.OutputFile.FullName, testCase.Input, testCase.TimeLimit.Value, testCase.MemoryLimit.Value);

                        result.RunTime = runResult.RunTime;
                        result.UsedMemory = runResult.UsedMemory;
                        result.Output = runResult.Output;

                        if (runResult.Result != RunResultEnum.Successful)
                            result.Notification = runResult.Result.ToString();
                        else
                        {
                            StreamWriter writer;
                            writer = new StreamWriter(file1.FullName);
                            writer.Write(testCase.Output);
                            writer.Close();
                            writer = new StreamWriter(file2.FullName);
                            writer.Write(runResult.Output);
                            writer.Close();

                            Compare compare = Compare.CStringCase;
                            settingGrading.TryGetValue(question.FileName, out compare);
                            if (Comparer(file1.FullName, file2.FullName, compare, exam.Folder + "\\" + question.FileName + ".exe"))
                            {
                                result.Mark = testCase.Mark;
                                result.Notification = RunResultEnum.CorrectAnswer.ToString();
                            }
                            else result.Notification = RunResultEnum.WrongAnswer.ToString();
                        }
                    }
                    else
                    {
                        result.Notification = compilerResult.Error;
                    }

                    BLResult.AddOrUpdate(result);

                    fep.rtbNotifications.Text += candidate.Name + " - " + question.FileName + " - " + testCase.Name + "\t:" + result.Notification + "\n";
                }
            }

            file1.Delete();
            file2.Delete();
            fep.Close();
        }

        public static bool Comparer(string file1, string file2, Compare compare, string pathCCustom)
        {
            string path = pathCCustom;
            if (compare != Compare.CCustom)
                path = "Compare\\" + compare.ToString() + ".exe";

            RunResult runResult = Run.RunExeFile(path, file1 + "\n" + file2, 1000, 100);
            if (runResult.Result == RunResultEnum.Successful)
                return runResult.Output.Trim() == "1";
            return false;
        }
    }
}
