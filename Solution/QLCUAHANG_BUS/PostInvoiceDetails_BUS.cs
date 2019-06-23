using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public class PostInvoiceDetails_BUS
    {
        public static List<PostInvoiceDetails_DTO> LoadPostInvoiceDetails(int transId)
        {
            return PostInvoiceDetails_DAL.LoadPostInvoiceDetails(transId);
        }

        public static bool InsertPostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            return PostInvoiceDetails_DAL.InsertPostInvoiceDetails(invoice);
        }

        public static bool UpdatePostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            return PostInvoiceDetails_DAL.UpdatePostInvoiceDetails(invoice);
        }

        public static bool DeletePostInvoiceDetails(PostInvoiceDetails_DTO invoice)
        {
            return PostInvoiceDetails_DAL.DeletePostInvoiceDetails(invoice);
        }
    }
}
