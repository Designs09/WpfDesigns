using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UIFramework.Controls
{
    /// <summary>
    /// 将<see cref="DateTime"/>转换为<see cref="string"/>的转换器
    /// </summary>
    [ValueConversion(typeof(DateTime), typeof(string))]
    public class TimeToStringConverter : BaseValueConverter<TimeToStringConverter>
    {
        private const string DefaultStyle = "yyyy-MM-dd HH:mm:ss";

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 若有参数，则按参数指定的样式转换为字符串
            if (parameter != null)
                return ((DateTime)value).ToString(parameter.ToString());
            // 若无参数，则按默认样式转换为字符串
            return ((DateTime)value).ToString(DefaultStyle);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
