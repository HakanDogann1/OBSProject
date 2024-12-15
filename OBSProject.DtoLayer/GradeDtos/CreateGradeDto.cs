using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DtoLayer.GradeDtos
{
    public class CreateGradeDto
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal Ggrade { get; set; }
        public decimal AverageGrade { get; set; }
        public bool PassStatus { get; set; }
    }
}
