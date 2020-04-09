using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Candidate")]
    public partial class Candidate
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; } = true;
    }
}
