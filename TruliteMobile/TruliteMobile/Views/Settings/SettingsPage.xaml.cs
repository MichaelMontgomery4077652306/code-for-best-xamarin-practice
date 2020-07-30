using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.ChangePassword;
using TruliteMobile.Views.Feedback;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private SettingsPageViewModel _vm;

        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new SettingsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }

        protected override async void OnDisappearing()
        {
            await _vm.Save();
        }
    }


    public class SettingsPageViewModel : TruliteBaseViewModel
    {


        private bool _groupByAccount;

        public bool GroupByAccount
        {
            get { return _groupByAccount; }
            set
            {
                _groupByAccount = value;
                RaisePropertyChanged();
            }
        }

        private bool _showSelectAccountDropdown;

        public bool ShowSelectAccountDropdown
        {
            get { return _showSelectAccountDropdown; }
            set
            {
                _showSelectAccountDropdown = value;
                RaisePropertyChanged();
            }
        }



        private bool _isAdmin;

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                _isAdmin = value;
                RaisePropertyChanged();
            }
        }

        private bool _accountDropDown;

        public bool AccountDropDown
        {
            get { return _accountDropDown; }
            set
            {
                _accountDropDown = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<DynamicCustomer> _accountList;

        public ObservableCollection<DynamicCustomer> AccountList
        {
            get { return _accountList; }
            set
            {
                _accountList = value;
                RaisePropertyChanged();
            }
        }

        private DynamicCustomer _selectedAccount;

        public DynamicCustomer SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                _selectedAccount = value;
                RaisePropertyChanged();
                UpdateSettings();
            }
        }

        private void UpdateSettings()
        {
            Settings.GroupByAccount = _groupByAccount;
            Settings.ShowSelectAccountDropdown = _showSelectAccountDropdown;
            if (_showSelectAccountDropdown && _selectedAccount != null)
            {
                Settings.AxCustomerId = _selectedAccount.Key;
            }
            else
            {
                Settings.AxCustomerId = Settings.MyInfo.CustomerInfo.Key;
            }

        }


        public ICommand ChangeGroupingCommand { get; }
        public ICommand OpenFeedbackCommand { get; }
        public ICommand ChangePasswordCommand { get; }
        public ICommand OpenAboutCommand { get; }


        public SettingsPageViewModel()
        {
            OpenFeedbackCommand = new AsyncDelegateCommand(OnOpenFeedback);
            ChangePasswordCommand = new AsyncDelegateCommand(OnChangePassword);
            OpenAboutCommand = new AsyncDelegateCommand(OnAbout);
            ChangeGroupingCommand = new Command(() => AccountDropDown = !_accountDropDown);
            IsAdmin = Settings.MyInfo.CurrentUser.IsAdmin.GetValueOrDefault();
            GroupByAccount = Settings.GroupByAccount;
            ShowSelectAccountDropdown = Settings.ShowSelectAccountDropdown;
        }

        private async Task OnAbout()
        {

        }

        private async Task OnChangePassword()
        {
            await Nav.NavigateTo(new ResetPasswordPage());
        }

        private async Task OnOpenFeedback()
        {
            await Nav.NavigateTo(new GiveFeedbackPage());
        }

        public async Task Load()
        {

            try
            {
                if (!_isAdmin) return;
                IsBusy = true;

                var result = await Api.GetAccounts(Api.GetCustomerContext());
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.ShowMessage(result.ExceptionMessage);
                    return;
                }

                AccountList = new ObservableCollection<DynamicCustomer>(result.Data);

                SelectedAccount = _accountList.FirstOrDefault(p => p.Key.Equals(Settings.AxCustomerId));
            }
            catch (Exception ex)
            {
                await Alert.DisplayError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public async Task Save()
        {

            try
            {
                UpdateSettings();
            }
            catch (Exception ex)
            {
                await Alert.DisplayError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}