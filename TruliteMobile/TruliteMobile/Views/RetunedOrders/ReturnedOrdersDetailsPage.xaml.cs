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
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Invoices;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.PackingSlips;
using TruliteMobile.Views.Pdf;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.RetunedOrders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnedOrdersDetailsPage : ContentPage
    {
        private readonly RetunedOrderDetailLinesPageViewModel _vm;

        public ReturnedOrdersDetailsPage(ReturnOrder selectedOrder)
        {
            InitializeComponent();
            BindingContext = _vm = new RetunedOrderDetailLinesPageViewModel
            {
                OrderId = selectedOrder.Key
            };
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class RetunedOrderDetailLinesPageViewModel : TruliteBaseViewModel
    {
        public string OrderId { get; set; }

        private ReturnOrderLine _order;

        public ReturnOrderLine Order
        {
            get { return _order; }
            set
            {
                _order = value;
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
        public ICommand ToggleActionsFrameCommand { get; }

        public RetunedOrderDetailLinesPageViewModel()
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
            ShowTrackingButton = Settings.AccountPermissions["Show Rack Tracking"];
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
                var salesOrderResult = (await Api.GetReturnOrderLines(new ReturnOrderLineQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    SalesOrderId = _order.Key,

                }));

                var salesOrder = salesOrderResult.Data.FirstOrDefault();

                if (salesOrder != null)
                {
                    Order = salesOrder;
                }

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