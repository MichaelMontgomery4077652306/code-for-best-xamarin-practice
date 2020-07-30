using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TruliteMobile.Misc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{

    /// <summary>
    /// Convert the value of an enum to the equivalent string that is passed using the parameter as
    /// semicolon separated values. For example:
    /// an enum that the following values Value1,Value2,Value3 to be converted to a string
    /// should receive a parameter "Value One;Value Two; Value Three" so that the conversion works
    /// </summary>
    public class EnumToStringConverter:IMarkupExtension, IValueConverter
    {
        private static EnumToStringConverter _instance;
        public static EnumToStringConverter Instance => _instance ?? (_instance = new EnumToStringConverter());

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = (int) value;
            if (parameter == null) return intValue;
            var list = parameter.ToString().Split(';');
            if (list.Length >= intValue + 1)
            {

                return list[intValue].Translate();
            }

            return nameof(EnumToStringConverter) + $" Out of bounds, value: {intValue} - parameter list: {parameter}";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
