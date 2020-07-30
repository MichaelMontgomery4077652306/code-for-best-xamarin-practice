using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineAddNotePage : ContentPage
    {
        private readonly PipelineAddNotePageViewModel _vm;

        public PipelineAddNotePage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineAddNotePageViewModel(inquiry);
        }
    }

    public class PipelineAddNotePageViewModel : TruliteBaseViewModel
    {

        private string _note;

        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
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

        public PipelineAddNotePageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
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
                    Notes = _note,
                };
                var result =await Api.PostQuotationUpdate(context);

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
            await Back();
        }
    }

}