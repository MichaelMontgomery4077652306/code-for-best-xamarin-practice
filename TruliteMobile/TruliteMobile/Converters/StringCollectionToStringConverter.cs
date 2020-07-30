using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
     public class StringCollectionToStringConverter: IMarkupExtension, IValueConverter
    {
        private static StringCollectionToStringConverter _instance;
        public static StringCollectionToStringConverter Instance => _instance ?? (_instance = new StringCollectionToStringConverter());
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var stringCollection = value as ICollection<string>;
            if (stringCollection == null) return null;
            var returnString = string.Concat(stringCollection.Select(p=>$"{p}{Environment.NewLine}"));
            return returnString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
