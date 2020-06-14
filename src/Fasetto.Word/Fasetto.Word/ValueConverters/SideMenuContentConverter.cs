using System;
using System.Globalization;
using System.Windows;
using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in a <see cref="SideMenuContent"/> and converts it to the
    /// current UI element
    /// </summary>
    public class SideMenuContentConverter : BaseValueConverter<SideMenuContentConverter>
    {
        #region Protected Members

        /// <summary>
        /// An instance of the current chat list control
        /// </summary>
        protected ChatListControl mChatListControl = new ChatListControl();

        #endregion

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the side menu type
            var sideMenuType = (SideMenuContent)value;

            // Switch based on type
            switch (sideMenuType)
            {
                // Chat
                case SideMenuContent.Chat:
                    return mChatListControl;
                // Unknown
                default:
                    return "No UI yet, sorry ;)";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
