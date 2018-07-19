using AOB_GUI.MODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
namespace AOB_GUI.HELPER
{
    public class CollectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ObservableCollection<UserInfo>)
            {
                StringBuilder builder = new StringBuilder();
               
                foreach(var s in value as ObservableCollection<UserInfo>)
                {  
                    builder.Append(s.getAllUserInfo());
                }
                return builder;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
