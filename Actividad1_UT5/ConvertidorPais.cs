using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Actividad1_UT5
{
    class ConvertidorPais : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains("Americana"))
            {
                return "assets/united_states.png";
            }
            else if (value.ToString().Contains("Mexicana"))
            {
                return "assets/mexico.png";
            }
            else return "assets/china.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
