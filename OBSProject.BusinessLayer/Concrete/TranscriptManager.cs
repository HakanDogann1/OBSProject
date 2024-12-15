using OBSProject.BusinessLayer.Abstract;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DtoLayer.TranscriptDtos;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class TranscriptManager : GenericService<ResultTranscriptDto, CreateTranscriptDto, UpdateTranscriptDto, Transcript>, ITranscriptService
    {
        public TranscriptManager(IGenericRepository<Transcript> genericRepository) : base(genericRepository)
        {
        }
    }
}
