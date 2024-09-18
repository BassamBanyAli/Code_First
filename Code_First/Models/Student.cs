using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Student
    {
        public int StudentId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation property for one-to-one relationship
        public virtual StudentDetails StudentDetails { get; set; }
    }
}