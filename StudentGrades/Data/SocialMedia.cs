using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using StudentGrades.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;




namespace StudentGrades.Data
{
    public class SocialMedia : DbContext
    {

        public SocialMedia(DbContextOptions<SocialMedia> options) : base(options)
        { }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PhotoPost> Photos { get; set; }
        public DbSet<MessagePost> MessagePosts { get; set; }

      

    }
}
