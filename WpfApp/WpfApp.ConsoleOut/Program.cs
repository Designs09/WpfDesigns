using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Baml2006;
using System.Windows.Controls;
using System.Xaml;

namespace WpfApp.ConsoleOut
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

        }

        #region ModelAs
        static void ModelAs()
        {
            var obj = new Object();
            //int i = obj as int;
        }
        #endregion

        #region XamlOverview
        static void XamlOverview()
        {
            //以下代码不可执行
            XamlServices.Load("");
            //读取
            XamlObjectReader xor;
            XamlXmlReader xxr;
            Baml2006Reader br;
            //写入
            XamlObjectWriter xow;
            XamlXmlWriter xxw;

            //转换
            Action<XamlXmlReader, XamlXmlWriter> f = XamlServices.Transform;

            //WPF支持
            System.Windows.Markup.XamlReader xr;
            //System.Windows.Markup.XamlWriter xw;
        }
        #endregion

        #region CalenderType
        public static void CalenderType()
        {
            GregorianCalendar grCal = new GregorianCalendar();
            HijriCalendar hiCal = new HijriCalendar();
            JapaneseLunisolarCalendar
                              jaCal = new JapaneseLunisolarCalendar();
            Display(grCal);
            Display(hiCal);
            Display(jaCal);
        }

        static void Display(System.Globalization.Calendar c)
        {
            string name = c.ToString().PadRight(50, '.');
            Console.WriteLine("{0} {1}", name, c.AlgorithmType);
        }
        #endregion

        #region Show
        private static void Show()
        {
            var button = new Button()
            {
                Content = "点我!",
            };
            button.Click += (sender, e) =>
            {
                button.Content = "按键已点击";
            };

            var window = new Window()
            {
                Title = "演示",
                Content = button,
            };

            var app = new Application();
            app.Run(window);
        } 
        #endregion
    }
}
