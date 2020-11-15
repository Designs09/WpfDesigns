//using System;
//using System.ComponentModel;
//using System.Collections;
//using System.Drawing;

//namespace StandardValuesTest
//{
//    public class StandardValuesIntConverter : System.ComponentModel.TypeConverter
//    {
//        private ArrayList values;
//        public StandardValuesIntConverter()
//        {
//            // Initializes the standard values list with defaults.
//            values = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
//        }

//        // Indicates this converter provides a list of standard values.
//        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
//        {
//            return true;
//        }

//        // Returns a StandardValuesCollection of standard value objects.
//        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
//        {
//            // Passes the local integer array.
//            StandardValuesCollection svc =
//                new StandardValuesCollection(values);
//            return svc;
//        }

//        // Returns true for a sourceType of string to indicate that 
//        // conversions from string to integer are supported. (The 
//        // GetStandardValues method requires a string to native type 
//        // conversion because the items in the drop-down list are 
//        // translated to string.)
//        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
//        {
//            if (sourceType == typeof(string))
//                return true;
//            else
//                return base.CanConvertFrom(context, sourceType);
//        }

//        // If the type of the value to convert is string, parses the string 
//        // and returns the integer to set the value of the property to. 
//        // This example first extends the integer array that supplies the 
//        // standard values collection if the user-entered value is not 
//        // already in the array.
//        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
//        {
//            if (value.GetType() == typeof(string))
//            {
//                // Parses the string to get the integer to set to the property.
//                int newVal = int.Parse((string)value);

//                // Tests whether new integer is already in the list.
//                if (!values.Contains(newVal))
//                {
//                    // If the integer is not in list, adds it in order.
//                    values.Add(newVal);
//                    values.Sort();
//                }
//                // Returns the integer value to assign to the property.
//                return newVal;
//            }
//            else
//                return base.ConvertFrom(context, culture, value);
//        }
//    }

//    // Provides a test control with an integer property associated with 
//    // the StandardValuesIntConverter type converter.
//    public class IntStandardValuesControl : System.Windows.Forms.UserControl
//    {
//        [TypeConverter(typeof(StandardValuesIntConverter))]
//        public int TestInt
//        {
//            get
//            {
//                return this.integer_field;
//            }
//            set
//            {
//                if (value.GetType() == typeof(int))
//                    this.integer_field = value;
//            }
//        }
//        private int integer_field = 0;

//        public IntStandardValuesControl()
//        {
//            this.BackColor = Color.White;
//            this.Size = new Size(472, 80);
//        }

//        // OnPaint override displays instructions for the example.
//        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
//        {
//            if (this.DesignMode)
//            {
//                e.Graphics.DrawString("TypeConverter.GetStandardValues Example Control", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Blue), 5, 5);
//                e.Graphics.DrawString("The type converter for the TestInt property of this", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Black), 5, 20);
//                e.Graphics.DrawString("component provides a list of standard values to the", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Black), 5, 30);
//                e.Graphics.DrawString("Properties window. Setting a value through a property", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Black), 5, 40);
//                e.Graphics.DrawString("grid adds it to the list of standard values.", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Black), 5, 50);
//            }
//            else
//            {
//                e.Graphics.DrawString("TypeConverter.GetStandardValues Example Control", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Blue), 5, 5);
//                e.Graphics.DrawString("This control was intended for use in design mode.", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Black), 5, 20);
//            }
//        }
//    }
//}