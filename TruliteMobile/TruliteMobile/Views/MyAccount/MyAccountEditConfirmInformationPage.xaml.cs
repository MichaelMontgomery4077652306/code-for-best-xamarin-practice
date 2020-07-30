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

namespace TruliteMobile.Views.MyAccount
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountEditConfirmInformationPage : ContentPage
    {


        private readonly MyAccountEditConfirmInformationPageViewModel _vm;
        public MyAccountEditConfirmInformationPage(CustomerConfirmInformation customerConfirmInformation)
        {
            InitializeComponent();
            BindingContext = _vm = new MyAccountEditConfirmInformationPageViewModel(customerConfirmInformation);
        }

    }

    public class MyAccountEditConfirmInformationPageViewModel : TruliteBaseViewModel
    {
        private CustomerConfirmInformation _customerConfirmInformation;

        public CustomerConfirmInformation CustomerConfirmInformation
        {
            get { return _customerConfirmInformation; }
            set { _customerConfirmInformation = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<KeyValuePair<string,string>> _typeList;

        public ObservableCollection<KeyValuePair<string,string>> TypeList
        {
            get { return _typeList; }
            set
            {
                _typeList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string,string> _selectedType;

        public KeyValuePair<string,string> SelectedType
        {
            get { return _selectedType; }
            set
            {
                _selectedType = value;
                RaisePropertyChanged();
            }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand SubmitCommand { get; }

        public MyAccountEditConfirmInformationPageViewModel(CustomerConfirmInformation customerConfirmInformation)
        {
            _customerConfirmInformation = customerConfirmInformation;
            Value = _customerConfirmInformation.Value;
            SubmitCommand = new AsyncDelegateCommand(Submit);
            CloseCommand = new AsyncDelegateCommand(OnClose);

            TypeList = new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(null, nameof(AppResources.SelectCommunication).Translate()),
                new KeyValuePair<string, string>("ASN Email", nameof(AppResources.AdvancedShippingNotesEmail).Translate()),
                new KeyValuePair<string, string>("ASN Fax", nameof(AppResources.AdvancedShippingNotesFax).Translate()),
                new KeyValuePair<string, string>("Invoice Email", nameof(AppResources.InvoiceEmail).Translate()),
                new KeyValuePair<string, string>("Invoice Fax", nameof(AppResources.InvoiceFax).Translate()),
                new KeyValuePair<string, string>("Quote Email", nameof(AppResources.QuoteEmail).Translate()),
                new KeyValuePair<string, string>("Quote Fax", nameof(AppResources.QuoteFax).Translate()),
                new KeyValuePair<string, string>("Conf Email", nameof(AppResources.ConfirmationEmail).Translate()),
                new KeyValuePair<string, string>("Conf Fax", nameof(AppResources.ConfirmationFax).Translate()),
            };
            var currentType= 
                _typeList.FirstOrDefault(p => p.Key == _customerConfirmInformation.CommunicationTypeId);
            ;
            SelectedType = currentType;
        }

        private async Task Submit()
        {
            try
            {
                IsBusy = true;
                var context = new CustomerConfirmInfoContext
                {
                    CommunicationTypeId = _selectedType.Key,
                    CustomerInfo = Api.GetCustomerContext(),
                    Email = _selectedType.Key.Contains("Email")? _value:null,
                    Fax = _selectedType.Key.Contains("Fax") ? _value:null,
                    Key = _customerConfirmInformation.Key,
                    Value = _value
                };
                var result = await Api.UpdateCustomerConfirm(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, 
                        result.ValidationErrors);
                    return;
                }

                await OnClose();

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