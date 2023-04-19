using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournalDesktop.Models
{
    public class ScheduleEducationProcess
    {
        [Key]
        public int IdScheduleEducationProcess { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey("School")]
        public int IdSchool { get; set; }
        public virtual School? School { get; set; }

        public virtual List<RegisterJournal> RegisterJournals { get; set; } = new();
    }
}
