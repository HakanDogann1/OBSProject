using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DtoLayer.CourseDtos
{
    public class ResultCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public int Quota { get; set; }
        public string Semester { get; set; }
        public bool IsActive { get; set; }
    }
}
