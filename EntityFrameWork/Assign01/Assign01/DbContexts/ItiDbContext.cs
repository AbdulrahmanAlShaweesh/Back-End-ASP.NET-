using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign01.Models;
using Microsoft.EntityFrameworkCore;

namespace Assign01.DbContexts
{
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4971H0U\\SQLEXPRESS;Database=ItiDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<CourseInstructor> CoursesInstructors { get;set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
