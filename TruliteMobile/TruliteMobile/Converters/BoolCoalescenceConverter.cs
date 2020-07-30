using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    public class BoolCoalescenceConverter : IMarkupExtension, IValueConverter
    {
        private static BoolCoalescenceConverter _instance;

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new BoolCoalescenceConverter());
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (value as bool?).GetValueOrDefault();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}