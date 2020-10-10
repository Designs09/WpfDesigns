using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class WorkItemListItemDesignModel : WorkItemListItemViewModel
    {
        public static WorkItemListItemDesignModel Instance = new WorkItemListItemDesignModel();
        public static WorkItemListItemDesignModel Instance1 = new WorkItemListItemDesignModel(WorkItemType.待接受);
        public static WorkItemListItemDesignModel Instance2 = new WorkItemListItemDesignModel(WorkItemType.处理中);
        public static WorkItemListItemDesignModel Instance3 = new WorkItemListItemDesignModel(WorkItemType.待确认);

        public WorkItemListItemDesignModel(WorkItemType type)
        {
            Name = "B2区冷量表-冷量:过高";
            Type = type;
            Priority = WorkItemPriority.一般;
            Time = DateTime.Now;
            Location = "F1机房去B栋4楼B2区";
            Collapsed = false;
        }

        public WorkItemListItemDesignModel() : this(WorkItemType.待分配) { }
    }
}
