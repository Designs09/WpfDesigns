using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Core
{
    public class DeviceListItemDesignModel : DeviceListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static DeviceListItemDesignModel Instance => new DeviceListItemDesignModel();

        #endregion

        public DeviceListItemDesignModel()
        {
            Name = "C_M5C_CH1";
            Path = "camp/0_150_1_105fe5491b87cd5641/CH1/C_M543/_";
            Type = DeviceType.Talkback;
        }
    }
}
