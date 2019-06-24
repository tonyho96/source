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
        public static List<Product_DTO> LoadProduct()
        {
            return Product_DAL.LoadProduct();
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
