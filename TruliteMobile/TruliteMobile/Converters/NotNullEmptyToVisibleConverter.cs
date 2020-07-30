using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Returns true if a value (string) is not null and not empty. 
    /// </summary>
    public class NotNullEmptyToVisibleConverter : IMarkupExtension, IValueConverter
    {
        private static NotNullEmptyToVisibleConverter _instance;
        public static NotNullEmptyToVisibleConverter Instance => _instance ?? (_instance = new NotNullEmptyToVisibleConverter());
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            return value != null && !string.IsNullOrWhiteSpace(value.ToString());
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
