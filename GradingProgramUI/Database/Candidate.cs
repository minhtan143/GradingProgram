using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key]
        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; } = true;
    }
}
