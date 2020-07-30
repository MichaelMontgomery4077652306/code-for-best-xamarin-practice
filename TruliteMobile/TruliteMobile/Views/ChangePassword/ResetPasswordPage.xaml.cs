using System;
using System.Collections.Generic;
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

namespace TruliteMobile.Views.ChangePassword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPasswordPage : ContentPage
    {
        private readonly ResetPasswordPageViewModel _vm;

        public ResetPasswordPage()
        {
            InitializeComponent();
            BindingContext = _vm = new ResetPasswordPageViewModel();
        }
    }

    public class ResetPasswordPageViewModel : TruliteBaseViewModel
    {
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                RaisePropertyChanged();
            }
        }
        public ICommand ContinueCommand { get; }
        public ResetPasswordPageViewModel()
        {
            ContinueCommand= new AsyncDelegateCommand(OnContinue);
        }

        private async Task OnContinue()
        {
            try
            {
                IsBusy = true;
                if (string.IsNullOrWhiteSpace(_phone))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterPhone).Translate());
                    return;
                }
#if DEBUG
                await Nav.NavigateTo(new PasswordResetCodeConfirmationPage(_phone, Guid.NewGuid()));
#endif
                var context = new PasswordResetPhoneQueryContext
                {
                    PhoneNumber = _phone
                };
                var result = await Api.SendPasswordResetPhone(context);
                if (!result.Successful.GetValueOrDefault()|| result.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }
                if (!result.Data.HasValue)
                {
                    await Alert.ShowMessage(nameof(AppResources.PhoneNotVerified).Translate());
                    return;
                }

                var confirmationGuid = result.Data.Value;
               

                await Nav.NavigateTo(new PasswordResetCodeConfirmationPage(_phone, confirmationGuid));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}