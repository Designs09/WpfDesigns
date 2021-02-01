using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Core;

namespace UIFramework.Controls
{
    public class ListAnimationViewModel : BaseViewModel
    {
        public double Width
        {
            get => Items.Count * 50;
        }

        public ObservableCollection<ListAnimationItemViewModel> Items { get; set; }
    }
}
