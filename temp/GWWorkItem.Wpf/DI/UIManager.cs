using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GWWorkItem.Wpf
{
    public class UIManager
    {
        public static Task ShowMessage(string message)
        {
            new WorkItemDistributeBox().ShowDialog(new BaseDialogViewModel { Title = "Hello World! "});

            //Application.Current.Dispatcher.Invoke(() =>
            //{
            //    MessageBox.Show(message);
            //});

            return Task.CompletedTask;
        }

        public static async Task<bool> ShowDistributeDialog(string message)
        {


            return false;
        }
    }
}
