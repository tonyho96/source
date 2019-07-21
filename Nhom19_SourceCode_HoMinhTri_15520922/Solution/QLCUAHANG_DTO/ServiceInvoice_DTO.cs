using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class ServiceInvoice_DTO
    {
        private int serviceTransId;
        private DateTime createdate;
        private int customerId;
        private string customerName;
        private float total;
        private float prepaid;
        private float remain;
        private string status;

        public int ServiceTransId
        {
            get
            {
                return serviceTransId;
            }

            set
            {
                serviceTransId = value;
            }
        }

        public DateTime Createdate
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

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public float Prepaid
        {
            get
            {
                return prepaid;
            }

            set
            {
                prepaid = value;
            }
        }

        public float Remain
        {
            get
            {
                return remain;
            }

            set
            {
                remain = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
