using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QLCUAHANG_DTO
{

    public class Product_DTO
    {
        private string productID;
        private string productName;
        private string vendorID;
        private string vendorName;
        private string productCategoryID;
        private string productCategoryName;
        private float percentRevenue;
        private string unitID;
        private string unitName;
        private float importPrice;
        private string imageUrl;
        private string weight;
        private int quantity;

        public string ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public string VendorID
        {
            get
            {
                return vendorID;
            }

            set
            {
                vendorID = value;
            }
        }

        public string VendorName
        {
            get
            {
                return vendorName;
            }

            set
            {
                vendorName = value;
            }
        }

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

        public string UnitID
        {
            get
            {
                return unitID;
            }

            set
            {
                unitID = value;
            }
        }

        public string UnitName
        {
            get
            {
                return unitName;
            }

            set
            {
                unitName = value;
            }
        }

        public float ImportPrice
        {
            get
            {
                return importPrice;
            }

            set
            {
                importPrice = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
            }
        }

        public string Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
