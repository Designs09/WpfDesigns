using Fasetto.Word;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    public class DateTimeToFormatStrsConverter : BaseValueConverter<DateTimeToFormatStrsConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as IEnumerable<DateTime>).Select(t => $"{t:MM/dd}").ToArray();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
