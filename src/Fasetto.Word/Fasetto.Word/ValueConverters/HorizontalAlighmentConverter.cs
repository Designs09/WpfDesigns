using System;
using System.Globalization;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in the core horizontal alignment enum and converts it to a WPF alighment
    /// </summary>
    public class HorizontalAlighmentConverter : BaseValueConverter<HorizontalAlighmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (HorizontalAlignment)value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
