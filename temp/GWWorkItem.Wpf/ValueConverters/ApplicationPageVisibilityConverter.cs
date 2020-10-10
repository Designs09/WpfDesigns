using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class ApplicationPageVisibilityConverter : BaseValueConverter<ApplicationPageVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var currentPage = (ApplicationPage)value;
            var exceptedPage = (ApplicationPage)parameter;

            return currentPage == exceptedPage;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
