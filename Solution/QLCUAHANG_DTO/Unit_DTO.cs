using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class Unit_DTO
    {
        private string unitID;
        private string unitName;
        private string unitPrice;

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

        public string UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }
    }
}
