using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;


namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {

        static public DataTable GetAllTable()
        {
            string query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, 
                            CASE
                            WHEN People.Gendor = '0' THEN 'Male'
                            Else 'Female'
                            END AS Gender,
                            People.DateOfBirth, Countries.CountryName, People.Phone, People.Email
                            FROM   People INNER JOIN Countries 
                            ON People.NationalityCountryID = Countries.CountryID;";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Code;
                ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
         
        static public int AddNewPerson(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, 
        DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
       {
            int PersonID = -1;

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                           VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);  

            if(ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);            
           
            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int inserted))
                {
                    PersonID = inserted;
                }
                
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                return PersonID;
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
       }

        static public bool IsNationalNO_Exist(string National_NO)
        {
            bool isfound = false;

            string query = "SELECT NationalNo FROM People WHERE NationalNo = @NationalNo";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", National_NO);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isfound = true;
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return isfound;
            }
            finally
            {
                connection.Close();
            }
            return isfound;


        }

        static public bool DeletePerson(int PersonID)
        {
            bool IsNotReferences = false;
            string query = @"IF EXISTS (SELECT 1 FROM Users WHERE Users.PersonID = @PersonID)
                             OR EXISTS (SELECT 1 FROM Applications WHERE Applications.ApplicantPersonID = @PersonID)
                             OR EXISTS (SELECT 1 FROM Drivers WHERE Drivers.PersonID = @PersonID)
                             BEGIN 
                                 SELECT 1
                             END
                             
                             ELSE
                             BEGIN 
                             	DELETE FROM People WHERE People.PersonID = @PersonID
                             END;
                             ;";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                int roweffected = command.ExecuteNonQuery();

                if(roweffected > 0)
                {
                    IsNotReferences = true;
                }
               
            }
            catch(SqlException ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
            return IsNotReferences;
        }

        static public bool UpdatePerson(int PersonID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName,
        DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            bool isupdated = false;

            string query = @"UPDATE People SET 
                            NationalNo = @NationalNo,
                            FirstName = @FirstName, 
                            SecondName = @SecondName,
                            ThirdName = @ThirdName,
                            LastName= @LastName,
                            DateOfBirth = @DateOfBirth,
                            Gendor = @Gendor,
                            Address = @Address,
                            Phone = @Phone,
                            Email = @Email,
                            NationalityCountryID = @NationalityCountryID,
                            ImagePath = @ImagePath
                            WHERE PersonID = @PersonID;";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                int roweffected = command.ExecuteNonQuery();

                if(roweffected > 0)
                {
                    isupdated = true;
                }
            }
            catch(SqlException ex)
            {
                ex.Message.ToString();
            }
            finally 
            {
                connection.Close();
            }

            return isupdated;
        }
        
        static public bool FindPersonByID(int PersonID, ref string NationalNO, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
        ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isfound = false;

            string query = @"SELECT * FROM People WHERE People.PersonID = @PersonID;";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    NationalNO = (string)reader["NationalNO"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = reader["ThirdName"] == DBNull.Value? null : (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = reader["Email"] == DBNull.Value? null : (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == DBNull.Value? null: (string)reader["ImagePath"];

                    isfound = true;
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

    }
};