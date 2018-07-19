using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOB_GUI.MODEL
{
    public class UserInfo
    {
        public string vehicleType { get; set; }
        public string chassisNumber { get; set; } 
        public string vehicleNumber { get; set; }
        public string customerNumber { get; set; }
        public string fileName { get; set; }

        public string getAllUserInfo()
        {
            return this.vehicleType + "      " + this.chassisNumber + "      " + this.vehicleNumber
                + "      " + this.customerNumber + "      " + this.fileName;
        }
    }
}
