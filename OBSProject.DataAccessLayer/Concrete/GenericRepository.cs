using Microsoft.EntityFrameworkCore;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private readonly OBSProjectDbContext _context;

        public GenericRepository(OBSProjectDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var values = await _context.Set<T>().ToListAsync();
            return values;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var value = await _context.Set<T>().FindAsync(id);

            return value;
        }

        public T Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }


    }
}
