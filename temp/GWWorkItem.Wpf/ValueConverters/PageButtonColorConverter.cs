using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GWWorkItem.Wpf
{
    public class PageButtonColorConverter : BaseValueConverter<PageButtonColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var currentPage = (ApplicationPage)value;
            var exceptedPage = (ApplicationPage)parameter;

            if (currentPage == exceptedPage)
                return new BrushConverter().ConvertFrom($"#008AF5");
            else
                return new BrushConverter().ConvertFrom($"#3DD8D8D8");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
