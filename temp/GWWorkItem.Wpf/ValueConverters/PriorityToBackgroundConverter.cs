using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GWWorkItem.Wpf
{
    public class PriorityToBackgroundConverter : BaseValueConverter<PriorityToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var priority = (WorkItemPriority)value;
            switch (priority)
            {
                case WorkItemPriority.一般: return new BrushConverter().ConvertFrom("#FFBAF5DE");
                case WorkItemPriority.紧急: return new BrushConverter().ConvertFrom("#FFF5D6BA");
                case WorkItemPriority.非常紧急: return new BrushConverter().ConvertFrom("#FFF5BAC0");
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
