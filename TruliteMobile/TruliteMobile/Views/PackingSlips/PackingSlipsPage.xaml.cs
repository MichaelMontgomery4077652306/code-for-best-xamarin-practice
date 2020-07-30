using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.Interfaces;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.PackingSlips
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackingSlipsPage : ContentPage
    {
        private readonly PackingSlipsPageViewModel _vm;

        public PackingSlipsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new PackingSlipsPageViewModel();

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PackingSlipsPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private ObservableCollection<PackingSlipModel> _list;

        private PackingSlipModel _selectedPackingSlip;

        public PackingSlipModel SelectedPackingSlip
        {
            get { return _selectedPackingSlip; }
            set
            {
                _selectedPackingSlip = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<PackingSlipModel> List
        {
            get { return _list; }
            set { _list = value; RaisePropertyChanged(); }
        }
        #endregion

        #region Commands
        public ICommand OpenLinesCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterChangeCommand { get; } 
        #endregion


        public PackingSlipsPageViewModel()
        {
            OpenLinesCommand = new AsyncDelegateCommand(OnOpenLines);
            List = new ObservableCollection<PackingSlipModel>();
            SearchCommand = new AsyncDelegateCommand<PackingSlipFilterModel>(OnSearch);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
        }

        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                IsBusy = true;
                ShowFilter = false;
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
        private PackingSlipFilterModel _previousFilter;


        private bool IsFilterDifferentFromLast(PackingSlipFilterModel currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.SelectedQty != currentFilter.SelectedQty) return true;
            if (_previousFilter.AccountNumber != currentFilter.AccountNumber) return true;
            if (_previousFilter.CustAccount != currentFilter.CustAccount) return true;
            if (_previousFilter.DateFrom != currentFilter.DateFrom) return true;
            if (_previousFilter.DateTo != currentFilter.DateTo) return true;
            if (_previousFilter.SalesOrder != currentFilter.SalesOrder) return true;
            if (_previousFilter.PackingSlipId != currentFilter.PackingSlipId) return true;
            if (_previousFilter.PurchaseOrder != currentFilter.PurchaseOrder) return true;
            return false;

        }


        private async Task OnOpenLines()
        {
            if (_selectedPackingSlip == null) return;
            await Nav.NavigateTo(new PackingSlipsDetailLinesPage(_selectedPackingSlip.OriginalData));
            SelectedPackingSlip = null;//Reset listview selection
        }

        private async Task OnSearch(PackingSlipFilterModel arg)
        {
            ShowFilter = false;
            await Load(arg);

        }


        private SortColumnItem _currentSortColumn;
        public async Task Load(PackingSlipFilterModel filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {
                IsBusy = true;
                if (filter == null)
                {
                    filter = new PackingSlipFilterModel
                    {
                        AccountNumber = Settings.AxCustomerId,
                        DateFrom = DateTime.Today.AddDays(-900),
                        DateTo = DateTime.Today,
                        
                    };
                }
                var sortOrder= sortColumnItem
                                ?? _currentSortColumn 
                    ?? new SortColumnItem(PackingSlipSortableColumns.OrderDate, null)
                                {
                                    Ascending = true
                                };


                IEnumerable<PackingSlipModel> lines;
                if (IsFilterDifferentFromLast(filter))
                {
                    var result = await Api.GetPackingSlips(filter.ToQueryContext());
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                        return;
                    }
                    _previousFilter = filter;
                    lines = new List<PackingSlipModel>(result.Data.Select(p => p.ToPackingSlipModel()));
                }
                else
                {
                    lines = _list;
                }
                var sortedLines = SortList(sortOrder, lines.ToList())
                    .Take(filter.SelectedQty)
                    .ToList();
                _currentSortColumn = sortOrder;
                List = new ObservableCollection<PackingSlipModel>(sortedLines);
                NoResults =!sortedLines.Any();
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

        private static ICollection<PackingSlipModel> SortList(SortColumnItem sortOrder, ICollection<PackingSlipModel> list)
        {
            switch ((PackingSlipSortableColumns)sortOrder.Key)
            {

                case PackingSlipSortableColumns.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.AccountNumber).ToList()
                        : list.OrderByDescending(p => p.AccountNumber).ToList();

                    break;
                case PackingSlipSortableColumns.Account:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account).ToList()
                        : list.OrderByDescending(p => p.Account).ToList();
                    break;

                case PackingSlipSortableColumns.PurchaseOrder:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.PurchaseOrder).ToList()
                        : list.OrderByDescending(p => p.PurchaseOrder).ToList();
                    break;
                case PackingSlipSortableColumns.JobName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.JobName).ToList()
                        : list.OrderByDescending(p => p.JobName).ToList();
                    break;

                case PackingSlipSortableColumns.OrderNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.OrderNumber).ToList()
                        : list.OrderByDescending(p => p.OrderNumber).ToList();
                    break;
                case PackingSlipSortableColumns.Plant:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Plant).ToList()
                        : list.OrderByDescending(p => p.Plant).ToList();
                    break;
                case PackingSlipSortableColumns.PackingSlip:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Voucher).ToList()
                        : list.OrderByDescending(p => p.Voucher).ToList();
                    break;

                case PackingSlipSortableColumns.OrderDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.OrderDate).ToList()
                        : list.OrderByDescending(p => p.OrderDate).ToList();
                    break;
                case PackingSlipSortableColumns.DateShipped:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DateShipped).ToList()
                        : list.OrderByDescending(p => p.DateShipped).ToList();
                    break;
                case PackingSlipSortableColumns.RequestedDeliveryDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.RequestedDeliveryDate).ToList()
                        : list.OrderByDescending(p => p.RequestedDeliveryDate).ToList();
                    break;
                case PackingSlipSortableColumns.Terms:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Terms).ToList()
                        : list.OrderByDescending(p => p.Terms).ToList();
                    break;

                case PackingSlipSortableColumns.Weight:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Weight).ToList()
                        : list.OrderByDescending(p => p.Weight).ToList();
                    break;
                case PackingSlipSortableColumns.Sqft:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Sqft).ToList()
                        : list.OrderByDescending(p => p.Sqft).ToList();
                    break;
                case PackingSlipSortableColumns.Lines:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Lines).ToList()
                        : list.OrderByDescending(p => p.Lines).ToList();
                    break;
                case PackingSlipSortableColumns.Voucher:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Voucher).ToList()
                        : list.OrderByDescending(p => p.Voucher).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}