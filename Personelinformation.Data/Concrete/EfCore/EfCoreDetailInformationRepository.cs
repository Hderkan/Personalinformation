using Personelinformation.Data.Abstract;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Concrete.EfCore
{
    public class EfCoreDetailInformationRepository : EfCoreGenericRepository<DetailInformation>, IDetailInformationRepository
    {
       
    }
}
