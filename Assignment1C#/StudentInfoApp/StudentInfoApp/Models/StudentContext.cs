using Microsoft.EntityFrameworkCore;

namespace StudentInfoApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { 
                    StudentId = 1,
                    Name = "Jerry",
                    Age = 103,
                    Course = "Computer Science"
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Jerry2",
                    Age = 104,
                    Course = "Computer Science"
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Jerry3",
                    Age = 105,
                    Course = "Computer Science"
                }
            );
        }
    }
}
