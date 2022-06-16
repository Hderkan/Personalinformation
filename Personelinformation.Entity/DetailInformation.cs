using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Entity
{
    public class DetailInformation
    {
        public int DetailInformationID { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string BirthPlace { get; set; }

        List<Information> Informations { get; set; }

        //public DateTime BirthDate { get; set; }

        //public string Genger { get; set; }

        //public int Age { get; set; }





    }
}
