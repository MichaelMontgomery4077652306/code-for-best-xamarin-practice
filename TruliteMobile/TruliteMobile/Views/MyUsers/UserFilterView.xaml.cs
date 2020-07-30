using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.SupportTickets;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserFilterView : ContentView
    {


        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(UserFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }

        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(UserFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }


        private UserFilterViewViewModel _filterModel;

        public UserFilterViewViewModel FilterModel
        {
            get { return _filterModel; }
            set
            {
                _filterModel = value;
                OnPropertyChanged();
            }
        }

        public UserFilterView()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            FilterModel = new UserFilterViewViewModel();
            Children[0].BindingContext = this;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (!await _filterModel.Validate()) return;
            var filter = _filterModel.ToFilter();
            SearchCommand?.Execute(filter);
        }

        protected override async void OnBindingContextChanged()
        {
            await FilterModel.Load();
        }

        private async void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init();
            await FilterModel.Load();
        }
    }



    public class UserFilter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? SelectedRoleKey { get; set; }
        public KeyNameModelOfGuid SelectedStatus { get; set; }
        
        public SortColumnItem SortColumnItem { get; set; }
        public bool IsAscending { get; set; }

        public bool IsDefaultRole { get; set; }
        public bool IsDefaultStatus { get; set; }
        public string Phone { get; set; }
        public LanguagesEnum Language { get; set; }
    }



    public class UserFilterViewViewModel : TruliteBaseViewModel
    {
        #region Properties

        private ObservableCollection<SortColumnItem> _sortColumns;

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                RaisePropertyChanged();
            }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        private KeyNameModelOfGuid _selectedStatus;

        public KeyNameModelOfGuid SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<int?, string> _selectedRole;

        public KeyValuePair<int?, string> SelectedRole
        {
            get { return _selectedRole; }
            set
            {
                _selectedRole = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyNameModelOfGuid> _statusList;

        public ObservableCollection<KeyNameModelOfGuid> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<int?, string>> _roleList;

        public ObservableCollection<KeyValuePair<int?, string>> RoleList
        {
            get { return _roleList; }
            set
            {
                _roleList = value;
                RaisePropertyChanged();
            }
        }

        private SortColumnItem _selectedSortColumn;

        public SortColumnItem SelectedSortColumn
        {
            get { return _selectedSortColumn; }
            set
            {
                _selectedSortColumn = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<LanguagesEnum, string>> _languageList;

        public ObservableCollection<KeyValuePair<LanguagesEnum, string>> LanguageList
        {
            get { return _languageList; }
            set
            {
                _languageList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<LanguagesEnum, string> _selectedLanguage;

        public KeyValuePair<LanguagesEnum, string> SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                _selectedLanguage = value;
                RaisePropertyChanged();
            }
        }

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

        private bool _isAscending;

        public bool IsAscending
        {
            get { return _isAscending; }
            set
            {
                _isAscending = value;
                RaisePropertyChanged();
            }
        }


        #endregion
        public UserFilterViewViewModel()
        {
            RoleList = new ObservableCollection<KeyValuePair<int?, string>>
            {    

                new KeyValuePair<int?, string>(null, nameof(AppResources.All).Translate()),
                new KeyValuePair<int?, string>(0, nameof(AppResources.RegularAccount).Translate()),
                new KeyValuePair<int?, string>(1,  nameof(AppResources.PlantViewer).Translate()),
                new KeyValuePair<int?, string>(2,   nameof(AppResources.PlantAdmin).Translate()),
                new KeyValuePair<int?, string>(3,   nameof(AppResources.SalesRep).Translate()),
            };
            SelectedRole = _roleList.First();

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(UserSortableColumns.FirstName , nameof(AppResources.FirstName).Translate()),
                new SortColumnItem(UserSortableColumns.LastName,  nameof(AppResources.LastName).Translate()),
                new SortColumnItem(UserSortableColumns.Email,  nameof(AppResources.Email).Translate()),
                new SortColumnItem(UserSortableColumns.Status,  nameof(AppResources.Status).Translate()),
                new SortColumnItem(UserSortableColumns.Language, nameof(AppResources.Language).Translate()),
                new SortColumnItem(UserSortableColumns.Created,  nameof(AppResources.Created).Translate()),
                new SortColumnItem(UserSortableColumns.PhoneNumber,  nameof(AppResources.PhoneNumber).Translate()),
                new SortColumnItem(UserSortableColumns.IsAdmin, nameof(AppResources.IsAdmin).Translate()),
                new SortColumnItem(UserSortableColumns.TimeZone,  nameof(AppResources.Timezone).Translate()),
                new SortColumnItem(UserSortableColumns.Users,  nameof(AppResources.Users).Translate()),

            };
            SelectedSortColumn = SortColumns[0];
            LanguageList= new ObservableCollection<KeyValuePair<LanguagesEnum, string>>
            {
                new KeyValuePair<LanguagesEnum, string>(LanguagesEnum.All,nameof(AppResources.All).Translate()),
                new KeyValuePair<LanguagesEnum, string>(LanguagesEnum.English,nameof(AppResources.English).Translate()),
                new KeyValuePair<LanguagesEnum, string>(LanguagesEnum.French,nameof(AppResources.French).Translate()),
                new KeyValuePair<LanguagesEnum, string>(LanguagesEnum.Spanish,nameof(AppResources.Spanish).Translate()),
            };

            SelectedLanguage = _languageList[0];


        }


        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var statusListResponse = await Api.GetUserAccountStatuses();
                if (!statusListResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(statusListResponse.ExceptionMessage,
                        statusListResponse.ValidationErrors, nameof(AppResources.CouldNotRetrieveAccountStatus).Translate());
                    return;
                }

                var statusList = new List<KeyNameModelOfGuid>
                {
                    new KeyNameModelOfGuid
                    {
                        Name = nameof(AppResources.All).Translate()
                    }
                };
                statusList.AddRange(TranslateAccountStatusList(statusListResponse.Data));
                StatusList = new ObservableCollection<KeyNameModelOfGuid>(statusList);
                SelectedStatus = _statusList[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                await Alert.DisplayError(e,
                    nameof(AppResources.ServerError).Translate());
            }
            finally
            {
                IsBusy = true;
            }

        }


        private IEnumerable<KeyNameModelOfGuid> TranslateAccountStatusList(IEnumerable<KeyNameModelOfGuid> inputList)
        {
            var returnList = new List<KeyNameModelOfGuid>();
            foreach (var keyName in inputList)
            {
                switch (keyName.Name)
                {
                    case "Locked":
                        returnList.Add(new KeyNameModelOfGuid
                        {
                            Key = keyName.Key,
                            Name = nameof(AppResources.AccountStatusLocked).Translate()
                        });
                        break;
                    case "Active":
                        returnList.Add(new KeyNameModelOfGuid
                        {
                            Key = keyName.Key,
                            Name = nameof(AppResources.AccountStatusActive).Translate()
                        });
                        break;
                    case "RequireNewPassword":
                        returnList.Add(new KeyNameModelOfGuid
                        {
                            Key = keyName.Key,
                            Name = nameof(AppResources.AccountStatusRequireNewPassword).Translate()
                        });
                        break;
                    case "InActive":
                        returnList.Add(new KeyNameModelOfGuid
                        {
                            Key = keyName.Key,
                            Name = nameof(AppResources.AccountStatusInActive).Translate()
                        });
                        break;
                }
            }

            return returnList;
        }

        public UserFilter ToFilter()
        {
            return new UserFilter
            {
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                IsAscending = _isAscending,
                SelectedRoleKey = _selectedRole.Key,
                SelectedStatus = _selectedStatus,
                SortColumnItem = _selectedSortColumn.CloneJson(),
                IsDefaultRole = _roleList.IndexOf(_selectedRole) < 0,
                IsDefaultStatus = _statusList.IndexOf(_selectedStatus) < 1,
                Phone = _phone,
                Language = _selectedLanguage.Key

            };
        }

        public async Task<bool> Validate()
        {
            if (string.IsNullOrWhiteSpace(_email)
            || _email.IsValidEmail()) return true;
            await Alert.ShowMessage(nameof(AppResources.PleaseEnterValidEmail).Translate());
            return false;

        }
    }

   

    public enum UserSortableColumns
    {
        FirstName,
        LastName,
        Email,
        Status,
        Created,
        IsAdmin,
        TimeZone,
        Language,
        PhoneNumber,
        Users
    }
}