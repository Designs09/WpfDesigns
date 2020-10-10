using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class WorkItemListDesignModel : WorkItemListViewModel
    {
        public static WorkItemListDesignModel Instance = new WorkItemListDesignModel()
        {
            Items = new ObservableCollection<WorkItemListItemViewModel>
            {
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区", Collapsed = false },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },

                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待分配, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
            }
        };

        public static WorkItemListDesignModel Instance1 = new WorkItemListDesignModel(WorkItemType.待接受)
        {
            Items = new ObservableCollection<WorkItemListItemViewModel>
            {
                new WorkItemListItemViewModel { Type = WorkItemType.待接受, Collapsed = false, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待接受, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待接受, Handlers = new List<string> { "p1", "p2", "p3" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
            }
        };
        public static WorkItemListDesignModel Instance2 = new WorkItemListDesignModel(WorkItemType.处理中)
        {
            Items = new ObservableCollection<WorkItemListItemViewModel>
            {
                new WorkItemListItemViewModel { Type = WorkItemType.处理中, Collapsed = false, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.处理中, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.处理中, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
            }
        };

        public static WorkItemListDesignModel Instance3 = new WorkItemListDesignModel(WorkItemType.待确认)
        {
            Items = new ObservableCollection<WorkItemListItemViewModel>
            {
                new WorkItemListItemViewModel { Type = WorkItemType.待确认, Collapsed = false, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.一般, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待确认, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
                new WorkItemListItemViewModel { Type = WorkItemType.待确认, Handlers = new List<string> { "付澜 - 17819567071" }, Name = "B2区冷量表-冷量:过高", Priority = WorkItemPriority.非常紧急, Time = DateTime.Now, Location = "F1机房去B栋4楼B2区",  },
            }
        };

        public WorkItemListDesignModel(WorkItemType type)
        {
            Type = type;
        }

        public WorkItemListDesignModel() : this(WorkItemType.待分配) { }
    }
}
