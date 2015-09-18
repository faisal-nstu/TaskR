using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace TaskR.Converter
{
    public class StrikeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isDone = (bool) value;
            if (parameter.ToString().ToLower() == "stroke")
            {
                return isDone ? "Black" : "Transparent";
            }
            else if (parameter.ToString().ToLower() == "titlecolor")
            {
                return isDone ? "Gray" : "Black";
            }
            return "Black";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
