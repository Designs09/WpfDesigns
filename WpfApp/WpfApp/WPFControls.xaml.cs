using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// WPFControls.xaml 的交互逻辑
    /// </summary>
    public partial class WPFControls : Window
    {
        public WPFControls()
        {
            InitializeComponent();



            //Dialog Boxes
            OpenFileDialog d1;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            var result = d1.ShowDialog();
            ShowDialogResult(result);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog d3 = new SaveFileDialog();
            var result = d3.ShowDialog();
            ShowDialogResult(result);
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog d2 = new PrintDialog();
            var result = d2.ShowDialog();
            ShowDialogResult(result);
        }

        private void ShowDialogResult(bool? result)
        {
            var message = result.HasValue ? result.Value.ToString() : "null";
            MessageBox.Show($"Dialog Result: {message}");
        }
    }
}
