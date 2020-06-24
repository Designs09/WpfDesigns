using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Core;

namespace UIFramework.Controls
{
    public class AlarmListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// 报警设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 报警名称
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 报警时间
        /// </summary>
        public DateTime AlarmTime { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        public AlarmHandleStatus HandleStatus { get; set; }

        private bool _isSelected = false;
        /// <summary>
        /// 是否选中该条报警
        /// </summary>
        public bool IsSelected 
        {
            get => _isSelected;
            set
            {
                if (_isSelected == value)
                    return;

                _isSelected = value;
                base.OnPropertyChanged(nameof(IsSelected));
            }
        }
    }
}
