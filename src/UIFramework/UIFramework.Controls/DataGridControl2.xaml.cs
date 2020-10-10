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
    /// DataGridControl1.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridControl2 : UserControl
    {
        public DataGridControl2()
        {
            InitializeComponent();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Double Click!");
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //foreach (var cellInfo in e.AddedCells)
            //{

            //}
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //foreach (var item in e.AddedItems)
            //{
            //    var alarm = item as AlarmListItemViewModel;
            //    alarm.IsSelected = true;
            //}

            //foreach (var item in e.RemovedItems)
            //{
            //    var alarm = item as AlarmListItemViewModel;
            //    alarm.IsSelected = false;
            //}
        }

        private void DataGridRow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Single Click!");
        }
    }
}
