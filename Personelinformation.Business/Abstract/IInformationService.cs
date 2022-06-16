using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Business.Abstract
{
    public interface IInformationService
    {
        Task<Information> GetById(int id);
        Task<List<Information>> GetAll();
        Task CreateAsync(Information entity);
        Task UpdateAsync(Information entity);
        Task DeleteAsync(Information entity);
        Task<List<Information>> GetAllWithDetails();


    }
}
