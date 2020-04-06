using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfApp
{
    class DependencyObj : UIElement
    {

        #region Value
        public event RoutedPropertyChangedEventHandler<int> ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(DependencyObj), new PropertyMetadata(0, OnValueChanged, CoreceValue));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var control = (DependencyObj)d;
            var e = new RoutedPropertyChangedEventArgs<int>((int)args.OldValue, (int)args.NewValue, ValueChangedEvent);
            control.OnValueChanged(e);
        }

        protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<int> e)
        {
            RaiseEvent(e);
        }

        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble
            , typeof(RoutedPropertyChangedEventHandler<int>), typeof(DependencyObj));

        private static object CoreceValue(DependencyObject d, object baseValue)
        {
            var newValue = (int)baseValue;
            var control = (DependencyObj)d;

            newValue = Math.Max(control.Minimum, Math.Min(control.Maximun, newValue));
            return newValue;
        }
        #endregion

        #region Minimun
        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minimum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(int), typeof(DependencyObj), new PropertyMetadata(0));
        #endregion

        #region Maximun

        public int Maximun
        {
            get { return (int)GetValue(MaximunProperty); }
            set { SetValue(MaximunProperty, value); }
        }


        // Using a DependencyProperty as the backing store for Maximun.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximunProperty =
            DependencyProperty.Register("Maximun", typeof(int), typeof(DependencyObj), new PropertyMetadata(100));

        #endregion

    }
}
