using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> messages = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            messages.Add("Hello1");
            messages.Add("Hello2");
            messages.Add("Hello3");
            messages.Add("Hello4");
            this.DataContext = messages;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            MessageBox.Show(button.Content.ToString());
            //e.Handled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            MessageBox.Show("外部");
            //e.Handled = true;
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("2");
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("3");
        }

        private void Button_PreviewMouseMove_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void Button_MouseMove_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show("4");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"StackPanel Clicked, Source: {e.Source}, OriginalSource: {e.OriginalSource}");
        }
    }
}
