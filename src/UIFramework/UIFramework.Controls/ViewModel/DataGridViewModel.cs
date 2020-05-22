using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Core;

namespace UIFramework.Controls
{
    public class DataGridViewModel : BaseViewModel
    {
        public static DataGridViewModel Instance = new DataGridViewModel();

        public List<DataGridItemViewModel> Items { get; set; }

        public DataGridViewModel()
        {
            Items = new List<DataGridItemViewModel> 
            { 
                new DataGridItemViewModel(),
                new DataGridItemViewModel(),
                new DataGridItemViewModel(),
                new DataGridItemViewModel(),
                new DataGridItemViewModel(),
            };
        }
    }

    public class DataGridItemViewModel : BaseViewModel
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public AlarmHandleStatus Status { get; set; }

        public DataGridItemViewModel()
        {
            Value = 5;
            Name = "Miki";
            Status = AlarmHandleStatus.已处理;
        }
    }
}
