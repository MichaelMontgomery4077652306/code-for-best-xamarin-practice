using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineLoseQuotationPage : ContentPage
    {
        private readonly PipelineLoseQuotationPageViewModel _vm;

        public PipelineLoseQuotationPage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineLoseQuotationPageViewModel(inquiry);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PipelineLoseQuotationPageViewModel : TruliteBaseViewModel
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


        private ObservableCollection<KeyNameModelOfString> _reasonList;

        public ObservableCollection<KeyNameModelOfString> ReasonList
        {
            get { return _reasonList; }
            set
            {
                _reasonList = value;
                RaisePropertyChanged();
            }
        }

        private KeyNameModelOfString _selectedReason;

        public KeyNameModelOfString SelectedReason
        {
            get { return _selectedReason; }
            set
            {
                _selectedReason = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }
        public PipelineLoseQuotationPageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SaveCommand = new AsyncDelegateCommand(OnSave);
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;

                var quotationReasons = await Api.GetQuotationReasons();

                if (!quotationReasons.Successful.GetValueOrDefault()
                    || quotationReasons.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(quotationReasons.ExceptionMessage, quotationReasons.ValidationErrors);
                    return;
                }
                var list = new List<KeyNameModelOfString> { new KeyNameModelOfString
                {
                    Name = nameof(AppResources.SelectOne).Translate()
                } };
                list.AddRange(quotationReasons.Data);
                ReasonList = new ObservableCollection<KeyNameModelOfString>(list);
                SelectedReason = _reasonList[0];

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

        private async Task OnSave()
        {
            try
            {

                if (_selectedReason.Key == null)
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseSelectReason).Translate());
                    return;
                }
                IsBusy = true;
                var context = new LostQuotationQueryContext
                {
                    QuotationId = _inquiry.QuotationId,
                    ReasonId =_selectedReason.Key 
                };
                var result = await Api.LostQuotation(context);

                if (!result.Successful.GetValueOrDefault()
                    || result.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }
                //This message is sent to force the refresh of
                //pipeline list as this quotation will not longer
                //appear on the list.
                MessengerInstance.Send(new RefreshPipelineScreenMessage());
                await Nav.Nav.PopToRootAsync();

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