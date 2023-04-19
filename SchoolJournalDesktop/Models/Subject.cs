using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolJournalDesktop.Models
{
    public class Subject
    {
        [Key]
        public int IdSubject { get; set; }

        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public virtual List<RegisterJournal> RegisterJournals { get; set; } = new();
    }
}
