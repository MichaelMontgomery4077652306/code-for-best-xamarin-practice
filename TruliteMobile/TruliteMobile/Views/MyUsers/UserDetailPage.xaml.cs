using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.MyUsers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDetailPage : ContentPage
    {
        private readonly UserDetailPageViewModel _vm;

        public UserDetailPage(AppUserView selectedUser)
        {

            InitializeComponent();
            BindingContext = _vm = new UserDetailPageViewModel(selectedUser);
        }
    }

    public class UserDetailPageViewModel : TruliteBaseViewModel
    {

        #region Properties
        public bool IsAdmin
        {
            get
            {
                return Settings.MyInfo.CurrentUser.IsAdmin.GetValueOrDefault();
            }
        }

        private bool _showHeaderFrame;

        public bool ShowHeaderFrame
        {
            get { return _showHeaderFrame; }
            set
            {
                _showHeaderFrame = value;
                RaisePropertyChanged();
            }
        }


        private bool _showActionsFrame;

        public bool ShowActionsFrame
        {
            get { return _showActionsFrame; }
            set
            {
                _showActionsFrame = value;
                RaisePropertyChanged();
            }
        }

        private AppUserView _user;

        public AppUserView User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged();
            }
        }


        #endregion


        #region Commands
        public ICommand ToggleHeaderFrameCommand { get; }
        public ICommand ToggleActionsFrameCommand { get; }
        public ICommand EditUserCommand { get; }
        public ICommand DeleteUserCommand { get; }
        public ICommand ResetPasswordCommand { get; }
        #endregion


        public UserDetailPageViewModel(AppUserView selectedUser)
        {
            User = selectedUser;
            ToggleHeaderFrameCommand = new Command<bool>((show) => ShowHeaderFrame = show);
            ToggleActionsFrameCommand = new Command<bool>((show) => ShowActionsFrame = show);
            EditUserCommand = new AsyncDelegateCommand(OnEdit);
            DeleteUserCommand = new AsyncDelegateCommand(OnDelete);
            ResetPasswordCommand = new AsyncDelegateCommand(OnResetPassword);
            ShowHeaderFrame = true;//Requested by Bassam to show user details as default
        }

       

        private async Task OnResetPassword()
        {
            await Alert.ShowMessage("Coming soon");
            return;

            //try
            //{
            //    if (IsBusy) return;
            //    IsBusy = true;
            //    await Nav.NavigateTo(new MyUsersResetPasswordPage(_user));
            //}
            //finally
            //{
            //    IsBusy = false;
            //}
        }

        private async Task OnDelete()
        {

            try
            {
                IsBusy = true;

                if (!(await Alert.ShowMessageConfirmation(
                    $"Are you sure you want to delete the user {_user.FirstName} {_user.LastName}?", null, "Yes",
                    "No")))
                {
                    return;
                }

                AppUsersQueryContext context = new AppUsersQueryContext
                {
                    LoginId = _user.LoginId,
                    FirstName = _user.FirstName,
                    LastName = _user.LastName,
                    Id = _user.AppUserId
                };
                var deleteResponse = await Api.DeleteUser(context);
                if (!deleteResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(deleteResponse.ExceptionMessage,
                        deleteResponse.ValidationErrors, "Could not get branches");
                    return;
                }

                await Nav.Nav.PopAsync();
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e,
                    "Could not delete user - server error, please check your connection and try again");
            }
            finally
            {

                IsBusy = false;
            }
        }

        private async Task OnEdit()
        {
            try
            {
                IsBusy = true;
                await Nav.NavigateTo(new EditUserPage(_user));
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}