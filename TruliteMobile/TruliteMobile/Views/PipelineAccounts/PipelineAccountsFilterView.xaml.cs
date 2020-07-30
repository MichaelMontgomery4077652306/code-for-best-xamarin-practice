using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.PipelineAccounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineAccountsFilterView : ContentView
    {

        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create("IsBusy", typeof(bool), typeof(PipelineAccountsFilterView), default(bool));

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(PipelineAccountsFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }


        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(PipelineAccountsFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        private PipelineFilterViewModel _filterModel;

        public PipelineFilterViewModel FilterModel
        {
            get { return _filterModel; }
            set
            {
                _filterModel = value;
                OnPropertyChanged();
            }
        }

    

        public PipelineAccountsFilterView()
        {
            InitializeComponent();
            FilterModel = new PipelineFilterViewModel();
            Children[0].BindingContext = this;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SearchCommand?.Execute(_filterModel.ToFilter());
        }

        protected override async void OnParentSet()
        {
            base.OnParentSet();
            await _filterModel.Load();
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            _filterModel.Reset();
        }

        private string _lastSearch = null;
        /// <summary>
        /// Filters the Accounts name based on the letter selected in the filter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSegmentedControl_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            string searchString = null;
            if (e.Index > 0)
            {
                searchString = $"{char.ConvertFromUtf32(e.Index + 64)}*";
            }
           
            if (_lastSearch == searchString) return;
            FilterModel.AccountName = null;
            var filterParam = _filterModel.ToFilter();
            filterParam.CustomerName = searchString;
            SearchCommand?.Execute(filterParam);
            _lastSearch = searchString;
        }


    }


    public class PipelineFilterViewModel : TruliteBaseViewModel
    {

        #region Properties
        private int _selectedLetterIndex;

        public int SelectedLetterIndex
        {
            get { return _selectedLetterIndex; }
            set
            {
                _selectedLetterIndex = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<BranchView> _branchList;

        public ObservableCollection<BranchView> BranchList
        {
            get { return _branchList; }
            set
            {
                _branchList = value;
                RaisePropertyChanged();
            }
        }


        private BranchView _selectedBranch;

        public BranchView SelectedBranch
        {
            get { return _selectedBranch; }
            set
            {
                _selectedBranch = value;
                RaisePropertyChanged();
            }
        }



        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                _accountNumber = value;
                RaisePropertyChanged();
            }
        }


        private string _accountName;

        public string AccountName
        {
            get { return _accountName; }
            set
            {
                _accountName = value;
                RaisePropertyChanged();
            }
        }

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


        private bool _ascending;
        private ObservableCollection<int> _qtyList;

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<int> QtyList
        {
            get { return _qtyList; }
            set
            {
                _qtyList = value;
                RaisePropertyChanged();
            }
        }

        private int _selectedQty;

        public int SelectedQty
        {
            get { return _selectedQty; }
            set
            {
                _selectedQty = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        public async Task Load()
        {
            var branchesResult = await Api.GetBranches();
            if (!branchesResult.Successful.GetValueOrDefault() &&
                !string.IsNullOrEmpty(branchesResult.ExceptionMessage))
            {
                await Alert.DisplayApiCallError(branchesResult.ExceptionMessage, branchesResult.ValidationErrors);
                return;
            }

            var branchList = new List<BranchView>
            {
                new BranchView {Description = nameof(AppResources.ChoosePlant).Translate()}
            };
            branchList.AddRange(branchesResult.Data.OrderBy(p => p.Code));
            BranchList = new ObservableCollection<BranchView>(branchList);
            SelectedBranch = _branchList.FirstOrDefault();

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(PipelineAccountSortColumn.Name, nameof(AppResources.Name).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.EmailAddress, nameof(AppResources.Email).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.ContactName, nameof(AppResources.Contact).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.Address, nameof(AppResources.AddressCamelcase).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.Key, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.WarehouseNo, nameof(AppResources.Warehouse).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.SalesGroup, nameof(AppResources.SalesGroup).Translate()),
                new SortColumnItem(PipelineAccountSortColumn.Users, nameof(AppResources.Users).Translate()),

            };

            Ascending = true;
            SelectedSortColumn = _sortColumns[0];
            QtyList = new ObservableCollection<int> { 20,50, 100, 1000, 5000,10000 };
            SelectedQty = _qtyList[0];


        }


        public GetCustomersSearchContext ToFilter()
        {

            var filter = new GetCustomersSearchContext
            {
                CustomerName = this.AccountName,
                BranchCode = this.SelectedBranch?.Code,
                AXCustomerId = this.AccountNumber,
                PageSize = _selectedQty
            };
            return filter;
        }

        public void Reset()
        {
            AccountName = null;
            AccountNumber = null;
            SelectedBranch = _branchList.FirstOrDefault();
            Ascending = true;
            SelectedSortColumn = _sortColumns[0];
            SelectedLetterIndex = 0;
            SelectedQty = _qtyList[0];

        }
    }

    public enum PipelineAccountSortColumn
    {
        Name,
        EmailAddress,
        ContactName,
        Address,
        Key,
        WarehouseNo,
        SalesGroup,
        Users
    }
}