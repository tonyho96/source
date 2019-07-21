using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class Customer_BUS
    {
        public static List<Customer_DTO> LoadCustomerList()
        {
            return Customer_DAL.LoadCustomerList();
        }

        public static bool InsertCustomer(Customer_DTO customer)
        {
            return Customer_DAL.InsertCustomer(customer);
        }

        public static bool UpdateCustomer(Customer_DTO customer)
        {
            return Customer_DAL.UpdateCustomer(customer);
        }

        public static bool DeleteCustomer(Customer_DTO customer)
        {
            return Customer_DAL.DeleteCustomer(customer);
        }
    }
}
