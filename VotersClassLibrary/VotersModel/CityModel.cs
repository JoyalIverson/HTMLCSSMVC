using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotersClassLibrary.VotersModel
{
    public class CityModel
    {
        public int VoterID { get; set; }
        [Required]
        public string City { get; set; }
    }
}
