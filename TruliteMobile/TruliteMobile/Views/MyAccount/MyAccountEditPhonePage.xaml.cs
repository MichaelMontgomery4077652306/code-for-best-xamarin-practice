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

namespace TruliteMobile.Views.MyAccount
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountEditPhonePage : ContentPage
    {
        private readonly MyAccountEditPhonePageViewModel _vm;

        public MyAccountEditPhonePage()
        {
            InitializeComponent();
            BindingContext = _vm = new MyAccountEditPhonePageViewModel();
        }
    }

    public class MyAccountEditPhonePageViewModel : TruliteBaseViewModel
    {
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged();
            }
        }

        private string _verificationCode;
        private Guid _confirmationGuid;

        public string VerificationCode
        {
            get { return _verificationCode; }
            set
            {
                _verificationCode = value;
                RaisePropertyChanged();
            }
        }

        private bool _verificationMode;

        public bool VerificationMode
        {
            get { return _verificationMode; }
            set
            {
                _verificationMode = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand VerifyCommand { get; }
        public MyAccountEditPhonePageViewModel()
        {
            SaveCommand = new AsyncDelegateCommand(OnSave);
            VerifyCommand = new AsyncDelegateCommand(OnVerify);
            PhoneNumber = Settings.MyInfo.CurrentUser.PhoneNumber;
        }

        private async Task OnVerify()
        {
            try
            {

                IsBusy = true;

                VerifyCodeQueryContext verficationContext = new VerifyCodeQueryContext
                {
                    Code = _verificationCode,
                    VerificationCodeId = _confirmationGuid
                };
                var verifyUserPhoneNumber = await Api.VerifyUserPhoneNumber(verficationContext);
                if (!verifyUserPhoneNumber.Successful.GetValueOrDefault() || verifyUserPhoneNumber.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(verifyUserPhoneNumber.ExceptionMessage, verifyUserPhoneNumber.ValidationErrors);
                    return;
                }

                if (verifyUserPhoneNumber.Data.GetValueOrDefault())
                {
                    await Alert.ShowMessage(nameof(AppResources.PhoneNumberChanged).Translate());
                    await Nav.Nav.PopAsync();
                }
                await Alert.ShowMessage(nameof(AppResources.VerificationCodeIsInvalid).Translate());

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

                IsBusy = true;
                UpdatePhoneQueryContext context = new UpdatePhoneQueryContext
                {
                    PhoneNumber = _phoneNumber
                };
                var editUserPhoneNumber = await Api.EditUserPhoneNumber(context);
                if (!editUserPhoneNumber.Successful.GetValueOrDefault()|| editUserPhoneNumber.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(editUserPhoneNumber.ExceptionMessage, editUserPhoneNumber.ValidationErrors);
                    return;
                }

                _confirmationGuid = editUserPhoneNumber.Data.GetValueOrDefault();
                VerificationMode = true;//Switch the screen UI to verification mode
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