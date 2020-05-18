using System;

namespace LiveChartsDemo
{
    /// <summary>
    /// 车辆进出图标视图模型
    /// </summary>
    public class CarEnterOutChartViewModel : BaseViewModel
    {
        /// <summary>
        /// 每个时间段的驶入车辆
        /// </summary>
        public int[] EnterCarsInTime { get; set; }

        /// <summary>
        /// 每个时间段的驶出车辆
        /// </summary>
        public int[] OutCarsInTime { get; set; }

        /// <summary>
        /// 时间段
        /// </summary>
        public TimeSpan[] Times { get; set; }
    }
}
