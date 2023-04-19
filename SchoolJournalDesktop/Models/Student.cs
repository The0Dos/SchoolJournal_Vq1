using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournalDesktop.Models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set;}

        public string? MiddleName { get; set; }

        public string? FullName => LastName + " " + FirstName + " " + MiddleName;

        public string? Address { get; set; }

        public string? CurrentClass => Grades.FirstOrDefault()?.DateJournalRecord?.RegisterJournal?.StudingClass?.Name;

        public virtual List<Grade> Grades { get; set; } = new();

        public string? ParentTelephone { get; set; }
    }
}
