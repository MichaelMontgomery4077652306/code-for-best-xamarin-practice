using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Converters
{
    /// <summary>
    /// Receives a SalesOrderStatus enum and returns its value as string and
    /// translated to the selected app language
    /// </summary>
    public class SalesOrderStatusToString: IMarkupExtension,IValueConverter
    {
        private static SalesOrderStatusToString _instance;
        public static SalesOrderStatusToString Instance => _instance ?? (_instance = new SalesOrderStatusToString());
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value as SalesOrderStatus?;
          
            switch (status)
            {
                case SalesOrderStatus.None:
                    return nameof(AppResources.None).Translate(); 
                    break;
                case SalesOrderStatus.BackOrder:
                    return nameof(AppResources.OpenOrder).Translate();
                    break;
                case SalesOrderStatus.Delivered:
                    return nameof(AppResources.Delivered).Translate();
                    break;
                case SalesOrderStatus.Invoiced:
                    return nameof(AppResources.Invoiced).Translate();
                    break;
                case SalesOrderStatus.Canceled:
                    return nameof(AppResources.Cancelled).Translate();
                    break;
                case null:
                    return null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
