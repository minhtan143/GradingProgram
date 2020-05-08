using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Result")]
    public class Result
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Candidate")]
        public int CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Exam")]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("TestCase")]
        public int TestCaseID { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? RunTime { get; set; } = 0;

        public int? UsedMemory { get; set; } = 0;

        public int? Mark { get; set; } = 0;

        [Column(TypeName = "ntext")]
        public string Notification { get; set; }

        public Candidate Candidate { get; set; }

        public Exam Exam { get; set; }

        public TestCase TestCase { get; set; }
    }
}
