using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    public class CurveGraphViewModel : BaseViewModel
    {
        public double[] Values1 { get; set; }
        public double[] Values2 { get; set; }
        public double[] Values3 { get; set; }
        public double[] Values4 { get; set; }
        public DateTime[] Times { get; set; }
    }
}
