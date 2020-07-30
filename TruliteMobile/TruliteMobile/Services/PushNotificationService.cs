using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using TruliteMobile.i18n;

namespace TruliteMobile.Services
{
    public class PushNotificationService
    {
        private static PushNotificationService _instance;
        private ApiService _api;
        private ISettingsService _settings;
        public static PushNotificationService Instance => _instance ?? (_instance = new PushNotificationService());

        public PushNotificationService()
        {
            Api = ApiService.Instance;
            Settings = SettingsService.Instance;
        }

        public ISettingsService Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        public ApiService Api
        {
            get { return _api; }
            set { _api = value; }
        }


        public async Task RegisterTokenWithServer()
        {
            try
            {

                //#if DEBUG
                //                Settings.PushNotificationToken = "testToken";
                //#endif

                if (string.IsNullOrWhiteSpace(Settings.Email)
                    || string.IsNullOrWhiteSpace(Settings.PushNotificationToken)
                    || string.IsNullOrWhiteSpace(Settings.PnsHandle)) return;


                var currentDevicesResponse = await Api.GetCustNotificationDevice(Api.GetCustomerContext());

                var token = Settings.PushNotificationToken;

                var sameDevice = currentDevicesResponse.Data.FirstOrDefault(p => p.DeviceId.Equals(token));

                if (sameDevice != null)
                {
                    if (sameDevice.RecId.GetValueOrDefault() > 0)
                    {
                        await Api.UpdateCustNotificationDevice(new UpdateDeleteCustNotificationDeviceContext
                        {
                            RecId = sameDevice.RecId,
                            TimeStamp = DateTimeOffset.Now,
                            PnsHandle = Settings.PnsHandle,
                            RegistrationId = Settings.RegistrationId
                        });
                        return;
                    }
                }

                var notificationDeviceContext = new CreateCustNotificationDeviceContext
                {
                    Device = Settings.PushNotificationToken,
                    CustomerInfo = Api.GetCustomerContext(),
                    TimeStamp = DateTimeOffset.Now,
                    UserName = Settings.Email,
                    PnsHandle = Settings.PnsHandle,
                    RegistrationId = Settings.RegistrationId
                };
                await Api.CreateCustNotificationDevice(notificationDeviceContext);
            }
            catch (Exception e)
            {
                Analytics.TrackEvent("RegisterToken", new Dictionary<string, string>
                {
                    {"User", Settings.Email},
                    {"Pass", Settings.Password}

                });
                Crashes.TrackError(e);
                //await AlertService.Instance.DisplayError(e, TranslationService.Instance.Get(nameof(AppResources.PushNotificationError))); ;
                await AlertService.Instance.DisplayError(e, null);

            }

        }


    }
}
