using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.Themes;
using TruliteMobile.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.MyAccount
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountPage : ContentPage
    {
        private readonly MyAccountPageViewModel _vm;

        public MyAccountPage()
        {
            InitializeComponent();
            BindingContext = _vm = new MyAccountPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }

        protected override void OnDisappearing()
        {
            _vm.Save();
        }
    }

    public class MyAccountPageViewModel : TruliteBaseViewModel
    {
        #region Properties

        private bool _expandAccountInformation;

        public bool ExpandAccountInformation
        {
            get { return _expandAccountInformation; }
            set
            {
                _expandAccountInformation = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandCostumerInformation;

        public bool ExpandCostumerInformation
        {
            get { return _expandCostumerInformation; }
            set
            {
                _expandCostumerInformation = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandPreferences;

        public bool ExpandPreferences
        {
            get { return _expandPreferences; }
            set
            {
                _expandPreferences = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandConfirmations;

        public bool ExpandConfirmations
        {
            get { return _expandConfirmations; }
            set
            {
                _expandConfirmations = value;
                RaisePropertyChanged();
            }
        }


        private MyInfoViewModel _myInfo;

        public MyInfoViewModel MyInfo
        {
            get { return _myInfo; }
            set
            {
                _myInfo = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<string> _themeList;

        public ObservableCollection<string> ThemeList
        {
            get { return _themeList; }
            set
            {
                _themeList = value;
                RaisePropertyChanged();
            }
        } 

        private AppUserPreferencesViewModel _myPreferences;

        public AppUserPreferencesViewModel MyPreferences
        {
            get { return _myPreferences; }
            set
            {
                _myPreferences = value;
                RaisePropertyChanged();
            }
        }

        private string _selectedTheme;

        public string SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                if (value == null ||
                    _selectedTheme == value) return;

                _selectedTheme = value;
                RaisePropertyChanged();
                ChangeTheme();
            }
        }

        private void ChangeTheme()
        {
            var isDark = _themeList.IndexOf(_selectedTheme) == 1;
            if (Settings.IsDarkTheme == isDark) return;
            Settings.IsDarkTheme = isDark;
            App.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary theme = isDark ? (ResourceDictionary) new DarkTheme() : (ResourceDictionary) new LightTheme();
            App.Current.Resources.MergedDictionaries.Add(theme);

        }


        private ObservableCollection<CustomerConfirmInformation> _confirmations;

        public ObservableCollection<CustomerConfirmInformation> Confirmations
        {
            get { return _confirmations; }
            set
            {
                _confirmations = value;
                RaisePropertyChanged();
            }
        }

        private bool _showConfirmations;

        public bool ShowConfirmations
        {
            get { return _showConfirmations; }
            set
            {
                _showConfirmations = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region ICommand
        public ICommand ExpandAccountInformationCommand { get; }
        public ICommand ExpandCustomerInformationCommand { get; }
        public ICommand ExpandPreferencesCommand { get; }
        public ICommand ExpandConfirmationsCommand { get; }
        public ICommand EditConfirmInformationCommand { get; }
        public ICommand EditPhoneCommand { get; }
        #endregion

        //public ICommand DeleteConfirmInformationCommand { get; }
        //public ICommand HistoryConfirmInformationCommand { get; }
        public MyAccountPageViewModel()
        {
            ExpandAccountInformationCommand = new Command<bool>((show => ExpandAccountInformation = show));
            ExpandCustomerInformationCommand = new Command<bool>((show => ExpandCostumerInformation = show));
            ExpandPreferencesCommand = new Command<bool>((show => ExpandPreferences = show));
            ExpandConfirmationsCommand = new Command<bool>((show => ExpandConfirmations = show));
            EditPhoneCommand = new AsyncDelegateCommand(OnEditPhone);
            EditConfirmInformationCommand =
                new AsyncDelegateCommand<CustomerConfirmInformation>(OnEditConfirmInformation);
            MyInfo = Settings.MyInfo;
            MyPreferences = Settings.MyPreferences.CloneJson();
            ThemeList = new ObservableCollection<string>{
                nameof(AppResources.Light).Translate(),
                nameof(AppResources.Dark).Translate(),
            };
            SelectedTheme = Settings.IsDarkTheme ? _themeList[1] : ThemeList[0];

        }

        private async Task OnEditPhone()
        {
            await Nav.NavigateTo(new MyAccountEditPhonePage());
        }

        private async Task OnEditConfirmInformation(CustomerConfirmInformation arg)
        {
            await Nav.NavigateTo(new MyAccountEditConfirmInformationPage(arg));
        }

        public async Task Load()
        {

            try
            {

                IsBusy = true;
                if (Settings.MyInfo.CurrentUser.IsAdmin.GetValueOrDefault())
                {
                    var commListReturn = await Api.GetCustomersConfirmInformations(Api.GetCustomerContext());
                    if (!commListReturn.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(commListReturn.ExceptionMessage, commListReturn.ValidationErrors);
                        return;
                    }
                    Confirmations = new ObservableCollection<CustomerConfirmInformation>(commListReturn.Data);
                    ShowConfirmations = true;
                }


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

        public void Save()
        {
            Settings.MyPreferences = MyPreferences;
            
        }
    }
}