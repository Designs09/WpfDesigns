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

namespace UIFramework.Controls
{
    /// <summary>
    /// DataRangeItemControl.xaml 的交互逻辑
    /// </summary>
    public partial class DateRangeItemControl : UserControl
    {
        #region 依赖属性

        /// <summary>
        /// 文本
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(DateRangeItemControl), new PropertyMetadata("日", TextChangedCallback));

        private static void TextChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = d as DateRangeItemControl;
            ctrl.Content = e.NewValue as string;
        }


        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect
        {
            get { return (bool)GetValue(IsSelectProperty); }
            set { SetValue(IsSelectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectProperty =
            DependencyProperty.Register("IsSelect", typeof(bool), typeof(DateRangeItemControl), new PropertyMetadata(true, IsSelectChangedCallback));

        private static void IsSelectChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = d as DateRangeItemControl;

            ctrl.IsEnabled = (bool)e.NewValue;
        }

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public DateRangeItemControl()
        {
            InitializeComponent();
        }

        #endregion
    }
}
