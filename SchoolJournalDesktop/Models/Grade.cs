using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolJournalDesktop.Models
{
    public class Grade
    {
        [Key]
        public int IdGrade { get; set; }

        public int GradeNum { get; set; }

        [ForeignKey("Student")]
        public int IdStudent { get; set; }
        public virtual Student? Student { get; set; }

        [ForeignKey("DateJournalRecord")]
        public int IdDateJournalRecord { get; set; }
        public virtual DateJournalRecord? DateJournalRecord { get; set; }
    }
}
