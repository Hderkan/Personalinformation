using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Entity
{
    public class PersonelInformation
    {
        public int PersonelInformationID { get; set; }

        public int  CiltNo{ get; set; }

        public int  AileSiraNo { get; set; }

        public string Title { get; set; }

        List<Information> Informations { get; set; }




    }
}
