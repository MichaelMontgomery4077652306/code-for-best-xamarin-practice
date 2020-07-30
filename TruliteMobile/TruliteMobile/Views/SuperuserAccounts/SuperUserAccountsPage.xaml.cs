using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.PipelineAccounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.SuperuserAccounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuperUserAccountsPage : ContentPage
    {
        private readonly SuperUserAccountsPageViewModel _vm;

        public SuperUserAccountsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new SuperUserAccountsPageViewModel();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.Load();
        }

    }

    public class SuperUserAccountsPageViewModel : TruliteBaseViewModel
    {

        #region Properties
        private ObservableCollection<DynamicCustomer> _customerList;

        public ObservableCollection<DynamicCustomer> CustomerList
        {
            get { return _customerList; }
            set { _customerList = value; RaisePropertyChanged(); }
        }


        private DynamicCustomer _selectedCustomer;

        public DynamicCustomer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Command
        public ICommand SearchCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand FilterTriggerCommand { get; }
        #endregion


        public SuperUserAccountsPageViewModel()
        {
            SearchCommand = new AsyncDelegateCommand<GetCustomersSearchContext>(OnSearch);
            OpenCommand = new AsyncDelegateCommand(OnOpen);
            FilterTriggerCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterTrigger);
        }

        private SortColumnItem _currentFilter;
        private async Task OnFilterTrigger(SortColumnItem arg)
        {
            if (arg == null) return;
            try
            {
                IsBusy = true;
                ShowFilter = false;
                _currentFilter = arg;
                CustomerList?.Clear();
                await Refresh(_countContext);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task OnOpen()
        {

            try
            {
                if (IsBusy) return;
                IsBusy = true;
                if (_selectedCustomer == null) return;

                await ChangeLogin(_selectedCustomer.Key);
                Device.BeginInvokeOnMainThread(() =>
                {
                    App.Current.MainPage = new NavigationPage(new MasterDetailPage1(MainPageMode.Default));
                }
                );

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

        private async Task ChangeLogin(string customerId)
        {
            Settings.MasterAxCustomerId = Settings.AxCustomerId;
            Settings.MasterToken = Settings.Token;
            Settings.MasterTokenExpiration = Settings.TokenExpiration;
            Settings.AxCustomerId = _selectedCustomer.Key;
            Settings.IsImpersonatingCustomer = true;


            var result = await Api.GetToken(Settings.Email, Settings.Password, false,
                customerId);
            Settings.Token = result.access_token;
            Settings.TokenExpiration = DateTime.Now.AddSeconds(result.expires_in);

            var infoResult = await ApiService.Instance.GetMyInfo(new CustomerContext
            {
                AXCustomerId = customerId
            });
            if (infoResult.Data == null)
            {
                await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotReceiveInformationFromServer)));
                return;
            }
            Settings.MyPreferences = infoResult.Data.AppPreferences;
            Messenger.Reset();
        }


        private async Task OnSearch(GetCustomersSearchContext arg)
        {
            var countResponse = await Api.GetCustomerCount(arg);
            if (!countResponse.Successful.GetValueOrDefault())
            {
                await Alert.DisplayApiCallError(countResponse.ExceptionMessage, countResponse.ValidationErrors);
            }
            else
            {
                customerCount = countResponse.Data.Value;
                _maxPageNumber = (int)Math.Ceiling(customerCount / (double)_pageSize);
            }
            _pageNumber = 0;
            _pageSize = arg.PageSize ?? 50;
            _loading = false;
            ShowFilter = false;
            await Refresh(arg);
        }


        private int _pageSize = 50;
        private long customerCount = 0;
        protected int _pageNumber = 0;
        protected int _maxPageNumber = 1;
        protected bool _loading = false;
        public bool HasMoreToLoad { get { return _maxPageNumber > _pageNumber; } }
        protected object _lock = new object();
        protected GetCustomersSearchContext _countContext;

        public async Task Load()
        {
            var countContext = new GetCustomersSearchContext
            {
                BranchCode = Settings.MyInfo.CurrentUser.SiteBranchCode
            };
            var countResponse = await Api.GetCustomerCount(countContext);
            if (!countResponse.Successful.GetValueOrDefault())
            {
                await Alert.DisplayApiCallError(countResponse.ExceptionMessage, countResponse.ValidationErrors);
                return;
            }

            customerCount = countResponse.Data.Value;
            _maxPageNumber = (int)Math.Ceiling(customerCount / (double)_pageSize);
            _pageNumber = 0;
            _loading = false;
            await Refresh(countContext);
        }

        private async Task Refresh(GetCustomersSearchContext countContext)
        {
            //lock (_lock)
            //{
            //    if (!_loading && HasMoreToLoad)
            //    {
            //        _loading = true;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            try
            {

                _countContext = countContext ?? new GetCustomersSearchContext();
                if (_currentFilter.Key != null)
                {
                    _countContext.SortBy = _currentFilter.Key.ToString();
                    _countContext.IsDescendingSort = !_currentFilter.Ascending;

                }

                if (_pageNumber == 0)
                {
                    IsBusy = true;
                    CustomerList = new ObservableCollection<DynamicCustomer>();
                }

                _countContext.StartPage = _pageNumber;
                _countContext.PageSize = _pageSize;
                var result = await Api.GetCustomers(_countContext);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);

                }
                //_pageNumber += 1;
                CustomerList = new ObservableCollection<DynamicCustomer>(result.Data);

            }
            catch (Exception ex)
            {
                await Alert.DisplayError(ex);
            }
            finally
            {
                IsBusy = false;
                _loading = false;
            }
        }

    }
}