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

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// WorkItemDistributeBox.xaml 的交互逻辑
    /// </summary>
    public partial class WorkItemDistributeBox 
    {
        public WorkItemDistributeBox()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 保存分配人员

            this.CloseCommand.Execute(null);
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.CloseCommand.Execute(null);
        }
    }
}
