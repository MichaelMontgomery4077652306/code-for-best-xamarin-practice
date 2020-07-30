using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.DrvManifests;
using TruliteMobile.Views.DrvPackingSlip;
using TruliteMobile.Views.DrvReportIssue;
using TruliteMobile.Views.DrvSurvey;
using TruliteMobile.Views.Pdf;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvRoutesPackingSlipDetailPage : ContentPage
    {
        private readonly DrvRoutesPackingSlipDetailPageViewModel _vm;

        public DrvRoutesPackingSlipDetailPage(PackingSlip slip, bool showClockActions)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvRoutesPackingSlipDetailPageViewModel(slip, showClockActions);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvRoutesPackingSlipDetailPageViewModel : TruliteBaseViewModel
    {
        #region Properties

        private PackingSlip _packingSlip;

        public PackingSlip PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                _packingSlip = value;
                RaisePropertyChanged();
            }
        }


        private bool _showAddressFrame;

        public bool ShowAddressFrame
        {
            get { return _showAddressFrame; }
            set
            {
                _showAddressFrame = value;
                RaisePropertyChanged();
            }
        }

        private bool _showPackingSlipFrame;

        public bool ShowPackingSlipFrame
        {
            get { return _showPackingSlipFrame; }
            set
            {
                _showPackingSlipFrame = value;
                RaisePropertyChanged();
            }
        }

        private bool _showActionFrame;

        public bool ShowActionFrame
        {
            get { return _showActionFrame; }
            set
            {
                _showActionFrame = value;
                RaisePropertyChanged();
            }
        }

        private bool _showLinesFrame;

        public bool ShowLinesFrame
        {
            get { return _showLinesFrame; }
            set
            {
                _showLinesFrame = value;
                RaisePropertyChanged();
            }
        }


        private bool _enableRepack;

        public bool EnableRepack
        {
            get { return _enableRepack; }
            set
            {
                _enableRepack = value;
                RaisePropertyChanged();
            }
        }


        private PackingSlipLine _selectedLine;

        public PackingSlipLine SelectedLine
        {
            get { return _selectedLine; }
            set
            {
                _selectedLine = value;
                RaisePropertyChanged();
            }
        }

        private bool _showClockActions;

        public bool ShowClockActions
        {
            get { return _showClockActions; }
            set
            {
                _showClockActions = value;
                RaisePropertyChanged();
            }
        }

        public bool ShowClockIn => _packingSlip.ClockInDateTime == null;
        public bool ShowClockOut => _packingSlip.ClockInDateTime != null && _packingSlip.ClockOutDateTime == null;


        #endregion
        #region Commands
        public ICommand OpenMapCommand { get; }

        public ICommand MarkReadyForInvoicedCommand { get; }
        public ICommand UndoMarkReadyCommand { get; }
        public ICommand ViewPdfCommand { get; }

        public ICommand ToggleAddressFrameCommand { get; }
        public ICommand TogglePackingSlipFrameCommand { get; }
        public ICommand ToggleActionFrameCommand { get; }

        public ICommand ToggleLinesFrameCommand { get; }
        public ICommand SignCommand { get; }
        public ICommand RepackCommand { get; }

        public ICommand OpenLineCommand { get; }

        public ICommand DirectionsCommand { get; }

        public ICommand NotifyCustomerCommand { get; }

        public ICommand ReportIssueCommand { get; }

        public ICommand ClockInCommand { get; }
        public ICommand ClockOutCommand { get; }
        public ICommand UpcomingDeliveriesCommand { get; }

        public ICommand TrackSalesOrderCommand { get; }
        #endregion
        public DrvRoutesPackingSlipDetailPageViewModel(PackingSlip slip, bool showClockActions)
        {
            ShowClockActions = showClockActions;
            PackingSlip = slip;
            OpenMapCommand = new AsyncDelegateCommand(OnOpenMap);
            MarkReadyForInvoicedCommand = new AsyncDelegateCommand(OnMarkReady);
            UndoMarkReadyCommand = new AsyncDelegateCommand(OnUndoMarkReady);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            ToggleAddressFrameCommand = new Command<bool>((show) => ShowAddressFrame = show);
            TogglePackingSlipFrameCommand = new Command<bool>((show) => ShowPackingSlipFrame = show);
            ToggleActionFrameCommand = new Command<bool>((show) => ShowActionFrame = show);
            ToggleLinesFrameCommand = new Command<bool>((show) => ShowLinesFrame = show);
            SignCommand = new AsyncDelegateCommand(OnSign);
            RepackCommand = new AsyncDelegateCommand(OnRepack);
            OpenLineCommand = new AsyncDelegateCommand(OnOpenLine);
            DirectionsCommand = new AsyncDelegateCommand(OnDirections);
            ReportIssueCommand = new AsyncDelegateCommand(OnReportIssue);
            NotifyCustomerCommand = new AsyncDelegateCommand(OnNotifyCustomer);
            ClockInCommand = new AsyncDelegateCommand(OnClockIn);
            ClockOutCommand = new AsyncDelegateCommand(OnClockOut);
            UpcomingDeliveriesCommand = new AsyncDelegateCommand(OnUpcomingDeliveries);
            TrackSalesOrderCommand = new AsyncDelegateCommand(OnTrack);

        }
        private async Task OnTrack()
        {
            await Launcher.OpenAsync(new Uri($"https://portal-dev.trulite.com/WorkOrders/Track/{_packingSlip.Order.Key}"));

        }
        private async Task OnUpcomingDeliveries()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new DrvManifestUpcomingDeliveriesPage(_packingSlip.Account.Key,  _packingSlip));
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task OnClockIn()
        {

            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    nameof(AppResources.AreYouSureYouWantToClockIn).Translate()
                    , $"{nameof(AppResources.PackingSlip).Translate()} {_packingSlip.Key}"
                    , nameof(AppResources.Yes).Translate(), nameof(AppResources.No).Translate());
                if (!userConfirmation) return;

                IsBusy = true;
                var date = DateTimeOffset.Now;
                var context = new PostDriverClockInOutContext
                {
                    PackingSlipKey = _packingSlip.Key,
                    ClockInOutAction = PostDriverClockInOutContextClockInOutAction.ClockIn,
                    AccountNo = _packingSlip.Account.Key
                };
                var result = await Api.PostDriverClockInOut(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                _packingSlip.ClockInDateTime = date;
                RaisePropertyChanged(nameof(ShowClockIn));
                RaisePropertyChanged(nameof(ShowClockOut));

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

        private async Task OnClockOut()
        {

            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    nameof(AppResources.AreYouSureYouWantToClockOut).Translate()
                    , $"{nameof(AppResources.PackingSlip).Translate()} {_packingSlip.Key}"
                    , nameof(AppResources.Yes).Translate(), nameof(AppResources.No).Translate());
                if (!userConfirmation) return;

                IsBusy = true;
                var date = DateTimeOffset.Now;
                var context = new PostDriverClockInOutContext
                {
                    PackingSlipKey = _packingSlip.Key,
                    ClockInOutAction = PostDriverClockInOutContextClockInOutAction.ClockOut,
                    AccountNo = _packingSlip.Account.Key
                };
                var result = await Api.PostDriverClockInOut(context);
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                _packingSlip.ClockOutDateTime = date;
                RaisePropertyChanged(nameof(ShowClockIn));
                RaisePropertyChanged(nameof(ShowClockOut));
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
        private async Task OnReportIssue()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new DrvReportIssuePage());

            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task OnNotifyCustomer()
        {
            await NavigateTo(new DrvRoutesNotifyCustomerPage(_packingSlip));
        }

        private async Task OnDirections()
        {
            var placemark = new Placemark
            {
                Thoroughfare = _packingSlip.CustAddress.PackedAddress
            };
            var options = new MapLaunchOptions { Name = _packingSlip.CustomerName };

            await Map.OpenAsync(placemark, options);
        }

        private async Task OnOpenLine()
        {
            if (_selectedLine == null) return;
            await NavigateTo(new DrvPackingSlipLineEditPage(_selectedLine));
        }

        private async Task OnRepack()
        {

            await Nav.NavigateTo(new DrvPackingSlipSubmitPage(_packingSlip));

        }

        private async Task OnSign()
        {
            await Nav.NavigateTo(new DrvPackingSlipSignPage(new[] { _packingSlip }));
        }



        private async Task OnViewPdf()
        {
            try
            {
                IsBusy = true;
                var data = await ApiService.Instance.GetPackageSlipCopy(_packingSlip.Key, _packingSlip.DateShipped.GetValueOrDefault(), _packingSlip.Order.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Packing Slip {_packingSlip.Key}.pdf"));

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

        private async Task OnUndoMarkReady()
        {
            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    $"{Translate.Get(nameof(AppResources.SalesOrder))}{Environment.NewLine}{Environment.NewLine}" +
                    $"{Translate.Get(nameof(AppResources.AreYouSureMarkPacklingSlip))}" +
                    $" {_packingSlip.Key} {Translate.Get(nameof(AppResources.NotReadyToBeInvoiced))}",
                    $"{Translate.Get(nameof(AppResources.PackingSlip))} {_packingSlip.Key}",
                    Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));

                if (!userConfirmation) return;


                IsBusy = true;

                var result = await Api.PostUndoReadyToInvoicePackingSlipsAsync(new[] { long.Parse(_packingSlip.RecId) });
                _packingSlip.Status = "Pending";
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

        private async Task OnMarkReady()
        {
            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    $"{Translate.Get(nameof(AppResources.SalesOrder))}{Environment.NewLine}{Environment.NewLine}" +
                    $"{Translate.Get(nameof(AppResources.AreYouSureMarkPacklingSlip))} {_packingSlip.Key} " +
                    $"{Translate.Get(nameof(AppResources.ReadyToBeInvoiced))}",
                    $"{Translate.Get(nameof(AppResources.PackingSlip))} {_packingSlip.Key}", Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));

                if (!userConfirmation) return;

                IsBusy = true;

                var result = await Api.PostReadyToInvoicePackingSlips(new[] { long.Parse(_packingSlip.RecId) });
                _packingSlip.Status = "Ready";
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

        private async Task OnOpenMap()
        {

            var placemark = new Placemark
            {
                AdminArea = _packingSlip.CustAddress.State,
                Thoroughfare = _packingSlip.CustAddress.Street,
                Locality = _packingSlip.CustAddress.City,
                PostalCode = _packingSlip.CustAddress.ZipCode,
                CountryName = "United States of America"
            };
            var options = new MapLaunchOptions
            {
                Name = _packingSlip.CustAddress.Name,
                NavigationMode = NavigationMode.Driving
            };

            await Map.OpenAsync(placemark, options);
        }


        public async Task Load()
        {
            try
            {

                if (PackingSlip.Lines != null)
                {
                    EnableRepack = _packingSlip.Lines.Any(p => p.PackingReasonList?.Any() ?? false);
                    return;
                }
                IsBusy = true;

                PackingSlipLineQueryContext filter = new PackingSlipLineQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    SalesOrderId = _packingSlip.Order.Key,
                    Id = _packingSlip.Key,
                    PackingSlipDate = _packingSlip.DateShipped

                };

                var response = await Api.GetPackingSlipsLines(filter);
                if (!response.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
                        Translate.Get(nameof(AppResources.CouldntGetPackingSlipLines)));
                    return;
                }

                PackingSlip.Lines = response.Data;

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
}