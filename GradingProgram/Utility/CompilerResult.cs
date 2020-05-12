using System.IO;

namespace GradingProgram
{
    public class CompilerResult
    {
        public FileInfo OutputFile { get; set; }

        public string Error { get; set; }

        public int CompilerTime { get; set; }

        public long UsedMemory { get; set; }

        public int ExitCode { get; set; }
    }
}
