using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("TestCase")]
    class TestCase
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Input { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        [DefaultValue(1000)]
        public int? TimeOut { get; set; }

        [DefaultValue(250000)]
        public int? MemoryLimit { get; set; }

        public int? Mark { get; set; }

        public int? QuestionID { get; set; }
    }
}
