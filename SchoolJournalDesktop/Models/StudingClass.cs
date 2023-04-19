using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolJournalDesktop.Models
{
    public class StudingClass
    {
        [Key]
        public int IdStudingClass { get; set; }

        public string? Name { get; set; }

        public int ParallelIndex { get; set; }

        public virtual List<RegisterJournal> RegisterJournals { get; set; } = new();
    }
}
