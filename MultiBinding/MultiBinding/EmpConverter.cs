using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBinding
{
    public class EmpConverter : IMultiValueConverter
    {
        public object Convert(object[] val, Type targetType, object param,
       CultureInfo culture)
        {
            string EmpData;
            switch ((string)param)
            {
                case "reverse": EmpData = val[1] + " : " + val[0]; break;
                default: EmpData = val[0] + " : " + val[1]; break;
            }
            return EmpData;
        }
        public object[] ConvertBack(object val, Type[] targetTypes, object param,
       CultureInfo culture)
        {
            var splitValues = ((string)val).Split(':');
            return splitValues;
        }
    }
}
