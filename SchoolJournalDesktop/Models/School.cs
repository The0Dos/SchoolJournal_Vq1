using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournalDesktop.Models
{
    public class School
    {
        [Key]
        public int IdSchool { get; set; }

        public int Number { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public virtual List<ScheduleEducationProcess> ScheduleEducationProcesses { get; set; } = new();
    }
}
