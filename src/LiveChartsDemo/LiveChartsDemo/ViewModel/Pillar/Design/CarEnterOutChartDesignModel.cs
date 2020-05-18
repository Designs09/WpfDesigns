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
    /// <summary>
    /// <see cref="CarEnterOutChartViewModel"/>的设计时数据
    /// </summary>
    public class CarEnterOutChartDesignModel : CarEnterOutChartViewModel
    {
        #region 单例

        /// <summary>
        /// 单例
        /// </summary>
        public static CarEnterOutChartDesignModel Instance = new CarEnterOutChartDesignModel();

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CarEnterOutChartDesignModel()
        {
            // 初始化设计时数据
            EnterCarsInTime = new int[] { 39, 11, 20, 52, 49, 61, 12, 41, 69, 26, 26, 26, 26, 26, 34 };
            OutCarsInTime = new int[] { 86, 38, 31, 65, 53, 35, 53, 25, 78, 31, 31, 31, 31, 31, 64 };
            Times = new TimeSpan[EnterCarsInTime.Length];
            for (int i = 0; i < Times.Length; i++)
                Times[i] = new TimeSpan(8 + i, 0, 0);
        }

        #endregion

    }
}
