using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// 工单类型
    /// </summary>
    [Flags]
    public enum WorkItemType
    {
        待分配 = 0x0001,
        待接受 = 0x0002,
        处理中 = 0x0004,
        待确认 = 0x0008,
        已完成 = 0x0010,
        误报 = 0x0020,
    }
}
