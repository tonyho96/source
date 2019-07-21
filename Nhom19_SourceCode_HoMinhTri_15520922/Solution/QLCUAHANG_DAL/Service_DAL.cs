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
    public class Service_DAL
    {
        public static List<Service_DTO> LoadService()
        {
            List<Service_DTO> listService = new List<Service_DTO>();
            SqlConnection con = DataProvider.OpenConnection();

            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getServiceList]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Service_DTO service = new Service_DTO();
                service.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                service.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                service.ServicePrice = float.Parse(dt.Rows[i]["ServicePrice"].ToString());

                listService.Add(service);
            }
            DataProvider.CloseConnection(con);

            return listService;
        }

        public static bool InsertService(Service_DTO service)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertService]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ServiceName", service.ServiceName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServicePrice", service.ServicePrice);
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

        public static bool UpdateService(Service_DTO service)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateService]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ServiceID", service.ServiceID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServiceName", service.ServiceName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ServicePrice", service.ServicePrice);
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

        public static bool DeleteService(Service_DTO service)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteService]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ServiceID", service.ServiceID);
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
