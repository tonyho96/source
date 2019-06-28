using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCUAHANG_DTO;
using QLCUAHANG_DAL;

namespace QLCUAHANG_BUS
{
    public class ServiceInvoice_BUS
    {
        public static List<ServiceInvoice_DTO> ServiceInvoiceLoad(int serviceTransId)
        {
            return ServiceInvoice_DAL.ServiceInvoiceLoad(serviceTransId);
        }

        public static bool InsertServiceInvoice(ServiceInvoice_DTO invoice)
        {
            return ServiceInvoice_DAL.InsertServiceInvoice(invoice);
        }

        public static bool UpdateServiceInvoice(ServiceInvoice_DTO invoice)
        {
            return ServiceInvoice_DAL.UpdateServiceInvoice(invoice);
        }

        public static bool DeleteServiceInvoice(ServiceInvoice_DTO invoice)
        {
            return ServiceInvoice_DAL.DeleteServiceInvoice(invoice);
        }
    }
}
