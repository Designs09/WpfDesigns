using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.Controls
{
    public class AlarmListDesignModel : AlarmListViewModel
    {
        #region 单例

        /// <summary>
        /// 同步锁
        /// </summary>
        private static object _objLock = new object();

        /// <summary>
        /// 单例字段
        /// </summary>
        private static AlarmListDesignModel _instance = null;

        /// <summary>
        /// 单例属性
        /// </summary>
        public static AlarmListDesignModel Instance
        {
            get
            {
                if (_instance == null)
                    lock (_objLock)
                        if (_instance == null)
                            _instance = new AlarmListDesignModel();
                return _instance;
            }
        }

        #endregion

        private AlarmListDesignModel()
        {
            Items = new ObservableCollection<AlarmListItemViewModel>
            {
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.待处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.处理中,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.待处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.处理中,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.待处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.处理中,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
                new AlarmListItemViewModel
                {
                    DeviceName = "危房监测点1",
                    EventName = "危房位移报警",
                    AlarmTime = DateTime.Now,
                    HandleStatus = AlarmHandleStatus.已处理,
                },
            };
        }
    }
}
