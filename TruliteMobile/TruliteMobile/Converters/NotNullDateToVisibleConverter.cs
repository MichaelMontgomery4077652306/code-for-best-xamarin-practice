using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Returns true if a value is not null
    /// </summary>
    public class NotNullDateToVisibleConverter : IMarkupExtension, IValueConverter
    {
        private static NotNullDateToVisibleConverter _instance;
        public static NotNullDateToVisibleConverter Instance => _instance ?? (_instance = new NotNullDateToVisibleConverter());
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }
    }
}