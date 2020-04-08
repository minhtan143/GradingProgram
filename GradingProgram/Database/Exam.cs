using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Exam")]
    class Exam
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string CandidatesFolder { get; set; }

        public DateTime? CreateDate { get; set; }

        [DefaultValue(true)]
        public bool? Status { get; set; }
    }
}
