using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Quotes
{
    public enum QuotesSortableColumns
    {
        AccountNumber,
        Account,
        Quotation,
        Name,
        PurchaseOrder,
        JobName,
        Plant,
        Status,
        OrderNumber,
        ExpiryDate,
        DeliveryAddress,
        ConfirmationDate,
        RequestedShipDate,
        Lines,
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteFilterView : ContentView
    {
        #region Public Properties

        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(QuoteFilterView), default(ICommand));

        public static readonly BindableProperty SearchCommandProperty =
                    BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(QuoteFilterView), default(ICommand));



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

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
                OnPropertyChanged();
            }
        }


        public QuoteFilter Filter
        {
            get { return _filter; }
            set
            {
                _filter = value;
                OnPropertyChanged();
            }
        }

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
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

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
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

        public ObservableCollection<KeyValuePair<QuotationsQueryContextStatus, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                OnPropertyChanged();
            }
        }

        #endregion Public Properties
        #region Private Fields

        private QuoteFilter _filter;

        private ObservableCollection<int> _qtyList;

        private ObservableCollection<SortColumnItem> _sortColumns;

        private ObservableCollection<KeyValuePair<QuotationsQueryContextStatus, string>> _statusList;

        #endregion Private Fields

        #region Public Constructors

        public QuoteFilterView()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Filter = new QuoteFilter();
            QtyList = new ObservableCollection<int> {50, 100, 150, 200};

            Filter.SelectedQty = _qtyList.First();
            StatusList = new ObservableCollection<KeyValuePair<QuotationsQueryContextStatus, string>>
            {
                new KeyValuePair<QuotationsQueryContextStatus, string>(QuotationsQueryContextStatus.None,
                    nameof(AppResources.SelectStatus).Translate()),
                new KeyValuePair<QuotationsQueryContextStatus, string>(QuotationsQueryContextStatus.Created,
                    nameof(AppResources.Created).Translate()),
                new KeyValuePair<QuotationsQueryContextStatus, string>(QuotationsQueryContextStatus.Sent,
                    nameof(AppResources.Sent).Translate()),
                new KeyValuePair<QuotationsQueryContextStatus, string>(QuotationsQueryContextStatus.Confirmed,
                    nameof(AppResources.Confirmed).Translate()),
            };
            Filter.SelectedStatus = _statusList.First();


            Filter.StartDate = DateTime.Today.AddDays(-900);
            Filter.EndDate = DateTime.Today;

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(QuotesSortableColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(QuotesSortableColumns.Account, nameof(AppResources.Account).Translate()),
                new SortColumnItem(QuotesSortableColumns.Quotation, nameof(AppResources.Quotation).Translate()),
                new SortColumnItem(QuotesSortableColumns.Name, nameof(AppResources.DeliveryName).Translate()),
                new SortColumnItem(QuotesSortableColumns.PurchaseOrder, nameof(AppResources.PurchaseOrder).Translate()),
                new SortColumnItem(QuotesSortableColumns.JobName, nameof(AppResources.JobName).Translate()),
                new SortColumnItem(QuotesSortableColumns.Plant, nameof(AppResources.TrulitePlant).Translate()),
                new SortColumnItem(QuotesSortableColumns.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(QuotesSortableColumns.OrderNumber, nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(QuotesSortableColumns.ExpiryDate, nameof(AppResources.ExpiryDate).Translate()),
                new SortColumnItem(QuotesSortableColumns.DeliveryAddress, nameof(AppResources.DeliveryAddress).Translate()),
                new SortColumnItem(QuotesSortableColumns.ConfirmationDate, nameof(AppResources.ConfirmationDate).Translate()),
                new SortColumnItem(QuotesSortableColumns.RequestedShipDate, nameof(AppResources.RequestedShipDate).Translate()),
                new SortColumnItem(QuotesSortableColumns.Lines, nameof(AppResources.LinesCamelCase).Translate()),
            };
            Ascending = true;
            Children[0].BindingContext = this;
            SelectedSortColumn = _sortColumns[2];
        }

        #endregion Public Constructors



        #region Private Methods

        private void Button_Clicked(object sender, EventArgs e)
        {
            SearchCommand?.Execute(_filter.CloneJson());
        }

        #endregion Private Methods

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            Init();
        }
    }
}