using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("TestCase")]
    public class TestCase
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Input { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? TimeLimit { get; set; } = 1000;

        public int? MemoryLimit { get; set; } = 100;

        public int? Mark { get; set; } = 10;

        [ForeignKey("Question")]
        public int QuestionID { get; set; }

        public Question Question { get; set; }
    }
}
