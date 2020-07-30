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
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.PackingSlips
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PackinSlipsFilterView : ContentView
	{


        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(PackinSlipsFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand) GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(PackinSlipsFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }
        private ObservableCollection<int> _qtyList;
        private PackingSlipFilterModel _filter;



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

        public PackingSlipFilterModel Filter
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
        public PackinSlipsFilterView ()
		{
			InitializeComponent ();
            Init();
        }

        
        private void Init(bool resetExistingValues=false)
        {
            Filter = new PackingSlipFilterModel
            {
                AccountNumber = SettingsService.Instance.AxCustomerId,
                DateFrom = DateTime.Today.AddDays(-900),
                DateTo = DateTime.Today,
            };
            QtyList = new ObservableCollection<int> { 50, 100, 150, 200 };
            if (resetExistingValues|| _filter.SelectedQty==0)
            {
                Filter.SelectedQty = _qtyList.First();
            }
            
            Children[0].BindingContext = this;
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(PackingSlipSortableColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Account, nameof(AppResources.Account).Translate() ),
                new SortColumnItem(PackingSlipSortableColumns.PurchaseOrder, nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.JobName, nameof(AppResources.JobName).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.OrderNumber,nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Plant,nameof(AppResources.TrulitePlant).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.PackingSlip,nameof(AppResources.PackingSlip).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.OrderDate, nameof(AppResources.OrderDate).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.RequestedDeliveryDate, nameof(AppResources.RequestedDeliveryDate).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.DateShipped, nameof(AppResources.DateShipped).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Terms, nameof(AppResources.Terms).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Voucher,nameof(AppResources.Voucher).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Weight, nameof(AppResources.Weight).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Sqft, nameof(AppResources.SquareFoot).Translate()),
                new SortColumnItem(PackingSlipSortableColumns.Lines,nameof(AppResources.LinesCamelCase).Translate()),
                   };
            if (resetExistingValues || _selectedSortColumn == null)
            {
                SelectedSortColumn = _sortColumns[7];
                Ascending = true;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            SearchCommand?.Execute(_filter.CloneJson());
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init(true);
        }
    }

    public enum PackingSlipSortableColumns
    {
        AccountNumber,
        Account,
        PurchaseOrder,
        JobName,
        OrderNumber,
        Plant,
        PackingSlip,
        OrderDate,
        DateShipped,
        RequestedDeliveryDate,
        Terms,
        Weight,
        Sqft,
        Lines,
        Voucher,
        Safety,
        ClockIn,
        ClockOut,
        Status
    }
}