using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VotersClassLibrary.VotersModel
{

        public class Voters
        {
        public Voters()
        {
        Cityname = new List<CityModel>();
        }
            public int VoterID { get; set; }
            public string VotersName { get; set; }
            [Required]
            public string City { get; set; }
            [Required]
            public string VoterAddress { get; set; }
            [Range(18,100)]
            public int Age { get; set; }
            [Required][DataType (DataType.CreditCard)]
            public long AadharNumber { get; set; }

        public List<CityModel> Cityname { get; set; }


        }
    
}
