using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Orders
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrdersFilterView : ContentView
	{
        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(OrdersFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand) GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(OrdersFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }


        private ObservableCollection<KeyValuePair<SalesOrderQueryContextStatus, string>> _statusList;

        public ObservableCollection<KeyValuePair<SalesOrderQueryContextStatus, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<int> _qtyList;
        private OrderFilter _filter;

        public ObservableCollection<int> QtyList
        {
            get { return _qtyList; }
            set
            {
                _qtyList = value;
                OnPropertyChanged();
            }
        }

        public OrderFilter Filter
        {
            get { return _filter; }
            set { _filter = value; OnPropertyChanged(); }
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
        public OrdersFilterView ()
        {
            InitializeComponent ();
            Init();
        }

        private void Init()
        {
            Filter = new OrderFilter();
            QtyList = new ObservableCollection<int> {50, 100, 150, 200};
            Filter.SelectedQty = _qtyList.First();
            //Filter.AccountNumber = SettingsService.Instance.AxCustomerId;
            StatusList = new ObservableCollection<KeyValuePair<SalesOrderQueryContextStatus, string>>
            {
                new KeyValuePair<SalesOrderQueryContextStatus, string>(SalesOrderQueryContextStatus.BackOrder,
                    nameof(AppResources.OpenOrder).Translate()),
                new KeyValuePair<SalesOrderQueryContextStatus, string>(SalesOrderQueryContextStatus.Invoiced,
                    nameof(AppResources.Invoiced).Translate()),
                new KeyValuePair<SalesOrderQueryContextStatus, string>(SalesOrderQueryContextStatus.Delivered,
                    nameof(AppResources.Delivered).Translate()),
            };
            Filter.SelectedStatus = _statusList.First();

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(OrdersSortableColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(OrdersSortableColumns.Account, nameof(AppResources.Account).Translate()),
                new SortColumnItem(OrdersSortableColumns.PurchaseOrder, nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(OrdersSortableColumns.JobName, nameof(AppResources.JobName).Translate()),
                new SortColumnItem(OrdersSortableColumns.OrderNumber, nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(OrdersSortableColumns.Plant, nameof(AppResources.TrulitePlant).Translate()),
                new SortColumnItem(OrdersSortableColumns.Invoices, nameof(AppResources.Invoices).Translate()),
                new SortColumnItem(OrdersSortableColumns.Amount, nameof(AppResources.Amount).Translate()),
                new SortColumnItem(OrdersSortableColumns.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(OrdersSortableColumns.OrderDate, nameof(AppResources.OrderDate).Translate()),
                new SortColumnItem(OrdersSortableColumns.DeliveryDate, nameof(AppResources.DeliveryDate).Translate()),
                new SortColumnItem(OrdersSortableColumns.Lines, nameof(AppResources.LinesCamelCase).Translate()),
                new SortColumnItem(OrdersSortableColumns.PackingSlips, nameof(AppResources.PackingSlip).Translate()),
            };
            Children[0].BindingContext = this;
            SelectedSortColumn = _sortColumns[4];
            Ascending = true;
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            SearchCommand?.Execute(Filter.CloneJson());
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init();
        }
    }

    public enum OrdersSortableColumns
    {
        AccountNumber,
        Account,
        PurchaseOrder,
        JobName,
        Plant,
        Status,
        OrderNumber,
        DeliveryDate,
        Lines,
        Amount,
        OrderDate,
        PackingSlips,
        //ProofOfDelivery
        Invoices
    }
}