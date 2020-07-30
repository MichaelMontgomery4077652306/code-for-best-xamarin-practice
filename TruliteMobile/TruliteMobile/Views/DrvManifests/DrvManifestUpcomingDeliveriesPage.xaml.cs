using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.PackingSlips;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvManifests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvManifestUpcomingDeliveriesPage : ContentPage
    {
        private readonly DrvManifestUpcomingDeliveriesPageViewModel _vm;

        public DrvManifestUpcomingDeliveriesPage(string customerAccount, PackingSlip packingSlip)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvManifestUpcomingDeliveriesPageViewModel(packingSlip, customerAccount);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvManifestUpcomingDeliveriesPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private readonly PackingSlip _packingSlip;
        private readonly string _customerAccount;
        private ObservableCollection<SalesOrder> _deliveryList;

        public ObservableCollection<SalesOrder> DeliveryList
        {
            get { return _deliveryList; }
            set
            {
                _deliveryList = value;
                RaisePropertyChanged();
            }
        }

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

        private ObservableCollection<SortColumnItem> _sortColumns;

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                RaisePropertyChanged();
            }
        }

        private SortColumnItem _selectedSortColumn;

        public SortColumnItem SelectedSortColumn
        {
            get { return _selectedSortColumn; }
            set
            {
                _selectedSortColumn = value;
                RaisePropertyChanged();
            }
        }



        #endregion
        #region Commands

        public ICommand EmailCustomerCommand { get; }
        public ICommand FilterTriggerCommand { get; }

        public ICommand SelectAllCommand { get; }
        #endregion
        public DrvManifestUpcomingDeliveriesPageViewModel(PackingSlip packingSlip, string customerAccount)
        {

            _packingSlip = packingSlip;
            _customerAccount = customerAccount;
            EmailCustomerCommand = new AsyncDelegateCommand(OnEmailCustomer);
            SelectAllCommand = new Command(OnSelectAll);
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(UpcomingDeliveriesSortColumns.IsSelected,  nameof(AppResources.Selected).Translate()),
                new SortColumnItem(UpcomingDeliveriesSortColumns.OrderNumber,  nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(UpcomingDeliveriesSortColumns.PurchaseOrder,  nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(UpcomingDeliveriesSortColumns.DeliveryDate,  nameof(AppResources.DeliveryDate).Translate()),
            };
            SelectedSortColumn = _sortColumns[0];
            FilterTriggerCommand= new Command<SortColumnItem>(OnFilterTriggered);
            
        }

        private void OnFilterTriggered(SortColumnItem sortColumn)
        {
            IEnumerable<SalesOrder> list= new List<SalesOrder>();
            switch (sortColumn.Key.ObjectToEnum<UpcomingDeliveriesSortColumns>())
            {
                case UpcomingDeliveriesSortColumns.IsSelected:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.IsSelected).ToList()
                        : list.OrderByDescending(p => p.IsSelected).ToList();
                    break;
                case UpcomingDeliveriesSortColumns.OrderNumber:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;
                case UpcomingDeliveriesSortColumns.PurchaseOrder:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CustomerPurchaseOrderNo).ToList()
                        : list.OrderByDescending(p => p.CustomerPurchaseOrderNo).ToList();
                    break;
                case UpcomingDeliveriesSortColumns.DeliveryDate:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.OrderDate.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.OrderDate.GetValueOrDefault()).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            DeliveryList= new ObservableCollection<SalesOrder>(list);
        }

        private void OnSelectAll()
        {
            if (!_deliveryList?.Any() ?? true) return;
            if (_deliveryList.All(p => p.IsSelected))
            {
                foreach (var salesOrder in _deliveryList)
                {
                    salesOrder.IsSelected = false;
                }
                return;
            }
            foreach (var salesOrder in _deliveryList)
            {
                salesOrder.IsSelected = true;
            }
        }

        private async Task OnEmailCustomer()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                if (!_email.IsValidEmail())
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterValidEmail).Translate());
                    return;
                }

                if (!_deliveryList.Any(p => p.IsSelected))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseSelectAnItem).Translate());
                    return;
                }
                
                var context = new UpcomingDeliveriesQueryContext
                {
                    EmailAddress = _email,
                    SelectedOrders = _deliveryList
                        .Where(p => p.IsSelected)
                        .Select(p => p.Key)
                        .ToList(),
                    
                };

                var result = await Api.NotifyUpcomingDeliveries(context);
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                await Back();
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

        public async Task Load()
        {
            try
            {
                if(IsBusy)return;
                IsBusy = true;
                var context = new SalesOrderQueryContext
                {
                    CustomerInfo = new CustomerContext{
                    AXCustomerId= _packingSlip.Account.Key
                    },
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(21),
                    Status = SalesOrderQueryContextStatus.None,
                };

                var result = await Api.UpcomingDeliveries(context);
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                DeliveryList = new ObservableCollection<SalesOrder>(result.Data);
                NoResults = (!_deliveryList?.Any()??true);

                var getCustomerResponse = await Api.GetCustomerInfo(_customerAccount);
                if (!getCustomerResponse.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(getCustomerResponse.ExceptionMessage, getCustomerResponse.ValidationErrors,
                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                Email = getCustomerResponse.Data.EmailAddress;

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

    public enum UpcomingDeliveriesSortColumns
    {
        IsSelected,
        OrderNumber,
        PurchaseOrder,
        DeliveryDate,
    }
}