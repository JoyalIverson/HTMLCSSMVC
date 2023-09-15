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
    public class VotersMethod
    {
        public readonly string connectionString;


        public VotersMethod()
        {
            connectionString = @"Data source=DESKTOP-DDKSO40\SQLEXPRESS;Initial catalog=VoterDetails;User Id=sa;Password=Anaiyaan@123";
        }


        public void InsertSP(Voters e) 
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString );

                con.Open();
                con.Execute($"exec insertVoterDetails '{e.VotersName}','{e.City}','{e.VoterAddress}',{e.Age},{e.AadharNumber}");

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


        public void updateSP(Voters e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec updateVoterDetails '{e.VoterID}','{e.VotersName}','{e.City}','{e.VoterAddress}','{e.Age}','{e.AadharNumber}'");

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


        public List<Voters> SelectSP()
        {
            try
            {
                List<Voters> constrain = new List<Voters>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<Voters>("exec votersselect", connectionString).ToList();
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
                con.Execute($"exec deleteVoterDetails{VoterID}");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Voters SelectSp1 (int VoterID)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var con = connection.QueryFirst<Voters>($"exec selectVoterDetails {VoterID}");

                connection.Close();

                return con;
            }
            catch(SqlException e)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

