using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the one-to-one relationship
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.StudentDetails)
                .WithRequired(sd => sd.Student);
            modelBuilder.Entity<Teacher>()
       .HasMany(t => t.Courses)             // A Teacher has many Courses
       .WithRequired(c => c.Teacher);     // Each Course has one Teacher



            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Code_First.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<Code_First.Models.Teacher> Teachers { get; set; }
    }
}