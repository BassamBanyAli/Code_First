using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Code_First.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}