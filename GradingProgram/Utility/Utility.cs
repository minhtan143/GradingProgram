using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GradingProgram
{
    public class Utility
    {
        public static List<TestCase> ScanTestCases(DirectoryInfo directoryInfo)
        {
            List<TestCase> testCases = new List<TestCase>();
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                TestCase testCase = new TestCase(0/*string example*/);
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
}
