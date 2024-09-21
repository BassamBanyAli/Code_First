using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Task> Tasks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {





            base.OnModelCreating(modelBuilder);
        }


      
    }
}