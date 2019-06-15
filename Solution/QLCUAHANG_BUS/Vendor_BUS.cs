using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class Vendor_BUS
    {
        public static List<Vendor_DTO> LoadVendor()
        {
            return Vendor_DAL.LoadVendor();
        }
        public static bool InsertVendor(Vendor_DTO vendor)
        {
            return Vendor_DAL.InsertVendor(vendor);
        }
        public static bool UpdateVendor(Vendor_DTO vendor)
        {
            return Vendor_DAL.UpdateVendor(vendor);
        }

        public static bool DeleteVendor(Vendor_DTO vendor)
        {
            return Vendor_DAL.DeleteVendor(vendor);
        }
    }
}
