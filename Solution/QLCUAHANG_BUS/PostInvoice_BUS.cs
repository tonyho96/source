using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class PostInvoice_BUS
    {
        public static List<PostInvoice_DTO> PostInvoiceLoad()
        {
            return PostInvoice_DAL.PostInvoiceLoad();
        }
        public static bool InsertPostInvoice(PostInvoice_DTO invoice)
        {
            return PostInvoice_DAL.InsertPostInvoice(invoice);
        }
        public static bool DeletePostInvoice(PostInvoice_DTO invoice)
        {
            return PostInvoice_DAL.DeletePostInvoice(invoice);
        }

        public static bool UpdatePostInvoice(PostInvoice_DTO invoice)
        {
            return PostInvoice_DAL.UpdatePostInvoice(invoice);
        }
        public static List<string> LoadDS_MaHDNhap(string s)
        {
            return PostInvoice_DAL.LoadDS_MaHDNhap(s);
        }       
    }
}
