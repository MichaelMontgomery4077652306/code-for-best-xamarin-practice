using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditUserPage : ContentPage
    {
        private readonly EditUserPageViewModel _vm;

        public EditUserPage(AppUserView user)
        {
            InitializeComponent();
            BindingContext = _vm = new EditUserPageViewModel(user);
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.Load();
        }
    }

    public class EditUserPageViewModel : TruliteBaseViewModel
    {

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


        private ObservableCollection<KeyNameModelOfGuid> _timeZoneList;
        private readonly AppUserView _userParam;

        public ObservableCollection<KeyNameModelOfGuid> TimezoneList
        {
            get { return _timeZoneList; }
            set
            {
                _timeZoneList = value;
                RaisePropertyChanged();
            }
        }



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


        public ICommand CloseCommand { get; }
        public ICommand SaveCommand { get; }
        public EditUserPageViewModel(AppUserView user)
        {
            SaveCommand = new AsyncDelegateCommand(OnSave);
            CloseCommand = new AsyncDelegateCommand(OnClose);
            _userParam = user;
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
            if (_user.TimeZone.Key == null)
            {
                await Alert.ShowMessage("Please select a timezone");
                return false;
            }
            

            return true;
        }

        private async Task OnSave()
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
                    _user.Permissions = new List<AppPermissionView>();
                }
                else
                {
                    _user.Permissions.Clear();
                }
                
                _user.Permissions.AddRange(_permissionList
                    .Where(p => p.IsChecked)
                    .ToList()
                    .Select(p => p.CloneToType<AppPermissionView, AppPermissionViewSelection>()));
                var addUserResponse = await Api.EditUser(_user);
                if (!addUserResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(addUserResponse.ExceptionMessage,
                        addUserResponse.ValidationErrors, "Couldn't save user information. Server error");
                    return;
                }
                await Nav.Nav.PopAsync();
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e,"Couldn't save user data - please check your connection and try again'");

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
                        permissionListResponse.ValidationErrors, "Could not get permission list from server");
                    return;
                }

             
                var selectedTimezone= _timeZoneList.FirstOrDefault(p => p.Key == _userParam.TimeZone?.Key);
                _userParam.TimeZone = selectedTimezone ?? _timeZoneList.First();

                var permissionList = permissionListResponse.Data
                    .Where(p => p.Active.GetValueOrDefault())
                    .Select(p => p.CloneToType<AppPermissionViewSelection, AppPermissionView>());

                PermissionList = new ObservableCollection<AppPermissionViewSelection>(permissionList);

                foreach (var userParamPermission in _userParam.Permissions)
                {
                    var permissionFromList = _permissionList
                        .FirstOrDefault(p => p.AppPermissionId == userParamPermission.AppPermissionId);
                    if(permissionFromList==null) continue;
                    permissionFromList.IsChecked = true;
                }

                User = _userParam;

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