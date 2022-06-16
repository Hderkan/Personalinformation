using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Business.Abstract
{
    public interface IDetailInformationService
    {
        Task<DetailInformation> GetById(int id);
        Task<List<DetailInformation>> GetAll();
        Task CreateAsync(DetailInformation entity);
        Task UpdateAsync(DetailInformation entity);
        Task DeleteAsync(DetailInformation entity);
    }
}
