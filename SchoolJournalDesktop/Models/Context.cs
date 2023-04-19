using Microsoft.EntityFrameworkCore;

namespace SchoolJournalDesktop.Models
{
    public class MyContext : DbContext
    {
    

        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<RegisterJournal> RegisterJournals { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ScheduleEducationProcess> ScheduleEducationProcesses { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudingClass> StudingClasses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherCard> TeacherCards { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<TeacherPosition> TeacherPositions { get; set; }
        public DbSet<User> Users { get; set; }

        private static MyContext? _context;

        public static MyContext GetContext()
        {
            _context = _context ?? new MyContext();
            return _context;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=192.168.147.55\sqlexpress;User id=sa; pwd=ArbiDOL2+0;Database=SchoolJournalBase;TrustServerCertificate=True")
                .UseLazyLoadingProxies();
        }
    }
}
