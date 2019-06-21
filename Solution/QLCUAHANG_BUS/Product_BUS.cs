using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public  class Product_BUS
    {
        public static List<Product_DTO> LoadSanPHamCH()
        {
            return Product_DAL.LoadSanPhamCH();
        }
        public static Product_DTO TimKiemTenSP(string t) {
            return Product_DAL.TimKiemTenSP(t);
        }
       
        public static bool SuaSPCH(Product_DTO sanpham)
        {
            return Product_DAL.SuaSanPhamCH(sanpham);
        }
        public static bool XoaSPCH(Product_DTO sanpham)
        {
            return Product_DAL.XoaSPCH(sanpham);
        }
    }
}
