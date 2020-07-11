using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public bool Status { get; set; } = true;
    }
}
