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

    }
}
