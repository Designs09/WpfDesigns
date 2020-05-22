using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UIFramework.Controls
{
    public class AlarmHandleStatusToColorConverter : BaseValueConverter<AlarmHandleStatusToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (AlarmHandleStatus)value;
            switch (status)
            {
                case AlarmHandleStatus.待处理:
                    return (SolidColorBrush)new BrushConverter().ConvertFrom("#EB6370");
                case AlarmHandleStatus.处理中:
                    return (SolidColorBrush)new BrushConverter().ConvertFrom("#EBC463");
                case AlarmHandleStatus.已处理:
                    return (SolidColorBrush)new BrushConverter().ConvertFrom("#47CFB3");
            }

            return (SolidColorBrush)new BrushConverter().ConvertFrom("#47CFB3");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
