using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolJournalDesktop.Models
{
    public class AcademicYear
    {
        [Key]
        public int IdAcademicYear { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public string BeginEnd => BeginDate.ToString("dd.MM.yyyy") + " - " + EndDate.ToString("dd.MM.yyyy");

        public virtual List<RegisterJournal> RegisterJournals { get; set; } = new();
    }
}
