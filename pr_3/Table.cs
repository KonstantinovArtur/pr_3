using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_3
{
    internal class Table
    {
        public int HouseID;
        public int DistrictID;
        public string HouseName { get; private set; }
        public string DistrictName { get; private set; }
        public Table(District2 hou)
        {
            DistrictID = hou.ID;
            DistrictName = hou.Name1;
            if (hou. houses2 != null)
            {
                HouseID = hou.houses2.ID;
                HouseName = hou.houses2.Name1;
            }

        }
    }
}
