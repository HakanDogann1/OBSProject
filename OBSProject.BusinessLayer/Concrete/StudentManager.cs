using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.StudentDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class StudentManager : GenericService<ResultStudentDto, CreateStudentDto, UpdateStudentDto, Student>, IStudentService
    {
        public StudentManager(IGenericRepository<Student> genericRepository) : base(genericRepository)
        {
        }
    }
}
