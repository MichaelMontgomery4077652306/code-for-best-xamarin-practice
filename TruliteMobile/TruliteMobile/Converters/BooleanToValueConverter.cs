using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KimGate.Converters
{
    public class BooleanToValueConverter:IMarkupExtension, IValueConverter
    {
        private static BooleanToValueConverter _instance;
        public static BooleanToValueConverter Instance => _instance ?? (_instance = new BooleanToValueConverter()); 
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


            if (value == null || parameter == null) return 1;
            var booleanValue = value as bool?;
            if (booleanValue == null) return 1;
            var param = parameter.ToString();
            var parameters=param.Split(':');
            if (booleanValue.Value)
            {
                return double.Parse(parameters[0], CultureInfo.InvariantCulture);
            }

            return double.Parse(parameters[1], CultureInfo.InvariantCulture);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
