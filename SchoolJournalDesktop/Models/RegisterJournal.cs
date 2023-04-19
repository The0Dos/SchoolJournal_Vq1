using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SchoolJournalDesktop.Models
{
    public class RegisterJournal
    {
        [Key]
        public int IdRegisterJournal { get; set; }

        public int Number { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public int BadGradesCount => DateJournalRecords.Sum(p => p.BadGradesCount);

        [ForeignKey("ScheduleEducationProcess")]
        public int IdScheduleEducationProcess { get; set; }
        public virtual ScheduleEducationProcess? ScheduleEducationProcess { get; set; }

        [ForeignKey("Subject")]
        public int IdSubject { get; set; }
        public virtual Subject? Subject { get; set; }

        [ForeignKey("TeacherCard")]
        public int IdTeacherCard { get; set; }
        public virtual TeacherCard? TeacherCard { get; set; }

        [ForeignKey("AcademicYear")]
        public int IdAcademicYear { get; set; }
        public virtual AcademicYear? AcademicYear { get; set; }

        [ForeignKey("StudingClass")]
        public int IdStudingClass { get; set; }
        public virtual StudingClass? StudingClass { get; set; }

        public virtual List<DateJournalRecord> DateJournalRecords { get; set; } = new();
    }
}
