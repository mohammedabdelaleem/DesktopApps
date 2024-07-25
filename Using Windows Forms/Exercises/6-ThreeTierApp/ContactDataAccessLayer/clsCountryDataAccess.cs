using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName, ref string Code, ref string PhoneCode)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Countries where CountryID=@CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"] as string ?? string.Empty;
                    Code = reader["Code"]!= DBNull.Value ? (string)reader["Code"] : string.Empty;
                    PhoneCode = reader["PhoneCode"] != DBNull.Value ? (string)reader["PhoneCode"] : string.Empty;
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log Exception
                // we are inside class library
                isFound = false;
            }
            finally
            {
                // may be the CLR throw exception during initialization
                // As we know finally blocks must execute
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCountryInfoByName(ref int CountryID, ref string CountryName, ref string Code, ref string PhoneCode)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Countries where CountryName=@CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryID = (int)reader["CountryID"];
                    CountryName = reader["CountryName"] != DBNull.Value ? (string)reader["CountryName"] : string.Empty; // egYPt ==> Egypt as it stored
                    Code = reader["Code"] != DBNull.Value ? (string)reader["Code"] : string.Empty;
                    PhoneCode = reader["PhoneCode"] != DBNull.Value ? (string)reader["PhoneCode"] : string.Empty; ;
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log Exception
                // we are inside class library
                isFound = false;
            }
            finally
            {
                // may be the CLR throw exception during initialization
                // As we know finally blocks must execute
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewCountry(string CountryName, string Code, string PhoneCode)
        {
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Countries (CountryName,Code, PhoneCode)
                        values (@CountryName, @Code, @PhoneCode)
                          select SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    CountryID = insertedID;

            }
            catch (Exception ex)
            {
                // Log Exception
                // we are inside class library
            }
            finally
            {
                // may be the CLR throw exception during initialization
                connection.Close();
            }

            return CountryID;
        }


        public static bool UpdateCountry(int CountryID, string CountryName,string Code, string PhoneCode)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update Countries 
                            set CountryName= @CountryName,
                             Code= @Code ,
                             PhoneCode= @PhoneCode 
                            where CountryID= @CountryID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@PhoneCode", PhoneCode);


            try
            {
                connection.Open();
                RowsEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Log Exception
                // we are inside class library
            }
            finally
            {
                // may be the CLR throw exception during initialization
                connection.Close();
            }

            return RowsEffected > 0;
        }

        public static bool DeleteCountry(int CountryID)
        {
            int RowsEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete Countries
                             where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                RowsEffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // Log Ex.
            }
            finally
            {
                connection.Close();
            }

            return RowsEffected > 0;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Countries";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return dataTable;

        }

        public static bool IsExists(int CountryID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 Found=1 from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    IsFound = true;
            }
            catch (Exception e)
            {
                // Log Ex.
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsExists(string CountryName)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 Found=1 from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    IsFound = true;
            }
            catch (Exception e)
            {
                // Log Ex.
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


    }
}
