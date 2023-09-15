using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClassLibrary.Connection.ConnectionModel;

namespace WebApiClassLibrary.Repository
{
    public class FoodRepo: IFoodRepo
    {
        private readonly Context _context;

        public FoodRepo(Context con)
        {
            _context = con;
        }
        public void SP_Delete(int EmpID)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec deleteFoodID {EmpID}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FoodModels> SP_GetAllRegistration()
        {
            try
            {
                var lst = _context.FoodModels.FromSqlRaw<FoodModels>($"exec SelectFood").ToList();

                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FoodModels SP_GetRegistrationById(int empId)
        {
            try
            {
                var lst = _context.FoodModels.FromSqlRaw<FoodModels>($"exec selectFoodID").FirstOrDefault();

                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SP_Save(FoodModels data)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec insertFood '{data.FirstName}','{data.LastName}','{data.Age}','{data.Email}','{data.Gender}'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SP_Update(FoodModels data)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec updateFoodID '{data.EmpID}' '{data.FirstName}','{data.LastName}','{data.Age}','{data.Email}','{data.Gender}' ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
