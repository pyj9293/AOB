using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using AOB_GUI.VIEWMODEL;
namespace AOB_GUI.MODEL
{
    public class UserInfoService
    {
        UserInfo userInfo;
        VAR path = new VAR();
        INI ini = new INI();
        
        private const string iniFileName = "Info.ini";

        public ObservableCollection<UserInfo> GetUserInfo()
        {
            userInfo = new UserInfo();
            userInfo.vehicleType = ReadSetting("info", "VEHICLE_TYPE");
            userInfo.chassisNumber = ReadSetting("info", "CHASSIS_NUMBER");
            userInfo.vehicleNumber = ReadSetting("info", "VEHICLE_NUMBER");
            userInfo.customerNumber = ReadSetting("info", "CUSTOMER_REGISTRATION_NUMBER");
            userInfo.fileName = ReadSetting("info", "FILE_NAME");

            return new ObservableCollection<UserInfo> { userInfo };
        }

        public string ReadSetting(string section, string key)
        {
            return ini.ReadINI(path.getPath(), iniFileName, section, key);
        }
    }
}
