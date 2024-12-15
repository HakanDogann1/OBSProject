using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.CourseDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class CourseManager : GenericService<ResultCourseDto, CreateCourseDto, UpdateCourseDto, Course>, ICourseService
    {
        public CourseManager(IGenericRepository<Course> genericRepository) : base(genericRepository)
        {
        }
    }
}
