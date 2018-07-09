using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOB_GUI.MODEL;
namespace AOB_GUI.VIEWMODEL
{
    public class UserInfoService
    {
        private VAR path;
        private INI ini;
        private UserInfo userInfo;
        private string InfoFile = "info.ini";

        public UserInfoService()
        {
            path = new VAR();
            ini = new INI();
            userInfo = new UserInfo();

            AllReadUserInfo("info");
        }

        public void AllReadUserInfo(string section)
        {
            userInfo.vehicleType = ini.ReadINI(path.getPath(), InfoFile, section, "VEHICLE_TYPE");
            userInfo.chassisNumber = ini.ReadINI(path.getPath(), InfoFile, section, "CHASSIS_NUMBER");
            userInfo.vehycleNumber = ini.ReadINI(path.getPath(), InfoFile, section, "VEHICLE_NUMBER");
            userInfo.customerNumber = ini.ReadINI(path.getPath(), InfoFile, section, "CUSTOMER_REGISTRATION_NUMBER");
            userInfo.fileName = ini.ReadINI(path.getPath(), InfoFile, section, "FILE_NAME");
        }
    }
}
