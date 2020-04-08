using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Result")]
    class Result
    {
        [Key]
        [Column(Order = 0)]
        public string CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TestCaseID { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? RunTime { get; set; }

        public int? UsedMemory { get; set; }

        public int? Mark { get; set; }

        [Column(TypeName = "ntext")]
        public string Notification { get; set; }
    }
}
