using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App03;
using Microsoft.EntityFrameworkCore;

namespace StudentGrades.Data 
{
    public class StudentData : DbContext
    {
        public StudentData(DbContextOptions<StudentData> options) : base(options)
        { }
            public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
