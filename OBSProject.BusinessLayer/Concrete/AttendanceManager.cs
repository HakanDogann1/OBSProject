using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.AttendanceDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class AttendanceManager : GenericService<ResultAttendanceDto, CreateAttendanceDto, UpdateAttendanceDto, Attendance>, IAttendanceService
    {
        public AttendanceManager(IGenericRepository<Attendance> genericRepository) : base(genericRepository)
        {
        }
    }
}
