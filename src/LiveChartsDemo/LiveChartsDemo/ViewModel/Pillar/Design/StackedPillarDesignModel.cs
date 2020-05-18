using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsDemo
{
    public class StackedPillarDesignModel : StackedPillarViewModel
    {
        public static StackedPillarDesignModel Instance = new StackedPillarDesignModel();

        public StackedPillarDesignModel()
        {
            SeriesCollection = new LiveCharts.SeriesCollection()
            {
                new StackedColumnSeries()
                {
                    Values = new ChartValues<int> { 2, 5 },
                    StackMode = StackMode.Values,
                },
                new StackedColumnSeries()
                {
                    Values = new ChartValues<int> { 5, 10},
                    StackMode = StackMode.Values,
                }
            };

            XLabels = new string[]
            {
                "8:00", "9:00", "10:00"
            };

            YLabels = new string[]
            {
                "0", "20", "40", "60", "80", "100"
            };

            Formatter = i => $"{i}辆";
        }
    }
}
