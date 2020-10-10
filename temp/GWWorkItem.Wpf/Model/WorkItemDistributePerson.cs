using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GWWorkItem.Wpf
{
    public class WorkItemDistributePerson
    {
        public bool? IsCheck { get; set; }
        public string Content { get; set; }

        public int Id { get; set; } = 5;
        public ICommand CheckCommand { get; set; }
    }
}
