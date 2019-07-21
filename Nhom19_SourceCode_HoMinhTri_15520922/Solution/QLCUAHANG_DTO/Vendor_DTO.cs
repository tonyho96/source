using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
   public class Vendor_DTO
    {
        private string vendorID;
        private string vendorName;
        private string vendorAddress;
        private string vendorPhone;

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

        public string VendorAddress
        {
            get
            {
                return vendorAddress;
            }

            set
            {
                vendorAddress = value;
            }
        }

        public string VendorPhone
        {
            get
            {
                return vendorPhone;
            }

            set
            {
                vendorPhone = value;
            }
        }
    }
}
