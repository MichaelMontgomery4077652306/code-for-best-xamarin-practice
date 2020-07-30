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
using TruliteMobile.Views.DrvReportIssue;
using TruliteMobile.Views.DrvRoutes;
using TruliteMobile.Views.Pdf;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvManifests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvManifestDetailPage2 : ContentPage
    {
        private readonly DrvManifestDetailPage2ViewModel _vm;

        public DrvManifestDetailPage2(ShipManifestDetail manifest)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvManifestDetailPage2ViewModel(manifest);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvManifestDetailPage2ViewModel : TruliteBaseViewModel
    {

        #region Properties
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

        private bool _showHeaderFrame;

        public bool ShowHeaderFrame
        {
            get { return _showHeaderFrame; }
            set
            {
                _showHeaderFrame = value;
                RaisePropertyChanged();
            }
        }

        private ShipManifestDetail _manifest;

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

        public ShipManifestDetail Manifest
        {
            get { return _manifest; }
            set
            {
                _manifest = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(ShowClockIn));
                RaisePropertyChanged(nameof(ShowClockOut));
            }
        }

        public bool ShowClockIn => _manifest.ClockInDateTime == null;
        public bool ShowClockOut => _manifest.ClockInDateTime != null && _manifest.ClockOutDateTime == null;

        #endregion
        #region Commands

        public ICommand ToggleHeaderCommand { get; }
        public ICommand ToggleActionCommand { get; }
        public ICommand MarkReadyForInvoicedCommand { get; }
        public ICommand UndoMarkReadyCommand { get; }
        public ICommand ViewPdfCommand { get; }
        public ICommand TrackSalesOrderCommand { get; }
        public ICommand ReportIssueCommand { get; }
        public ICommand OpenPackingSlipCommand { get; }
        public ICommand UpcomingDeliveriesCommand { get; }
        public ICommand ClockInCommand { get; }
        public ICommand ClockOutCommand { get; }
        public ICommand DirectionsCommand { get; }
        public ICommand SignCommand { get; }


        #endregion
        public DrvManifestDetailPage2ViewModel(ShipManifestDetail manifest)
        {
            Manifest = manifest;
            ToggleHeaderCommand = new Command<bool>((show) => ShowHeaderFrame = show);
            ToggleActionCommand = new Command<bool>((show) => ShowActionFrame = show);
            OpenPackingSlipCommand = new AsyncDelegateCommand(OnOpenPackingSlip);
            ReportIssueCommand = new AsyncDelegateCommand(OnReportIssue);
            TrackSalesOrderCommand = new AsyncDelegateCommand(OnTrackSalesOrder);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            MarkReadyForInvoicedCommand = new AsyncDelegateCommand(OnMarkSelectedReady);
            UndoMarkReadyCommand = new AsyncDelegateCommand(OnUndoMarkSelectedReady);
            UpcomingDeliveriesCommand = new AsyncDelegateCommand(OnUpcomingDeliveries);
            ClockInCommand = new AsyncDelegateCommand(OnClockIn);
            ClockOutCommand = new AsyncDelegateCommand(OnClockOut);
            DirectionsCommand = new AsyncDelegateCommand(OnDirections);
            SignCommand = new AsyncDelegateCommand(OnSign);
        }


        public async Task Load()
        {
            try
            {
                IsBusy = true;
                if (_packingSlip != null) return;
                if (_manifest.PackingSlipId == null) return;
                var filter = new PackingSlipsQueryContext
                {
                    CustomerInfo = new CustomerContext
                    {
                        AXCustomerId = _manifest.CustAccount
                    },
                    InventLocationId = Settings.MyInfo.CurrentUser.UserBranchCode,
                    SalesOrderId = _manifest.SalesOrderId,
                    Id = _manifest.PackingSlipId
                };
                var result = await Api.GetPackingSlips(filter);
                if (!result.Successful.GetValueOrDefault())
                {
                    throw new Exception($"{Translate.Get(nameof(AppResources.ServerError))}:" +
                                        $"{result.ExceptionMessage}");
                }

                PackingSlip = result.Data.FirstOrDefault();
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
                if(IsBusy)return;
                IsBusy = true;
                if (_packingSlip == null) return;
                await Nav.NavigateTo(new DrvPackingSlipSignPage(new []{_packingSlip}));
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
        private async Task OnDirections()
        {
            var placemark = new Placemark
            {
                Thoroughfare = _packingSlip.CustAddress.PackedAddress
            };
            var options = new MapLaunchOptions { Name = _packingSlip.CustomerName };

            await Map.OpenAsync(placemark, options);
        }

        private async Task OnClockIn()
        {

            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                        nameof(AppResources.AreYouSureYouWantToClockIn).Translate()
                    , nameof(AppResources.UpdatePackingSlip).Translate()
                    ,nameof(AppResources.Yes).Translate(), nameof(AppResources.No).Translate());
                if (!userConfirmation) return;

                IsBusy = true;
                var date = DateTimeOffset.Now;
                var context = new ClockInTimeQueryContext
                {
                    ManifestId = _manifest.Key,
                    StopNumber = int.Parse(_manifest.StopNumber),
                    DateTime = date
                };
                var result = await Api.UpdateManifestClockInTime(context);
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,

                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                Manifest.ClockInDateTime = date;
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
                    , nameof(AppResources.UpdatePackingSlip).Translate()
                    , nameof(AppResources.Yes).Translate(), nameof(AppResources.No).Translate());
                if (!userConfirmation) return;

                IsBusy = true;
                var date = DateTimeOffset.Now;
                var context = new ClockInTimeQueryContext
                {
                    ManifestId = _manifest.Key,
                    StopNumber = int.Parse(_manifest.StopNumber),
                    DateTime = date
                };
                var result = await Api.UpdateManifestClockOutTime(context);
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,

                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                Manifest.ClockOutDateTime = date;
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
        private async Task OnUpcomingDeliveries()
        {
            try
            {
                if(IsBusy)return;
                IsBusy = true;
                await Nav.NavigateTo(new DrvManifestUpcomingDeliveriesPage(Manifest.CustAccount, PackingSlip));
            }
            finally
            {
                IsBusy = false;
            }
       
        }


        private async Task OnUndoMarkSelectedReady()
        {

            try
            {

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    Translate.Get(nameof(AppResources.AreYouSureMarkNotInvoice))
                   , Translate.Get(nameof(AppResources.UpdatePackingSlip))
                    , Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));

                if (!userConfirmation) return;
                IsBusy = true;

                var result = await Api.PostUndoReadyToInvoicePackingSlipsAsync(new[] { _packingSlip.RecId.ToLong() });
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,

                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                PackingSlip.Status = "Pending";

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


               

                var userConfirmation = await Alert.ShowMessageConfirmation(
                    Translate.Get(nameof(AppResources.AreYouSureMarkInvoiced)),
                    Translate.Get(nameof(AppResources.UpdatePackingSlip))
                    , Translate.Get(nameof(AppResources.Yes)), Translate.Get(nameof(AppResources.No)));
                if (!userConfirmation) return;
                IsBusy = true;

                var result = await Api.PostReadyToInvoicePackingSlips(new[] { _packingSlip.RecId.ToLong() });
                if (!result.Successful.GetValueOrDefault())
                {

                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"{Translate.Get(nameof(AppResources.CouldNotMarkAsNotReady))}" +
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }
                PackingSlip.Status = "Ready";
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
        private async Task OnViewPdf()
        {
            try
            {
                IsBusy = true;


                var data = await ApiService.Instance.GetPackageSlipCopy(_manifest.PackingSlipId, _manifest.DeliveryDate.ToDateTime(), _manifest.SalesOrderId);
                await Nav.NavigateTo(new PdfPage(data, $"Packing Slip {_manifest.PackingSlipId}.pdf"));

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


        private async Task OnTrackSalesOrder()
        {
            await Launcher.OpenAsync(new Uri($"https://portal-dev.trulite.com/WorkOrders/Track/{_manifest.SalesOrderId}"));
        }

        private async Task OnReportIssue()
        {
            await Nav.NavigateTo(new DrvReportIssuePage());
        }

        private async Task OnOpenPackingSlip()
        {

            try
            {
                IsBusy = true;

                CustomerContext customerContext = (Settings.IsDriver)
                    ? new CustomerContext
                    {
                        AXCustomerId = _manifest.CustAccount
                    }
                    : Api.GetCustomerContext();

                var filter = new PackingSlipsQueryContext
                {
                    CustomerInfo = customerContext,
                    //InventLocationId = Settings.MyInfo.CurrentUser.SiteBranchCode,
                    Id = _manifest.PackingSlipId,
                    SelectedQty = 1
                };

                var result = await Api.GetPackingSlips(filter);

                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        Translate.Get(nameof(AppResources.CouldNotRetrievePackingSlip)));
                    return;
                }
                var lines = result.Data.ToList();
                if (!lines.Any())
                {
                    await Alert.ShowMessage(
                        Translate.Get(nameof(AppResources.CouldNotFindPackingSlip)));
                    return;
                }
                await Nav.NavigateTo(new DrvRoutesPackingSlipDetailPage(lines.First(),false));
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

