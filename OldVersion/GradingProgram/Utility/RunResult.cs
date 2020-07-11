namespace GradingProgram
{
    public enum RunResultEnum { Successful, RunError, NotResponding, TimeLimit, MemoryLimit, CorrectAnswer, WrongAnswer }

    public class RunResult
    {
        public RunResultEnum Result { get; set; }

        public int ExitCode { get; set; }

        public int RunTime { get; set; }

        public long UsedMemory { get; set; }

        public string Output { get; set; }

        public string Error { get; set; }
    }
}
