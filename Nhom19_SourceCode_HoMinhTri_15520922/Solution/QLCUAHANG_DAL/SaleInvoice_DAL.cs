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
    public class SaleInvoice_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;

        public static List<SaleInvoice_DTO> LoadSaleInvoice()
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getSaleInvoice]", con);
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

            List<SaleInvoice_DTO> saleInvoiceList = new List<SaleInvoice_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SaleInvoice_DTO invoice = new SaleInvoice_DTO();
                invoice.TransID = Convert.ToInt32(dt.Rows[i]["TransID"].ToString());
                invoice.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerId"].ToString());
                invoice.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                invoice.CreateDate = Convert.ToDateTime(dt.Rows[i]["TransDate"].ToString());
                invoice.TotalPrice = Convert.ToDouble(dt.Rows[i]["TotalPrice"].ToString());

                saleInvoiceList.Add(invoice);
            }
            DataProvider.CloseConnection(con);
            return saleInvoiceList;
        }

        public static bool InsertSaleInvoice(SaleInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertSaleInvoice]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@CreateDate", invoice.CreateDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CustomerID", invoice.CustomerId);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK,MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool UpdateSaleInvoice(SaleInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateSaleInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CreateDate", invoice.CreateDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CustomerID", invoice.CustomerId);
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

        public static bool DeleteSaleInvoice(SaleInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteSaleInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@TransID", invoice.TransID);
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
