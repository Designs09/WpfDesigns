using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// 工单列表
    /// </summary>
    public class WorkItemListViewModel : BaseViewModel
    {
        /// <summary>
        /// 工单类型
        /// </summary>
        public WorkItemType Type { get; set; }

        /// <summary>
        /// 工单列表
        /// </summary>
        public ObservableCollection<WorkItemListItemViewModel> Items { get; set; }
    }
}
