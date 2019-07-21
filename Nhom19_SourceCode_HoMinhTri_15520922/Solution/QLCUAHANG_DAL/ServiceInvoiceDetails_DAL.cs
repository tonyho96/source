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
    public class ServiceInvoiceDetails_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;

        public static List<ServiceInvoiceDetails_DTO> LoadServiceInvoiceDetails(int serviceTransId)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getServiceInvoice_Details]", con);
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

            List<ServiceInvoiceDetails_DTO> serviceInvoiceDetailsList = new List<ServiceInvoiceDetails_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ServiceInvoiceDetails_DTO serviceInvoiceDetails = new ServiceInvoiceDetails_DTO();
                serviceInvoiceDetails.ServiceTransDetailsID = Convert.ToInt32(dt.Rows[i]["ServiceTransDetailsID"].ToString());
                serviceInvoiceDetails.ServiceTransID = Convert.ToInt32(dt.Rows[i]["ServiceTransID"].ToString());
                serviceInvoiceDetails.ServiceID = Convert.ToInt32(dt.Rows[i]["ServiceID"].ToString());
                serviceInvoiceDetails.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                serviceInvoiceDetails.ServicePrice = float.Parse(dt.Rows[i]["ServicePrice"].ToString());
                serviceInvoiceDetails.AdditionalPrice = float.Parse(dt.Rows[i]["AdditionalPrice"].ToString());
                serviceInvoiceDetails.TransPrice = float.Parse(dt.Rows[i]["TransPrice"].ToString());
                serviceInvoiceDetails.TransQuantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                serviceInvoiceDetails.TransTotal = float.Parse(dt.Rows[i]["TransTotal"].ToString());
                serviceInvoiceDetails.TransPrepaid = float.Parse(dt.Rows[i]["TransPrepaid"].ToString());
                serviceInvoiceDetails.TransRemain = float.Parse(dt.Rows[i]["TransRemain"].ToString());
                serviceInvoiceDetails.DeliveredDate = Convert.ToDateTime(dt.Rows[i]["DeliveredDate"].ToString());
                serviceInvoiceDetails.TransStatus = dt.Rows[i]["TransStatus"].ToString();

                serviceInvoiceDetailsList.Add(serviceInvoiceDetails);
            }
            DataProvider.CloseConnection(con);
            return serviceInvoiceDetailsList;
        }

        public static bool InsertServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertServiceInvoice_Details]", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransID", invoice.ServiceTransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServiceID", invoice.ServiceID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@AdditionalPrice", invoice.AdditionalPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Quantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransTotal", invoice.TransTotal);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrepaid", invoice.TransPrepaid);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransRemain", invoice.TransRemain);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DeliveredDate", invoice.DeliveredDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransStatus", invoice.TransStatus);
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

        public static bool UpdateServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateServiceInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransDetailsID", invoice.ServiceTransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServiceTransID", invoice.ServiceTransID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServiceID", invoice.ServiceID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@AdditionalPrice", invoice.AdditionalPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrice", invoice.TransPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Quantity", invoice.TransQuantity);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransTotal", invoice.TransTotal);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransPrepaid", invoice.TransPrepaid);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransRemain", invoice.TransRemain);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DeliveredDate", invoice.DeliveredDate);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TransStatus", invoice.TransStatus);
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

        public static bool DeleteServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteServiceInvoice_Details]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceTransDetailsID", invoice.ServiceTransDetailsID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServiceTransID", invoice.ServiceTransID);
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
