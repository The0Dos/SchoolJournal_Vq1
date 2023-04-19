using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolJournalDesktop.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        public string? Name { get; set; }

        public virtual List<User> Users { get; set; } = new();
    }
}
