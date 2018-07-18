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
    public class UserInfoViewModel : INotifyPropertyChanged
    {
        private UserInfoService service;
        private ObservableCollection<UserInfo> userInfoList;

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

        public UserInfoViewModel()
        {
            service = new UserInfoService();

        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        private ICommand showUserInfo;

        public ICommand ShowUserInfo
        {
            get { return (this.showUserInfo) ?? (this.showUserInfo = new DelegateCommand(getUserInfo)); }
        }

        private void getUserInfo()
        {
            UserInfoList = service.GetUserInfo();
        }
    }
}
