using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using TruliteMobile.Themes;
using TruliteMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Services;
using Device = Xamarin.Forms.Device;

namespace TruliteMobile
{
    public partial class App : Application
    {
        public App()
        {

            try
            {
                Syncfusion.Licensing.SyncfusionLicenseProvider
                    .RegisterLicense("MTQzODQyQDMxMzcyZTMyMmUzMEZ0TTdKVDIwZ1V4MlJCTW9IMzQxUTlVMFRNRHFEUHYrcDhPd2dnUy9tQzQ9");

                AppResources.Culture = new CultureInfo("en-US");
                InitializeComponent();
                XamUInfrastructure.Init();

                var languageCode = SettingsService.Instance.Language;
                if (languageCode != null)
                {
                    var localize = DependencyService.Get<ILocalize>();
                    localize.SetLocale(new CultureInfo(languageCode));
                }

                MainPage =new NavigationPage( new LoginPage());
            }
            catch (Exception e)
            {
                Crashes.TrackError(e);
                Task.Run(async () => await AlertService.Instance.DisplayError(e));
            }
           
        }

        public void MessageReceived(string notificationBody, string title)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                App.Current.MainPage.DisplayAlert(title, notificationBody, "Ok");
            });
           
        }


        protected override void OnStart()
        {
            AppCenter.Start("ios=a88d2b0d-df98-447d-b874-3de2839fdc43;"
                + "android=554f407d-6342-4c28-a4d7-c604bcfd5073;");

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
