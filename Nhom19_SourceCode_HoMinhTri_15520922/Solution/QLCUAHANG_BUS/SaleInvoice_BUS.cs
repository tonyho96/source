using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class SaleInvoice_BUS
    {
        public static List<SaleInvoice_DTO> LoadSaleInvoice()
        {
            return SaleInvoice_DAL.LoadSaleInvoice();
        }

        public static bool InsertSaleInvoice(SaleInvoice_DTO invoice)
        {
            return SaleInvoice_DAL.InsertSaleInvoice(invoice);
        }

        public static bool UpdateSaleInvoice(SaleInvoice_DTO invoice)
        {
            return SaleInvoice_DAL.UpdateSaleInvoice(invoice);
        }

        public static bool DeleteSaleInvoice(SaleInvoice_DTO invoice)
        {
            return SaleInvoice_DAL.DeleteSaleInvoice(invoice);
        }
    }
}
