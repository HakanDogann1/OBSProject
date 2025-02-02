﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.EntityLayer.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public decimal Ggrade { get; set; }
        public decimal AverageGrade { get; set; }
        public bool PassStatus { get; set; }
    }
}
