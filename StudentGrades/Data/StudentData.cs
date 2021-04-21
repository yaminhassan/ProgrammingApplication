using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App03;
using StudentGrades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using System.Data.Entity;


namespace StudentGrades.Data
{
    public class StudentData : DbContext
    {
        public StudentData(DbContextOptions<StudentData> options) : base(options)
        { }
         public DbSet<Student> Student { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<PhotoPost> Photos { get; set; }
        public DbSet<MessagePost> MessagePosts { get; set; }
        
    }
}
