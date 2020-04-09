using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppFW
{
    //[ImplementPropertyChange]
    [AddINotifyPropertyChangedInterface]
    class Class1 : INotifyPropertyChanged
    {
        private string _text;

        public string Text { get; set; }
        //{
        //    get
        //    {
        //        return _text;
        //    }
        //    set
        //    {
        //        if (_text == value)
        //            return;
        //        _text = value;
        //        OnTextValueChanged();
        //    }
        //}
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        private void OnTextValueChanged()
        {
            if (PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Text)));
            }
        }


        public Class1()
        {
            Task.Run(async () =>
            {
                int i = 99;
                while (true)
                {
                    await Task.Delay(200);
                    Text = (i++).ToString();
                }
            });
        }
    }
}
