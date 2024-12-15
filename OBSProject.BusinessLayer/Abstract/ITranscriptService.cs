using OBSProject.DtoLayer.TranscriptDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Abstract
{
    public interface ITranscriptService:IGenericService<ResultTranscriptDto,CreateTranscriptDto,UpdateTranscriptDto,Transcript>
    {
    }
}
