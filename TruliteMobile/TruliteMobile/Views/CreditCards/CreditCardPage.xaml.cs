using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.CreditCards
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardPage : ContentPage
    {
        private readonly CreditCardPageViewModel _vm;

        public CreditCardPage()
        {
            InitializeComponent();
            BindingContext = _vm = new CreditCardPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class CreditCardPageViewModel : TruliteBaseViewModel
    {


        private ObservableCollection<CustomerCreditCardTokenViewModel> _creditCardList;

        public ObservableCollection<CustomerCreditCardTokenViewModel> CreditCardList
        {
            get { return _creditCardList; }
            set
            {
                _creditCardList = value;
                RaisePropertyChanged();
            }
        }

        private CustomerCreditCardTokenViewModel _selectedCard;

        public CustomerCreditCardTokenViewModel SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                _selectedCard = value;
                RaisePropertyChanged();
            }
        }
        public ICommand OpenCardCommand { get; }
        public CreditCardPageViewModel()
        {
            OpenCardCommand = new AsyncDelegateCommand(OnOpenDetails);
        }

        private async Task OnOpenDetails()
        {
            if (_selectedCard == null) return;
            await Nav.NavigateTo(new CreditCardDetailPage(_selectedCard));
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;

                List<CustomerCreditCardTokenViewModel> creditCardTokens;

                if (Settings.MyInfo.CurrentUser.IsTruliteUser)
                {
                   var creditCardResponse = await Api.GetCustomerCreditCardTokens(Api.GetCustomerContext());
                   if (!creditCardResponse.Successful.GetValueOrDefault())
                   {
                       await Alert.DisplayApiCallError(creditCardResponse.ExceptionMessage, creditCardResponse.ValidationErrors);
                       return;
                   }

                   creditCardTokens = creditCardResponse.Data.ToList();
                }
                else
                {
                    var creditCardResponse = await Api.GetAppUserCreditCardTokens(Api.GetCustomerContext());
                    if (!creditCardResponse.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(creditCardResponse.ExceptionMessage, creditCardResponse.ValidationErrors);
                        return;
                    }

                    creditCardTokens = creditCardResponse.Data
                        .Select(p=>
                            p.CloneToType<CustomerCreditCardTokenViewModel, AppUserCreditCardTokenViewModel>())
                        .ToList();

                }

                CreditCardList = new ObservableCollection<CustomerCreditCardTokenViewModel>(creditCardTokens);
                NoResults = !_creditCardList.Any();
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