using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("CandidateDetail")]
    public class CandidateDetail
    {
        [Key]
        [Column(Order = 0)]
        public string CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ExamID { get; set; }
    }
}
