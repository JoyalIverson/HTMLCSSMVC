using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClassLibrary.Connection.ConnectionModel
{
    public class FoodModels

    {
            [Key]
            public int EmpID { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public int Age { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Gender { get; set; }
        
    }
}
