using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineUpdateExpiryDatePage : ContentPage
    {
        private PipelineUpdateExpiryDatePageViewModel _vm;
         
        public PipelineUpdateExpiryDatePage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineUpdateExpiryDatePageViewModel(inquiry);
        }
    }

    public class PipelineUpdateExpiryDatePageViewModel : TruliteBaseViewModel
    {
        private SalesQuotationInquiry _inquiry;

        public SalesQuotationInquiry Inquiry
        {
            get { return _inquiry; }
            set
            {
                _inquiry = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _expiryDate;

        public DateTime? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                _expiryDate = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }

        public PipelineUpdateExpiryDatePageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SaveCommand = new AsyncDelegateCommand(OnSave);
            if (inquiry.ExpiryDate.HasValue)
            {
                ExpiryDate = inquiry.ExpiryDate.Value.DateTime;
            }
        }

        private async Task OnSave()
        {
            try
            {
                IsBusy = true;
                DateTimeOffset? expiryDate = null;
                if (_expiryDate.HasValue)
                {
                    expiryDate = _expiryDate;
                }
                var context = new QuotationUpdateQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustAccount = _inquiry.CustAccount,
                    Id = _inquiry.QuotationId,
                    ExpiryDate = expiryDate,
                };
                var result = await Api.PostQuotationUpdate(context);
                _inquiry.ExpiryDate = expiryDate;
                if (!result.Successful.GetValueOrDefault()
                    || result.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                await OnClose();

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

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }
    }
}