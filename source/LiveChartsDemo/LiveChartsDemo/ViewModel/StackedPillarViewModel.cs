using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    public class StackedPillarViewModel : BaseViewModel
    {
        public SeriesCollection SeriesCollection { get; set; }

        public string[] XLabels { get; set; }

        public string[] YLabels { get; set; }

        public Func<double, string> Formatter { get; set; }
    }
}
