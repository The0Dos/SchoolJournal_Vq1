using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournalDesktop.Models
{
    public class TeacherPosition
    {
        [Key]
        public int IdTeacherPosition { get; set; }

        public string? Position { get; set; }

        public DateTime BeginWorking { get; set; }

        public double OccupiedRate { get; set; }

        [ForeignKey("TeacherCard")]
        public int IdTeacherCard { get; set; }
        public virtual TeacherCard? TeacherCard { get; set; }

        [ForeignKey("TeacherCategory")]
        public int IdTeacherCategory { get; set; }
        public virtual TeacherCategory? TeacherCategory { get; set; }
    }
}
