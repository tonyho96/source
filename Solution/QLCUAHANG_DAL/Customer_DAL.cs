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
   public class Customer_DAL
    {
        public static List<Customer_DTO> LoadCustomerList()
        {
            try
            {
                SqlConnection con = DataProvider.OpenConnection();

                DataTable dt = DataProvider.GetDataTable("[JEWELRYSTOREMGMT].[dbo].[usp_getCustomerList]", con);

                List<Customer_DTO> customerList = new List<Customer_DTO>();

                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Customer_DTO customer = new Customer_DTO();
                    customer.CustomerID = dt.Rows[i]["CustomerID"].ToString();
                    customer.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                    customer.CustomerAddress = dt.Rows[i]["Address"].ToString();
                    customer.CustomerPhone = dt.Rows[i]["PhoneNo"].ToString();

                    customerList.Add(customer);
                }
                DataProvider.CloseConnection(con);
                return customerList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool InsertCustomer(Customer_DTO customer)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertCustomer]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@CustomerName", customer.CustomerName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Address", customer.CustomerAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PhoneNo", customer.CustomerPhone);
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

        public static bool UpdateCustomer(Customer_DTO customer)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateCustomer]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@CustomerID", customer.CustomerID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CustomerName", customer.CustomerName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Address", customer.CustomerAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PhoneNo", customer.CustomerPhone);
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

        public static bool DeleteCustomer(Customer_DTO customer)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteCustomer]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@CustomerID", customer.CustomerID);
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
    }
}
