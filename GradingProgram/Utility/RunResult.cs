namespace GradingProgram
{
    public enum RunResultEnum { RunError, TimeLimit, MemoryLimit, CorrectAnswer, WrongAnswer }

    public class RunResult
    {
        public RunResultEnum Result { get; set; }

        public int ExitCode { get; set; }

        public int RunTime { get; set; }

        public int UsedMemory { get; set; }

        public string Output { get; set; }

        public string Error { get; set; }
    }
}
