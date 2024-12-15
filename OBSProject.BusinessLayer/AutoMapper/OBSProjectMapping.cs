using AutoMapper;
using OBSProject.DtoLayer.AttendanceDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.AutoMapper
{
    public class OBSProjectMapping:Profile
    {
        public OBSProjectMapping()
        {
            CreateMap<CreateAttendanceDto, Attendance>().ReverseMap();
            CreateMap<UpdateAttendanceDto, Attendance>().ReverseMap();
            CreateMap<ResultAttendanceDto, Attendance>().ReverseMap();
        }
    }
}
