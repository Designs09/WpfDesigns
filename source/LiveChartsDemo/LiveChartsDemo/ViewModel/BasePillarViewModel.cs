using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    public class BasePillarViewModel : BaseViewModel
    {
        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels { get; set; }


        public Func<double, string> Formatter { get; set; }
    }
}
