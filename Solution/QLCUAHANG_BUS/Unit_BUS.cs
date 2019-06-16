using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class Unit_BUS
    {
        public static List<Unit_DTO> LoadUnit()
        {
            return Unit_DAL.LoadUnit();
        }

        public static bool InsertUnit(Unit_DTO unit)
        {
            return Unit_DAL.InsertUnit(unit);
        }

        public static bool UpdateUnit(Unit_DTO unit)
        {
            return Unit_DAL.UpdateUnit(unit);
        }

        public static bool DeleteUnit(Unit_DTO unit)
        {
            return Unit_DAL.DeleteUnit(unit);
        }
    }
}
