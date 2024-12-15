using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.StudentDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Abstract
{
    public interface IStudentService:IGenericService<ResultStudentDto,CreateStudentDto,UpdateStudentDto,Student>
    {
    }
}
