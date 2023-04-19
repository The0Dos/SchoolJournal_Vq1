using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SchoolJournalDesktop.Models
{
    public class DateJournalRecord
    {
        [Key]
        public int IdDateJournalRecord { get; set; }

        public DateTime DateRecord { get; set; }

        [ForeignKey("RegisterJournal")]
        public int IdRegisterJournal { get; set; }
        public virtual RegisterJournal? RegisterJournal { get; set; }

        public int BadGradesCount => Grades.Where(p => p.GradeNum <= 3).Count();

        public virtual List<Grade> Grades { get; set; } = new();
    }
}
