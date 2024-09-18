using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class StudentDetails
    {
        [Key] // Set this as the Primary Key
        [ForeignKey("Student")] // Link it to the Student entity
        public int StudentId { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }

        // Navigation property for the one-to-one relationship
        public virtual Student Student { get; set; }
    }
}