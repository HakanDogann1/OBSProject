using OBSProject.DtoLayer.GradeDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Abstract
{
    public interface IGradeService:IGenericService<ResultGradeDto,CreateGradeDto,UpdateGradeDto,Grade>
    {
    }
}
