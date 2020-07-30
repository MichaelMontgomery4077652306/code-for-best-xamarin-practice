using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;
using Extensions = TruliteMobile.Misc.Extensions;

namespace TruliteMobile.Views.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUserPage : ContentPage
    {
        private readonly AddUserPageViewModel _vm;

        public AddUserPage(AppUserView user=null)
        {
            InitializeComponent();
            BindingContext = _vm = new AddUserPageViewModel(user);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class AddUserPageViewModel : TruliteBaseViewModel
    {


        #region Properties
        private ObservableCollection<AppPermissionViewSelection> _permissionList;

        public ObservableCollection<AppPermissionViewSelection> PermissionList
        {
            get { return _permissionList; }
            set
            {
                _permissionList = value;
                RaisePropertyChanged();
            }
        }


        private AddAppUserView _user;

        public AddAppUserView User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<KeyNameModelOfGuid> _timezoneList;

        public ObservableCollection<KeyNameModelOfGuid> TimezoneList
        {
            get { return _timezoneList; }
            set
            {
                _timezoneList = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<KeyValuePair<AddAppUserViewRole, string>> _roleList;

        public ObservableCollection<KeyValuePair<AddAppUserViewRole, string>> RoleList
        {
            get { return _roleList; }
            set
            {
                _roleList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<AddAppUserViewRole, string> _selectedRole;

        public KeyValuePair<AddAppUserViewRole, string> SelectedRole
        {
            get { return _selectedRole; }
            set
            {
                _selectedRole = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<BranchView> _branches;


        public ObservableCollection<BranchView> Branches
        {
            get { return _branches; }
            set
            {
                _branches = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Commands

        public ICommand CloseCommand { get; }
        public ICommand AddCommand { get; }


        #endregion
        public AddUserPageViewModel(AppUserView user=null)
        {
            AddCommand = new AsyncDelegateCommand(OnAdd);
            CloseCommand = new AsyncDelegateCommand(OnClose);
            User =new AddAppUserView();
            RoleList = new ObservableCollection<KeyValuePair<AddAppUserViewRole, string>>
            {
                new KeyValuePair<AddAppUserViewRole, string>(AddAppUserViewRole.None, "None"),
                new KeyValuePair<AddAppUserViewRole, string>(AddAppUserViewRole.Plant_Admin, "Plant Admin"),
                new KeyValuePair<AddAppUserViewRole, string>(AddAppUserViewRole.Plant_Viewer, "Plant Viewer"),
                new KeyValuePair<AddAppUserViewRole, string>(AddAppUserViewRole.Sales_Rep, "Sales Rep"),
                
            };
            SelectedRole = _roleList.First();

        }

        private async Task<bool> ValidateInput()
        {

            if (string.IsNullOrWhiteSpace(_user.FirstName))
            {
                await Alert.ShowMessage("Please fill in First Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_user.LastName))
            {
                await Alert.ShowMessage("Please fill in Last Name");
                return false;
            }
            if (_user.LoginId == null || !_user.LoginId.IsValidEmail())
            {
                await Alert.ShowMessage("Please enter a valid email");
                return false;
            }
            if (_user.TimeZone == null || _user.TimeZone.Key == null)
            {
                await Alert.ShowMessage("Please select a timezone");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_user.Password))
            {
                await Alert.ShowMessage("Please enter a password");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_user.ConfirmPassword))
            {
                await Alert.ShowMessage("Please enter the password confirmation");
                return false;
            }
            if (!Equals(_user.Password, User.ConfirmPassword))
            {
                await Alert.ShowMessage("Password and password confirmation do not match");
                return false;
            }
            return true;
        }

        private async Task OnAdd()
        {
            try
            {
                if (!await ValidateInput())
                {
                    return;
                }

                IsBusy = true;

                if (_user.Permissions == null)
                {
                    _user.Permissions= new List<AppPermissionView>();
                }
                else
                {
                    _user.Permissions.Clear();
                }


                _user.Role = _selectedRole.Key;
                _user.Permissions.AddRange(_permissionList
                    .Where(p => p.IsChecked)
                    .ToList()
                    .Select(p=>p.CloneToType< AppPermissionView, AppPermissionViewSelection>()));
                var addUserResponse = await Api.AddUser(_user);
                if (addUserResponse == null)
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

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;

                var timeZoneResponse = await Api.GetUserTimeZones();
                if (!timeZoneResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(timeZoneResponse.ExceptionMessage,
                        timeZoneResponse.ValidationErrors, "Could not get timezone list");
                    return;
                }

                var timeZones = new List<KeyNameModelOfGuid>();
                timeZones.Add(new KeyNameModelOfGuid { Name = "Please choose TimeZone" });
                timeZones.AddRange(timeZoneResponse.Data);

                TimezoneList = new ObservableCollection<KeyNameModelOfGuid>(timeZones);
               

                var permissionListResponse = await Api.GetUserAppPermissions();
                if (!permissionListResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(permissionListResponse.ExceptionMessage,
                        permissionListResponse.ValidationErrors, "Could not get users permissions");
                    return;
                }

                var permissionList = permissionListResponse.Data
                    .Where(p => p.Active.GetValueOrDefault())
                    .Select(p => p.CloneToType<AppPermissionViewSelection, AppPermissionView>());

                PermissionList = new ObservableCollection<AppPermissionViewSelection>(permissionList);
                
                var branchResponse = await Api.GetBranches();
                if (!branchResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(branchResponse.ExceptionMessage,
                        branchResponse.ValidationErrors, "Could not get branches");
                    return;
                }
                Branches = new ObservableCollection<BranchView>(branchResponse.Data
                    .OrderBy(p => p.Code));


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

    public class AppPermissionViewSelection : AppPermissionView
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                RaisePropertyChanged();
            }
        }
    }
}