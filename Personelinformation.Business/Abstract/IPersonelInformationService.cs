using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Business.Abstract
{
    public interface IPersonelInformationService
    {
        Task<PersonelInformation> GetById(int id);
        Task<List<PersonelInformation>> GetAll();
        Task CreateAsync(PersonelInformation entity);
        Task UpdateAsync(PersonelInformation entity);
        Task DeleteAsync(PersonelInformation entity);
    }
}
