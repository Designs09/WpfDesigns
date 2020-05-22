using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIFramework.Controls1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public Brush CustomColor
        {
            get { return (Brush)GetValue(CustomColorProperty); }
            set { SetValue(CustomColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomColorProperty =
            DependencyProperty.Register("CustomColor", typeof(Brush), typeof(UserControl1), new PropertyMetadata(new BrushConverter().ConvertFromString("#FF0000"), CustomColorChanged, CoerceValueCallback));

        private static void CustomColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as UserControl1;
            var color = (Brush)e.NewValue;
            control.MessageText.Foreground = color;
        }

        private static object CoerceValueCallback(DependencyObject d, object value)
        {
            return value;
        }


        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
