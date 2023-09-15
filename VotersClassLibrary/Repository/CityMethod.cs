using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using VotersClassLibrary.VotersModel;

namespace VotersClassLibrary.Repository
{
    public class CityMethod
    {
        public readonly string connectionString;


        public CityMethod()
        {
            connectionString = @"Data source=DESKTOP-DDKSO40\SQLEXPRESS;Initial catalog=VoterDetails;User Id=sa;Password=Anaiyaan@123";
        }


        public void InsertSP(CityModel e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec insertVoterDetails'{e.City}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void updateSP(CityModel e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec updateVoterDetails '{e.VoterID}','{e.City}'");

                con.Close();

            }
            catch (SqlException eu)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<CityModel> SelectSP()
        {
            try
            {
                List<CityModel> constrain = new List<CityModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<CityModel>("exec votersselect").ToList();
                connection.Close();

                return constrain;

            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public void deleteSP(int VoterID)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"  exec deletebasedonlocation {VoterID}");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public CityModel SelectSp1(int VoterID)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var con = connection.QueryFirst<CityModel>($"exec selectVoterDetails {VoterID}");

            connection.Close();

            return con;
        }

    }
}

