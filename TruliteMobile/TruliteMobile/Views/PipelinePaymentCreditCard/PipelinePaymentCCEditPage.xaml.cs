using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.PipelinePaymentCreditCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelinePaymentCCEditPage : ContentPage
    {
        private readonly PipelinePaymentCCEditPageViewModel _vm;

        public PipelinePaymentCCEditPage(CustomerCreditCardTokenViewModel selectedCreditCard)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelinePaymentCCEditPageViewModel(selectedCreditCard);
        }

    }

    public class PipelinePaymentCCEditPageViewModel : TruliteBaseViewModel
    {


        private ObservableCollection<KeyValuePair<string, string>> _countryList;

        public ObservableCollection<KeyValuePair<string, string>> CountryList
        {
            get { return _countryList; }
            set
            {
                _countryList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string, string> _selectedCountry;

        public KeyValuePair<string, string> SelectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                _selectedCountry = value;
                RaisePropertyChanged();
            }
        }



        private CustomerCreditCardTokenViewModel _card;

        public CustomerCreditCardTokenViewModel Card
        {
            get { return _card; }
            set
            {
                _card = value;
                RaisePropertyChanged();
            }
        }


        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }

        public PipelinePaymentCCEditPageViewModel(CustomerCreditCardTokenViewModel card)
        {
            CountryList = new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("us", "United States"),
                new KeyValuePair<string, string>("ca", "Canada"),
            };
            SelectedCountry = _countryList[0];
            Card = card;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SaveCommand = new AsyncDelegateCommand(OnSave);

        }

        private async Task OnSave()
        {
            try
            {
                IsBusy = true;
                var context = new UpdateCreditCardTokenContext
                {
                    City = _card.City,
                    CountryCode = _selectedCountry.Key,
                    CreditCardTokenId = _card.TokenId,
                    State = _card.State,
                    Street = _card.Street,
                    ZipCode = _card.ZipCode,
                    CopyEmailAddresses = _card.CopyReceiptEmailAddresses
                };
                var updateResult = await Api.UpdateCustomerCreditCardToken(context);
                if (updateResult.Successful.GetValueOrDefault())
                {
                    await OnClose();
                    return;

                }
                await Alert.DisplayApiCallError(updateResult.ExceptionMessage, updateResult.ValidationErrors);

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