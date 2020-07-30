using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Settlements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettlementViewReceiptPage : ContentPage
    {
        private readonly SettlementViewReceiptPageViewModel _vm;

        public SettlementViewReceiptPage(InvoicePaymentView invoicePaymentView)
        {
            InitializeComponent();
            BindingContext = _vm = new SettlementViewReceiptPageViewModel(invoicePaymentView);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class SettlementViewReceiptPageViewModel : TruliteBaseViewModel
    {
        #region Properties

        private string _emailText;

        public string EmailText
        {
            get { return _emailText; }
            set
            {
                _emailText = value;
                RaisePropertyChanged();
            }
        }


        private InvoicePaymentView _invoice;

        public InvoicePaymentView Invoice
        {
            get { return _invoice; }
            set
            {
                _invoice = value;
                RaisePropertyChanged();
            }
        }


        private ReceiptModel _receipt;

        public ReceiptModel Receipt
        {
            get { return _receipt; }
            set
            {
                _receipt = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<string> _emailList;

        public ObservableCollection<string> EmailList
        {
            get { return _emailList; }
            set
            {
                _emailList = value;
                RaisePropertyChanged();
            }
        }

        private string _feesText;

        public string FeesText
        {
            get { return _feesText; }
            set
            {
                _feesText = value;
                RaisePropertyChanged();
            }
        }

        private decimal _feeAmount;

        public decimal FeeAmount
        {
            get { return _feeAmount; }
            set
            {
                _feeAmount = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Command
        public ICommand BackCommand { get; }
        public ICommand AddEmailCommand { get; }
        public ICommand SendEmailCommand { get; }
        #endregion
        public SettlementViewReceiptPageViewModel(InvoicePaymentView invoicePaymentView)
        {
            Invoice = invoicePaymentView;
            BackCommand = new AsyncDelegateCommand(Back);
            EmailList = new ObservableCollection<string>
            {
                Settings.Email
            };
            AddEmailCommand = new AsyncDelegateCommand(OnAddEmail);
            SendEmailCommand = new AsyncDelegateCommand(OnSendEmail);
        }

        private async Task OnAddEmail()
        {
            if (!_emailText.IsValidEmail())
            {

                await Alert.ShowMessage(nameof(AppResources.PleaseEnterValidEmail).Translate());
                return;
            }
            EmailList.Add(_emailText);
        }

        public async Task Load()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                var context = new InvoiceReceiptContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    PaymentId = _invoice.InvoicePaymentId

                };
                var invoiceReceipt = await Api.GetInvoiceReceipt(context);

                if (!invoiceReceipt.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(invoiceReceipt.ExceptionMessage, invoiceReceipt.ValidationErrors);
                    return;
                }

                Receipt = invoiceReceipt.Data;
                FeesText = invoiceReceipt.Data.Invoices.FirstOrDefault()?.FeesText;
                FeeAmount =(decimal) invoiceReceipt.Data.Invoices.Sum(p => p.FeesAmount.GetValueOrDefault());

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


        public async Task OnSendEmail()
        {
            try
            {

                if (!_emailList.Any())
                {
                    await Alert.ShowMessage(nameof(AppResources.NoEmailOnList).Translate());
                    return;
                }
                if (IsBusy) return;
                IsBusy = true;
                var context = new InvoiceReceiptContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    PaymentId = _invoice.InvoicePaymentId,
                    Recipients = _emailList

                };
                var emailReceipt = await Api.EmailReceipt(context);

                if (!emailReceipt.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(emailReceipt.ExceptionMessage, emailReceipt.ValidationErrors);
                    return;
                }

                if (emailReceipt.Data.Successful.GetValueOrDefault())
                {
                    await Alert.ShowMessage(nameof(AppResources.EmailSent).Translate());
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