using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("TestCase")]
    public partial class TestCase
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Input { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? TimeOut { get; set; } = 1000;

        public int? MemoryLimit { get; set; } = 250000;

        public int? Mark { get; set; }

        public string QuestionID { get; set; }
    }
}
