using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
   public class PostInvoice_DAL
    {

        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static List<PostInvoice_DTO> PostInvoiceLoad()
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                //con.ChangeDatabase("JEWELRYSTOREMGMT");
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getPostInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();

                da.Fill(dt);
            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

            List<PostInvoice_DTO> PostInvoiceList = new List<PostInvoice_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PostInvoice_DTO postInvoice = new PostInvoice_DTO();
                postInvoice.TransID = Convert.ToInt32(dt.Rows[i]["TransID"].ToString());
                postInvoice.VendorID = Convert.ToInt32(dt.Rows[i]["VendorID"].ToString());
                postInvoice.VendorName = dt.Rows[i]["VendorName"].ToString();
                postInvoice.Address = dt.Rows[i]["Address"].ToString();
                postInvoice.PhoneNo = dt.Rows[i]["PhoneNo"].ToString();
                postInvoice.CreateDate = Convert.ToDateTime(dt.Rows[i]["TransDate"].ToString());
                postInvoice.TotalPrice = Convert.ToDouble(dt.Rows[i]["TotalPrice"].ToString());
                PostInvoiceList.Add(postInvoice);
            }
            DataProvider.CloseConnection(con);
            return PostInvoiceList;
        }

        public static bool InsertPostInvoice(PostInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_InsertPostInvoice]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@CreateDate", invoice.CreateDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@VendorID", invoice.VendorID);
                cmd.Parameters.Add(p);
                
                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch
            {
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool UpdatePostInvoice(PostInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_UpdatePostInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CreateDate", invoice.CreateDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@VendorID", invoice.VendorID);
                cmd.Parameters.Add(p);
                

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch
            {
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool DeletePostInvoice(PostInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_DeletePostInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                DataProvider.CloseConnection(con);
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
