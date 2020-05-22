using Fasetto.Word;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;

namespace LiveChartsDemo
{
    /// <summary>
    /// 将<see cref="double[]"/>转化为<see cref="ChartValues<double>"/>的转化器
    /// </summary>
    public class DoubleArrayToChartValuesConverter : BaseValueConverter<DoubleArrayToChartValuesConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new ChartValues<double>(value as IEnumerable<double>);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
