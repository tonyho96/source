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
        public static List<SaleInvoice_DTO> LoadPhieuBan()
        {
            return SaleInvoice_DAL.LoadPhieuBan();
        }
        public static bool ThemPHBan(SaleInvoice_DTO phieu)
        {
            return SaleInvoice_DAL.ThemPHBanHang(phieu);
        }
        public static List<string> LoadDS_MaHDB(string s)
        {
            return SaleInvoice_DAL.LoadDS_MaHDB(s);
        }

        public static bool XoaPHBan(SaleInvoice_DTO phieunhap)
        {
            return SaleInvoice_DAL.XoaPhieuBanHang(phieunhap);
        }

        public static bool SuaPHBan(SaleInvoice_DTO phieu)
        {
            return SaleInvoice_DAL.SuaPhieuBanHang(phieu);
        }

        public static List<SaleInvoice_DTO> DS_KHNoTien()
        {
            return SaleInvoice_DAL.DS_KHNoTien();
        }
        public static List<string> DS_TongNo(string s)
        {
            return SaleInvoice_DAL.DS_TongNo(s);
        }
    }
}
