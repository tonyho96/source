using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCUAHANG_DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
    public class ServiceInvoice_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;

        public static List<ServiceInvoice_DTO> ServiceInvoiceLoad(int serviceTransId)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getServiceInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransID", serviceTransId);
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

            List<ServiceInvoice_DTO> serviceInvoiceList = new List<ServiceInvoice_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ServiceInvoice_DTO serviceInvoice = new ServiceInvoice_DTO();
                serviceInvoice.ServiceTransId = Convert.ToInt32(dt.Rows[i]["ServiceTransID"].ToString());
                serviceInvoice.Createdate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"].ToString());
                serviceInvoice.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerID"].ToString());
                serviceInvoice.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                serviceInvoice.Total = float.Parse(dt.Rows[i]["Total"].ToString());
                serviceInvoice.Prepaid = float.Parse(dt.Rows[i]["Prepaid"].ToString());
                serviceInvoice.Remain = float.Parse(dt.Rows[i]["Remain"].ToString());
                serviceInvoice.Status = dt.Rows[i]["Status"].ToString();

                serviceInvoiceList.Add(serviceInvoice);
            }
            DataProvider.CloseConnection(con);
            return serviceInvoiceList;
        }

        public static bool InsertServiceInvoice(ServiceInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_InsertServiceInvoice]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@CreateDate", invoice.Createdate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CustomerID", invoice.CustomerId);
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

        public static bool UpdateServiceInvoice(ServiceInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_UpdateServiceInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransID", invoice.ServiceTransId);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CreateDate", invoice.Createdate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CustomerID", invoice.CustomerId);
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

        public static bool DeleteServiceInvoice(ServiceInvoice_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_DeleteServiceInvoice]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransID", invoice.ServiceTransId);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.CloseConnection(con);
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
