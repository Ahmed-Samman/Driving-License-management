using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {

       
       static public DataTable GetAllTable()
       {
            string query = "select * from People";
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
            }
            finally
            {
                connection.Close();
            }
            return dt;
       }
        
       static public int AddNewPerson(int NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, 
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
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

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
                Console.WriteLine($"Error: {ex}");
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
       }


    }
}
