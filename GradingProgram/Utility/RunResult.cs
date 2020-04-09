using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public enum RunResultEnum { Successful, BuildError, RunError, BuildTimeError, RunTimeError, MemoryLimit, CorrectAnswer, WrongAnswer }

    public class RunResult
    {
        public RunResultEnum Result { get; set; }

        public int ExitCode { get; set; }

        public int RunTime { get; set; }

        public float UsedMemory { get; set; }

        public string Output { get; set; }

        public string Error { get; set; }

        public string OutputFile { get; set; }
    }
}
