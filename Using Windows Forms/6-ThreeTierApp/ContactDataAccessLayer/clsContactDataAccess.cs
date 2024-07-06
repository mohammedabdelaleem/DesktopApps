using System.Data;
using System.Data.SqlClient;

namespace ContactDataAccessLayer
{
    // ensure that the whole methods are static , you don't need an object to call them
    public class clsContactDataAccess
    {

        #region Contact Methods
        public static bool GetContactInfoByID(int ID, ref string FirstName, ref string LastName,
          ref string Address, ref string Email, ref string Phone,
         ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Contacts where ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    // imagepath may be null only here in my DB , but i do the checks for practice not more
                    FirstName = (string)reader["FirstName"] as string ?? string.Empty; 
                    LastName = (string)reader["LastName"] as string ?? string.Empty; 
                    Address = (string)reader["Address"] as string ?? string.Empty; 
                    Email = (string)reader["Email"] as string ?? string.Empty; 
                    Phone = (string)reader["Phone"] as string ?? string.Empty; 
                    DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : DateTime.MinValue;
                    CountryID = reader["CountryID"] != DBNull.Value ? (int)reader["CountryID"] : 0;
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;

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

        public static int AddNewContact(string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int ContactID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Contacts (FirstName, LastName, Email , Phone, Address, 
                            DateOfBirth, CountryID , ImagePath)
                        values (@FirstName, @LastName, @Email , @Phone, @Address, @DateOfBirth, @CountryID ,@ImagePath)
                          select SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@ImagePath", (ImagePath != string.Empty) ? ImagePath : DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ContactID = insertedID;

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

            return ContactID;
        }


        public static bool UpdateContact(int ContactID, string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int RowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update Contacts 
                            set FirstName=@FirstName ,
                                LastName=@LastName,
                                Email=@Email,
                                Phone=@Phone,
                                Address=@Address,
                                DateOfBirth=@DateOfBirth,
                                CountryID=@CountryID,
                                ImagePath=@ImagePath
                            where ContactID=@ContactID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@ImagePath", (ImagePath != string.Empty) ? ImagePath : DBNull.Value);

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

        public static bool DeleteContact(int ContactID)
        {
            int RowsEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"delete Contacts
                             where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

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

        public static DataTable GetAllContacts()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Contacts";
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

        public static bool IsExists(int ContactID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 Found=1 from Contacts where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

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



