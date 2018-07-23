using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AOB_GUI.MODEL;
using System.Collections.ObjectModel;
namespace AOB_GUI.VIEWMODEL
{
    public class UserInfoViewModel : ViewModelBase
    {
        private UserInfoService service;
        private ObservableCollection<UserInfo> userInfoList;
        public DelegateCommand ShowUserInfoCmd { get; private set; }

        public UserInfoViewModel()
        {
            Initialize();
        }
        
        /// <summary>
        /// The Initialize
        /// <remarks>UserInfoService 객체 및 Command 객체 생성</remarks>
        /// </summary>
        private void Initialize()
        {
            service = new UserInfoService();
            ShowUserInfoCmd = new DelegateCommand(GetUserInfo);
        }

        /// <summary>
        /// 사용자 정보 및 차량 정보를 get/set
        /// </summary>
        /// <value>사용자 정보 및 차량 정보 컬렉션</value>
        public ObservableCollection<UserInfo> UserInfoList
        {
            get
            {
                return userInfoList;
            }
            set
            {
                this.userInfoList = value;
                OnPropertyChanged("UserInfoList");
            }
        }

        /// <summary>
        /// 사용자 정보 및 차량 정보의 컬렉션을 가져오는 함수
        /// <remarks>Main -> FileOpen -> Read File of InI</remarks>
        /// </summary>
        private void GetUserInfo()
        {
            UserInfoList = service.GetUserInfo();
        }
    }
}
