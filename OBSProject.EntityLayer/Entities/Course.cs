using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.EntityLayer.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public int Quota { get; set; }
        public string Semester { get; set; }
        public bool IsActive { get; set; }

        public List<Transcript> Transcripts { get; set; }
    }
}
