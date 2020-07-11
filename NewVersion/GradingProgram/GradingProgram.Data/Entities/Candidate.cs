using System.Collections;
using System.Collections.Generic;

namespace GradingProgram.Data.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? ExamId { get; set; }
        public bool? Status { get; set; }
     
        public Exam Exam { get; set; }
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();
    }
}
