using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.GradeDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class GradeManager : GenericService<ResultGradeDto, CreateGradeDto, UpdateGradeDto, Grade>, IGradeService
    {
        public GradeManager(IGenericRepository<Grade> genericRepository) : base(genericRepository)
        {
        }
    }
}
