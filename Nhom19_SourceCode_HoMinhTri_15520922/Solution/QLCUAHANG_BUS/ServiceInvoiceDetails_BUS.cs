using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCUAHANG_DTO;
using QLCUAHANG_DAL;

namespace QLCUAHANG_BUS
{
    public class ServiceInvoiceDetails_BUS
    {
        public static List<ServiceInvoiceDetails_DTO> LoadServiceInvoiceDetails(int serviceTransId)
        {
            return ServiceInvoiceDetails_DAL.LoadServiceInvoiceDetails(serviceTransId);
        }

        public static bool InsertServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            return ServiceInvoiceDetails_DAL.InsertServiceInvoiceDetails(invoice);
        }

        public static bool UpdateServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            return ServiceInvoiceDetails_DAL.UpdateServiceInvoiceDetails(invoice);
        }

        public static bool DeleteServiceInvoiceDetails(ServiceInvoiceDetails_DTO invoice)
        {
            return ServiceInvoiceDetails_DAL.DeleteServiceInvoiceDetails(invoice);
        }
    }
}
