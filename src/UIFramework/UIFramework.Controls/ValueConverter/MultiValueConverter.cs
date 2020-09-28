using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UIFramework.Controls
{
    public class MultiValueConverter : BaseMultiValueConverter<MultiValueConverter>
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var strValue = values.Aggregate((prev, cur) => $"{prev.ToString()}_{cur.ToString()}");
            return $"{strValue}+{parameter.ToString()}";
        }

        public override object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
