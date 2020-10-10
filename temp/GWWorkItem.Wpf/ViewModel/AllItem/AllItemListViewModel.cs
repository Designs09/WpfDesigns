using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class AllItemListViewModel : BaseViewModel
    {
        public ObservableCollection<WorkItemListItemViewModel> Items { get; set; }
    }
}
