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
        public static List<SaleInvoiceDetails_DTO> LoadChiTietPhieuBan()
        {
            return SaleInvoiceDetails_DAL.LoadChiTietPhieuBan();
        }
        public static bool ThemChiTietPHBan(SaleInvoiceDetails_DTO phieu)
        {
            return SaleInvoiceDetails_DAL.ThemChiTietPHBanHang(phieu);
        }

        public static bool XoaChiTietPHBan(SaleInvoiceDetails_DTO phieunhap)
        {
            return SaleInvoiceDetails_DAL.XoaChiTietPhieuBanHang(phieunhap);
        }

        public static bool SuaChiTietPHBan(SaleInvoiceDetails_DTO phieu)
        {
            return SaleInvoiceDetails_DAL.SuaChiTietPhieuBanHang(phieu);
        }
        public static string TimDonViSanPham(string t)
        {
            return SaleInvoiceDetails_DAL.TimDonViSanPham(t);
        }
        public static string ThongSoMax(string t)
        {
            return SaleInvoiceDetails_DAL.ThongSoMax(t);
        }
        public static string SoLuongMax(string t)
        {
            return SaleInvoiceDetails_DAL.SoLuongMax(t);
        }
    }
}
