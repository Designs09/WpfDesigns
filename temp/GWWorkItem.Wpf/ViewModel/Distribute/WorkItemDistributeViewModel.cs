using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class WorkItemDistributeViewModel
    {
        /// <summary>
        /// 分配人员名单
        /// </summary>
        public ObservableCollection<WorkItemDistributePerson> Items { get; set; }
    }
}
