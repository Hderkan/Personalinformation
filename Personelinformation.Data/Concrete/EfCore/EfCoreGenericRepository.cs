using Microsoft.EntityFrameworkCore;
using Personelinformation.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class

    {
      
        public async Task CreateAsync(TEntity entity)
        {
            using (var _context=new PersonelContext())
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var _context = new PersonelContext())
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var _context = new PersonelContext())
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var _context = new PersonelContext())
            {
                return await _context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var _context = new PersonelContext())
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
