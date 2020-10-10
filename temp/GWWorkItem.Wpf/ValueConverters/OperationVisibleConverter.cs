using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GWWorkItem.Wpf
{
    public class OperationVisibleConverter : BaseValueConverter<OperationVisibleConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 获取预期类型
            var type = (WorkItemType)value;

            // 获取实际类型
            if (!Enum.TryParse<WorkItemType>(parameter.ToString(), out var paramType))
                return Visibility.Collapsed;

            return ((int)(type & paramType)) != 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
