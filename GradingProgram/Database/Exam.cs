using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string CandidatesFolder { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public bool Status { get; set; } = true;
    }
}
