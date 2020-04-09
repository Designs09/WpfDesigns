using System;
using System.Collections.Generic;
using System.IO;
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
    /// WpfTreeView.xaml 的交互逻辑
    /// </summary>
    public partial class WpfTreeView : Window
    {
        #region Constructor

        public WpfTreeView()
        {
            InitializeComponent();

        } 
        #endregion

        /// <summary>
        /// When the Application first opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Directory.GetLogicalDrives())
            {
                var t = new TreeViewItem();
                FolderView.Items.Add(t);
            }
            
        }
    }
}
