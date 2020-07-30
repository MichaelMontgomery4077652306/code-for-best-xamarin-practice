using System;
using System.Collections.Generic;
using System.Text;

namespace TruliteMobile.Misc
{
    public static class Constants
    {
        public static string Version = "0.117";
        public const string TRULITE_TRACK_URL= "https://portal.trulite.com/WorkOrders/Track/";
        public const string TRULITE_HOME_URL = "https://www.trulite.com/";
        public const string TRULITE_LOCATION_URL = "https://www.trulite.com/contact-us/find-a-location/";
        public const string TRULITE_CONTACT_US_URL = "https://www.trulite.com/contact-us/";

        public static string NotificationChannelName { get; set; } = "XamarinNotifyChannel";
        public static string NotificationHubName { get;  } = "trulite02testhub";
        public static string ListenConnectionString { get; } = "Endpoint=sb://trulite.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=EM5bmnmOKD9OmG+UUNHEIqjEQs2xoaRms+YoXghvkJo=";
        public static string DebugTag { get; set; } = "XamarinNotify";
        public static string[] SubscriptionTags { get; set; } = { "default" };
        public static string FCMTemplateBody { get; set; } = "{\"data\":{\"message\":\"$(messageParam)\"}}";
        public static string APNTemplateBody { get; set; } = "{\"aps\":{\"alert\":\"$(messageParam)\"}}";

        public static string GoogleMapApiKey = "AIzaSyBY-FNu4vjn2VIpssIJlQuMX5TFeE3xWIE";

        public static string GoogleMapDirectionApiURL = "https://maps.googleapis.com/maps/api/directions/json?origin={0},{1}&destination={2},{3}&key=" + GoogleMapApiKey + "";
    }
}
