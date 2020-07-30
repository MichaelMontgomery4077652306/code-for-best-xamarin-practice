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
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Orders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.RetunedOrders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnedOrdersPage : ContentPage
    {
        private readonly RetunedOrdersPageViewModel _vm;

        public ReturnedOrdersPage()
        {
            InitializeComponent();
            BindingContext = _vm = new RetunedOrdersPageViewModel();
        }
        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class RetunedOrdersPageViewModel : TruliteBaseViewModel
    {
        private List<ReturnOrder> _rawList;


        private ObservableCollection<ReturnOrder> _returnedOrderList;

        public ObservableCollection<ReturnOrder> ReturnedOrderList
        {
            get { return _returnedOrderList; }
            set
            {
                _returnedOrderList = value;
                RaisePropertyChanged();
            }
        }


        private ReturnOrder _selectedOrder;

        public ReturnOrder SelectedOrder
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
        public ICommand OpenLinesCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterChangeCommand { get; }

        public RetunedOrdersPageViewModel()
        {
            OpenLinesCommand = new AsyncDelegateCommand(OnOpenLines);
            SearchCommand = new AsyncDelegateCommand<ReturnOrderQueryContext>(OnSearch);
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
        private ReturnOrderQueryContext _previousFilter;


        private bool IsFilterDifferentFromLast(ReturnOrderQueryContext currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.EndDate != currentFilter.EndDate) return true;
            if (_previousFilter.StartDate != currentFilter.StartDate) return true;
            return false;

        }



        private async Task OnOpenLines()
        {
            if (_selectedOrder == null) return;
            await Nav.NavigateTo(new ReturnedOrdersDetailsPage(_selectedOrder));
        }

        private async Task OnSearch(ReturnOrderQueryContext arg)
        {
            ShowFilter = false;
            await Load(arg);

        }


        public async Task Load(ReturnOrderQueryContext filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {

                IsBusy = true;
                if (filter == null)
                {
                    filter = new ReturnOrderQueryContext
                    {
                        CustomerInfo = Api.GetCustomerContext(),
                        
                    };

                }

                if ((filter.EndDate.GetValueOrDefault() - filter.StartDate.GetValueOrDefault()).TotalDays > 90)
                {
                    await Alert.ShowMessage(nameof(AppResources.DiffLessThan90DaysMessage).Translate());
                    return;
                }

                if (sortColumnItem != null)
                {
                    _sortColumnItem = sortColumnItem;
                }
                else if (_sortColumnItem == null)
                {
                    _sortColumnItem = new SortColumnItem(OrdersSortableColumns.OrderNumber, null) { Ascending = true };
                }

                if (IsFilterDifferentFromLast(filter))
                {

                    var lines = await Api.GetReturnOrders(filter);
                    if (!lines.Successful.GetValueOrDefault())
                    {
                        await Alert.ShowMessage(lines.ExceptionMessage);
                        return;
                    }
                    _previousFilter = filter;
                    _rawList = lines.Data.ToList();
                }

                TotalAmount = (decimal)_rawList.Sum(p => p.Amount.GetValueOrDefault());
                RowCount = _rawList.Count;

                var sortedLines = SortList(_sortColumnItem, _rawList)
                     .ToList();

                ReturnedOrderList= new ObservableCollection<ReturnOrder>(sortedLines);
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
        private static ICollection<ReturnOrder> SortList(SortColumnItem sortOrder, List<ReturnOrder> list)
        {
            switch (sortOrder.Key.ObjectToEnum<ReturnedOrdersSortColumns>())
            {
                case ReturnedOrdersSortColumns.SalesOrder:
                        list = sortOrder.Ascending ? list.OrderBy(p => p.SalesOrder?.Key).ToList()
                            : list.OrderByDescending(p => p.SalesOrder?.Key).ToList();
                    break;
                case ReturnedOrdersSortColumns.Invoice:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Invoice?.Key).ToList()
                        : list.OrderByDescending(p => p.Invoice?.Key).ToList();
                    break;
                case ReturnedOrdersSortColumns.Amount:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Amount.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.Amount.GetValueOrDefault()).ToList();
                    break;
                case ReturnedOrdersSortColumns.OrderNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.OrderNo).ToList()
                        : list.OrderByDescending(p => p.OrderNo).ToList();
                    break;
                case ReturnedOrdersSortColumns.Status:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Status.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.Status.GetValueOrDefault()).ToList();
                    break;
                case ReturnedOrdersSortColumns.ReturnDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ReturnDate).ToList()
                        : list.OrderByDescending(p => p.ReturnDate).ToList();
                    break;
                case ReturnedOrdersSortColumns.Lines:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.LinesCount).ToList()
                        : list.OrderByDescending(p => p.LinesCount).ToList();
                    break;
                case ReturnedOrdersSortColumns.Id:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}