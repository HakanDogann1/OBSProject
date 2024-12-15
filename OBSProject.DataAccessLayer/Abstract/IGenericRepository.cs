﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
