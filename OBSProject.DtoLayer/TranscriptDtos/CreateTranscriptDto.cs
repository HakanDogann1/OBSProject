using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DtoLayer.TranscriptDtos
{
    public class CreateTranscriptDto
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public decimal Grade { get; set; }
    }
}
