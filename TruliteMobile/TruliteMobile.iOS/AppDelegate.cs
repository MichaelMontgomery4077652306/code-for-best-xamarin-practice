using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WindowsAzure.Messaging;
using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Plugin.DownloadManager;
using Syncfusion.SfBusyIndicator.XForms.iOS;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using UIKit;
using UserNotifications;

namespace TruliteMobile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate :
        global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate/*, IUNUserNotificationCenterDelegate*/
    {
        private SBNotificationHub _hub;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppCenter.Start("a88d2b0d-df98-447d-b874-3de2839fdc43",
                typeof(Analytics), typeof(Crashes));
            Xamarin.IQKeyboardManager.SharedManager.EnableAutoToolbar = true;
            Xamarin.IQKeyboardManager.SharedManager.ShouldResignOnTouchOutside = true;
            //Xamarin.IQKeyboardManager.SharedManager.ShouldToolbarUsesTextFieldTintColor = true;
            //Xamarin.IQKeyboardManager.SharedManager.KeyboardDistanceFromTextField = 300f;

            var npac = Xamarin.IQKeyboardManager.SharedManager.ToolbarPreviousNextAllowedClasses;

            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.Forms.FormsMaterial.Init();
            global::Xamarin.FormsMaps.Init();
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();
            new SfBusyIndicatorRenderer();
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();
            Syncfusion.SfPdfViewer.XForms.iOS.SfPdfDocumentViewRenderer.Init();
            Syncfusion.SfRangeSlider.XForms.iOS.SfRangeSliderRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfSegmentedControlRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfChipRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfChipGroupRenderer.Init();


            if (UIDevice.CurrentDevice.CheckSystemVersion(10, 0))
            {
                UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert | UNAuthorizationOptions.Badge | UNAuthorizationOptions.Sound,
                    (granted, error) =>
                    {
                        if (granted)
                            InvokeOnMainThread(UIApplication.SharedApplication.RegisterForRemoteNotifications);
                    });
            }
            else if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                var pushSettings = UIUserNotificationSettings.GetSettingsForTypes(
                    UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound,
                    new NSSet());

                UIApplication.SharedApplication.RegisterUserNotificationSettings(pushSettings);
                UIApplication.SharedApplication.RegisterForRemoteNotifications();
            }
            else
            {
                UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound;
                UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);
            }


            LoadApplication(new App());

            base.FinishedLaunching(app, options);
            RegisterForRemoteNotifications();
            return true;
        }




        public SBNotificationHub Hub
        {
            get { return _hub; }
            set { _hub = value; }
        }


        /**
 * Save the completion-handler we get when the app opens from the background.
 * This method informs iOS that the app has finished all internal processing and can sleep again.
 */
        public override void HandleEventsForBackgroundUrl(UIApplication application, string sessionIdentifier, Action completionHandler)
        {
            CrossDownloadManager.BackgroundSessionCompletionHandler = completionHandler;
        }

        //void ProcessNotification(NSDictionary options, bool fromFinishedLaunching)
        //{
        //    // make sure we have a payload
        //    if (options != null && options.ContainsKey(new NSString("aps")))
        //    {
        //        // get the APS dictionary and extract message payload. Message JSON will be converted
        //        // into a NSDictionary so more complex payloads may require more processing
        //        NSDictionary aps = options.ObjectForKey(new NSString("aps")) as NSDictionary;
        //        string payload = string.Empty;
        //        NSString payloadKey = new NSString("alert");
        //        if (aps.ContainsKey(payloadKey))
        //        {
        //            payload = aps[payloadKey].ToString();
        //        }

        //        if (!string.IsNullOrWhiteSpace(payload))
        //        {
        //            (App.Current.MainPage as MainPage)?.AddMessage(payload);
        //        }

        //    }
        //    else
        //    {
        //        Debug.WriteLine($"Received request to process notification but there was no payload.");
        //    }
        //}

        public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
        {
            ProcessNotification(userInfo, false);
        }

        void ProcessNotification(NSDictionary options, bool fromFinishedLaunching)
        {
            // Check to see if the dictionary has the aps key.  This is the notification payload you would have sent
            if (null != options && options.ContainsKey(new NSString("aps")))
            {
                //Get the aps dictionary
                NSDictionary aps = options.ObjectForKey(new NSString("aps")) as NSDictionary;

                string alert = string.Empty;

                //Extract the alert text
                // NOTE: If you're using the simple alert by just specifying
                // "  aps:{alert:"alert msg here"}  ", this will work fine.
                // But if you're using a complex alert with Localization keys, etc.,
                // your "alert" object from the aps dictionary will be another NSDictionary.
                // Basically the JSON gets dumped right into a NSDictionary,
                // so keep that in mind.
                if (aps.ContainsKey(new NSString("alert")))
                    alert = (aps[new NSString("alert")] as NSString).ToString();

                //If this came from the ReceivedRemoteNotification while the app was running,
                // we of course need to manually process things like the sound, badge, and alert.
                if (!fromFinishedLaunching)
                {
                    //Manually show an alert
                    if (!string.IsNullOrEmpty(alert))
                    {
                        UIAlertView avAlert = new UIAlertView("Notification", alert, null, "OK", null);
                        avAlert.Show();
                    }
                }
            }
        }

        void RegisterForRemoteNotifications()
        {
            // register for remote notifications based on system version
            if (UIDevice.CurrentDevice.CheckSystemVersion(10, 0))
            {
                UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert |
                                                                      UNAuthorizationOptions.Sound |
                                                                      UNAuthorizationOptions.Sound,
                    (granted, error) =>
                    {
                        if (granted)
                            InvokeOnMainThread(UIApplication.SharedApplication.RegisterForRemoteNotifications);
                    });
            }
            else if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                var pushSettings = UIUserNotificationSettings.GetSettingsForTypes(
                    UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound,
                    new NSSet());

                UIApplication.SharedApplication.RegisterUserNotificationSettings(pushSettings);
                UIApplication.SharedApplication.RegisterForRemoteNotifications();
            }
            else
            {
                UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound;
                UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);
            }
        }
        public override async void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
        {
            Hub = new SBNotificationHub(Constants.ListenConnectionString, Constants.NotificationHubName);

            // update registration with Azure Notification Hub
            Hub.UnregisterAll(deviceToken, (error) =>
            {
                if (error != null)
                {
                    Debug.WriteLine($"Unable to call unregister {error}");
                    return;
                }

                var tags = new NSSet(Constants.SubscriptionTags.ToArray());
                Hub.RegisterNative(deviceToken, tags, (errorCallback) =>
                {
                    if (errorCallback != null)
                    {
                        Debug.WriteLine($"RegisterNativeAsync error: {errorCallback}");
                    }
                });

                var templateExpiration = DateTime.Now.AddDays(120)
                    .ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                Hub.RegisterTemplate(deviceToken, "defaultTemplate", Constants.APNTemplateBody, templateExpiration,
                    tags, (errorCallback) =>
                    {
                        if (errorCallback == null) return;
                        Debug.WriteLine($"RegisterTemplateAsync error: {errorCallback}");
                    });

            });

            SettingsService.Instance.RegistrationId = deviceToken.ToString();
            SettingsService.Instance.PnsHandle = deviceToken.ToString();
            SettingsService.Instance.PushNotificationToken = deviceToken.ToString();
            await PushNotificationService.Instance.RegisterTokenWithServer();
        }


    }
}
