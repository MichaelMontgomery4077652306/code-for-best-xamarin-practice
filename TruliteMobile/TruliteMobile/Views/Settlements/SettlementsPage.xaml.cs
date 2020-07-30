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
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.RetunedOrders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Settlements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettlementsPage : ContentPage
    {
        private readonly SettlementsPageViewModel _vm;

        public SettlementsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new SettlementsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class SettlementsPageViewModel : TruliteBaseViewModel
    {

        private ObservableCollection<InvoicePaymentView> _completed;

        public ObservableCollection<InvoicePaymentView> Completed
        {
            get { return _completed; }
            set
            {
                _completed = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoCompletedResults));
            }
        }


        private ObservableCollection<InvoiceSettlement> _settledList;

        public ObservableCollection<InvoiceSettlement> SettledList
        {
            get { return _settledList; }
            set
            {
                _settledList = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoSettledResults));
            }
        }




        private ObservableCollection<InvoicePaymentView> _pendingList;

        public ObservableCollection<InvoicePaymentView> PendingList
        {
            get { return _pendingList; }
            set
            {
                _pendingList = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoPendingResults));
            }
        }



        private bool _showPending;

        public bool ShowPending
        {
            get { return _showPending; }
            set
            {
                _showPending = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoPendingResults));
            }
        }



        private bool _showSettled;

        public bool ShowSettled
        {
            get { return _showSettled; }
            set
            {
                _showSettled = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoSettledResults));
            }
        }

        private bool _showCompleted;

        public bool ShowCompleted
        {
            get { return _showCompleted; }
            set
            {
                _showCompleted = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowNoCompletedResults));
            }
        }

        public bool ShowNoCompletedResults
        {
            get { return _showCompleted && (!_completed?.Any() ?? true); }
        }

        public bool ShowNoPendingResults
        {
            get { return _showPending && (!_pendingList?.Any() ?? true); }
        }

        public bool ShowNoSettledResults
        {
            get { return _showSettled && (!_settledList?.Any() ?? true); }
        }


        public ICommand ViewPendingReceiptCommand { get; }
        public ICommand ViewSettledReceiptCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand TogglePendingCommand { get; }
        public ICommand ToggleCompletedCommand { get; }
        public ICommand ToggleSettledCommand { get; }
        public ICommand FilterChangeCommand { get; }
        public SettlementsPageViewModel()
        {
            SearchCommand = new AsyncDelegateCommand<SettlementsFilterModel>(OnSearch);
            ViewPendingReceiptCommand = new AsyncDelegateCommand<InvoicePaymentView>(OnViewPendingReceipt);
            ViewSettledReceiptCommand = new AsyncDelegateCommand<InvoicePaymentView>(OnViewSettledReceipt);
            TogglePendingCommand = new Command<bool>((show) => ShowPending = show);
            ToggleSettledCommand = new Command<bool>((show) => ShowSettled = show);
            ToggleCompletedCommand = new Command<bool>((show) => ShowCompleted = show);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
            ShowFilter = false;
        }

        private async Task OnFilterChanged(SortColumnItem sortColumn)
        {
            try
            {
                IsBusy = true;
                await Load(_previousFilter, sortColumn);
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

        private async Task OnSearch(SettlementsFilterModel filter)
        {
            await Load(filter);
            ShowFilter = false;
        }

        private async Task OnViewPendingReceipt(InvoicePaymentView payment)
        {
            if (payment == null) return;
            await Nav.NavigateTo(new SettlementViewReceiptPage(payment));

        }

        private async Task OnViewSettledReceipt(InvoicePaymentView payment)
        {
            if (payment == null) return;
            await Nav.NavigateTo(new SettlementViewReceiptPage(payment));
        }

        private SettlementsFilterModel _previousFilter;
        private SortColumnItem _sortColumnItem;


        private bool IsFilterDifferentFromLast(SettlementsFilterModel currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.EndDate != currentFilter.EndDate) return true;
            if (_previousFilter.StartDate != currentFilter.StartDate) return true;
            return false;

        }

        public async Task Load(SettlementsFilterModel filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {
                IsBusy = true;

                if (sortColumnItem != null)
                {
                    _sortColumnItem = sortColumnItem;
                }
                else if (_sortColumnItem == null)
                {
                    _sortColumnItem = new SortColumnItem(SettlementsSortColumns.Date, null) { Ascending = true };
                }

                filter = filter ?? new SettlementsFilterModel();
                if (IsFilterDifferentFromLast(filter))
                {
                   
                    var context = new CreditCardPaymentsQueryContext
                    {
                        CustomerInfo = Api.GetCustomerContext(),
                        FromDate = filter.StartDate,
                        ToDate = filter.EndDate,
                    };
                    var result = await Api.GetPayments(context);
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                            nameof(AppResources.ServerError));
                        return;
                    }
                    InvoiceSettlementsQueryContext settlementContext = new InvoiceSettlementsQueryContext
                    {
                        CustomerInfo = Api.GetCustomerContext(),
                        FromDate = filter.StartDate,
                        ToDate = filter.EndDate
                    };
                    var settlementResult = await Api.GetInvoiceSettlements(settlementContext);
                    if (!settlementResult.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(settlementResult.ExceptionMessage, settlementResult.ValidationErrors);
                        return;
                    }
                    var completed = result.Data.Where(p => p.Settled.GetValueOrDefault()).ToList();

                    PendingList = new ObservableCollection<InvoicePaymentView>(SortList(_sortColumnItem, result.Data.Except(completed)));
                    Completed = new ObservableCollection<InvoicePaymentView>(SortList(_sortColumnItem, completed));
                    SettledList = new ObservableCollection<InvoiceSettlement>(settlementResult.Data);
                    _previousFilter = filter;
                    return;
                }

                PendingList = new ObservableCollection<InvoicePaymentView>(SortList(_sortColumnItem, _pendingList));
                Completed = new ObservableCollection<InvoicePaymentView>(SortList(_sortColumnItem, _completed));




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
        private static IEnumerable<InvoicePaymentView> SortList(SortColumnItem sortOrder, IEnumerable<InvoicePaymentView> list)
        {
            switch (sortOrder.Key.ObjectToEnum<SettlementsSortColumns>())
            {

                case SettlementsSortColumns.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.AXCustomerId).ToList()
                        : list.OrderByDescending(p => p.AXCustomerId).ToList();
                    break;
                case SettlementsSortColumns.Account:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerName).ToList()
                        : list.OrderByDescending(p => p.CustomerName).ToList();
                    break;
                case SettlementsSortColumns.PaidBy:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.PaidBy).ToList()
                        : list.OrderByDescending(p => p.PaidBy).ToList();
                    break;
                case SettlementsSortColumns.Date:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DateProcessed.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateProcessed.GetValueOrDefault()).ToList();
                    break;
                case SettlementsSortColumns.MoneyOnAccount:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.IsMoneyOnAccountRequest.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.IsMoneyOnAccountRequest.GetValueOrDefault()).ToList();

                    break;
                case SettlementsSortColumns.Note:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Note).ToList()
                        : list.OrderByDescending(p => p.Note).ToList();

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}