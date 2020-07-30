using System;

using Android.App;
using Android.Content.PM;
using Android.Gms.Common;
using Android.Icu.Text;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Firebase;
using Firebase.Iid;
using Firebase.Messaging;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Plugin.Permissions;

namespace TruliteMobile.Droid
{
    [Activity(Label = "Trulite Mobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {


        static readonly string TAG = "MainActivity";
        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;

        public static MainActivity FormsContext { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            AppCenter.Start("554f407d-6342-4c28-a4d7-c604bcfd5073",
                typeof(Analytics), typeof(Crashes));
            base.OnCreate(savedInstanceState);
            FormsContext = this;


            ////You can use this method to check if play services are available.


            /*var f = FirebaseApp.GetApps(this);
            
            if (IsPlayServicesAvailable() && f.Count == 0)
            {

                var op = new FirebaseOptions.Builder()
                    .SetApplicationId("1:347067376936:android:8f9ff0bd4beca018")
                    .SetProjectId("trulite-mobile-app")
                    .SetDatabaseUrl("https://trulite-mobile-app.firebaseio.com")
                    .SetStorageBucket("trulite-mobile-app.appspot.com")
                    .SetApiKey("AIzaSyDk5FVuu1VYNhkfmEn-w2fuOhH-Vhb8Qsk")
                    .SetGcmSenderId("347067376936")
                    .Build();


                FirebaseApp app = FirebaseApp.InitializeApp(Android.App.Application.Context, op);
            }
            if (IsPlayServicesAvailable())
            {
                var refreshedToken = FirebaseInstanceId.Instance.Token;
                Log.Debug(TAG, "Refreshed token: " + refreshedToken);
            }*/
            if (Intent.Extras != null)
            {
                foreach (var key in Intent.Extras.KeySet())
                {
                    if (key != null)
                    {
                        var value = Intent.Extras.GetString(key);
                        Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
                    }
                }
            }
            IsPlayServicesAvailable();
            CreateNotificationChannel();


            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);
            global::Xamarin.FormsMaps.Init(this, savedInstanceState);
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
            LoadApplication(new App());
           

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this); if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    var text = GoogleApiAvailability.Instance.GetErrorString(resultCode);

                }
                else
                {
                    //This device is not supported           
                    Finish(); // Kill the activity if you want.         
                }
                return false;
            }
            else
            {
                //Google Play Services is available.         
                return true;
            }
        }

        void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var channelName = CHANNEL_ID;
            var channelDescription = string.Empty;
            var channel = new NotificationChannel(CHANNEL_ID, channelName, NotificationImportance.Default)
            {
                Description = channelDescription
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }

    }
}