using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using TruliteMobile.Enums;
using Xamarin.Essentials;

namespace TruliteMobile.Services
{
    public interface ISettingsService
    {
        string ServerUrl { set; get; }
        string Email { set; get; }
        string Password { set; get; }
        string Token { set; get; }
        DateTime TokenExpiration { set; get; }
        ApplicationModeEnum ApplicationMode { get; set; }
        string AxCustomerId { get; set; }
        MyInfoViewModel MyInfo { get; set; }
        bool IsDriver { get; set; }
        string PushNotificationToken { get; set; }
        string PushNotificationEmail { get; set; }
        string MasterAxCustomerId { get; set; }
        bool IsImpersonatingCustomer { get; set; }
        bool RememberMe { get; set; }
        string MasterToken { get; set; }
        DateTime MasterTokenExpiration { get; set; }
        string RegistrationId { get; set; }
        string PnsHandle { get; set; }
        Dictionary<string, bool> AccountPermissions { get; set; }
        bool IsDarkTheme { get; set; }
        string Language { get; set; }
        AppUserPreferencesViewModel MyPreferences { get; set; }
        Guid? CustomerId { get; set; }
        string Company { get; set; }
        bool IsPortalSuperUser { get; set; }
        bool GroupByAccount { get; set; }
        bool ShowSelectAccountDropdown { get; set; }
    }

    public class SettingsService : ISettingsService
    {
        public const string BASER_URL = "https://portal-dev.trulite.com";
        public const string FORGOT_PASSWORD_URL = "https://portal.trulite.com/Account/Recover";


        public static ISettingsService _instance;
        private MyInfoViewModel _myInfo;
        private bool _isDriver;
        private string _pushNotificationToken;
        private string _pushNotificationEmail;
        private bool _isImpersonatingCustomer;
        private bool _rememberMe;
        private string _masterToken;
        private DateTime _masterTokenExpiration;
        private string _registrationId;
        private string _pnsHandle;
        private Dictionary<string, bool> _accountPermissions;
        private string _language;
        private AppUserPreferencesViewModel _preferences;
        private bool _groupByAccount;
        private bool _showSelectAccountDropdown;
        public static ISettingsService Instance => _instance ?? (_instance = new SettingsService());


        public SettingsService(ISettingsService testInstance = null)
        {
            _instance = testInstance;
        }


        public string ServerUrl
        {
            set { Preferences.Set(nameof(ServerUrl), value); }
            get { return Preferences.Get(nameof(ServerUrl), "https://kimedics-stage.azurewebsites.net/api/"); }
        }

        public string Email
        {
            set { Preferences.Set(nameof(Email), value); }
            get { return Preferences.Get(nameof(Email), string.Empty); }
        }

        public string Password
        {
            set { Preferences.Set(nameof(Password), value); }
            get { return Preferences.Get(nameof(Password), string.Empty); }
        }


        public string Token
        {
            set { Preferences.Set(nameof(Token), value); }
            get { return Preferences.Get(nameof(Token), string.Empty); }
        }

        public DateTime TokenExpiration
        {
            set { Preferences.Set(nameof(TokenExpiration), value); }
            get { return Preferences.Get(nameof(TokenExpiration), default(DateTime)); }
        }

        public ApplicationModeEnum ApplicationMode { get; set; }

        public Guid? CustomerId
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }


        public string AxCustomerId
        {
            get;
            set;
        }

        public MyInfoViewModel MyInfo
        {
            set
            {
                if (value == null)
                {
                    Preferences.Set(nameof(MyInfo), null);
                    return;
                }

                var json = JsonConvert.SerializeObject(value);
                Preferences.Set(nameof(MyInfo), json);
            }
            get
            {
                var json = Preferences.Get(nameof(MyInfo), null);
                if (json == null) return null;
                return JsonConvert.DeserializeObject<MyInfoViewModel>(json);
            }
        }

        public bool IsDriver
        {
            set { Preferences.Set(nameof(IsDriver), value); }
            get { return Preferences.Get(nameof(IsDriver), default(bool)); }
        }

        public string PushNotificationToken
        {
            set { Preferences.Set(nameof(PushNotificationToken), value); }
            get { return Preferences.Get(nameof(PushNotificationToken), string.Empty); }
        }

        public string PushNotificationEmail
        {
            set { Preferences.Set(nameof(PushNotificationEmail), value); }
            get { return Preferences.Get(nameof(PushNotificationEmail), string.Empty); }
        }

        public bool RememberMe
        {
            set { Preferences.Set(nameof(RememberMe), value); }
            get { return Preferences.Get(nameof(RememberMe), true); }
        }

        public string MasterToken
        {
            set { Preferences.Set(nameof(MasterToken), value); }
            get { return Preferences.Get(nameof(MasterToken), string.Empty); }
        }

        public DateTime MasterTokenExpiration
        {
            set { Preferences.Set(nameof(MasterTokenExpiration), value); }
            get { return Preferences.Get(nameof(MasterTokenExpiration), default(DateTime)); }
        }

        public string RegistrationId
        {
            get { return _registrationId; }
            set { _registrationId = value; }
        }

        public string PnsHandle
        {
            get { return _pnsHandle; }
            set { _pnsHandle = value; }
        }

        public Dictionary<string, bool> AccountPermissions
        {
            get { return _accountPermissions; }
            set { _accountPermissions = value; }
        }

        public string MasterAxCustomerId
        {
            set { Preferences.Set(nameof(MasterAxCustomerId), value); }
            get { return Preferences.Get(nameof(MasterAxCustomerId), string.Empty); }
        }


        public bool IsImpersonatingCustomer
        {
            set { Preferences.Set(nameof(IsImpersonatingCustomer), value); }
            get { return Preferences.Get(nameof(IsImpersonatingCustomer), false); }
        }

        public bool IsDarkTheme
        {
            set { Preferences.Set(nameof(IsDarkTheme), value); }
            get { return Preferences.Get(nameof(IsDarkTheme), false); }
        }

        public bool IsPortalSuperUser
        {
            set { Preferences.Set(nameof(IsPortalSuperUser), value); }
            get { return Preferences.Get(nameof(IsPortalSuperUser), false); }
        }


        public bool GroupByAccount
        {
            set { Preferences.Set(nameof(GroupByAccount), value); }
            get { return Preferences.Get(nameof(GroupByAccount), false); }
        }

        public bool ShowSelectAccountDropdown
        {
            set { Preferences.Set(nameof(ShowSelectAccountDropdown), value); }
            get { return Preferences.Get(nameof(ShowSelectAccountDropdown), false); }
        }


        public string Language
        {
            set { Preferences.Set(nameof(Language), value); }
            get { return Preferences.Get(nameof(Language), null); }
        }

        public AppUserPreferencesViewModel MyPreferences
        {
            set
            {
                if (value == null)
                {
                    Preferences.Set(nameof(MyPreferences), null);
                    return;
                }

                var json = JsonConvert.SerializeObject(value);
                Preferences.Set(nameof(MyPreferences), json);
            }
            get
            {
                var json = Preferences.Get(nameof(MyPreferences), null);
                if (json == null) return null;
                return JsonConvert.DeserializeObject<AppUserPreferencesViewModel>(json);
            }
        }
    }
}
