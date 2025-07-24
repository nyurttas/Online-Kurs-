using _9_EFOnlineCourseDB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace _9_EFOnlineCourseDB.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YMYP7OnlineCourseDBEF;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamResult>()
                .HasKey(e => new { e.StudentID, e.ExamID });

            modelBuilder.Entity<Registration>()
                .HasKey(e => new { e.StudentID, e.CourseID });

            //Ara tablolarımızda extra bir ID alanı istemiyoruz. Zaten composite key olarak ilgili alanları yukarıda görüldüğü üzere kullanıyoruz.

            modelBuilder.Entity<Registration>()
                .Ignore(e => e.ID);

            modelBuilder.Entity<ExamResult>()
                .Ignore(e => e.ID);
        }
    }
}
