using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Teacher
    {

        [Key]  // Primary key annotation
        public int TeacherId { get; set; }
        public string Name { get; set; }

        // Navigation property representing the one-to-many relationship with Course
        public virtual ICollection<Course> Courses { get; set; }
    }
}