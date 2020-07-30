using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Interfaces;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.InvoicePayment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoicePaymentPage : ContentPage
    {
        private readonly List<InvoiceModel> _selectedInvoices;
        private readonly InvoicePaymentsViewModel _vm;

        public InvoicePaymentPage(List<InvoiceModel> selectedInvoices, PaymentRequest request)
        {
            _selectedInvoices = selectedInvoices ?? new List<InvoiceModel>();
            InitializeComponent();
            BindingContext = _vm = new InvoicePaymentsViewModel(selectedInvoices);
            _vm.PaymentRequest = request;
        }


        private async void OnNavigatedToNewPage(object sender, WebNavigatedEventArgs e)
        {

            try
            {
                string receipt = SettingsService.BASER_URL + "/Payment/Receipt";
                if (e.Url.IndexOf(receipt, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    AlertService.Instance.ShowMessage("Successful Payment").ConfigureAwait(false);
                    this._paymentView.IsVisible = false;
                }
            }
            catch (Exception exception)
            {

                await AlertService.Instance.DisplayError(exception);

            }
            finally
            {
                _vm.IsBusy = false;
            }

        }

        protected override async void OnAppearing()
        {
            try
            {
                if (_vm.IsBusy) return;
                _vm.IsBusy = true;
                MobilePaymentSSORequest requestData = null;
                switch (this._vm.PaymentRequest)
                {
                    case PaymentRequest.AddMoneyOnAccount:
                        requestData = new MobilePaymentSSORequest()
                        {
                            RequestType = MobilePaymentSSORequestRequestType.MoneyOnAccount
                        };
                        break;
                    case PaymentRequest.FullPayment:
                        requestData = new MobilePaymentSSORequest()
                        {
                            Lines = _selectedInvoices
                                .Select(f => new PartialInvoicePaymentLineItem
                            {
                                AXCustomerId = f.Account.Key,
                                InvoiceKey = f.Key,
                                Note = "",
                                Amount = f.Amount,
                                PartialAmount = f.Amount,
                                RecId = f.RecId
                            }).ToList(),
                            Language = MobilePaymentSSORequestLanguage.English, // Fernando to fill,
                            RequestType = MobilePaymentSSORequestRequestType.FullPayment,
                        };
                        break;

                    case PaymentRequest.PartialPayment:
                        requestData = new MobilePaymentSSORequest()
                        {
                            Lines = _selectedInvoices
                                .Select(f => new PartialInvoicePaymentLineItem
                            {
                                Amount = f.Amount,
                                AXCustomerId = f.Account.Key,
                                InvoiceKey = f.Key,
                                Note = "",
                                PartialAmount = f.Amount,
                                RecId = f.RecId
                            }).ToList(),
                            Language = MobilePaymentSSORequestLanguage.English, // Fernando to fill,
                            RequestType = MobilePaymentSSORequestRequestType.PartialPayment
                        };
                        break;
                }

                requestData.CustomerInfo = _vm.Api.GetCustomerContext();
                requestData.CustomerInfo.CustomerId = SettingsService.Instance.CustomerId;
                requestData.IsDarkTheme = SettingsService.Instance.IsDarkTheme;

                var guidVal = await _vm.Api.PrepareMobilePaymentAsync(requestData);
                if (guidVal.Successful.GetValueOrDefault() && guidVal.Data.HasValue)
                {
                    var url = 
                        $"{SettingsService.BASER_URL}/Payment/MobilePrePaySSO?id={guidVal.Data.Value}&appUserId={SettingsService.Instance.MyInfo.CurrentUser.AppUserId}";
                    this._paymentView.Source = url;
#if DEBUG
                    Debug.WriteLine( $"Payments URL: {url}");
#endif
                }
                else
                {
                    await AlertService.Instance.ShowMessage(guidVal.ExceptionMessage ?? "Error ");
                }

            }
            catch (Exception e)
            {

                await AlertService.Instance.DisplayError(e);
                _vm.IsBusy = false;

            }

        }
    }

    public class InvoicePaymentsViewModel : TruliteBaseViewModel
    {
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


        private PaymentRequest _paymentRequest;

        public PaymentRequest PaymentRequest
        {
            get { return _paymentRequest; }
            set
            {
                _paymentRequest = value;
                RaisePropertyChanged();
            }
        }

        private readonly List<InvoiceModel> _invoices;

        public InvoicePaymentsViewModel(List<InvoiceModel> selectedInvoices)
        {
            _invoices = selectedInvoices;
            TotalAmount = (decimal)selectedInvoices.Sum(p => p.Amount.GetValueOrDefault());
        }
    }

    public enum PaymentRequest
    {
        FullPayment,
        PartialPayment,
        AddMoneyOnAccount,
    }
}