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
    public partial class PipelineUpdateLeadTimePage : ContentPage
    {
        private readonly PipelineUpdateLeadTimePageViewModel _vm;

        public PipelineUpdateLeadTimePage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineUpdateLeadTimePageViewModel(inquiry);
        }
    }

    public class PipelineUpdateLeadTimePageViewModel : TruliteBaseViewModel
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

        private ObservableCollection<KeyValuePair<QuotationUpdateQueryContextLeadTime, string>> _leadTimeList;

        public ObservableCollection<KeyValuePair<QuotationUpdateQueryContextLeadTime, string>> LeadTimeList
        {
            get { return _leadTimeList; }
            set
            {
                _leadTimeList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<QuotationUpdateQueryContextLeadTime, string> _selectedLeadTime;

        public KeyValuePair<QuotationUpdateQueryContextLeadTime, string> SelectedLeadTime
        {
            get { return _selectedLeadTime; }
            set
            {
                _selectedLeadTime = value;
                RaisePropertyChanged();
            }
        }


        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }
        public PipelineUpdateLeadTimePageViewModel(SalesQuotationInquiry inquiry)
        {
            Inquiry = inquiry;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SaveCommand = new AsyncDelegateCommand(OnSave);
            LeadTimeList = new ObservableCollection<KeyValuePair<QuotationUpdateQueryContextLeadTime, string>>{
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.None,nameof(AppResources.None).Translate()),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month1,$"<1 {nameof(AppResources.Month).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month3,$"<3 {nameof(AppResources.Months).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month6,$"<6 {nameof(AppResources.Months).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month9,$"<9 {nameof(AppResources.Months).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month12,$"<12 {nameof(AppResources.Months).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.Month24,$"<24 {nameof(AppResources.Months).Translate()}"),
                new KeyValuePair<QuotationUpdateQueryContextLeadTime, string>(QuotationUpdateQueryContextLeadTime.MonthMax,$">24 {nameof(AppResources.Months).Translate()}"),

            };
            QuotationUpdateQueryContextLeadTime leadTime = QuotationUpdateQueryContextLeadTime.None;
            var leadTimeStr = inquiry.LeadTime.Split(' ')[0];
            switch (leadTimeStr)
            {
                case var s when string.IsNullOrWhiteSpace(s):
                    leadTime = QuotationUpdateQueryContextLeadTime.None;
                    break;
                case "<1":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month1;
                    break;
                case "<3":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month3;
                    break;
                case "<6":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month6;
                    break;
                case "<9":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month9;
                    break;
                case "<12":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month12;
                    break;
                case "<24":
                    leadTime = QuotationUpdateQueryContextLeadTime.Month24;
                    break;
                case ">24":
                    leadTime = QuotationUpdateQueryContextLeadTime.MonthMax;
                    break;

            }

            SelectedLeadTime = _leadTimeList.Single(p => p.Key == leadTime);
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
                    LeadTime = _selectedLeadTime.Key
                };
                var result = await Api.PostQuotationUpdate(context);
                Inquiry.LeadTime = _selectedLeadTime.Value;
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