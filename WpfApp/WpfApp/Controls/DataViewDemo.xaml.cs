using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp.Model;

namespace WpfApp.Controls
{
    /// <summary>
    /// DataViewDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DataViewDemo : Window
    {
        private ObservableCollection<Person> _person = new ObservableCollection<Person>();
        public DataViewDemo()
        {
            InitializeComponent();
            this.DataContext = _person;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _person.Add(new Person() { FirstName = "Wang", LastName = "Wu" });
        }
    }
}
