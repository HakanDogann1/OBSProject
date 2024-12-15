using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Abstract
{
    public interface IGenericService<TResult,TCreate,TUpdate,T> where TResult : class
        where TCreate : class 
        where TUpdate : class
        where T : class
    {
        Task<TCreate> AddAsync(TCreate entity);
        TUpdate Update(TUpdate entity);
        Task Delete(int id);
        Task<TResult> GetByIdAsync(int id);
        Task<List<TResult>> GetAllAsync();
    }
}
