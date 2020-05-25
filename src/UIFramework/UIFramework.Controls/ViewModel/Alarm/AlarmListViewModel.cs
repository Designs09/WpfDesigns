using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Core;

namespace UIFramework.Controls
{
    public class AlarmListViewModel : BaseViewModel
    {
        public ObservableCollection<AlarmListItemViewModel> Items { get; set; }
    }
}
