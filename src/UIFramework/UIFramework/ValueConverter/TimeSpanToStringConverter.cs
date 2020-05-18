using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework
{
    /// <summary>
    /// 将<see cref="TimeSpan"/>转换为<see cref="String"/>的转换器
    /// </summary>
    public class TimeSpanToStringConverter : BaseValueConverter<TimeSpanToStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var ts = (TimeSpan)value;

            var sb = new StringBuilder();
            if (ts.Days > 0)
                sb.Append($"{ts.Days}天");
            if (ts.Hours > 0)
                sb.Append($"{ts.Hours}小时");
            if (ts.Minutes > 0)
                sb.Append($"{ts.Minutes}分钟");
            if (ts.Seconds > 0 || sb.Length == 0)
                sb.Append($"{ts.Seconds}秒");
            return sb.ToString();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
