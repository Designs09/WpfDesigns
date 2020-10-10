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
        /// <summary>
        /// 弹出消息对话框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <returns></returns>
        public static Task ShowMessageAsync(string message)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                // TODO：用风格统一的样式显示消息。


                MessageBox.Show(message);
            });

            return Task.CompletedTask;
        }

        /// <summary>
        /// 弹出“分配工单”对话框
        /// </summary>
        /// <param name="orderId">工单Id</param>
        /// <returns></returns>
        public static async Task ShowDistributeDialogAsync(WorkItemListItemViewModel workItem)
        {
            // TODO: 获取人员列表


            var vm = new WorkItemDistributeViewModel
            {
                Title = "分配人员",
            };
            vm.AddItem("别萍 - 17049095516");
            vm.AddItem("应珊文 - 18173849792");
            vm.AddItem("别爽黛 - 13061398763");
            vm.AddItem("郝强黛 - 19946741147");

            // 分配人员
            await new WorkItemDistributeBox().ShowDialogAsync(vm);
        }
    }
}
