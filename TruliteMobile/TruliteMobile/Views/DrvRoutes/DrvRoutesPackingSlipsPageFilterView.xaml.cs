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
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.Views.PackingSlips;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvRoutesPackingSlipsPageFilterView : ContentView
    {


        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(DrvRoutesPackingSlipsPageFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(DrvRoutesPackingSlipsPageFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }
        private ObservableCollection<int> _qtyList;
        private PackingSlipsQueryContext _filter;



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

        private bool _ascending;
        private ObservableCollection<SortColumnItem> _sortColumns;

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                OnPropertyChanged();
            }
        }

        public PackingSlipsQueryContext Filter
        {
            get { return _filter; }
            set { _filter = value; OnPropertyChanged(); }
        }

        public ObservableCollection<int> QtyList
        {
            get { return _qtyList; }
            set
            {
                _qtyList = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _fromDate;

        public DateTime? FromDate
        {
            get { return _fromDate; }
            set
            {
                _fromDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _toDate;

        public DateTime? ToDate
        {
            get { return _toDate; }
            set
            {
                _toDate = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<string, string>> _statusList;

        public ObservableCollection<KeyValuePair<string, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                OnPropertyChanged();
            }
        }

        private KeyValuePair<string, string> _selectedStatus;

        public KeyValuePair<string, string> SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                OnPropertyChanged();
            }
        }

        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                _accountNumber = value;
                OnPropertyChanged();
            }
        }

        public DrvRoutesPackingSlipsPageFilterView()
        {
            InitializeComponent();
            QtyList = new ObservableCollection<int> { 50, 100, 150, 200 };

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(PackingSlipSortableColumns.AccountNumber,  nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Account, nameof(AppResources.Account).Translate() ),
                new SortColumnItem(PackingSlipSortableColumns.Plant,  nameof(AppResources.TrulitePlant).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.PackingSlip, nameof(AppResources.PackingSlip).Translate() ),
                new SortColumnItem(PackingSlipSortableColumns.OrderNumber,  nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.JobName,  nameof(AppResources.JobName).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.PurchaseOrder,  nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.OrderDate,  nameof(AppResources.OrderDate).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.RequestedDeliveryDate, nameof(AppResources.RequestedDeliveryDate).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.DateShipped, nameof(AppResources.DateShipped).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Sqft,  nameof(AppResources.Sqft).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.ClockIn, nameof(AppResources.ClockIn).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.ClockOut, nameof(AppResources.ClockOut).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Lines,  nameof(AppResources.LinesCamelCase).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Safety,  nameof(AppResources.Safety).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Status,nameof(AppResources.Status).Translate()),

            };

            StatusList = new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("All",nameof(AppResources.All).Translate()),
                new KeyValuePair<string, string>("Ready",nameof(AppResources.Ready).Translate()),
                new KeyValuePair<string, string>("Pending",nameof(AppResources.Pending).Translate())
            };

            ResetForm();
            Children[0].BindingContext = this;
            SelectedSortColumn = _sortColumns[7];
            SelectedStatus = _statusList[1];

        }

        private void ResetForm()
        {
            Filter = new PackingSlipsQueryContext { Status = _statusList[1].Key, SelectedQty = _qtyList.First() };
            ToDate = null;
            FromDate = null;
            Ascending = true;
            SelectedStatus = _statusList[1];

        }


        private void SearchButton_Clicked(object sender, EventArgs e)
        {

            _selectedSortColumn.Ascending = _ascending;
            var filter = _filter.CloneJson();
            filter.SortColumn = _selectedSortColumn;
            filter.FromShipDate = _fromDate;
            filter.ToShipDate = _toDate;
            filter.SelectedQty = 50;
            filter.Status = _selectedStatus.Key;
            if (!string.IsNullOrWhiteSpace(_accountNumber))
            {
                filter.CustomerInfo = new CustomerContext
                {
                    AXCustomerId = AccountNumber
                };
            }
            SearchCommand?.Execute(filter);
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}