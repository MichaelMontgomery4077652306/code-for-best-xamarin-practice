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
    public partial class PipelineUpdateProbabilityPage : ContentPage
    {
        private readonly PipelineUpdateProbabilityPageViewModel _vm;

        public PipelineUpdateProbabilityPage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineUpdateProbabilityPageViewModel(inquiry);
        }
    }

    public class PipelineUpdateProbabilityPageViewModel : TruliteBaseViewModel
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

        private double? _probability;

        public double? Probability
        {
            get { return _probability; }
            set
            {
                _probability = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }

      
        public PipelineUpdateProbabilityPageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
            Probability = _inquiry.Probability;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SaveCommand = new AsyncDelegateCommand(OnSave);
        }
        private async Task OnSave()
        {
            try
            {
                IsBusy = true;
                var context = new QuotationUpdateQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustAccount = _inquiry.CustAccount,
                    Id = _inquiry.QuotationId,
                    Percent = _probability,
                };
                Inquiry.Probability = _probability;
                var result = await Api.PostQuotationUpdate(context);

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