using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProject
{
    public class Compiler
    {
        public static RunResult BuildCpp()
        {
            RunResult runResult = new RunResult();
            return runResult;
        }
    }

    public class Run
    {
        public static RunResult RunExeFile()
        {
            RunResult runResult = new RunResult();
            return runResult;
        }
    }

    public enum RunResultEnum { BuildError, RunError, TimeOut, MemoryLimit }

    public class RunResult
    {
        public RunResultEnum ResultEnum { get; set; }

        public string Error { get; set; }
    }
}
