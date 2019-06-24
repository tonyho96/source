using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class Service_DTO
    {
        private string serviceID;
        private string serviceName;
        private float servicePrice;

        public string ServiceID
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
    }
}
