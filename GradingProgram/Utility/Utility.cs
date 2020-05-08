using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
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

        public static async void Grading(int examId)
        {
            SettingGrading settingGrading = new SettingGrading();
            List<ExamDetail> questions = BLExamDetail.GetExamDetails(x => x.ExamID == examId, y => y).ToList();
            DirectoryInfo dirExam = new DirectoryInfo(BLExam.GetExam(examId).Folder);
            DirectoryInfo[] dirCandidates = dirExam.GetDirectories();


            frmExaminationProcess fep = new frmExaminationProcess();
            fep.pbCandidate.Maximum = dirCandidates.Length;
            fep.pbCandidate.Value = 0;
            fep.Show();

            foreach (DirectoryInfo dirCandidate in dirCandidates)
            {
                Candidate candidate = new Candidate();
                if (BLCandidate.Exists(dirCandidate.Name))
                    candidate = BLCandidate.GetCandidate(dirCandidate.Name);
                else
                {
                    candidate.Code = dirCandidate.Name;
                    BLCandidate.Add(candidate);
                }

                fep.pbQuestion.Maximum = questions.Count;
                fep.pbQuestion.Value = 0;

                foreach (ExamDetail question in questions)
                {
                    FileInfo[] file = dirCandidate.GetFiles(question.FileName + ".*");
                    if (file.Length > 0)
                    {
                        CompilerResult compilerResult = Compiler.FileCompiler(file, 5000);
                        List<TestCase> testCases = BLTestCase.GetTestCases(question.QuestionID).ToList();

                        fep.pbTestcase.Maximum = testCases.Count;
                        fep.pbTestcase.Value = 0;

                        foreach (TestCase testCase in testCases)
                        {
                            Result result = new Result();
                            result.ExamID = examId;
                            result.CandidateID = candidate.ID;
                            result.TestCaseID = testCase.ID;

                            if (compilerResult.OutputFile != null)
                            {
                                RunResult runResult = Run.RunExeFile(compilerResult.OutputFile.FullName, testCase.Input, testCase.TimeLimit.Value, testCase.MemoryLimit.Value);

                                result.RunTime = runResult.RunTime;
                                result.UsedMemory = runResult.UsedMemory;
                                result.Output = runResult.Output;

                                if (runResult.Result == RunResultEnum.RunError)
                                    result.Notification = runResult.Error;
                                else result.Notification = runResult.Result.ToString();

                                FileInfo tFile = new FileInfo(dirExam.FullName + "\\Temp\\" + "TOutput.txt");
                                FileInfo cFile = new FileInfo(dirExam.FullName + "\\Temp\\" + "COutput.txt");
                                StreamWriter writer;
                                writer = new StreamWriter(tFile.FullName);
                                writer.Write(testCase.Output);
                                writer = new StreamWriter(cFile.FullName);
                                writer.Write(runResult.Output);
                                writer.Close();

                                if (ComparatorOutput.Comparator(tFile, cFile, settingGrading.Comparator))
                                    result.Mark = testCase.Mark;
                            }
                            else
                            {
                                result.Notification = compilerResult.Error;
                            }

                            BLResult.AddOrUpdate(result);

                            fep.pbTestcase.Value++;
                            fep.rtbNotifications.Text += "\n" + dirCandidate.Name + " - " + question.FileName + " - " + testCase.Name + "\t:\t" + result.Notification;
                        }
                    }

                    fep.pbQuestion.Value++;
                }

                fep.pbCandidate.Value++;
            }
        }
    }
}
