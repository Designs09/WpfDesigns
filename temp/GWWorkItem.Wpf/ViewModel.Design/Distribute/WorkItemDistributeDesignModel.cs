using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class WorkItemDistributeDesignModel : WorkItemDistributeViewModel
    {
        public static WorkItemDistributeDesignModel Instance = new WorkItemDistributeDesignModel();

        public WorkItemDistributeDesignModel()
        {
            Items = new System.Collections.ObjectModel.ObservableCollection<WorkItemDistributePerson>
            {
                new WorkItemDistributePerson{ IsCheck = null, Content = "全部" },
                new WorkItemDistributePerson{ IsCheck = true, Content = "别萍 - 17049095516" },
                new WorkItemDistributePerson{ IsCheck = false, Content = "应珊文 - 18173849792" },
                new WorkItemDistributePerson{ IsCheck = false, Content = "别爽黛 - 13061398763" },
                new WorkItemDistributePerson{ IsCheck = false, Content = "郝强黛 - 19946741147" },
            };
        }
    }
}
