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
    class PersonelInformationConfig : IEntityTypeConfiguration<PersonelInformation>
        {
            public void Configure(EntityTypeBuilder<PersonelInformation> builder)
            {

                builder.HasData(


             new PersonelInformation { PersonelInformationID = 1, CiltNo = 13, AileSiraNo = 302, Title = "Mühendis" },
                new PersonelInformation { PersonelInformationID = 2, CiltNo = 25, AileSiraNo = 407, Title = "Yazılımcı" },
                new PersonelInformation { PersonelInformationID = 3, CiltNo = 32, AileSiraNo = 123, Title = "Satış Danışmanı" }
               );
            }


        }
    }
