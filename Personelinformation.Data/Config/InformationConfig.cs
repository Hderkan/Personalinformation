using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Config
{
    class InformationConfig : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.HasData(
            new Information { InformationID = 1, PersonelName = "Hakan", PersonelSurname = "Derkan", DetailInformationID = 1, PersonelInformationID = 1 },
               new Information { InformationID = 2, PersonelName = "Adnan", PersonelSurname = "Derkan", DetailInformationID = 2, PersonelInformationID = 2 },
               new Information { InformationID = 3, PersonelName = "Konuralp", PersonelSurname = "Derkan", DetailInformationID = 3, PersonelInformationID = 3 }

               );
        }
    }
}
