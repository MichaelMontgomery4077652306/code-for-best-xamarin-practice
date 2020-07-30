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
using TruliteMobile.Views.PackingSlips;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.SupportTickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportTicketsFilterView : ContentView
    {


        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(SupportTicketsFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }


        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(SupportTicketsFilterView), default(ICommand));

        private SupportTicketsFilterModel _filter;

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }


        private ObservableCollection<KeyValuePair<SupportTicketStatusEnum, string>> _statusList;

        public ObservableCollection<KeyValuePair<SupportTicketStatusEnum, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                OnPropertyChanged();
            }
        }

        public static readonly BindableProperty BranchListProperty =
            BindableProperty.Create("BranchList", typeof(ObservableCollection<ExtendedCustomerBranchView>), typeof(SupportTicketsFilterView), default(ObservableCollection<ExtendedCustomerBranchView>), BindingMode.Default, null, OnBranchListPropertyChanged);

        private static void OnBranchListPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var ctr = (SupportTicketsFilterView)bindable;
            if (newvalue == null)
            {
                ctr.Filter.SelectedBranch = null;
            }

            ctr.Filter.SelectedBranch = ((ObservableCollection<ExtendedCustomerBranchView>)newvalue).FirstOrDefault();
        }

        public ObservableCollection<ExtendedCustomerBranchView> BranchList
        {
            get { return (ObservableCollection<ExtendedCustomerBranchView>)GetValue(BranchListProperty); }
            set { SetValue(BranchListProperty, value); }
        }


        private ObservableCollection<SortColumnItem> _sortColumns;

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                OnPropertyChanged();
            }
        }


        private SortColumnItem _selectedSortColumn;

        public SortColumnItem SelectedSortColumn
        {
            get { return _selectedSortColumn; }
            set
            {
                _selectedSortColumn = value;
                OnPropertyChanged();
            }
        }


        private bool _isAscending;

        public bool IsAscending
        {
            get { return _isAscending; }
            set
            {
                _isAscending = value;
                OnPropertyChanged();
            }
        }


        public SupportTicketsFilterView()
        {
            InitializeComponent();
            Filter = new SupportTicketsFilterModel();
            StatusList = new ObservableCollection<KeyValuePair<SupportTicketStatusEnum, string>>
            {
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.All, nameof(AppResources.AllRequests).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.Open, nameof(AppResources.OpenRequests).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.Closed, nameof(AppResources.ClosedRequests).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.Completed,nameof(AppResources.CompletedRequests).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.OnHold,nameof(AppResources.RequestsOnHold).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.Pending,nameof(AppResources.PendingRequests).Translate()),
                new KeyValuePair<SupportTicketStatusEnum, string>(SupportTicketStatusEnum.Overdue,nameof(AppResources.OverdueRequests).Translate()),

            };

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(SupportTicketsSortableColumns.Id, "Id"),
                new SortColumnItem(SupportTicketsSortableColumns.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(SupportTicketsSortableColumns.Subject, nameof(AppResources.Subject).Translate()),
                new SortColumnItem(SupportTicketsSortableColumns.Contact,nameof(AppResources.Contact).Translate()),
                new SortColumnItem(SupportTicketsSortableColumns.LastUpdated, nameof(AppResources.LastUpdated).Translate()),
                new SortColumnItem(SupportTicketsSortableColumns.SupportRep, nameof(AppResources.SupportRep).Translate()),
                new SortColumnItem(SupportTicketsSortableColumns.Priority, nameof(AppResources.Priority).Translate()),

            };
            Children[0].BindingContext = this;
            Init();
        }

        private void Init()
        {
            SelectedSortColumn = SortColumns[4];

            Filter.Status = _statusList.First();
            if (BranchList?.Any() ?? false)
            {
                Filter.SelectedBranch = BranchList[0];
            }
        }


        public SupportTicketsFilterModel Filter
        {
            get { return _filter; }
            set { _filter = value; OnPropertyChanged(); }
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            var sortColumn = _selectedSortColumn.CloneJson();
            sortColumn.Ascending = _isAscending;
            _filter.SortColumn = sortColumn;
            SearchCommand?.Execute(_filter);
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init();
        }
    }


    public enum SupportTicketsSortableColumns
    {
        Id,
        Status,
        Subject,
        Contact,
        LastUpdated,
        SupportRep,
        Priority
    }


    public class SupportTicketsFilterModel : ObservableObject
    {
        private KeyValuePair<SupportTicketStatusEnum, string> _status;

        public KeyValuePair<SupportTicketStatusEnum, string> Status
        {
            get { return _status; }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        private ExtendedCustomerBranchView _selectedBranch;
        private SortColumnItem _sortColumn;

        public ExtendedCustomerBranchView SelectedBranch
        {
            get { return _selectedBranch; }
            set
            {
                _selectedBranch = value;
                RaisePropertyChanged();
            }
        }

        public SortColumnItem SortColumn
        {
            get { return _sortColumn; }
            set
            {
                _sortColumn = value;
                RaisePropertyChanged();
            }
        }
    }
}