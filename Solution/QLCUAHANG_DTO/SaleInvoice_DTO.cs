using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class SaleInvoice_DTO
    {
        private int transid;
        private string customerName;
        private int customerId;
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

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
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
