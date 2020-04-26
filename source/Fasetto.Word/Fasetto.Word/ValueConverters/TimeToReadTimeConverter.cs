using System;
using System.Globalization;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in a date and converts it to a user friendly message read time
    /// </summary>
    public class TimeToReadTimeConverter : BaseValueConverter<TimeToReadTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            // If it is not read...
            if (time == DateTimeOffset.MinValue)
                return string.Empty;

            //If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
            {
                // Return just time
                var rd = time.ToLocalTime().ToString("HH:mm tt", CultureInfo.GetCultureInfo("en-us"));
                return $"Read {rd}";
            }

            // Otherwise, return a full date
            var readTime = time.ToLocalTime().ToString("HH:mm, MMM yyyy", CultureInfo.GetCultureInfo("en-us"));
            return $"Read {readTime}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
