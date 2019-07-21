using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class PostInvoice_DTO
    {
        private int transid;
        private string vendorname;
        private int vendorid;
        private string address;
        private string phoneno;
        private DateTime createdate;
        private double totalprice;

        public int TransID
        {
            get
            {
                return transid;
            }

            set
            {
                transid = value;
            }
        }

        public int VendorID
        {
            get
            {
                return vendorid;
            }

            set
            {
                vendorid = value;
            }
        }

        public string VendorName
        {
            get
            {
                return vendorname;
            }

            set
            {
                vendorname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return phoneno;
            }

            set
            {
                phoneno = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return createdate;
            }

            set
            {
                createdate = value;
            }
        }

        public double TotalPrice
        {
            get
            {
                return totalprice;
            }

            set
            {
                totalprice = value;
            }
        }
    }
}
