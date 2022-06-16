using Microsoft.EntityFrameworkCore;
using Personelinformation.Data.Abstract;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Concrete.EfCore
{
    public class EfCoreInformationRepository : EfCoreGenericRepository<Information>, IInformationRepository
    {
        public async Task<List<Information>> GetAllWithDetails()
        {
            using (var _context=new PersonelContext())
            {
                return await _context.Informations.Include(x => x.DetailInformation).Include(x=>x.PersonelInformation).ToListAsync();
            }
        }
    }
}
