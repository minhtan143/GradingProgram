using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("ExamDetail")]
    public class ExamDetail
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Exam")]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Question")]
        public int QuestionID { get; set; }

        public string FileName { get; set; }

        public Exam Exam { get; set; }

        public Question Question { get; set; }
    }
}
