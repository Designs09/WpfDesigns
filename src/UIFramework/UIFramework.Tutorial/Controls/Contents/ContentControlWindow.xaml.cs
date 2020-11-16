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
using System.Windows.Shapes;

namespace UIFramework.Tutorial.Controls.Contents
{
    /// <summary>
    /// ContentControlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ContentControlWindow : Window
    {
        public ContentControlWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var content = (sender as Button).Content.ToString();
            MessageBox.Show(content);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("F1 Pressed");
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private int _count;

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Counter.Content = ++_count;
        }
    }
}
