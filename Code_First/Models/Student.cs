﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}