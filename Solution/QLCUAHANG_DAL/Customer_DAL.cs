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

                DataTable dt = DataProvider.GetDataTable("DSKhachHang", con);

                List<Customer_DTO> customerList = new List<Customer_DTO>();

                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Customer_DTO customer = new Customer_DTO();
                    customer.CustomerID = dt.Rows[i]["MaKH"].ToString();
                    customer.CustomerName = dt.Rows[i]["TenKH"].ToString();
                    customer.CustomerPhone = dt.Rows[i]["SoDT"].ToString();
                    customer.CustomerAddress = dt.Rows[i]["DiaChi"].ToString();

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
            SqlCommand cmd = new SqlCommand("ThemKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaKH", customer.CustomerID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", customer.CustomerName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", customer.CustomerAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", customer.CustomerPhone);
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
            SqlCommand cmd = new SqlCommand("SuaKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaKH", customer.CustomerID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", customer.CustomerName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", customer.CustomerAddress);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", customer.CustomerPhone);
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
            SqlCommand cmd = new SqlCommand("XoaKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaKH", customer.CustomerID);
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

        public static List<Customer_DTO> SearchCustomer(string keyword)
        {
            SqlConnection con = DataProvider.OpenConnection();
            string query = string.Format("EXEC dbo.TimKiemKH @TuKhoa = N'%" + keyword + "%'");
            DataTable dt = DataProvider.GetDataTable(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            
            List<Customer_DTO> customerList = new List<Customer_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer_DTO customer = new Customer_DTO();
                customer.CustomerID = dt.Rows[i]["MaKH"].ToString();
                customer.CustomerName = dt.Rows[i]["TenKH"].ToString();
                customer.CustomerAddress = dt.Rows[i]["DiaChi"].ToString();
                customer.CustomerPhone = dt.Rows[i]["SoDT"].ToString();

                customerList.Add(customer);
            }
            DataProvider.CloseConnection(con);
            return customerList;
        }

        public static List<Customer_DTO> SearchCustomer2(string keyword)
        {
            SqlConnection con = DataProvider.OpenConnection();
            string query = string.Format("EXEC dbo.TimKiemKH2 @TuKhoa = N'%" + keyword + "%'");
        
            DataTable dt = DataProvider.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                
            List<Customer_DTO> customerList = new List<Customer_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer_DTO customer = new Customer_DTO();
                customer.CustomerID = dt.Rows[i]["MaKH"].ToString();
                customer.CustomerName = dt.Rows[i]["TenKH"].ToString();
                customer.CustomerAddress = dt.Rows[i]["DiaChi"].ToString();
                customer.CustomerPhone = dt.Rows[i]["SoDT"].ToString();

                customerList.Add(customer);
            }
            DataProvider.CloseConnection(con);
            return customerList;
        }
    }
}
