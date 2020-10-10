using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GWWorkItem.Wpf
{
    public class PriorityToForegroundConverter : BaseValueConverter<PriorityToForegroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var priority = (WorkItemPriority)value;
            switch (priority)
            {
                case WorkItemPriority.一般: return new BrushConverter().ConvertFrom("#9C07B872");
                case WorkItemPriority.紧急: return new BrushConverter().ConvertFrom("#9CEB892F");
                case WorkItemPriority.非常紧急: return new BrushConverter().ConvertFrom("#9CF54556");
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
