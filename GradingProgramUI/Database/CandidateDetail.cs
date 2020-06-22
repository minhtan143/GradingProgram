using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("CandidateDetail")]
    public class CandidateDetail
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Candidate")]
        public int CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Exam")]
        public int ExamID { get; set; }

        public Candidate Candidate { get; set; }

        public Exam Exam { get; set; }
    }
}
