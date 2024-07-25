using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    // ensure that the whole methods are static , you don't need an object to call them
    public class clsPlayersDataAccess
    {

        #region Contact Methods

      
        /// ///////
       
        public static bool GetPlayerInfoByName(ref int ID,  string FirstName,  string LastName,
          ref int Win, ref int Loss, ref int Draw)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Players where FirstName=@FirstName and LastName=@LastName"; // i created an index to speed up the search by (F,L) name
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["ID"] ;
                    Win = reader["Win"] != DBNull.Value ? (int)reader["Win"] : 0;
                    Loss = reader["Loss"] != DBNull.Value ? (int)reader["Loss"] : 0;
                    Draw = reader["Draw"] != DBNull.Value ? (int)reader["Draw"] : 0;                
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

        public static int AddNewPlayer(string FirstName, string LastName
            , int Win=0, int Loss = 0, int Draw = 0)
        {
            int PlayerID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Players (FirstName, LastName, Win , Loss, Draw)
                        values (@FirstName, @LastName, @Win , @Loss, @Draw)
                          select SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Win", Win);
            command.Parameters.AddWithValue("@Loss", Loss);
            command.Parameters.AddWithValue("@Draw", Draw);
          
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    PlayerID = insertedID;

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

            return PlayerID;
        }


        public static bool UpdatePlayer(int PlayerID, string FirstName, string LastName
            , int Win = 0, int Loss = 0, int Draw = 0)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update Players 
                            set FirstName=@FirstName ,
                                LastName=@LastName,
                                Win=@Win,
                                Loss=@Loss,
                                Draw=@Draw
                               
                            where ID=@PlayerID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlayerID", PlayerID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Win", Win);
            command.Parameters.AddWithValue("@Loss", Loss);
            command.Parameters.AddWithValue("@Draw", Draw);
          
            try
            {
                connection.Open();
                RowsEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Log Exception // fire an event 
                // we are inside class library
            }
            finally
            {
                // may be the CLR throw exception during initialization
                connection.Close();
            }

            return RowsEffected > 0;
        }

       
        public static DataView GetAllPlayers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Players";
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

            return dataTable.DefaultView;

        }

        public static DataView GetAllPlayersNames()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select FullName = FirstName + ' ' + LastName  From Players";
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

            return dataTable.DefaultView;

        }

        public static bool IsExists(string FirstName, string LastName)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 Found=1 from Players where FirstName = @FirstName and LastName = @LastName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);

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


        #endregion

    }
}




