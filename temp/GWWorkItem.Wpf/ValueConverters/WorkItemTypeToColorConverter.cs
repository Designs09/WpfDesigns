using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GWWorkItem.Wpf
{
    public class WorkItemTypeToColorConverter : BaseValueConverter<WorkItemTypeToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (WorkItemType)value;
            switch (type)
            {
                case WorkItemType.待分配: return new BrushConverter().ConvertFrom($"#FFF54551");
                case WorkItemType.待接受: return new BrushConverter().ConvertFrom($"#FFF5BB36");
                case WorkItemType.处理中: return new BrushConverter().ConvertFrom($"#FF3875FF");
                case WorkItemType.待确认: return new BrushConverter().ConvertFrom($"#FF7358F5");
                default: return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
