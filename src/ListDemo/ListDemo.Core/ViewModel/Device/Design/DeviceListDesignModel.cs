using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Core
{
    public class DeviceListDesignModel : DeviceListViewModel
    {
        #region Singleton
        
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static DeviceListDesignModel Instance => new DeviceListDesignModel();

        #endregion

        public DeviceListDesignModel()
        {
            Items = new List<DeviceListItemViewModel>()
            {
                new DeviceListItemViewModel() { Name = "音视频", Path = "camp/0_150_1_105fe5491b87cd5641/CH1/C_M543/_", Type = DeviceType.AudioAndVideo },
                new DeviceListItemViewModel() { Name = "对讲", Path = "camp/0_150_2", Type = DeviceType.Talkback },
                new DeviceListItemViewModel() { Name = "广播", Path = "camp/0_150_3", Type = DeviceType.Broadcast },
                new DeviceListItemViewModel() { Name = "音频", Path = "camp/0_150_4", Type = DeviceType.Audio },
                new DeviceListItemViewModel() { Name = "视频", Path = "camp/0_150_5", Type = DeviceType.Video },
            };
        }
    }
}
