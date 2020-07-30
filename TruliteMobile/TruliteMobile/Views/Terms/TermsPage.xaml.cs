using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Terms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermsPage : ContentPage
    {
        private readonly TermsPageViewModel _vm;

        public TermsPage(MainPageMode mainPageMode)
        {

            InitializeComponent();
            BindingContext = _vm = new TermsPageViewModel(mainPageMode, scroll1);
        }

        protected async override void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class TermsPageViewModel : TruliteBaseViewModel
    {
        private readonly MainPageMode _mainPageMode;
        private readonly ScrollView _termsScrollView;

        private string _termsText;

        public string TermsText
        {
            get { return _termsText; }
            set
            {
                _termsText = value;
                RaisePropertyChanged();
            }
        }

        private string _policyUpdateText;

        public string PolicyUpdateText
        {
            get { return _policyUpdateText; }
            set
            {
                _policyUpdateText = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AcceptCommand { get; }

        public TermsPageViewModel(MainPageMode mainPageMode, ScrollView termsScrollView)
        {
            _mainPageMode = mainPageMode;
            _termsScrollView = termsScrollView;
            AcceptCommand = new AsyncDelegateCommand(OnAccept);

        }

        private async Task OnAccept()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;

                var mainpage = new NavigationPage(new MasterDetailPage1(_mainPageMode));
                App.Current.MainPage = mainpage;
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
        public async Task Load()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;

                Language language = Language.English;
                switch (Settings.Language)
                {
                    case "fr":
                        language = Language.French;
                        break;
                    case "es":
                        language = Language.Spanish;
                        break;
                }
                var result = await Api.GetPortalTerms(language);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                TermsText = result.Data.Text;
                PolicyUpdateText = $"{nameof(AppResources.PolicyUpdatedOn).Translate()} {   result.Data.PolicyDate.GetValueOrDefault():D}";
                await _termsScrollView.ScrollToAsync(0, 0, false);

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