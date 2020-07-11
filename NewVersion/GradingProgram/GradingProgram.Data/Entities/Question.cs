using System;
using System.Collections.Generic;

namespace GradingProgram.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string File { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Status { get; set; }

        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public ICollection<Testcase> Testcases { get; set; } = new HashSet<Testcase>();
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}
