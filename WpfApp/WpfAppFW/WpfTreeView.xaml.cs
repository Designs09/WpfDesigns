﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppFW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WpfTreeView : Window
    {
        #region Constructor
        public WpfTreeView()
        {
            InitializeComponent();

            this.DataContext = new DirectoryStructureViewModel();
        }
        #endregion
    }
}
