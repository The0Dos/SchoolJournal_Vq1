using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolJournalDesktop.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        [ForeignKey("Role")]
        public int IdRole { get; set; }

        public virtual Role? Role { get; set; }
    }
}
