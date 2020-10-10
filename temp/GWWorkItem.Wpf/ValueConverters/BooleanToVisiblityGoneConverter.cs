﻿using System;
using System.Globalization;
using System.Windows;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// A converter that takes in a boolean and returns a <see cref="Visibility"/>
    /// where false is <see cref="Visibility.Collapsed"/>
    /// </summary>
    public class BooleanToVisiblityGoneConverter : BaseValueConverter<BooleanToVisiblityGoneConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
