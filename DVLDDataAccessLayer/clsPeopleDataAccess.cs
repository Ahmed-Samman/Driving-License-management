using System;
using System.Data;
using System.Data.SqlClient;


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

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
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

    }
}
;