using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolJournalDesktop.Models
{
    public class TeacherCategory
    {
        [Key]
        public int IdTeacherCategory { get; set; }

        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public virtual List<TeacherPosition> TeacherPositions { get; set; } = new();
    }
}
