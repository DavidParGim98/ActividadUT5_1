using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Actividad1_UT5
{
    class ConvertidorFuente : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains("Americana"))
            {
                return "Slim Summer";
            }
            else if (value.ToString().Contains("Mexicana"))
            {
                return "Taco Salad";
            }
            else return "Chinese Wok Food St";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
