using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ExTrack.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Syncfusion.SfChart.XForms;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.Themes;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.SignUp;
using TruliteMobile.Views.Terms;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Messenger.Reset();
            NavigationService.Instance.Init(this.Navigation);
            BindingContext = new LoginViewModel();
        }

        protected override void OnAppearing()
        {
            //Reset navigation service Navigation due to a bug where
            //the navigation server INavigation instance might not update correctly
            //when the user logout from a previous session.
            // NavigationService.Instance.Init(Navigation);

        }
    }

    public class LoginViewModel : TruliteBaseViewModel
    {
        #region Properties
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private bool _rememberMe;

        public bool RememberMe
        {
            get { return _rememberMe; }
            set
            {
                _rememberMe = value;
                RaisePropertyChanged();
            }
        }

        private bool _isDriver;

        public bool IsDriver
        {
            get { return _isDriver; }
            set
            {
                _isDriver = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<string, string>> _languageList;

        public ObservableCollection<KeyValuePair<string, string>> LanguageList
        {
            get { return _languageList; }
            set
            {
                _languageList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string, string> _selectedLanguage;

        public KeyValuePair<string, string> SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                _selectedLanguage = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<string, string>> _companyList;

        public ObservableCollection<KeyValuePair<string, string>> CompanyList
        {
            get { return _companyList; }
            set
            {
                _companyList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string, string> _selectedCompany;

        public KeyValuePair<string, string> SelectedCompany
        {
            get { return _selectedCompany; }
            set
            {
                _selectedCompany = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; }
        public ICommand SignUpCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public ICommand OpenLinkCommand { get; }

        #endregion
        public LoginViewModel()
        {
            LoginCommand = new AsyncDelegateCommand(OnLogin);
            SignUpCommand = new AsyncDelegateCommand(OnSignUp);
            ForgotPasswordCommand = new AsyncDelegateCommand(OnForgotPassword);
            OpenLinkCommand = new RelayCommand<ExternalLinks>(OnOpenLink);

            RememberMe = Settings.RememberMe;

            if (_rememberMe)
            {
                Email = Settings.Email;
                Password = Settings.Password;
                IsDriver = Settings.IsDriver;
            }

            LanguageList = new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("en",
                    nameof(AppResources.English).Translate()),
                new KeyValuePair<string, string>("es",
                    nameof(AppResources.Spanish).Translate()),

                new KeyValuePair<string, string>("fr",
                    nameof(AppResources.French).Translate()),

            };

            if (Settings.Language == null)
            {
                var language = _languageList.FirstOrDefault(p => p.Key == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);

                SelectedLanguage = language.Key != null ?
                    _languageList.First(p => p.Key == language.Key)
                    : _languageList.First();
            }
            else
            {
                SelectedLanguage = _languageList.First(p => p.Key == Settings.Language);
            }

            CompanyList = new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("AAG","AAG"),
                new KeyValuePair<string, string>("GRE","GRE")
            };
            SelectedCompany = _companyList[0];


#if DEBUG

            Settings.ApplicationMode = ApplicationModeEnum.Driver;
            switch (Settings.ApplicationMode)
            {
                case ApplicationModeEnum.Portal:

                    //Email = "SuperUser@Baal.com";
                    //Password = "baal12";

                    //Email = "bs_plantadmin@trulite.com";
                    //Password = "bassam";

                    //Email = "alpha@baal.com";
                    //Password = "baal12";

                    Email = "9510@baal.com";
                    Password = "bassam";

                    //Email = "tester@baal.com";
                    //Password = "Password1234";

                    //Email = "baal@1.com";
                    //Password = "baal12";

                    //Multiple accounts
                    //Email = "fer@baal.com"; ;
                    //Password = "bassam";
                    break;
                case ApplicationModeEnum.Driver:
                    Email = "Drv101";
                    Password = "bassam";

                  
                    break;
                case ApplicationModeEnum.Pipeline:
                    Email = "137@trulite.com";
                    Password = "137137137";

                    Email = "bs@sc.com";
                    Password = "bassam";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

#endif
        }

        private void SetLanguage()
        {
            if (Settings.Language == _selectedLanguage.Key) return;
            var localize = DependencyService.Get<ILocalize>();
            localize.SetLocale(new CultureInfo(_selectedLanguage.Key));
            Translate.Init();
            Settings.Language = _selectedLanguage.Key;
        }


        private async void OnOpenLink(ExternalLinks linkToOpen)
        {
            Uri uriToOpen = null;
            switch (linkToOpen)
            {
                case ExternalLinks.TruliteHomePage:
                    uriToOpen = new Uri(Constants.TRULITE_HOME_URL);
                    break;
                case ExternalLinks.Locations:
                    uriToOpen = new Uri(Constants.TRULITE_LOCATION_URL);
                    break;
                case ExternalLinks.ContactUs:
                    uriToOpen = new Uri(Constants.TRULITE_CONTACT_US_URL);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(linkToOpen), linkToOpen, null);
            }

            await Launcher.OpenAsync(uriToOpen);
        }

        private async Task OnForgotPassword()
        {
            await Launcher.OpenAsync(new Uri(SettingsService.FORGOT_PASSWORD_URL));
        }

        private async Task OnSignUp()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new SignUpPage());
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task<bool> Validate()
        {
            if (string.IsNullOrWhiteSpace(_email))
            {
                await Alert.ShowMessage(Translate.Get(nameof(AppResources.EmailCannotBeEmpty)));
                return false;
            }
            if (string.IsNullOrWhiteSpace(_password))
            {
                await Alert.ShowMessage(Translate.Get(nameof(AppResources.PasswordCannotBeEmpty)));
                return false;
            }

            if (Connectivity.NetworkAccess != NetworkAccess.Internet
                && Connectivity.NetworkAccess != NetworkAccess.ConstrainedInternet)
            {

                await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotConnectToServer)),
                    Translate.Get(nameof(AppResources.Offline)));
                return false;
            }

            return true;
        }

        private async Task OnLogin()
        {
            IsBusy = true;
            try
            {
                if (!await Validate()) return;

                var result = await ApiService.Instance.GetToken(_email, _password, _isDriver, null, _selectedCompany.Key);

                if (string.IsNullOrWhiteSpace(result?.access_token))
                {
                    await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotLoginMessage)));
                    return;
                }

                Settings.PushNotificationEmail = _email;
                Settings.IsImpersonatingCustomer = false;
                Settings.IsDriver = _isDriver;
                Settings.Password = _password;
                Settings.Email = _email;

                Settings.RememberMe = _rememberMe;
                Settings.Token = result.access_token;
                Settings.TokenExpiration = DateTime.Now.AddSeconds(result.expires_in);
                Settings.IsPortalSuperUser = false;

                var infoResult = await ApiService.Instance.GetMyInfo(null);

                if (infoResult.Data == null)
                {
                    await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotReceiveInformationFromServer)));
                    return;
                }

                
                var mainPageMode = MainPageMode.Default;
                var infoData = infoResult.Data;
                if (infoData.CurrentUser?.IsDriver.GetValueOrDefault() ?? false)
                {
                    Settings.ApplicationMode = ApplicationModeEnum.Driver;
                }
                else if (infoData.CurrentUser?.IsSalesRep.GetValueOrDefault() ?? false)
                {
                    Settings.ApplicationMode = ApplicationModeEnum.Pipeline;
                }
                else
                {
                    Settings.ApplicationMode = ApplicationModeEnum.Portal;

                    if (infoData.CurrentUser.IsTruliteUser)
                    {
                        Settings.IsPortalSuperUser = true;
                        mainPageMode = MainPageMode.PortalSuperUser;
                    }

                }

                //Currently only portal has Light/Dark mode
                if (Settings.ApplicationMode == ApplicationModeEnum.Portal)
                {
                    if (SettingsService.Instance.IsDarkTheme)
                    {
                        var dt = new DarkTheme();
                        App.Current.Resources.MergedDictionaries.Add(dt);
                    }
                }

                
                Settings.Company = _selectedCompany.Key;
                Settings.CustomerId = infoData?.CurrentUser?.ActiveCustomerId;
                Settings.AxCustomerId = infoData?.CustomerInfo?.Key;
                Settings.MasterAxCustomerId = infoData?.CustomerInfo?.Key;
                Settings.MyInfo = infoData;
                if (Settings.MyPreferences == null)
                {
                    Settings.MyPreferences = infoData.AppPreferences;
                }

                await PushNotificationService.Instance.RegisterTokenWithServer();

                var permissions = await Api.GetAccountPermissions();
                Settings.AccountPermissions = permissions.Data;
                SetLanguage();
                Analytics.TrackEvent("Logged", new Dictionary<string, string>
                {{ "User", _email}});


                if (infoData.CurrentUser.HasAgreedToTerms.GetValueOrDefault())
                {
                    var mainpage = new NavigationPage(new MasterDetailPage1(mainPageMode));
                    App.Current.MainPage = mainpage;
                    NavigationService.Instance.Init(mainpage.Navigation);
                }
                else
                {
                    await NavigateTo(new TermsPage(mainPageMode),true);
                   
                }
                //Crashes.GenerateTestCrash();
               
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }

        }


    }

}