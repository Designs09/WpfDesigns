using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Core
{
    public static class IconTypeExtensions
    {
        public static string ToFontAwesome(this DeviceType type)
        {
            switch (type)
            {
                case DeviceType.AudioAndVideo:
                    return "\uf03d";
                case DeviceType.Audio:
                    return "\uf001";
                case DeviceType.Video:
                    return "\uf144";
                case DeviceType.Talkback:
                    return "\uf130";
                case DeviceType.Broadcast:
                    return "\uf0a1";
                default:
                    return string.Empty;
            }
        }
    }
}
