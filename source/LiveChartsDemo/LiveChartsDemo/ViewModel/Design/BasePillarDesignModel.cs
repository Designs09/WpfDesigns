using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LiveChartsDemo
{
    public class BasePillarDesignModel : BasePillarViewModel
    {
        public static BasePillarDesignModel Instance = new BasePillarDesignModel();

        public BasePillarDesignModel()
        {
            var linearBlueBrush = new LinearGradientBrush()
            {
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1),
                GradientStops = new GradientStopCollection()
                        {
                            new GradientStop((Color)ColorConverter.ConvertFromString("#03F0FD"), 0),
                            new GradientStop((Color)ColorConverter.ConvertFromString("#4A8FDE"), 1),
                        }
            };
            var linearYellowBrush = new LinearGradientBrush()
            {
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1),
                GradientStops = new GradientStopCollection()
                        {
                            new GradientStop((Color)ColorConverter.ConvertFromString("#F5F258"), 0),
                            new GradientStop((Color)ColorConverter.ConvertFromString("#EAC042"), 1),
                        }
            };

            var dataTemplate = new DataTemplate();

            FrameworkElementFactory textFactory = new FrameworkElementFactory(typeof(TextBlock));
            textFactory.Name = "factory";
            textFactory.SetValue(TextBlock.TextProperty, "57");
            textFactory.SetValue(TextBlock.FontSizeProperty, 12D);
            textFactory.SetValue(TextBlock.ForegroundProperty, linearBlueBrush);

            dataTemplate.VisualTree = textFactory;

            SeriesCollection = new LiveCharts.SeriesCollection()
            {
                new ColumnSeries()
                {
                    MaxColumnWidth = 32,
                    Title="驶入车辆",
                    Fill = linearBlueBrush,
                    DataLabels = true,
                    DataLabelsTemplate = dataTemplate,
                    LabelPoint = p => p.Y.ToString(),
                    Values = new ChartValues<int> { 39, 11, 20, 52, 49, 61, 12, 41, 69, 26, 26, 26, 26, 26, 34  },
                },
                new ColumnSeries()
                {
                    MaxColumnWidth = 32,
                    Title="驶出车辆",
                    Fill = linearYellowBrush,
                    Values = new ChartValues<int> { 86, 38, 31, 65, 53, 35, 53, 25, 78, 31, 31, 31, 31, 31, 64 },
                },
            };

            Labels = new string[]
            {
                "8:00", "9:00", "10:00", "11:00",
                "12:00", "13:00", "14:00", "15:00",
                "16:00", "17:00", "18:00", "19:00",
                "20:00", "21:00", "22:00",
            };



            Formatter = i => $"{i}辆";
        }
    }
}
