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
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.PackingSlips;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Invoices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoicesFilterView : ContentView
    {
        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(InvoicesFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }



        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(InvoicesFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }


        public static readonly BindableProperty ModeProperty =
            BindableProperty.Create("Mode", typeof(InvoicePageDefaultMode), typeof(InvoicesFilterView), default(InvoicePageDefaultMode), BindingMode.Default,null, ModePropertyChanged);

        private static void ModePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            ((InvoicesFilterView)bindable).Init();
        }

        public InvoicePageDefaultMode Mode
        {
            get { return (InvoicePageDefaultMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        private ObservableCollection<int> _qtyList;
        private InvoicesFilterModel _filter;



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

        public ObservableCollection<int> QtyList
        {
            get { return _qtyList; }
            set
            {
                _qtyList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<InvoicesQueryContextStatus, string>> _invoiceStatusList;

        public ObservableCollection<KeyValuePair<InvoicesQueryContextStatus, string>> InvoiceStatusList
        {
            get { return _invoiceStatusList; }
            set
            {
                _invoiceStatusList = value;
                OnPropertyChanged();
            }
        }

        public InvoicesFilterModel Filter
        {
            get { return _filter; }
            set { _filter = value; OnPropertyChanged(); }
        }

        public InvoicesFilterView()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Filter = new InvoicesFilterModel();
            QtyList = new ObservableCollection<int> { 50, 100, 150, 200 };
            InvoiceStatusList = new ObservableCollection<KeyValuePair<InvoicesQueryContextStatus, string>>
            {
                new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.None,  nameof(AppResources.All).Translate()),
                new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.NotPaid,  nameof(AppResources.NotPaid).Translate()),
                new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.Paid,  nameof(AppResources.Paid).Translate()),
            };


            Filter.SelectedQty = _qtyList.First();
            Filter.StartDate = (Mode == InvoicePageDefaultMode.All) ? DateTime.Today.AddDays(-365) : default(DateTime?);
            Filter.EndDate = (Mode == InvoicePageDefaultMode.All) ? DateTime.Today : default(DateTime?);
            Children[0].BindingContext = this;
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(InvoiceSortableColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Account,  nameof(AppResources.Account).Translate()),
                new SortColumnItem(InvoiceSortableColumns.PurchaseOrder,  nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(InvoiceSortableColumns.JobName, nameof(AppResources.JobName).Translate()),
                new SortColumnItem(InvoiceSortableColumns.OrderNumber, nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Plant, nameof(AppResources.TrulitePlant).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Invoice,  nameof(AppResources.Invoice).Translate()),
                new SortColumnItem(InvoiceSortableColumns.InvoiceDate, nameof(AppResources.InvoiceDate).Translate()),
                new SortColumnItem(InvoiceSortableColumns.DueDate,nameof(AppResources.DueDate).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Amount,nameof(AppResources.OpenAmount).Translate()),
                new SortColumnItem(InvoiceSortableColumns.TotalInvoiceAmount,nameof(AppResources.TotalInvoiceAmount).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Status,nameof(AppResources.Status).Translate()),
                new SortColumnItem(InvoiceSortableColumns.SalesPerson, nameof(AppResources.SalesPerson).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Terms,  nameof(AppResources.Terms).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Weight,  nameof(AppResources.Weight).Translate()),
                new SortColumnItem(InvoiceSortableColumns.Sqft,  nameof(AppResources.SquareFoot).Translate()),
            };
            SelectedSortColumn = _sortColumns[7];
            Ascending = true;
            switch (Mode)
            {
                case InvoicePageDefaultMode.All:
                    Filter.Status = _invoiceStatusList[0];
                    break;
                case InvoicePageDefaultMode.Open:
                    Filter.Status = _invoiceStatusList[1];
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Mode == InvoicePageDefaultMode.Open)
            {
                Filter.Status = _invoiceStatusList[1];
            }

            if (Filter.StartDate.HasValue && Filter.EndDate.HasValue)
            {
                if ((Filter.EndDate.Value - Filter.StartDate.Value).TotalDays > 365)
                {
                    await AlertService.Instance.ShowMessage(nameof(AppResources.DateDiffLessThan365).Translate());
                    return;
                }
            }

            SearchCommand?.Execute(Filter.CloneJson());
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init();
        }
    }
    public enum InvoiceSortableColumns
    {
        AccountNumber,
        Account,
        PurchaseOrder,
        JobName,
        Invoice,
        InvoiceDate,
        DueDate,
        OrderNumber,
        Amount,
        Status,
        Terms,
        Plant,
        SalesPerson,
        Weight,
        Sqft,
        TotalInvoiceAmount
    }
}