using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTMLCSSMVC.FoodModels;
using Dapper;
using System.Data.SqlClient;

namespace HTMLCSSMVC.Repository
{
    public class Foodrepository
    {
        public readonly string connectionString;
        public Foodrepository()
        {
            connectionString = @"Data source=DESKTOP-DDKSO40\SQLEXPRESS ; Initial catalog=HTMLCSSMVC ; User Id=sa; Password=Anaiyaan@123";
        }

        public void Insert (FoodModelss data)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute($"exec ProductDetailsInsert '{data.Fullname}','{data.email}','{data.phonenumber}','{data.message}' ");
                con.Close();

            }
            catch(SqlException)
            {
                throw;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
