using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClassLibrary.Connection.ConnectionModel;

namespace WebApiClassLibrary.Repository
{
    public interface IFoodRepo
    {
           
            public List<FoodModels> SP_GetAllRegistration();

            
            public FoodModels SP_GetRegistrationById(int empId);

            
            public void SP_Save(FoodModels data);

            
            public void SP_Update(FoodModels data);

            
            public void SP_Delete(int empId);
        
    }
}
