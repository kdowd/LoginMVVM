using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace LoginMVVM.Converters  
{
    [ValueConversion(typeof(Boolean), typeof(String))]
    public class BooleanToOppositeBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          //  if (targetType != typeof(Visibility))
            //   throw new InvalidOperationException("Visibility Attribute Only");
           
            var temp = !(Boolean)value;
            if (temp == false)
            {
                return "Collapsed";   
            }

            return "Visible";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
