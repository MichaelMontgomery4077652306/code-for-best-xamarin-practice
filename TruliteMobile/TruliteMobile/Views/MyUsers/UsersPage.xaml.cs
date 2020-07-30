using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersPage : ContentPage
    {
        private readonly UsersPageViewModel _vm;

        public UsersPage()
        {
            InitializeComponent();
            BindingContext = _vm = new UsersPageViewModel();
        }

        protected override async void OnAppearing()
        {
            if (this.ToolbarItems.Count > 1
                    && !SettingsService.Instance.MyInfo.CurrentUser.IsAdmin.GetValueOrDefault())
            {
                this.ToolbarItems.RemoveAt(1);
            }
            base.OnAppearing();
            await _vm.Load();
        }
    }

    public class UsersPageViewModel : TruliteBaseViewModel
    {
        #region Property
        private ObservableCollection<AppUserView> _userList;
        public ObservableCollection<AppUserView> UserList
        {
            get { return _userList; }
            set { _userList = value; RaisePropertyChanged(); }
        }



        private AppUserView _selectedUser;

        public AppUserView SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                RaisePropertyChanged();
            }
        }


        #endregion

        #region Commands
        public ICommand OpenLinesCommand { get; }
        public ICommand FilterChangeCommand { get; }
        public ICommand SearchCommand { get; }

        public ICommand AddUserCommand { get; }

        #endregion

        public UsersPageViewModel()
        {
            _previousFilter = new UserFilter();
            OpenLinesCommand = new AsyncDelegateCommand(OnOpen);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
            SearchCommand = new AsyncDelegateCommand<UserFilter>(OnSearch);
            AddUserCommand = new AsyncDelegateCommand(OnAddUser);

        }

        private async Task OnAddUser()
        {
            _reloadList = true;
            await Nav.NavigateTo(new AddUserPage());
        }

        private async Task OnSearch(UserFilter arg)
        {
            try
            {
                IsBusy = true;
                ShowFilter = false;
                _reloadList = true;
                await Load(arg);
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

        private UserFilter _previousFilter;
        private List<AppUserView> _originalList;
        private bool _reloadList;

        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                if (arg == null) return;
                IsBusy = true;
                ShowFilter = false;
                _previousFilter.SortColumnItem = arg;
                await Load(_previousFilter);
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

        private async Task OnOpen()
        {
            if (_selectedUser == null) return;
            _reloadList = true;
            await Nav.NavigateTo(new UserDetailPage(_selectedUser));
        }


        public async Task Load(UserFilter filter = null)
        {
            try
            {
                IsBusy = true;

                if (_originalList == null || _reloadList)
                {
                    var result = await Api.GetUsers(new AppUsersQueryContext());
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.ShowMessage(result.ExceptionMessage);
                        return;
                    }
                    _originalList = result.Data.ToList();

                }
                IEnumerable<AppUserView> newSortedList = _originalList;

                if (filter == null)
                {
                    filter = new UserFilter();
                    newSortedList = SortList(filter.SortColumnItem, _originalList);
                    newSortedList = Filter(filter, newSortedList);
                }
                else
                {
                    if (filter.SortColumnItem != _previousFilter.SortColumnItem || _reloadList)
                    {
                        newSortedList = SortList(filter.SortColumnItem, _originalList).ToList();
                    }
                    if (IsFilterDifferentFromLast(filter) || _reloadList)
                    {
                        newSortedList = Filter(filter, newSortedList);
                    }
                    _reloadList = false;
                }


                UserList = new ObservableCollection<AppUserView>(newSortedList);
                _previousFilter = filter;

            }
            catch (Exception ex)
            {
                await Alert.DisplayError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool IsFilterDifferentFromLast(UserFilter currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.FirstName != currentFilter.FirstName) return true;
            if (_previousFilter.LastName != currentFilter.LastName) return true;
            if (_previousFilter.Email != currentFilter.Email) return true;
            if (_previousFilter.SelectedRoleKey != currentFilter.SelectedRoleKey) return true;
            if (_previousFilter.SelectedStatus != currentFilter.SelectedStatus) return true;
            if (_previousFilter.Language != currentFilter.Language) return true;
            return false;

        }


        private static IEnumerable<AppUserView> Filter(UserFilter filter, IEnumerable<AppUserView> list)
        {
            IEnumerable<AppUserView> filteredList = list;
            if (!string.IsNullOrWhiteSpace(filter.Email))
            {
                filteredList = filteredList
                    .Where(p => p.LoginId?.IndexOf(filter.Email, StringComparison.CurrentCultureIgnoreCase) > -1)
                    .ToList();
            }
            if (!string.IsNullOrWhiteSpace(filter.FirstName))
            {
                filteredList = filteredList
                    .Where(p => p.FirstName?.IndexOf(filter.FirstName, StringComparison.CurrentCultureIgnoreCase) > -1)
                    .ToList();
            }
            if (!string.IsNullOrWhiteSpace(filter.LastName))
            {
                filteredList = filteredList
                    .Where(p => p.LastName?.IndexOf(filter.LastName, StringComparison.CurrentCultureIgnoreCase) > -1)
                    .ToList();
            }
            if (filter.SelectedRoleKey > 0)
            {
                filteredList = filteredList
                    .Where(p => p.Role != null && (int?)p.Role == filter.SelectedRoleKey);
            }
            if (filter.SelectedStatus?.Key != null)
            {
                filteredList = filteredList
                    .Where(p => p.AccountStatus.Key == filter.SelectedStatus.Key);
            }

            if (!string.IsNullOrWhiteSpace(filter.Phone))
            {
                filteredList = filteredList
                    .Where(p => p.PhoneNumber?.IndexOf(filter.Phone, StringComparison.CurrentCultureIgnoreCase) > -1);
            }

            if (filter.Language != LanguagesEnum.All)
            {
                filteredList = filteredList.Where(p => p.Language == filter.Language.ToString());
            }
            return filteredList;
        }

        private static ICollection<AppUserView> SortList(SortColumnItem sortOrder, ICollection<AppUserView> list)
        {
            if (sortOrder == null)
            {
                return list;
            }

            var sortByColumn = sortOrder.Key.ObjectToEnum<UserSortableColumns>();
            switch (sortByColumn)
            {
                case UserSortableColumns.FirstName:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.FirstName).ToList()
                            : list.OrderByDescending(p => p.FirstName).ToList();
                    }
                    break;

                case UserSortableColumns.LastName:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.LastName).ToList()
                            : list.OrderByDescending(p => p.LastName).ToList();
                    }
                    break;
                case UserSortableColumns.Email:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.LoginId).ToList()
                            : list.OrderByDescending(p => p.LoginId).ToList();
                    }
                    break;
                case UserSortableColumns.Status:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.AccountStatus?.Name ?? string.Empty).ToList()
                            : list.OrderByDescending(p => p.AccountStatus?.Name ?? string.Empty).ToList();
                    }
                    break;
                case UserSortableColumns.Created:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.DateCreated).ToList()
                            : list.OrderByDescending(p => p.DateCreated).ToList();
                    }
                    break;
                case UserSortableColumns.IsAdmin:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.IsAdmin).ToList()
                            : list.OrderByDescending(p => p.IsAdmin).ToList();
                    }
                    break;

                case UserSortableColumns.TimeZone:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p?.TimeZone?.Name ?? string.Empty).ToList()
                            : list.OrderByDescending(p => p?.TimeZone?.Name ?? string.Empty).ToList();
                    }
                    break;
                case UserSortableColumns.Language:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p.Language).ToList()
                            : list.OrderByDescending(p => p.Language).ToList();
                    }
                    break;
                case UserSortableColumns.PhoneNumber:
                    {
                        list = sortOrder.Ascending ? list.OrderBy(p => p?.PhoneNumber ?? string.Empty).ToList()
                            : list.OrderByDescending(p => p.PhoneNumber ?? string.Empty).ToList();
                    }
                    break;
                //case UserSortableColumns.Users:
                //{
                //    list = sortOrder.Ascending ? list.OrderBy(p => p?.AppUserId ?? string.Empty).ToList()
                //        : list.OrderByDescending(p => p.PhoneNumber ?? string.Empty).ToList();
                //    }
                //    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}