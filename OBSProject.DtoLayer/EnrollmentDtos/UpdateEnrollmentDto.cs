using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DtoLayer.EnrollmentDtos
{
    public class UpdateEnrollmentDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool Status { get; set; }
        public string Remarks { get; set; }
    }

}
