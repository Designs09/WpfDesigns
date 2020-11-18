using MaterialDesignThemes.Wpf;
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
using System.Windows.Shapes;

namespace UIFramework.MaterialDesignApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTimeText.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void CombinedDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            var t = DateTime.Parse(DateTimeText.Text);
            CombinedCalendar.SelectedDate = t;
            CombinedClock.Time = t;
        }

        public void CombinedDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (Equals(eventArgs.Parameter, "1"))
            {
                var combined = CombinedCalendar.SelectedDate.Value.AddSeconds(CombinedClock.Time.TimeOfDay.TotalSeconds);
                DateTimeText.Text = $"{combined:yyyy-MM-dd HH:mm:ss}";
            }
        }
    }
}
