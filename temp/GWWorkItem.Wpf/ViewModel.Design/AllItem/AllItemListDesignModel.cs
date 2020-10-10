using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class AllItemListDesignModel : AllItemListViewModel
    {
        public static AllItemListDesignModel Instance = new AllItemListDesignModel();

        public AllItemListDesignModel()
        {
            Items = new System.Collections.ObjectModel.ObservableCollection<WorkItemListItemViewModel>
            {
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区", Collapsed = false },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待接受, Collapsed = false, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待接受, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待接受, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.处理中, Collapsed = false, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.处理中, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.处理中, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待确认, Collapsed = false, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待确认, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { DeviceName = "B2区冷量表", AlarmType = "通讯故障", Type = WorkItemType.待确认, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
            };
        }
    }
}
