using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}