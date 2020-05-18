using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Core
{
    public class DeviceListViewModel : BaseViewModel
    {
        /// <summary>
        /// The device items for the list
        /// </summary>
        public List<DeviceListItemViewModel> Items { get; set; }
    }
}
