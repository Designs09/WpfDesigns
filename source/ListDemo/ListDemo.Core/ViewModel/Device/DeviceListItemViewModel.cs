using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListDemo.Core
{
    public class DeviceListItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DeviceType Type { get; set; }

        public ICommand ClickCommand { get; set; }

        public DeviceListItemViewModel()
        {
            ClickCommand = new RelayCommand(Click);
        }

        private void Click()
        {
        }
    }
}
