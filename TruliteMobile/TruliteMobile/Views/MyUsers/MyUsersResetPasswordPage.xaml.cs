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
using TruliteMobile.Views.Users;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.MyUsers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyUsersResetPasswordPage : ContentPage
    {
        private readonly MyUsersResetPasswordPageViewModel _vm;

        public MyUsersResetPasswordPage(AppUserView user)
        {
            InitializeComponent();
            BindingContext = _vm = new MyUsersResetPasswordPageViewModel(user);
        }
    }

    public class MyUsersResetPasswordPageViewModel : TruliteBaseViewModel
    {
        private readonly AppUserView _user;

        #region Properties
        private string _header;

        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
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
        #endregion
        #region Commands

        public ICommand SetPasswordCommand { get; }
        public ICommand CloseCommand { get; }


        #endregion
        public MyUsersResetPasswordPageViewModel(AppUserView user)
        {
            _user = user;
            SetPasswordCommand= new AsyncDelegateCommand(OnSetPassword);
            CloseCommand= new AsyncDelegateCommand(OnClose);

            Header = string.Format(nameof(AppResources.EnterNewPasswordFor).Translate(),
                $"{_user.FirstName} {_user.LastName}");
        }

        private  async Task OnClose()
        {
            await Back();
        }

        private async Task OnSetPassword()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_password))
                {
                    await Alert.ShowMessage(nameof(AppResources.PleaseEnterPassword));
                    return;
                }

                IsBusy = true;
                var context = new ResetPasswordByAdminViewModel
                {
                    AppUserId = _user.AppUserId,
                    NewPassword = _password
                };
                var result=await Api.ResetPasswordByAdmin(context);

                if (!result.Successful.GetValueOrDefault()
                    || result.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                if (!result.Data.GetValueOrDefault())
                {
                    return;
                }
                await Nav.Nav.PopAsync();
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