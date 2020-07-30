using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Invoice numbers usually are returned by the server with a starting comma that needs to be removed
    /// when it is shown to the user.
    /// </summary>
    public class InvoiceNumberListToStringConverter:IMarkupExtension,IValueConverter
    {
        private static InvoiceNumberListToStringConverter _instance;
        public static InvoiceNumberListToStringConverter Instance => _instance ?? (_instance = new InvoiceNumberListToStringConverter());   
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var str = value.ToString().Trim();
            if (str.StartsWith(","))
            {
                str = str.Substring(1);
            }
            if (str.EndsWith(","))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str.Trim();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
