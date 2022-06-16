using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task CreateAsync(T entity);
        
        Task  UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
