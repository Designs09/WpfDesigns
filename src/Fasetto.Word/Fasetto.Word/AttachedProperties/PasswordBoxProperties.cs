using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// The MonitorPassword attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Make sure it is a password box
            if (!(d is PasswordBox passwordBox))
                return;

            // Remove any previous events
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            // If the caller set MonitorPassword to true...
            if ((bool)e.NewValue)
            {
                // Set default value
                HasTextProperty.SetValue(passwordBox);

                // Start listening out for password changed
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }    

        }

        /// <summary>
        /// Fired when the password box password value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Set the attached HasText value
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    /// <summary>
    /// The HasText attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool> 
    {
        /// <summary>
        /// Sets the HasText property based on if the caller <see cref="PasswordBox"/> has any text
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }
    }

    #region Pool
    ///// <summary>
    ///// Enhance the UI functionality of PasswordBox that it has the behavior of the TextBox's attached property TextProperty.
    ///// </summary>
    //public class PasswordBoxProperties
    //{

    //    public static readonly DependencyProperty MonitorPasswordProperty = DependencyProperty.RegisterAttached("MonitorPassword", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false, OnMonitorPasswordChanged));

    //    private static void OnMonitorPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //    {
    //        var passwordBox = (d as PasswordBox);

    //        if (passwordBox == null)
    //            return;

    //        passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

    //        if ((bool)e.NewValue)
    //        {
    //            SetHasText(passwordBox);
    //            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
    //        }

    //    }

    //    private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    //    {
    //        SetHasText((PasswordBox)sender);
    //    }

    //    public static void SetMonitorPassword(PasswordBox element, bool value)
    //    {
    //        element.SetValue(MonitorPasswordProperty, value);
    //    }

    //    public static bool GetMonitorPassword(PasswordBox element)
    //    {
    //        return (bool)element.GetValue(MonitorPasswordProperty);
    //    }



    //    public static readonly DependencyProperty HasTextProperty = DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false));

    //    private static void SetHasText(PasswordBox element)
    //    {
    //        element.SetValue(HasTextProperty, element.SecurePassword.Length > 0);
    //    }

    //    public static bool GetHasText(PasswordBox element)
    //    {
    //        return (bool)element.GetValue(HasTextProperty);
    //    }
    //}
    #endregion
}
