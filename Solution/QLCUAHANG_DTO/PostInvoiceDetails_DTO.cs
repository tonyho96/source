using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class PostInvoiceDetails_DTO
    {
        private string transID;
        private string productName;
        private string productCategoryName;
        private int transQuantity;
        private string unitName;
        private string importPrice;
        private string transPrice;
        private string weight;

        public string TransID
        {
            get
            {
                return transID;
            }

            set
            {
                transID = value;
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

        public int TransQuantity
        {
            get
            {
                return transQuantity;
            }

            set
            {
                transQuantity = value;
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

        public string ImportPrice
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

        public string TransPrice
        {
            get
            {
                return transPrice;
            }

            set
            {
                transPrice = value;
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
    }
}
