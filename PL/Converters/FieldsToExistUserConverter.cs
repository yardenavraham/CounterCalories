using BE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace PL
{
    public class FieldsToExistUserConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
            var result = new Main_Model();
            var existUser = new ExistUser();
            if (values[0].ToString().Equals("{DependencyProperty.UnsetValue}")) return result;
            existUser.UserName = values[0].ToString();
            var passwordBox = values[1] as PasswordBox;
            existUser.Password = passwordBox.Password.ToString();

            if (passwordBox.Password.ToString() != "")
            {
                int i = 1;
            }
            result.ExistUser = existUser;

            return result;
            //return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    
    }
}
