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
    public class Vendor_DAL
    {
        public static List<Vendor_DTO> LoadVendor()
        {
            List<Vendor_DTO> listVendor = new List<Vendor_DTO>();
            SqlConnection con = DataProvider.OpenConnection();

            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getVendorList]", con);
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
                Vendor_DTO vendor = new Vendor_DTO();
                vendor.VendorID = dt.Rows[i]["VendorID"].ToString();
                vendor.VendorName = dt.Rows[i]["VendorName"].ToString();
                vendor.VendorAddress = dt.Rows[i]["Address"].ToString();
                vendor.VendorPhone = dt.Rows[i]["PhoneNo"].ToString();

                listVendor.Add(vendor);
            }
            DataProvider.CloseConnection(con);

            return listVendor;
        }

        public static bool InsertVendor(Vendor_DTO vendor)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertVendor]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@VendorName", vendor.VendorName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Address", vendor.VendorAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PhoneNo", vendor.VendorPhone);
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

        public static bool UpdateVendor(Vendor_DTO vendor)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateVendor]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@VendorID", vendor.VendorID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@VendorName", vendor.VendorName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Address", vendor.VendorAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PhoneNo", vendor.VendorPhone);
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

        public static bool DeleteVendor(Vendor_DTO vendor)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteVendor]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@VendorID", vendor.VendorID);
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
