using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsCountryDataAccess
    {

        static public DataTable GetAllCountries_FromDatabase()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Countries;";

            SqlConnection connection = new SqlConnection(clsConectionWithDataBase.ConectionWithDataBase);
            SqlCommand command = new SqlCommand(query, connection);

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
                
                ex.Message.ToString();
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
