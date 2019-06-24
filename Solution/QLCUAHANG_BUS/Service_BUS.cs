using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCUAHANG_DTO;
using QLCUAHANG_DAL;

namespace QLCUAHANG_BUS
{
    public class Service_BUS
    {
        public static List<Service_DTO> LoadService()
        {
            return Service_DAL.LoadService();
        }
        public static bool InsertService(Service_DTO service)
        {
            return Service_DAL.InsertService(service);
        }
        public static bool UpdateService(Service_DTO service)
        {
            return Service_DAL.UpdateService(service);
        }
        public static bool DeleteService(Service_DTO service)
        {
            return Service_DAL.DeleteService(service);
        }
    }
}
