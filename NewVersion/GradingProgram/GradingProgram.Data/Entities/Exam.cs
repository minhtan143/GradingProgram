using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GradingProgram.Data.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Folder { get; set; }
        public DateTime? CreateDate { get; set; }
        [DefaultValue(true)]
        public bool? Status { get; set; }

        public ICollection<Candidate> Candidates { get; set; } = new HashSet<Candidate>();
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
    }
}
