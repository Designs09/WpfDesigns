using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// PopupControlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PopupControlWindow : Window
    {
        public PopupControlWindow()
        {
            InitializeComponent();
        }

        private void Run_MouseEnter(object sender, MouseEventArgs e)
        {
            Pop.IsOpen = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var uri = (sender as Hyperlink).NavigateUri;
            Process.Start(uri.ToString());
        }
    }
}
