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
using TruliteMobile.Views.PipelineAccounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineFilterView : ContentView
    {

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(PipelineFilterView), default(ICommand));

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

        public PipelineFilterView()
        {
            InitializeComponent();
            FilterModel = new PipelineFilterViewModel();
            Children[0].BindingContext = this;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SearchCommand?.Execute(_filterModel.ToFilter().CloneJson());
        }

        protected override async void OnParentSet()
        {
            base.OnParentSet();
            await _filterModel.Load();
        }

        private async void ResetFormView_Tapped(object sender, EventArgs e)
        {
            FilterModel = new PipelineFilterViewModel();
            await _filterModel.Load();
        }


    }


    public class PipelineFilterViewModel : TruliteBaseViewModel
    {



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

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
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

        private string _salesResponsible;

        public string SalesResponsible
        {
            get { return _salesResponsible; }
            set
            {
                _salesResponsible = value;
                RaisePropertyChanged();
            }
        }

        private string _probability;

        public string Probability
        {
            get { return _probability; }
            set
            {
                _probability = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<SalesInquiryContextFilter, string>> _statusList;

        public ObservableCollection<KeyValuePair<SalesInquiryContextFilter, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<SalesInquiryContextFilter, string> _selectedStatus;

        public KeyValuePair<SalesInquiryContextFilter, string> SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                RaisePropertyChanged();
            }
        }



        private ObservableCollection<KeyValuePair<SalesInquiryContextLeadTime, string>> _leadTimeList;

        public ObservableCollection<KeyValuePair<SalesInquiryContextLeadTime, string>> LeadTimeList
        {
            get { return _leadTimeList; }
            set
            {
                _leadTimeList = value;
                RaisePropertyChanged();
            }
        }


        private KeyValuePair<SalesInquiryContextLeadTime, string> _selectedLeadTime;

        public KeyValuePair<SalesInquiryContextLeadTime, string> SelectedLeadTime
        {
            get { return _selectedLeadTime; }
            set
            {
                _selectedLeadTime = value;
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

        private string _fromAmount;

        public string FromAmount
        {
            get { return _fromAmount; }
            set
            {
                _fromAmount = value;
                RaisePropertyChanged();
            }
        }

        private string _toAmount;

        public string ToAmount
        {
            get { return _toAmount; }
            set
            {
                _toAmount = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _fromDate;

        public DateTime? FromDate
        {
            get { return _fromDate; }
            set
            {
                _fromDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _toDate;

        public DateTime? ToDate
        {
            get { return _toDate; }
            set
            {
                _toDate = value;
                RaisePropertyChanged();
            }
        }


        public async Task Load()
        {
            var branchesResult = await Api.GetBranches();
            if (!branchesResult.Successful.GetValueOrDefault() &&
                !string.IsNullOrEmpty(branchesResult.ExceptionMessage))
            {
                await Alert.DisplayApiCallError(branchesResult.ExceptionMessage, branchesResult.ValidationErrors);
                return;
            }

            var branchList = branchesResult.Data.OrderBy(p=>p.Code).ToList();
            //Default branch
            branchList.Insert(0, new BranchView
            {
                Description = nameof(AppResources.SelectPlant).Translate()
            });
            BranchList = new ObservableCollection<BranchView>(branchList);
            SelectedBranch = _branchList.FirstOrDefault();

            StatusList = new ObservableCollection<KeyValuePair<SalesInquiryContextFilter, string>>
           {
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Active, nameof(AppResources.Active).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Created, nameof(AppResources.Created).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Sent,nameof(AppResources.Sent).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Confirmed,nameof(AppResources.Confirmed).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Lost,nameof(AppResources.Lost).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.Cancelled,nameof(AppResources.Cancelled).Translate()),
               new KeyValuePair<SalesInquiryContextFilter, string>(SalesInquiryContextFilter.All,nameof(AppResources.All).Translate())

           };
            SelectedStatus = _statusList[0];

            LeadTimeList = new ObservableCollection<KeyValuePair<SalesInquiryContextLeadTime, string>>{
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.None,nameof(AppResources.None).Translate()),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month1,$"<1 {nameof(AppResources.Month).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month3,$"<3 {nameof(AppResources.Months).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month6,$"<6 {nameof(AppResources.Months).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month9,$"<9 {nameof(AppResources.Months).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month12,$"<12 {nameof(AppResources.Months).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.Month24,$"<24 {nameof(AppResources.Months).Translate()}"),
               new KeyValuePair<SalesInquiryContextLeadTime, string>(SalesInquiryContextLeadTime.MonthMax,$">24 {nameof(AppResources.Months).Translate()}"),

           };
            SelectedLeadTime = _leadTimeList.First();


            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(PipelineSortColumn.Plant, nameof(AppResources.Plant).Translate()),
                new SortColumnItem(PipelineSortColumn.Quotation, nameof(AppResources.Quotation).Translate()),
                new SortColumnItem(PipelineSortColumn.AccountName, nameof(AppResources.AccountName).Translate()),
                new SortColumnItem(PipelineSortColumn.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(PipelineSortColumn.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(PipelineSortColumn.Amount, nameof(AppResources.Amount).Translate()),
                new SortColumnItem(PipelineSortColumn.CustomerRef, nameof(AppResources.CustomerRef).Translate()),
                new SortColumnItem(PipelineSortColumn.Percent, "%"),
                new SortColumnItem(PipelineSortColumn.LeadTime, nameof(AppResources.LeadTime).Translate()),
                new SortColumnItem(PipelineSortColumn.DateCreated, nameof(AppResources.DateCreated).Translate()),
                new SortColumnItem(PipelineSortColumn.SalesResponsible, nameof(AppResources.SalesResponsible).Translate()),
                new SortColumnItem(PipelineSortColumn.ExpiryDate, nameof(AppResources.ExpiryDate).Translate()),
                new SortColumnItem(PipelineSortColumn.Notes, nameof(AppResources.Notes).Translate()),
                new SortColumnItem(PipelineSortColumn.ContactName, nameof(AppResources.ContactName).Translate()),
                new SortColumnItem(PipelineSortColumn.FollowUpDate, nameof(AppResources.FollowUpDate).Translate()),
            };
            SelectedSortColumn = _sortColumns[0];
            ToDate = null;
            FromDate = null;

        }

        public SalesInquiryContext ToFilter()
        {

            var filter = new SalesInquiryContext
            {
                SalesGroup = SettingsService.Instance.MyInfo.CurrentUser.SalesRepTag,
                AccountName = this.AccountName,
                AccountNo = this.AccountNumber,
                Filter = this.SelectedStatus.Key,
                FromAmount = this.FromAmount?.ToNullableDouble(),
                ToAmount = this.ToAmount?.ToNullableDouble(),
                FromExpiryDate = this.FromDate,
                ToExpiryDate = this.ToDate,
                InventSiteId = this.SelectedBranch?.Code,
                LeadTime = this.SelectedLeadTime.Key,
                SalesResponsible = string.IsNullOrWhiteSpace(_salesResponsible) ? null : $"{this.SalesResponsible.Trim()}*",
                Probability = this.Probability?.ToNullableDouble(),
            };
            return filter;
        }
    }


    public enum PipelineSortColumn
    {
        Plant,
        Quotation,
        AccountName,
        Status,
        AccountNumber,
        Amount,
        CustomerRef,
        DateCreated,
        LeadTime,
        SalesResponsible,
        ExpiryDate,
        Notes,
        ContactName,
        FollowUpDate,
        Percent,
    }
}