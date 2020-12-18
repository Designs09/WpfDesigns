using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UIFramework.Controls
{
    /// <summary>
    /// 不继承父控件的样式
    /// </summary>
    public class NoInheritanceContentControl : ContentControl
    {
        public NoInheritanceContentControl()
        {
            this.InheritanceBehavior = System.Windows.InheritanceBehavior.SkipAllNow;
        }
    }

    // 例：
    
    //<local:NoInheritanceContentControl>
    //    <local:ExhibitionPage />
    //</local:NoInheritanceContentControl>
}
