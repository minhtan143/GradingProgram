using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("ExamDetail")]
    public partial class ExamDetail
    {
        [Key]
        [Column(Order = 0)]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int QuestionID { get; set; }
    }
}
