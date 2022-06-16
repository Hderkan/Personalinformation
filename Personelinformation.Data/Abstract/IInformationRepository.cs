using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Abstract
{
    public interface IInformationRepository : IRepository<Information>
    {
        Task<List<Information>> GetAllWithDetails();

    }
}
