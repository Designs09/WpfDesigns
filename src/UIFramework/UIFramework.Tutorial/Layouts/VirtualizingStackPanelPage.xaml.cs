using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UIFramework.Tutorial.Layouts
{
    /// <summary>
    /// VirtualizingStackPanelPage.xaml 的交互逻辑
    /// </summary>
    public partial class VirtualizingStackPanelPage 
    {
        //标准布局系统为与列表控件关联的每个项创建项容器并计算布局。 "虚拟化" 一词指的是一种技术，根据 用户界面 (UI) 屏幕上可见的项，从更多的数据项中生成元素子集。 UI如果屏幕上只有几个元素，则生成许多元素可能会对应用程序的性能产生负面影响。 VirtualizingStackPanel计算可见项的数目，并 ItemContainerGenerator 从 ItemsControl (（如 ListBox 或) ）使用 ListView 来仅为 UI 可见项创建元素。
    }
}
