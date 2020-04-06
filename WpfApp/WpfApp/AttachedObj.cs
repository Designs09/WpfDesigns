using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfApp
{
    class AttachedObj : DependencyObject
    {
        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }


        public static int GetMyProperty(UIElement element, int value)
        {
            return (int)element.GetValue(MyPropertyProperty);
        }

        public static void SetMyProperty(UIElement element, int value)
        {
            element.SetValue(MyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(AttachedObj));


    }
}
