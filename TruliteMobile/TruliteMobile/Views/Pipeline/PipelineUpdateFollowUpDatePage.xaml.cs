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

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineUpdateFollowUpDatePage : ContentPage
    {
        private readonly PipelineUpdateFollowUpDatePageViewModel _vm;
        public PipelineUpdateFollowUpDatePage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineUpdateFollowUpDatePageViewModel(inquiry);
        }
    }

    public class PipelineUpdateFollowUpDatePageViewModel : TruliteBaseViewModel
    {
        private DateTime _followUpDate;
         
        public DateTime FollowUpDate
        {
            get { return _followUpDate; }
            set
            {
                _followUpDate = value;
                RaisePropertyChanged();
            }
        }
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

        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }

        public PipelineUpdateFollowUpDatePageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
            FollowUpDate = inquiry.FollowUpDate.DateTime;
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
                    FollowUpDate = _followUpDate,
                };
                var result = await Api.PostQuotationUpdate(context);
                Inquiry.FollowUpDate = _followUpDate;
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