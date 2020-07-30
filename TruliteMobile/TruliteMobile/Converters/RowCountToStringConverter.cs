using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Receives a list and returns the row count as a string. Used in the Row Count for
    /// most screens
    /// </summary>
    public class RowCountToStringConverter : IMarkupExtension, IValueConverter
    {
        private static RowCountToStringConverter _instance;
        public static RowCountToStringConverter Instance => _instance ?? (_instance = new RowCountToStringConverter());
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            if (value == null||!(value is IList list))
            {
                return string.Empty;
            }

            return $"{list.Count}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
