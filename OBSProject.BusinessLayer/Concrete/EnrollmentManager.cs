using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.EnrollmentDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class EnrollmentManager : GenericService<ResultEnrollmentDto, CreateEnrollmentDto, UpdateEnrollmentDto, Enrollment>, IEnrollmentService
    {
        public EnrollmentManager(IGenericRepository<Enrollment> genericRepository) : base(genericRepository)
        {
        }
    }
}
