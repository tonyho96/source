using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class ServiceInvoiceDetails_DTO
    {
        private int serviceTransDetailsID;
        private int serviceTransID;
        private int serviceID;
        private string serviceName;
        private float servicePrice;
        private float additionalPrice;
        private float transPrice;
        private int transQuantity;
        private float transTotal;
        private float transPrepaid;
        private float transRemain;
        private DateTime deliveredDate;
        private string transStatus;

        public int ServiceTransDetailsID
        {
            get
            {
                return serviceTransDetailsID;
            }

            set
            {
                serviceTransDetailsID = value;
            }
        }

        public int ServiceTransID
        {
            get
            {
                return serviceTransID;
            }

            set
            {
                serviceTransID = value;
            }
        }

        public int ServiceID
        {
            get
            {
                return serviceID;
            }

            set
            {
                serviceID = value;
            }
        }

        public string ServiceName
        {
            get
            {
                return serviceName;
            }

            set
            {
                serviceName = value;
            }
        }

        public float ServicePrice
        {
            get
            {
                return servicePrice;
            }

            set
            {
                servicePrice = value;
            }
        }

        public float AdditionalPrice
        {
            get
            {
                return additionalPrice;
            }

            set
            {
                additionalPrice = value;
            }
        }

        public float TransPrice
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

        public float TransTotal
        {
            get
            {
                return transTotal;
            }

            set
            {
                transTotal = value;
            }
        }

        public float TransPrepaid
        {
            get
            {
                return transPrepaid;
            }

            set
            {
                transPrepaid = value;
            }
        }

        public float TransRemain
        {
            get
            {
                return transRemain;
            }

            set
            {
                transRemain = value;
            }
        }

        public DateTime DeliveredDate
        {
            get
            {
                return deliveredDate;
            }

            set
            {
                deliveredDate = value;
            }
        }

        public string TransStatus
        {
            get
            {
                return transStatus;
            }

            set
            {
                transStatus = value;
            }
        }
    }
}
