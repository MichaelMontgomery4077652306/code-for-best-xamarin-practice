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
using TruliteMobile.Views.Documents;
using TruliteMobile.Views.DrvRoutes;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvManifests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvManifestsDetailPage : ContentPage
    {
        private readonly DrvManifestsDetailPageViewModel _vm;

        public DrvManifestsDetailPage(string selectedManifestKey)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvManifestsDetailPageViewModel(selectedManifestKey)
            {
                RootGrid = root
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.Load();

        }
    }


    public class DrvManifestsDetailPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private ObservableCollection<ShipManifestDetail> _manifests;

        private string _selectedManifestKey;

        public string SelectedManifestKey
        {
            get { return _selectedManifestKey; }
            set
            {
                _selectedManifestKey = value;
                RaisePropertyChanged();
            }
        }


        public ObservableCollection<ShipManifestDetail> Manifests
        {
            get { return _manifests; }
            set { _manifests = value; RaisePropertyChanged(); }
        }

        private ShipManifestDetail _selectedManifestDetail;

        public ShipManifestDetail SelectedManifestDetail
        {
            get { return _selectedManifestDetail; }
            set
            {
                _selectedManifestDetail = value;
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



        private bool _showMarkReadyToUndoInvoiced;

        public bool ShowMarkReadyToUndoInvoiced
        {
            get { return _showMarkReadyToUndoInvoiced; }
            set
            {
                _showMarkReadyToUndoInvoiced = value;
                RaisePropertyChanged();
            }
        }

        private bool _showMarkReadyToInvoiced;

        public bool ShowMarkReadyToInvoiced
        {
            get { return _showMarkReadyToInvoiced; }
            set
            {
                _showMarkReadyToInvoiced = value;
                RaisePropertyChanged();
            }
        }


        #endregion

        #region Commands

        public ICommand SelectAllCommand { get; }
        public ICommand MarkReadyForInvoicedCommand { get; }

        public ICommand UndoMarkReadyCommand { get; }
        public ICommand DirectionsCommand { get; }
        public ICommand SignCommand { get; }
        public ICommand OpenDetailsCommand { get; }

        public ICommand FilterTriggerCommand { get; }
        public ICommand MarkManifestCompletedCommand { get; }
        #endregion
        public DrvManifestsDetailPageViewModel(string selectedManifestKey)
        {
            SelectedManifestKey = selectedManifestKey;
            OpenDetailsCommand = new AsyncDelegateCommand(OnOpenDetails);
            DirectionsCommand = new AsyncDelegateCommand(OnDirections);
            MarkManifestCompletedCommand = new AsyncDelegateCommand(OnMarkManifestCompleted);
            SelectAllCommand = new Command(OnSelectAll);
            SignCommand = new AsyncDelegateCommand(OnSign);
            FilterTriggerCommand = new Command<SortColumnItem>(OnChangeSortOrder);
            MarkReadyForInvoicedCommand = new AsyncDelegateCommand(OnMarkSelectedReady);
            UndoMarkReadyCommand = new AsyncDelegateCommand(OnUndoMarkSelectedReady);

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(DrvManifestDetailsSortColumns.PackingSlips, nameof(AppResources.PackingSlip).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.CustomerName, nameof(AppResources.CustName).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.Safety, nameof(AppResources.Safety).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.DeliveryDate, nameof(AppResources.DeliveryDate).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.CustomerAccount, nameof(AppResources.CustAccount).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.Street, nameof(AppResources.Street).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.City, nameof(AppResources.City).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.ZipCode, nameof(AppResources.ZipCode).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.StopNumber, nameof(AppResources.StopNumber).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.State, nameof(AppResources.State).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.ClockIn, nameof(AppResources.ClockIn).Translate()),
                new SortColumnItem(DrvManifestDetailsSortColumns.ClockOut, nameof(AppResources.ClockOut).Translate()),

            };
            SelectedSortColumn = _sortColumns[0];
            _currentSortColumn = _selectedSortColumn;
        }

        private async Task OnUndoMarkSelectedReady()
        {

            try
            {
                var selection = _manifests
                    .Where(p => p.IsSelected && p.Status == "Ready")
                    .ToList();
                if (!selection.Any())
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseSelectAnItem).Translate());
                    return;
                }
                var userConfirmation = await Alert.ShowMessageConfirmation(
                    Translate.Get(nameof(AppResources.AreYouSureMarkNotInvoice))
                    , Translate.Get(nameof(AppResources.UpdatePackingSlip))
                    , Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));

                if (!userConfirmation) return;
                IsBusy = true;

                var notInvoicedManifests = selection.Where(p => p.Status != "Invoiced")
                    .ToList();
                if (!notInvoicedManifests.Any())
                {
                    return;
                }
                var packingSlips = await GetPackingSlips(notInvoicedManifests);
                var result = await Api.PostUndoReadyToInvoicePackingSlipsAsync(packingSlips.Select(p => p.RecId.ToLong()));
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,

                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
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
                var selection = _manifests
                    .Where(p => p.IsSelected && p.Status=="Pending")
                    .ToList();
                if (!selection.Any())
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseSelectAnItem).Translate());
                    return;
                }
                var userConfirmation = await Alert.ShowMessageConfirmation(
                    Translate.Get(nameof(AppResources.AreYouSureMarkInvoiced)),
                    Translate.Get(nameof(AppResources.UpdatePackingSlip))
                    , Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));
                if (!userConfirmation) return;
                IsBusy = true;

                var notInvoicedManifests = selection.Where(p => p.Status != "Invoiced")
                    .ToList();
                if (!notInvoicedManifests.Any())
                {
                    return;
                }
                var packingSlips = await GetPackingSlips(notInvoicedManifests);

                var result = await Api.PostReadyToInvoicePackingSlips(packingSlips.Select(p => p.RecId.ToLong()));
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
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

        private async Task OnMarkManifestCompleted()
        {
            try
            {
                if (IsBusy) return;
                var confirmation = await Alert.ShowMessageConfirmation(
                    string.Format(nameof(AppResources.DrvMarkManifestCompletedConfirmation).Translate(), _selectedManifestKey)
                    , null, nameof(AppResources.Yes).Translate(),
                    nameof(AppResources.No).Translate());
                if (!confirmation) return;

                IsBusy = true;

                var result = await Api.MarkManifestCompleted(_selectedManifestKey);
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

                await Alert.ShowMessage((sb.Length == 0) ?
                    nameof(AppResources.ManifestMakedAsCompleted).Translate()
                    : sb.ToString());
                await ShowToast();
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

        private SortColumnItem _currentSortColumn = null;
        private void OnChangeSortOrder(SortColumnItem sortColumn)
        {

            if (sortColumn == null||_manifests==null) return;

            var list = _manifests.ToList();
            switch (sortColumn.Key.ObjectToEnum<DrvManifestDetailsSortColumns>())
            {
                case DrvManifestDetailsSortColumns.PackingSlips:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.PackingSlipId).ToList()
                        : list.OrderByDescending(p => p.PackingSlipId).ToList();
                    break;
                case DrvManifestDetailsSortColumns.CustomerName:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CustName).ToList()
                        : list.OrderByDescending(p => p.CustName).ToList();
                    break;
                case DrvManifestDetailsSortColumns.Safety:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.SafetyIndicator).ToList()
                        : list.OrderByDescending(p => p.SafetyIndicator).ToList();
                    break;
                case DrvManifestDetailsSortColumns.Status:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.Status).ToList()
                        : list.OrderByDescending(p => p.Status).ToList();
                    break;
                case DrvManifestDetailsSortColumns.DeliveryDate:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.DeliveryDate).ToList()
                        : list.OrderByDescending(p => p.DeliveryDate).ToList();
                    break;
                case DrvManifestDetailsSortColumns.CustomerAccount:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CustAccount).ToList()
                        : list.OrderByDescending(p => p.CustAccount).ToList();
                    break;
                case DrvManifestDetailsSortColumns.Street:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.Street).ToList()
                        : list.OrderByDescending(p => p.Street).ToList();
                    break;
                case DrvManifestDetailsSortColumns.City:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.City).ToList()
                        : list.OrderByDescending(p => p.City).ToList();
                    break;
                case DrvManifestDetailsSortColumns.ZipCode:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.ZipCode).ToList()
                        : list.OrderByDescending(p => p.ZipCode).ToList();
                    break;
                case DrvManifestDetailsSortColumns.StopNumber:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.StopNumber).ToList()
                        : list.OrderByDescending(p => p.StopNumber).ToList();
                    break;
                case DrvManifestDetailsSortColumns.State:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.State).ToList()
                        : list.OrderByDescending(p => p.State).ToList();
                    break;
                case DrvManifestDetailsSortColumns.ClockIn:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.ClockInDateTime.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.ClockInDateTime.GetValueOrDefault()).ToList();
                    break;
                case DrvManifestDetailsSortColumns.ClockOut:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.ClockOutDateTime.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.ClockOutDateTime.GetValueOrDefault()).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            _currentSortColumn = sortColumn;
            Manifests = new ObservableCollection<ShipManifestDetail>(list);
        }
        private bool _wasLastOptionSelect;
        private void OnSelectAll(object obj)
        {
            _wasLastOptionSelect = !_wasLastOptionSelect;
            foreach (var manifestDetail in Manifests)
            {
                manifestDetail.IsSelected = _wasLastOptionSelect;
            }

        }
        private async Task OnDirections()
        {


            var selection = _manifests
                .Where(p => p.IsSelected)
                .ToList();
            if (!selection.Any())
            {
                await Alert.ShowMessage(nameof(AppResources.YouMustCheckOnePackingSlip).Translate());
                return;
            }

            try
            {
                if (IsBusy) return;
                IsBusy = true;
                var packingSlips = await GetPackingSlips(selection);
                await Nav.NavigateTo(new DrvManifestDirectionsMapPage(packingSlips));
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

        private async Task OnSign()
        {
            try
            {

                if (IsBusy) return;
                IsBusy = true;
                var selection = _manifests.Where(p => p.IsSelected).ToList();
                if (!selection.Any())
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseSelectAnItem).Translate());
                    return;
                }

                var packingSlips = await GetPackingSlips(selection);
                if (!packingSlips.Any())
                {
                    await Alert.ShowMessage("Could not obtain packing slip(s) for this manifest from the server");
                    return;
                }
                await Nav.NavigateTo(new DrvPackingSlipSignPage(packingSlips));
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

        private async Task<List<PackingSlip>> GetPackingSlipsNotInvoiced(IEnumerable<ShipManifestDetail> selection)
        {
            var packingSlipList = new List<PackingSlip>();
            foreach (var shipManifestDetail in selection)
            {
                var ctx = new PackingSlipsQueryContext
                {
                    Id = shipManifestDetail.PackingSlipId,
                    CustomerInfo = new CustomerContext
                    {
                        AXCustomerId = shipManifestDetail.CustAccount
                    }
                };
                var packingSlip = await Api.GetPackingSlipsNotInvoiced(ctx);
                packingSlipList.AddRange(packingSlip.Data);
            }

            return packingSlipList;
        }

        private async Task<List<PackingSlip>> GetPackingSlips(IEnumerable<ShipManifestDetail> selection)
        {
            var packingSlipList = new List<PackingSlip>();
            foreach (var shipManifestDetail in selection)
            {
                var ctx = new PackingSlipsQueryContext
                {
                    Id = shipManifestDetail.PackingSlipId,
                    CustomerInfo = new CustomerContext
                    {
                        AXCustomerId = shipManifestDetail.CustAccount
                    }
                };
                var packingSlip = await Api.GetPackingSlips(ctx);
                packingSlipList.AddRange(packingSlip.Data);
            }

            return packingSlipList;
        }


        private static IEnumerable<long> GetPackingSlipsIdsAsLongs(IEnumerable<ShipManifestDetail> list)
        {
            return list.Select(p => p.PackingSlipId.Replace("SS", string.Empty).ToLong());

        }


        private async Task OnOpenDetails()
        {
            if (_selectedManifestDetail == null) return;
            _selectedManifestDetail.Key = _selectedManifestKey;
            await Nav.NavigateTo(new DrvManifestDetailPage2(_selectedManifestDetail));
        }

        public async Task Load()
        {

            try
            {
                IsBusy = true;

               
                var result = await Api.GetShipManifestDetail(_selectedManifestKey);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);

                }

                Manifests = new ObservableCollection<ShipManifestDetail>(result.Data);
                ShowMarkReadyToInvoiced = _manifests.Any(p => p.Status == "Ready");
                ShowMarkReadyToUndoInvoiced = _manifests.Any(p => p.Status == "Pending");
                NoResults = !_manifests.Any();
                if (_currentSortColumn != null)
                {
                    OnChangeSortOrder(_currentSortColumn);
                }
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

    public enum DrvManifestDetailsSortColumns
    {
        PackingSlips,
        CustomerName,
        Safety,
        Status,
        DeliveryDate,
        CustomerAccount,
        Street,
        City,
        ZipCode,
        StopNumber,
        State,
        ClockIn,
        ClockOut
    }
}