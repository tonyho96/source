using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class ProductCategory_DTO
    {
        private string productCategoryID;
        private string productCategoryName;
        private float percentRevenue;

        public string ProductCategoryID
        {
            get
            {
                return productCategoryID;
            }

            set
            {
                productCategoryID = value;
            }
        }

        public string ProductCategoryName
        {
            get
            {
                return productCategoryName;
            }

            set
            {
                productCategoryName = value;
            }
        }

        public float PercentRevenue
        {
            get
            {
                return percentRevenue;
            }

            set
            {
                percentRevenue = value;
            }
        }
    }
}
