using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using UIFramework.Controls;

namespace UIFramework.Tutorial
{
    public class FontDisplayConverter : BaseValueConverter<FontDisplayConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var font = value as FontFamily;
            return $"{font}_{font.BaseUri}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
