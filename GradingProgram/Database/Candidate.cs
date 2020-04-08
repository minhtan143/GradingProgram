using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingProgram
{
    [Table("Candidate")]
    class Candidate
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [DefaultValue(true)]
        public bool? Status { get; set; }
    }
}
