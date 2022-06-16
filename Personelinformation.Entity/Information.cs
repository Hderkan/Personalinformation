using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Entity
{
    public class Information
    {
        public int InformationID { get; set; }

        public string PersonelName  { get; set; }

        public string PersonelSurname { get; set; }
        
        public int DetailInformationID { get; set; }
        
        public int PersonelInformationID { get; set; }


        public DetailInformation DetailInformation { get; set; }

        public PersonelInformation PersonelInformation { get; set; }
    }
}
