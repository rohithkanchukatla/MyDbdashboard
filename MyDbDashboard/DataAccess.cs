using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MyDbDashboard
{

    public class DataAccess
    {
        // Get the connection string from Web.config
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        }

        // Method to get a list of databases (for our dropdown)
        public static DataTable GetDatabaseList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetDatabaseList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Method to get details for a single database
        public static DataTable GetDatabaseDetails(int dbId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetDatabaseDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DBID", dbId); // Add the parameter
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}