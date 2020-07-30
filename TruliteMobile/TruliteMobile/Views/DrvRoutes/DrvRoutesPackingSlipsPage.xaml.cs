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
using TruliteMobile.Views.PackingSlips;
using TruliteMobile.Views.Pdf;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvRoutesPackingSlipsPage : ContentPage
    {
        private readonly DrvRoutesPackingSlipsPageViewModel _vm;

        public DrvRoutesPackingSlipsPage(SalesPool salesPool)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvRoutesPackingSlipsPageViewModel(salesPool){RootGrid = root};
        }
        
        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }


    public class DrvRoutesPackingSlipsPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private readonly SalesPool _salesPool;
        private ObservableCollection<PackingSlip> _packingList;


        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }



        public ObservableCollection<PackingSlip> PackingList
        {
            get { return _packingList; }
            set { _packingList = value; RaisePropertyChanged(); }
        }


        private PackingSlip _selectedPackingSlip;

        public PackingSlip SelectedPackingSlip
        {
            get { return _selectedPackingSlip; }
            set
            {
                _selectedPackingSlip = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region Commands
        public ICommand FilterChangeCommand { get; }
        public ICommand SearchCommand { get; }



        public ICommand SignCommand { get; }
        public ICommand ViewPdfCommand { get; }


        public ICommand SelectAllCommand { get; }
        public ICommand MarkSelectedReadyCommand { get; }
        public ICommand UndoMarkSelectedReadyCommand { get; }
        public ICommand MarkRouteCompletedCommand { get; }
        public ICommand OpenDetailsCommand { get; }
        #endregion



        public DrvRoutesPackingSlipsPageViewModel(SalesPool salesPool)
        {
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
            SearchCommand = new AsyncDelegateCommand<PackingSlipsQueryContext>(OnSearch);

            ViewPdfCommand = new AsyncDelegateCommand<PackingSlip>(OnViewPdf);
            MarkRouteCompletedCommand = new AsyncDelegateCommand(OnMarkRouteCompleted);
            SelectAllCommand = new Command(OnSelectAll);

            MarkSelectedReadyCommand = new AsyncDelegateCommand(OnMarkSelectedReady);
            UndoMarkSelectedReadyCommand = new AsyncDelegateCommand(OnUndoMarkSelectedReady);
            SignCommand = new AsyncDelegateCommand(OnSign);

            OpenDetailsCommand = new AsyncDelegateCommand(OnOpenDetails);
            _salesPool = salesPool;
            Title = $" {nameof(AppResources.PackingSlipsForRoute).Translate()} {salesPool.Name} ({salesPool.Key})";
            PackingList = new ObservableCollection<PackingSlip>();
        }

        private async Task OnSign()
        {
            if (!_packingList.Any(p => p.IsSelected))
            {
                await Alert.ShowMessage(nameof(AppResources.YouMustCheckOnePackingSlip).Translate());
                return;
            }

            await Nav.NavigateTo(new DrvPackingSlipSignPage(_packingList.Where(p => p.IsSelected)));
        }

        private async Task OnMarkRouteCompleted()
        {
            try
            {

                var confirmation = await Alert.ShowMessageConfirmation(
                    string.Format(nameof(AppResources.DrvMarkRouteCompletedConfirmation).Translate(), _salesPool.Name)
                    , null, nameof(AppResources.Yes).Translate(),
                    nameof(AppResources.No).Translate());
                if (!confirmation) return;

                IsBusy = true;

                var context = new MarkRouteCompletedContext
                {
                    Key = _salesPool.Key,
                    Name = _salesPool.Name,
                    Site = _salesPool.Site
                };
                var result = await Api.MarkRouteCompleted(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                var sb = new StringBuilder();
                if (result.Data?.Messages != null)
                {
                    foreach (var dataMessage in result.Data.Messages)
                    {
                        sb.AppendLine(dataMessage);
                    }
                }

                var message = (sb.Length == 0) ? nameof(AppResources.RouteMakedAsCompleted).Translate() : sb.ToString();

                await Alert.ShowMessage(message);
                await Nav.Nav.PopAsync();

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

        private async Task OnOpenDetails()
        {
            if (_selectedPackingSlip == null) return;
            
            await Nav.NavigateTo(new DrvRoutesPackingSlipDetailPage(_selectedPackingSlip, true));
        }

        private async Task OnUndoMarkSelectedReady()
        {

            try
            {

                var selection = _packingList
                    .Where(p => p.IsSelected && p.Status == "Pending")
                    .ToList();

                if (!selection.Any(p => p.IsSelected))
                {
                    await Alert.ShowMessage(nameof(AppResources.YouMustCheckOnePackingSlip).Translate());
                    return;
                }

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    $"{Translate.Get(nameof(AppResources.MarkPackingSlipsAsNotReady))}",
                    $"{Translate.Get(nameof(AppResources.UpdatePackingSlip))}",
                    Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));
                if (!userConfirmation) return;
                IsBusy = true;
                var ids = selection.Where(p => p.IsSelected)
                    .Select(p => long.Parse(p.RecId))
                    .ToList();
                if (!ids.Any()) return;

                var result = await Api.PostUndoReadyToInvoicePackingSlipsAsync(ids);

                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                await ShowToast();
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

        private async Task OnMarkSelectedReady()
        {
            try
            {

                var selection = _packingList
                    .Where(p => p.IsSelected && p.Status == "Ready")
                    .ToList();

                if (!selection.Any(p => p.IsSelected))
                {
                    await Alert.ShowMessage(nameof(AppResources.YouMustCheckOnePackingSlip).Translate());
                    return;
                }

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    $"{Translate.Get(nameof(AppResources.MarkPackingSlipsAsReady))}",
                    $"{ Translate.Get(nameof(AppResources.UpdatePackingSlip))}",
                    Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));
                if (!userConfirmation) return;

                IsBusy = true;
                var ids = selection
                    .Where(p => p.IsSelected)
                    .Select(p => long.Parse(p.RecId))
                    .ToList();
                if (!ids.Any()) return;

                var result = await Api.PostReadyToInvoicePackingSlips(ids);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                await ShowToast();
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

        private bool _wasLastOptionSelect;
        private void OnSelectAll(object obj)
        {

            _wasLastOptionSelect = !_wasLastOptionSelect;
            foreach (var packingSlip in PackingList)
            {
                packingSlip.IsSelected = _wasLastOptionSelect;
            }

        }


        private async Task OnViewPdf(PackingSlip arg)
        {
            try
            {
                IsBusy = true;
                var data = await ApiService.Instance.GetPackageSlipCopy(arg.Key, arg.DateShipped.GetValueOrDefault(), arg.Order.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Packing Slip {arg.Key}.pdf"));

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


        private async Task OnSearch(PackingSlipsQueryContext arg)
        {
            await Load(arg, arg.SortColumn);
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
                ShowFilter = false;
            }

        }
        private PackingSlipsQueryContext _previousFilter;
        public async Task Load(PackingSlipsQueryContext filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {
                IsBusy = true;


                filter = filter ?? _previousFilter ?? new PackingSlipsQueryContext
                {
                    SelectedQty = 50,
                    Status = "Ready"
                };

                if (sortColumnItem == null)
                {
                    sortColumnItem = new SortColumnItem(PackingSlipSortableColumns.OrderDate, null) { Ascending = true };
                }

                filter.CustomerInfo = Api.GetCustomerContext();
                filter.InventLocationId = Settings.MyInfo.CurrentUser.UserBranchCode;
                filter.SalesPoolId = _salesPool.Key;
                if (filter.Status == "All")//remove filter status to avoid 500 server error if "All" is sent 
                {
                    filter.Status = null;
                }
                ICollection<PackingSlip> lines;
                if (IsFilterDifferentFromLast(filter))
                {

                    var result = await Api.GetPackingSlipsNotInvoiced(filter);
                    _previousFilter = filter;
                    if (!result.Successful.GetValueOrDefault())
                    {
                        throw new Exception($"{Translate.Get(nameof(AppResources.ServerError))}:" +
                                            $"{result.ExceptionMessage}");
                    }
                    lines = result.Data;
                }
                else
                {
                    lines = _packingList;
                }
                var sortedLines = SortList(sortColumnItem, lines.ToList())
                    .Take(filter.SelectedQty);

                PackingList = new ObservableCollection<PackingSlip>(sortedLines);
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
        private bool IsFilterDifferentFromLast(PackingSlipsQueryContext currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.SelectedQty != currentFilter.SelectedQty) return true;
            if (_previousFilter.FromShipDate != currentFilter.FromShipDate) return true;
            if (_previousFilter.ToShipDate != currentFilter.ToShipDate) return true;
            if (_previousFilter.CustomerPurchaseOrderNo != currentFilter.CustomerPurchaseOrderNo) return true;
            if (_previousFilter.Id != currentFilter.Id) return true;
            if (_previousFilter.SalesOrderId != currentFilter.SalesOrderId) return true;
            if (_previousFilter.Status != currentFilter.Status) return true;

            return false;

        }
        private static ICollection<PackingSlip> SortList(SortColumnItem sortOrder, ICollection<PackingSlip> list)
        {


            switch (sortOrder.Key.ObjectToEnum<PackingSlipSortableColumns>())
            {

                case PackingSlipSortableColumns.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Key).ToList()
                        : list.OrderByDescending(p => p.Account.Key).ToList();

                    break;
                case PackingSlipSortableColumns.Account:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Name).ToList()
                        : list.OrderByDescending(p => p.Account.Name).ToList();
                    break;
                case PackingSlipSortableColumns.Plant:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.InventLocationName).ToList()
                        : list.OrderByDescending(p => p.InventLocationName).ToList();
                    break;

                case PackingSlipSortableColumns.OrderNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Order.Key).ToList()
                        : list.OrderByDescending(p => p.Order.Key).ToList();
                    break;
                case PackingSlipSortableColumns.JobName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerRef).ToList()
                        : list.OrderByDescending(p => p.CustomerRef).ToList();
                    break;

                case PackingSlipSortableColumns.PurchaseOrder:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerPurchaseOrderNo).ToList()
                        : list.OrderByDescending(p => p.CustomerPurchaseOrderNo).ToList();
                    break;

                case PackingSlipSortableColumns.OrderDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.OrderDate).ToList()
                        : list.OrderByDescending(p => p.OrderDate).ToList();
                    break;

                case PackingSlipSortableColumns.DateShipped:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DateShipped).ToList()
                        : list.OrderByDescending(p => p.DateShipped).ToList();
                    break;

                case PackingSlipSortableColumns.Sqft:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.TotalSqft).ToList()
                        : list.OrderByDescending(p => p.TotalSqft).ToList();
                    break;

                case PackingSlipSortableColumns.Lines:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.LinesCount.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.LinesCount.GetValueOrDefault()).ToList();
                    break;

                case PackingSlipSortableColumns.Safety:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.SafetyIndicator).ToList()
                        : list.OrderByDescending(p => p.SafetyIndicator).ToList();
                    break;
                case PackingSlipSortableColumns.PackingSlip:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;
                case PackingSlipSortableColumns.RequestedDeliveryDate:
                    // throw new Exception("Requested Delivery Date field is not yet available in API response data");
                    break;
                case PackingSlipSortableColumns.ClockIn:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ClockInDateTime.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.ClockInDateTime.GetValueOrDefault()).ToList();
                    break;
                case PackingSlipSortableColumns.ClockOut:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ClockOutDateTime.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.ClockOutDateTime.GetValueOrDefault()).ToList();
                    break;
                case PackingSlipSortableColumns.Status:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Status).ToList()
                        : list.OrderByDescending(p => p.Status).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }

    }
}