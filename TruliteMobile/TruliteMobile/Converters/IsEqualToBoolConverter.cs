using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Receives an value and compares it to the passed in parameter, returning true if they are the same
    /// false otherwise.
    /// </summary>
    public class IsEqualToBoolConverter : IMarkupExtension, IValueConverter
    {

        private static IsEqualToBoolConverter _instance;
        public static IsEqualToBoolConverter Instance => _instance ?? (_instance = new IsEqualToBoolConverter());
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var revalue= Equals(value, parameter);
            return revalue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
