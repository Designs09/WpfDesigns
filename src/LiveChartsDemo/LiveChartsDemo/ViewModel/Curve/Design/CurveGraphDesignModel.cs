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
    public class CurveGraphDesignModel : CurveGraphViewModel
    {
        public static CurveGraphDesignModel Instance = new CurveGraphDesignModel();

        public CurveGraphDesignModel()
        {
            Values1 = new double[] { 0, 3, 2, 1, 2, 4, 2 };
            Values2 = new double[] { -1, 2, 3, 1, 1, 0, 1 };
            Values3 = new double[] { -1, 1, 0, -1, 1, 0, 1 };
            Values4 = new double[] { -2, -0, -1, -2, -1, 1, -1 };

            Times = new DateTime[7];
            for (int i = 0; i < Times.Length; i++)
                Times[i] = DateTime.Now.Date.AddDays(i - Times.Length + 1);
        }
    }
}
