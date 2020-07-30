using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Invoices;
using TruliteMobile.Views.PackingSlips;
using TruliteMobile.Views.Pdf;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetailLinesPage : ContentPage
    {
        private string _salesOrderId;
        private readonly OrderDetailLinesPageViewModel _vm;

        public OrderDetailLinesPage(SalesOrder order)
        {
            InitializeComponent();
            _salesOrderId = order.Key;
            BindingContext = _vm = new OrderDetailLinesPageViewModel { Order = order };
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class OrderDetailLinesPageViewModel : TruliteBaseViewModel
    {
        public string OrderId { get; set; }

        private SalesOrder _order;

        public SalesOrder Order
        {
            get { return _order; }
            set
            {
                _order = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<SalesOrderLine> _lines;

        public ObservableCollection<SalesOrderLine> Lines
        {
            get { return _lines; }
            set
            {
                _lines = value;
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

        private bool _showLines;

        public bool ShowLines
        {
            get { return _showLines; }
            set
            {
                _showLines = value;
                RaisePropertyChanged();
            }
        }

        private bool _showActionsFrame;

        public bool ShowActionsFrame
        {
            get { return _showActionsFrame; }
            set
            {
                _showActionsFrame = value;
                RaisePropertyChanged();
            }
        }


        private bool _showTrackingButton;

        public bool ShowTrackingButton
        {
            get { return _showTrackingButton; }
            set
            {
                _showTrackingButton = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ToggleLinesCommand { get; }
        public ICommand ToggleHeaderFrameCommand { get; }
        public ICommand ViewPdfCommand { get; }
        public ICommand DownloadPdfCommand { get; }

        public ICommand ViewInvoiceCommand { get; }
        public ICommand ViewPackingSlipCommand { get; }
        public ICommand TrackCommand { get; }
        public ICommand ToggleActionsFrameCommand { get; }

        public ICommand ViewImageCommand { get; }

        public ICommand OpenDateChangesCommand { get; }

        public ICommand RequestDateChangeCommand { get; }

        public OrderDetailLinesPageViewModel()
        {
            ShowHeaderFrame = true;
            ShowLines = true;
            ToggleHeaderFrameCommand = new RelayCommand<bool>((b => ShowHeaderFrame = b));
            ToggleLinesCommand = new RelayCommand<bool>((b => ShowLines = b));
            DownloadPdfCommand = new AsyncDelegateCommand(OnDownloadPdf);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            ViewInvoiceCommand = new AsyncDelegateCommand<Invoice>(OnViewInvoice);
            ViewPackingSlipCommand = new AsyncDelegateCommand<PackingSlip>(OnViewPackingSlip);
            ToggleActionsFrameCommand = new Command<bool>((isExpanded) => ShowActionsFrame = isExpanded);
            ViewImageCommand = new AsyncDelegateCommand<SalesOrderLine>(OnViewLineImage);
            TrackCommand = new RelayCommand(OnTrack);
            OpenDateChangesCommand = new AsyncDelegateCommand(OnOpenDateChanges);
            RequestDateChangeCommand = new AsyncDelegateCommand(OnRequestDateChange);
            ShowTrackingButton = Settings.AccountPermissions["Show Rack Tracking"];
        }

        private async Task OnRequestDateChange()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new OrderRequestDateChangePage(_order));
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

        private async Task OnOpenDateChanges()
        {

            await NavigateTo(new ViewDateChangesPage(_order));
           
          
        }

        private async Task OnViewLineImage(SalesOrderLine arg)
        {
            await Alert.ShowMessage("Coming soon...");
        }

        private async void OnTrack()
        {
            
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Launcher.OpenAsync(new Uri($"{Constants.TRULITE_TRACK_URL}/{_order.Key}"));
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

        private async Task OnViewPackingSlip(PackingSlip selectedPackingSlip)
        {

            if (selectedPackingSlip == null) return;
            await NavigateTo(new PackingSlipsDetailLinesPage(selectedPackingSlip, true));

        }



        private async Task OnViewInvoice(Invoice selectedInvoice)
        {
            if (selectedInvoice == null) return;
            await NavigateTo(new InvoiceViewPage(selectedInvoice, true));

        }

        private async Task OnViewPdf()
        {
            try
            {
                IsBusy = true;
                var data = await ApiService.Instance.GetConfirmationCopy(_order.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Order{_order.Key}"));

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

        private async Task OnDownloadPdf()
        {
            try
            {
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetConfirmationCopy(_order.Key);
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile($"Order{_order.Key}.pdf");
                Debug.WriteLine(path);
                File.WriteAllBytes(path, data);
                await Alert.ShowMessage($"File saved to: {path}");

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

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                //if this page is being loaded with an incomplete SalesOrder object
                //load from server
                if (_order.OrderDate.GetValueOrDefault().Year == 1)
                {
                    var salesOrderResult = (await Api.GetOrders(new OrderFilter
                    {
                        Number = _order.Key,

                    }));

                    var salesOrder = salesOrderResult.Data.FirstOrDefault();

                    if (salesOrder != null)
                    {
                        Order = salesOrder;
                    }

                }

                var lines = (await Api.GetOrderLines(_order)).ToList();
                Lines = new ObservableCollection<SalesOrderLine>(lines);

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