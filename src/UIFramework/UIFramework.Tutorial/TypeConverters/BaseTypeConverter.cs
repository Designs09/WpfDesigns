using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UIFramework.Tutorial.TypeConverters
{
    /// <summary>
    /// 类型转换器
    /// </summary>
    /// <remarks>
    /// ref：https://docs.microsoft.com/zh-cn/dotnet/api/system.componentmodel.typeconverter?view=net-5.0#examples
    /// </remarks>
    public class BaseTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var v = double.Parse(value.ToString());
            var obj = new BaseClass
            {
                Id = (int)v,
                Value = v * 2,
            };

            return obj;
        }

        public static void Convert()
        {
            // 1、抽象转换器集合
            var color = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString("Red");

            // 2、实例转换器
            color = (Color)ColorConverter.ConvertFromString("Red");
            var colrDesc = (new ColorConverter()).ConvertToString(color);

            // 自定义
            var baseConverter = new BaseTypeConverter();
            var obj = baseConverter.ConvertFromString("1.5");
            obj = TypeDescriptor.GetConverter(typeof(BaseClass)).ConvertFromString("5.7");

            // 获取值集
            var values = TypeDescriptor.GetConverter(typeof(Color)).GetStandardValues();

            //var v = new TypeConverter().ConvertFromString("1.5");
        }
    }

    [TypeConverter(typeof(BaseTypeConverter))]
    public class BaseClass
    {
        public int Id { get; set; }
        public double Value { get; set; }
    }
}
