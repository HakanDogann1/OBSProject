using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DtoLayer.AttendanceDtos
{
    public class ResultAttendanceDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool Status { get; set; }
        public string Remarks { get; set; }
        public bool WarningSent { get; set; }
    }
}
