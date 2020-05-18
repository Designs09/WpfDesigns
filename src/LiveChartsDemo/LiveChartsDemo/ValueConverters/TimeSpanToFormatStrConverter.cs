using Fasetto.Word;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    /// <summary>
    /// 将<see cref="TimeSpan[]"/>转化为格式化的<see cref="String[]"/>的转换器
    /// </summary>
    public class TimeSpansToFormatStrsConverter : BaseValueConverter<TimeSpansToFormatStrsConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as IEnumerable<TimeSpan>).Select(ts => $"{ts:hh\\:mm}").ToArray();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
