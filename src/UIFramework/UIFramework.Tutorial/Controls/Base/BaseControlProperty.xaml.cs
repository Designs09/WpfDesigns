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
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace UIFramework.Tutorial.Controls
{
    /// <summary>
    /// BaseControlProperty.xaml 的交互逻辑
    /// </summary>
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public partial class BaseControlProperty : UserControl
    {
        public int Size { get; set; }

        public BaseControlProperty()
        {
            InitializeComponent();

            DataContext = this;

            // 定义全局的光标
            //Mouse.OverrideCursor = Cursors.Arrow;
            //Mouse.OverrideCursor = Cursors.None;

            // 间接嵌入自定义光标
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("./Cursors/0001.ani", UriKind.Relative));
            Cursor cursor = new Cursor(sri.Stream);
            Mouse.OverrideCursor = cursor;
        }
    }
}
