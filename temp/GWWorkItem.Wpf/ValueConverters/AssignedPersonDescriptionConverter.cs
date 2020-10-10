using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class AssignedPersonDescriptionConverter : BaseValueConverter<AssignedPersonDescriptionConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var persons = (List<string>)value;
            switch (persons)
            {
                case null: 
                    return "-";
                case List<string> lst:
                    if (lst.Count == 1)
                        return lst[0];
                    else
                        return $"{lst.Count.ToString()}人";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
