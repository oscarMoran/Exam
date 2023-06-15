using DataBaseManagement.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace DataBaseManagement
{
    public class DBManagement
    {
        readonly string CnnSrtingSP = ConfigurationManager.AppSettings["ConnectionSport"] ?? "no conn supplied";  // config para la conexion// config para la conexion
        public User GetUser(string userName)
        {
            User response = new ();
            try
            {
                using (SqlConnection newConnection = new (CnnSrtingSP))
                {
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    {
                        SqlCommand commandWithSqL = new("SP_GetUser", newConnection);
                        commandWithSqL.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;

                        commandWithSqL.CommandType = CommandType.StoredProcedure; 
                        SqlDataReader CommSqlResult = commandWithSqL.ExecuteReader();
                        while (CommSqlResult.Read())
                        {
                            response.UserName = CommSqlResult[0].ToString();
                            response.Password = CommSqlResult[1].ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Connection problem, verify credentials" + e.Message);
            }

            return response;
        }

        public List<Bank> GetBanks()
        {
            List <Bank> response = new();
            try
            {
                using (SqlConnection newConnection = new(CnnSrtingSP))
                {
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    {
                        SqlCommand commandWithSqL = new("SP_GetBanks", newConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlDataReader CommSqlResult = commandWithSqL.ExecuteReader();
                        while (CommSqlResult.Read())
                        {
                            response.Add(new Bank
                            {
                                Id = int.Parse(CommSqlResult[0].ToString()),
                                Name = CommSqlResult[1].ToString(),
                                Description = CommSqlResult[2].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Connection problem, verify credentials" + e.Message);
            }

            return response;
        }

        public bool InsertLog(string status, int executionNumber, string triggerUser)
        {
            bool response = false;
            try
            {
                using (SqlConnection newConnection = new (CnnSrtingSP))
                {
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    {
                        SqlCommand commandWithSqL = new ("SPI_OperationLog", newConnection);
                        commandWithSqL.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;
                        commandWithSqL.Parameters.Add("@ExecutionNumber", SqlDbType.Int).Value = executionNumber;
                        commandWithSqL.Parameters.Add("@TriggierUser", SqlDbType.VarChar).Value = triggerUser;
                        commandWithSqL.CommandType = CommandType.StoredProcedure; 
                        int CommSqlResult = commandWithSqL.ExecuteNonQuery();
                        response = CommSqlResult == 1;
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("no se pudo realizar la conexion" + e.Message);
            }
            return response;
        }
    }
}