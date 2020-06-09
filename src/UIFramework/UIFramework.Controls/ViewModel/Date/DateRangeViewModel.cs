using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIFramework.Core;

namespace UIFramework.Controls
{
    /// <summary>
    /// 日期范围视图模型
    /// </summary>
    public class DateRangeViewModel : BaseViewModel
    {
        #region 私有成员


        #endregion

        #region 公共属性

        public bool IsDaySelected => PickDateType == DateType.日;
        public bool IsWeekSelected => PickDateType == DateType.周;
        public bool IsMonthSelected => PickDateType == DateType.月;
        public bool IsYearSelected => PickDateType == DateType.年;

        /// <summary>
        /// 当前选择的日期类型
        /// </summary>
        public DateType PickDateType { get; set; }

        #endregion

        #region 公共指令

        public ICommand DayCommand { get; set; }
        public ICommand WeekCommand { get; set; }
        public ICommand MonthCommand { get; set; }
        public ICommand YearCommand { get; set; }

        #endregion

        #region 构造函数

        public DateRangeViewModel()
        {
            DayCommand = new RelayCommand(() => PickDateType = DateType.日);
            WeekCommand = new RelayCommand(() => PickDateType = DateType.周);
            MonthCommand = new RelayCommand(() => PickDateType = DateType.月);
            YearCommand = new RelayCommand(() => PickDateType = DateType.年);
        }

        #endregion
    }
}
