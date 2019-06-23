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
   public class PostInvoiceDetails_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;

        public static List<PostInvoiceDetails_DTO> LoadPostInvoiceDetails(int transId)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getPostInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", transId);
                cmd.Parameters.Add(p);

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

            List<PostInvoiceDetails_DTO> postInvoiceDetailsList = new List<PostInvoiceDetails_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PostInvoiceDetails_DTO postInvoiceDetails = new PostInvoiceDetails_DTO();
                postInvoiceDetails.TransDetailsID = dt.Rows[i]["TransDetailsID"].ToString();
                postInvoiceDetails.ProductID = dt.Rows[i]["ProductID"].ToString();
                postInvoiceDetails.ProductName = dt.Rows[i]["ProductName"].ToString();
                postInvoiceDetails.ProductCategoryName = dt.Rows[i]["ProductCategoryName"].ToString();
                postInvoiceDetails.TransQuantity = Convert.ToInt32(dt.Rows[i]["TransQuantity"].ToString());
                postInvoiceDetails.UnitName = dt.Rows[i]["UnitName"].ToString();
                postInvoiceDetails.TransPrice = dt.Rows[i]["TransPrice"].ToString();
                postInvoiceDetails.Weight = dt.Rows[i]["Weight"].ToString();

                postInvoiceDetailsList.Add(postInvoiceDetails);
            }
            DataProvider.CloseConnection(con);
            return postInvoiceDetailsList;
        }

        public static bool InsertPostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertPostInvoice_Details]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductName", invoice.ProductName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductCategoryName", invoice.ProductCategoryName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@UnitName", invoice.UnitName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransQuantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Weight", invoice.Weight);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
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

        public static bool UpdatePostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updatePostInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransDetailsID", invoice.TransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductID", invoice.ProductID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductName", invoice.ProductName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductCategoryName", invoice.ProductCategoryName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@UnitName", invoice.UnitName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransQuantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Weight", invoice.Weight);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool DeletePostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deletePostInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransDetailsID", invoice.TransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductID", invoice.ProductID);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }
    }
}
