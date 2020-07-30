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
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.RetunedOrders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnedOrdersFilterView : ContentView
    {
        public static readonly BindableProperty FilterTriggerCommandProperty =
           BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(ReturnedOrdersFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(ReturnedOrdersFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }


        private ObservableCollection<KeyValuePair<ReturnOrderQueryContextStatus, string>> _statusList;

        public ObservableCollection<KeyValuePair<ReturnOrderQueryContextStatus, string>> StatusList
        {
            get { return _statusList; }
            set
            {
                _statusList = value;
                OnPropertyChanged();
            }
        }

        private ReturnOrderQueryContext _filter;


        public ReturnOrderQueryContext Filter
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
        public ReturnedOrdersFilterView()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Filter = new ReturnOrderQueryContext();
            //Filter.AccountNumber = SettingsService.Instance.AxCustomerId;
            StatusList = new ObservableCollection<KeyValuePair<ReturnOrderQueryContextStatus, string>>
            {
                new KeyValuePair<ReturnOrderQueryContextStatus, string>(ReturnOrderQueryContextStatus.BackOrder,
                    nameof(AppResources.OpenOrder).Translate()),
                new KeyValuePair<ReturnOrderQueryContextStatus, string>(ReturnOrderQueryContextStatus.Invoiced,
                    nameof(AppResources.Invoiced).Translate()),
                new KeyValuePair<ReturnOrderQueryContextStatus, string>(ReturnOrderQueryContextStatus.Delivered,
                    nameof(AppResources.Delivered).Translate()),
            };
            Filter.Status = _statusList.First().Key;

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(ReturnedOrdersSortColumns.SalesOrder, nameof(AppResources.SalesOrder).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.Invoice, nameof(AppResources.Invoice).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.Amount, nameof(AppResources.Amount).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.OrderNumber, nameof(AppResources.OrderNumber).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.Status, nameof(AppResources.Status).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.ReturnDate, nameof(AppResources.ReturnDate).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.Lines, nameof(AppResources.LinesCamelCase).Translate()),
                new SortColumnItem(ReturnedOrdersSortColumns.Id, "Id"),

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

    public enum ReturnedOrdersSortColumns
    {
        SalesOrder,
        Invoice,
        Amount,
        OrderNumber,
        Status,
        ReturnDate,
        Lines,
        Id
    }
}