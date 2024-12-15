using OBSProject.BusinessLayer.Abstract;
using OBSProject.BusinessLayer.AutoMapper;
using OBSProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.Concrete
{
    public class GenericService<TResult, TCreate, TUpdate,T> : IGenericService<TResult, TCreate,TUpdate,T> where TResult : class
        where TCreate : class
        where TUpdate : class
        where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<TCreate> AddAsync(TCreate entity)
        {
            var value=await _genericRepository.AddAsync(ObjectMapping.mapper.Map<T>(entity));
            return ObjectMapping.mapper.Map<TCreate>(value);
        }


        public async Task Delete(int id)
        {
            var value = await _genericRepository.GetByIdAsync(id);
            _genericRepository.Delete(value);
        }

        public async Task<List<TResult>> GetAllAsync()
        {
            var values = await _genericRepository.GetAllAsync();
            return ObjectMapping.mapper.Map<List<TResult>>(values);
        }

        public async Task<TResult> GetByIdAsync(int id)
        {
            var value =await _genericRepository.GetByIdAsync(id);
            return ObjectMapping.mapper.Map<TResult>(value);
        }

        public TUpdate Update(TUpdate entity)
        {
            _genericRepository.Update(ObjectMapping.mapper.Map<T>(entity));
            return entity;
        }
    }
}
