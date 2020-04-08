using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Question")]
    class Question
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public DateTime? CreateDate { get; set; }

        [DefaultValue(true)]
        public bool? Status { get; set; }
    }
}
