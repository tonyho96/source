using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//DevExpress.Patch.InMemoryPatch, DevExpress.Patch.Common, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7fc7bfca2443de66
namespace QLCUAHANG_DAL
{
    public class DataProvider
    {
        private static string connectionStr = ConfigurationManager.AppSettings["ConnectionString"];

        public static SqlConnection OpenConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionStr);
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }

        public static DataTable GetDataTable(string query, SqlConnection con)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static void ExecuteNonQuery(string query, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
        }

        public static string ExcuteScalar(string stringSQL)
        {
            string giaTri = "";
            try
            {
                SqlConnection sqlconn = OpenConnection();
                SqlCommand cmd = new SqlCommand(stringSQL, sqlconn);
                giaTri = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return giaTri;
        }
    }
}
