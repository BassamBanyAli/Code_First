using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Course
    {
        [Key]  // Primary key annotation
        public int CourseId { get; set; }
        public string Title { get; set; }

        public int TeacherId { get; set; }  // Foreign key property

        [ForeignKey("TeacherId")]  // This annotation indicates that TeacherId is the foreign key
        public virtual Teacher Teacher { get; set; }  // Navigation property to the Teacher
    }
}