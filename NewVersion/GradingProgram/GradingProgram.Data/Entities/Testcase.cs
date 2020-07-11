using System.Collections.Generic;

namespace GradingProgram.Data.Entities
{
    public class Testcase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public int? TimeLimit { get; set; }
        public int? MemoryLimit { get; set; }
        public int? Mark { get; set; }
        public int? QuestionId { get; set; }

        public Question Question { get; set; }
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}
