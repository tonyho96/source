using DevExpress.XtraEditors;
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
   public class SaleInvoiceDetails_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;

        public static List<SaleInvoiceDetails_DTO> LoadSaleInvoiceDetails(int transId)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getSaleInvoice_Details]", con);
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

            List<SaleInvoiceDetails_DTO> saleInvoiceDetailsList = new List<SaleInvoiceDetails_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SaleInvoiceDetails_DTO saleInvoiceDetails = new SaleInvoiceDetails_DTO();
                saleInvoiceDetails.TransDetailsID = dt.Rows[i]["TransDetailsID"].ToString();
                saleInvoiceDetails.ProductID = dt.Rows[i]["ProductID"].ToString();
                saleInvoiceDetails.ProductName = dt.Rows[i]["ProductName"].ToString();
                saleInvoiceDetails.ProductCategoryName = dt.Rows[i]["ProductCategoryName"].ToString();
                saleInvoiceDetails.TransQuantity = Convert.ToInt32(dt.Rows[i]["TransQuantity"].ToString());
                saleInvoiceDetails.UnitName = dt.Rows[i]["UnitName"].ToString();
                saleInvoiceDetails.TransPrice = dt.Rows[i]["TransPrice"].ToString();
                saleInvoiceDetails.Total = dt.Rows[i]["Total"].ToString();

                saleInvoiceDetailsList.Add(saleInvoiceDetails);
            }
            DataProvider.CloseConnection(con);
            return saleInvoiceDetailsList;
        }

        public static bool InsertSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertSaleInvoice_Details]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductID", invoice.ProductID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransQuantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Total", invoice.Total);
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

        public static bool UpdateSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateSaleInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransDetailsID", invoice.TransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductID", invoice.ProductID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransQuantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransChange", invoice.TransChange);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Total", invoice.Total);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool DeleteSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteSaleInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransDetailsID", invoice.TransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransChange", invoice.TransChange);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductID", invoice.ProductID);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }
    }
}
