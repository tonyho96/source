using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class ProductCategory_BUS
    {
        public static List<ProductCategory_DTO> LoadProductCategory()
        {
            return ProductCategory_DAL.LoadProductCategory();
        }
        public static bool InsertProductCategory(ProductCategory_DTO category)
        {
            return ProductCategory_DAL.InsertProductCategory(category);
        }
        public static bool UpdateProductCategory(ProductCategory_DTO category)
        {
            return ProductCategory_DAL.UpdateProductCategory(category);
        }
        public static bool DeleteProductCategory(ProductCategory_DTO category)
        {
            return ProductCategory_DAL.DeleteProductCategory(category);
        }
    }
}
