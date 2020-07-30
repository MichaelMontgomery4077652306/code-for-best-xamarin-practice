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
    public partial class PasswordResetCodeConfirmationPage : ContentPage
    {
        private readonly PasswordResetCodeConfirmationPageViewModel _vm;

        public PasswordResetCodeConfirmationPage(string phone, Guid confirmationGuid)
        {
            InitializeComponent();
            BindingContext = _vm = new PasswordResetCodeConfirmationPageViewModel(phone, confirmationGuid);
        }
    }

    public class PasswordResetCodeConfirmationPageViewModel : TruliteBaseViewModel
    {
        private readonly Guid _confirmationGuid;

        #region Properties
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

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                RaisePropertyChanged();
            }
        }

        private string _verificationCode;

        public string VerificationCode
        {
            get { return _verificationCode; }
            set
            {
                _verificationCode = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public ICommand ContinueCommand { get; }

        public PasswordResetCodeConfirmationPageViewModel(string phone, Guid confirmationGuid)
        {
            _confirmationGuid = confirmationGuid;
            Phone = phone;
            ContinueCommand = new AsyncDelegateCommand(OnContinue);
        }
        private async Task OnContinue()
        {
            try
            {
                IsBusy = true;
                if (string.IsNullOrWhiteSpace(_verificationCode))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterVerificationCode).Translate());
                    return;
                }
                if (string.IsNullOrWhiteSpace(_password))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterPassword).Translate());
                    return;
                }
                if (string.IsNullOrWhiteSpace(_confirmPassword))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterPassordVerification).Translate());
                    return;
                }

                if (_password != _confirmPassword)
                {
                    await Alert.ShowMessage(nameof(AppResources.PasswordAndConfirmationDontMatch).Translate());
                    return;
                }

                var context = new PasswordResetPhoneQueryContext
                {
                    PhoneNumber = _phone,
                    Verification = new VerifyCodeQueryContext
                    {
                        Code = _verificationCode,
                        VerificationCodeId = _confirmationGuid
                    }
                };
                var result = await Api.ResetPasswordPhone(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                if (!result.Data.GetValueOrDefault())
                {
                    await Alert.ShowMessage(nameof(AppResources.PhoneNotVerified).Translate());
                    return;
                }

                await Nav.Nav.PopToRootAsync();
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