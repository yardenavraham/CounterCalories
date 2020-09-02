using BE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using PL.Models;
namespace PL
{
    public class FieldsToUserConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
            var result = new RegisterUC_Model();
            var user = new User();
            if (values[0].ToString().Equals("{DependencyProperty.UnsetValue}")) return result;
            user.UserName = values[0].ToString();
            user.Name = values[1].ToString();
            user.Password= values[2].ToString();
            user.BirthYear = int.Parse(values[3].ToString());
            user.Height = int.Parse(values[4].ToString());
            user.Weight = int.Parse(values[5].ToString());
            user.GramsToLose = int.Parse(values[6].ToString());
            user.Gender = values[7].ToString().Equals("0");
            
           // user.ActivityLevel = values[7].ToString();
            result.User = user;

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
