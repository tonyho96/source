using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public class SaleInvoiceDetails_BUS
    {
        public static List<SaleInvoiceDetails_DTO> LoadSaleInvoiceDetails(int transId)
        {
            return SaleInvoiceDetails_DAL.LoadSaleInvoiceDetails(transId);
        }

        public static bool InsertSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            return SaleInvoiceDetails_DAL.InsertSaleInvoiceDetails(invoice);
        }

        public static bool UpdateSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            return SaleInvoiceDetails_DAL.UpdateSaleInvoiceDetails(invoice);
        }

        public static bool DeleteSaleInvoiceDetails(SaleInvoiceDetails_DTO invoice)
        {
            return SaleInvoiceDetails_DAL.DeleteSaleInvoiceDetails(invoice);
        }
    }
}
