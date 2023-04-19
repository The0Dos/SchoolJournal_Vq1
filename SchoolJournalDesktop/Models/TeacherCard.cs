using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournalDesktop.Models
{
    public class TeacherCard
    {
        [Key]
        public int IdTeacherCard { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? FullName => LastName + " " + FirstName + " " + MiddleName;

        public TeacherPosition? NowPosition =>
            TeacherPositions.OrderByDescending(p => p.IdTeacherPosition).FirstOrDefault();

        public virtual List<RegisterJournal> RegisterJournals { get; set; } = new();

        public virtual List<TeacherPosition> TeacherPositions { get; set; } = new();
    }
}
