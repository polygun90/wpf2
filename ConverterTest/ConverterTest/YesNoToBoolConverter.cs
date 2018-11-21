using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ConverterTest
{
    public class YesNoToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type tergetType, object param,
       System.Globalization.CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Yes": return true;
                case "No": return false;
            }
            return false;
        }
        public object ConvertBack(object value, Type tergetType, object param,
       System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true) return "Yes";
                else return "No";
            }
            return "No";
        }
    }
}
