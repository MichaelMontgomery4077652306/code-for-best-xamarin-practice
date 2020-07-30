using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {
        private readonly OrdersPageViewModel _vm;

        public OrdersPage()
        {
            InitializeComponent();
            BindingContext = _vm = new OrdersPageViewModel();

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class OrdersPageViewModel : TruliteBaseViewModel
    {
        private List<SalesOrder> _rawList;

        private OptimizedObservableCollection<GroupedObservableCollection<string, SalesOrder>> _groupedList;

        public OptimizedObservableCollection<GroupedObservableCollection<string, SalesOrder>> GroupedList
        {
            get { return _groupedList; }
            set
            {
                _groupedList = value;
                RaisePropertyChanged();
            }

        }

         
        private SalesOrder _selectedOrder;

        public SalesOrder SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                RaisePropertyChanged();
            }
        }

        private decimal _totalAmount;

        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                RaisePropertyChanged();
            }
        }

        private int _rowCount;

        public int RowCount
        {
            get { return _rowCount; }
            set
            {
                _rowCount = value;
                RaisePropertyChanged();
            }
        }


        public ICommand ViewProofDeliveryCommand { get; }
        //public ICommand ViewPdfCommand { get; }
        //public ICommand DownloadPdfCommand { get; }
        public ICommand OpenLinesCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterChangeCommand { get; }

        public OrdersPageViewModel()
        {
             OpenLinesCommand = new AsyncDelegateCommand(OnOpenLines);
            SearchCommand = new AsyncDelegateCommand<OrderFilter>(OnSearch);
            //ViewProofDeliveryCommand = new AsyncDelegateCommand<SalesOrder>(OnViewProofDelivery);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
            ShowFilter = false;

        }
        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                IsBusy = true;
                await Load(_previousFilter, arg);
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

        private SortColumnItem _sortColumnItem;
        private OrderFilter _previousFilter;


        private bool IsFilterDifferentFromLast(OrderFilter currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.Number != currentFilter.Number) return true;
            if (_previousFilter.AccountNumber != currentFilter.AccountNumber) return true;
            if (_previousFilter.PONumber != currentFilter.PONumber) return true;
            if (_previousFilter.EndDate != currentFilter.EndDate) return true;
            if (_previousFilter.StartDate != currentFilter.StartDate) return true;
            if (_previousFilter.SelectedStatus.Key != currentFilter.SelectedStatus.Key) return true;
            if (_previousFilter.SelectedQty != currentFilter.SelectedQty) return true;

            return false;

        }

        //private async Task OnViewProofDelivery(SalesOrder arg)
        //{

        //}


        private async Task OnOpenLines()
        {
            if (_selectedOrder == null) return;
            await Nav.NavigateTo(new OrderDetailLinesPage(_selectedOrder));
        }

        private async Task OnSearch(OrderFilter arg)
        {
            ShowFilter = false;
            await Load(arg);

        }


        

        public async Task Load(OrderFilter filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {

                IsBusy = true;
                if (filter == null)
                {
                    filter = new OrderFilter
                    {
                        AccountNumber = Settings.AxCustomerId,
                        SelectedStatus = new KeyValuePair<SalesOrderQueryContextStatus, string>(SalesOrderQueryContextStatus.BackOrder,
                            nameof(AppResources.OpenOrder).Translate())

                    };

                }

                if (Math.Abs((filter.EndDate.GetValueOrDefault() - filter.StartDate.GetValueOrDefault()).TotalDays) > 90)
                {
                    await Alert.ShowMessage(nameof(AppResources.DiffLessThan90DaysMessage).Translate());
                    return;
                }

                if (sortColumnItem != null)
                {
                    _sortColumnItem = sortColumnItem;
                }
                else if (_sortColumnItem==null)
                {
                    _sortColumnItem = new SortColumnItem(OrdersSortableColumns.OrderNumber, null) { Ascending = true };
                }

                if (IsFilterDifferentFromLast(filter))
                {

                    var lines = await Api.GetOrders(filter);
                    if (!lines.Successful.GetValueOrDefault())
                    {
                       await Alert.DisplayApiCallError(lines.ExceptionMessage, lines.ValidationErrors);
                       return;
                    }
                    _previousFilter = filter;
                    _rawList = lines.Data.ToList();
                }

                TotalAmount = (decimal)_rawList.Sum(p => p.NetAmount.GetValueOrDefault());
                RowCount = _rawList.Count;

                var sortedLines = SortList(_sortColumnItem, _rawList)
                     .Take(filter.SelectedQty)
                     .ToList();

                GroupedList = sortedLines.GroupBy(p => $"{p.Account.Key} - {p.Account.Name}", p => p)
                        .ToGroupedObservable()    
                        .ToObservableCollection();
                NoResults = !sortedLines.Any();

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
        private static ICollection<SalesOrder> SortList(SortColumnItem sortOrder, ICollection<SalesOrder> list)
        {
            switch (sortOrder.Key.ObjectToEnum<OrdersSortableColumns>())
            {

                case OrdersSortableColumns.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Key).ToList()
                        : list.OrderByDescending(p => p.Account.Key).ToList();

                    break;
                case OrdersSortableColumns.Account:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Name).ToList()
                        : list.OrderByDescending(p => p.Account.Name).ToList();
                    break;

                case OrdersSortableColumns.PurchaseOrder:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerPurchaseOrderNo).ToList()
                        : list.OrderByDescending(p => p.CustomerPurchaseOrderNo).ToList();
                    break;
                case OrdersSortableColumns.JobName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerRef).ToList()
                        : list.OrderByDescending(p => p.CustomerRef).ToList();
                    break;
                case OrdersSortableColumns.Plant:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.InventLocationName).ToList()
                        : list.OrderByDescending(p => p.InventLocationName).ToList();
                    break;
                case OrdersSortableColumns.Status:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.SalesOrderStatus).ToList()
                        : list.OrderByDescending(p => p.SalesOrderStatus).ToList();
                    break;
                case OrdersSortableColumns.OrderNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;

                case OrdersSortableColumns.DeliveryDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DeliveryDate).ToList()
                        : list.OrderByDescending(p => p.DeliveryDate).ToList();
                    break;

                case OrdersSortableColumns.Lines:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.LinesCount).ToList()
                        : list.OrderByDescending(p => p.LinesCount).ToList();
                    break;
                case OrdersSortableColumns.Amount:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.NetAmount).ToList()
                        : list.OrderByDescending(p => p.NetAmount).ToList();
                    break;
                case OrdersSortableColumns.OrderDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.OrderDate).ToList()
                        : list.OrderByDescending(p => p.OrderDate).ToList();
                    break;
                case OrdersSortableColumns.Invoices:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Invoices.Count).ToList()
                        : list.OrderByDescending(p => p.Invoices.Count).ToList();
                    break;
                case OrdersSortableColumns.PackingSlips:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.PackingSlips.Count).ToList()
                        : list.OrderByDescending(p => p.PackingSlips.Count).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}