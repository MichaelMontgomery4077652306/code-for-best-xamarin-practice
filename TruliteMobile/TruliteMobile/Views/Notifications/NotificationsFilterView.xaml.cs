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
using TruliteMobile.Views.Orders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Notifications
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationsFilterView : ContentView
    {

        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(OrdersFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(NotificationsFilterView),
                default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }


        private DateTime? _startDate;

        public DateTime? StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime? _endDate;

        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
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
        public NotificationsFilterView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
            ResetFilterValues();
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {
            ResetFilterValues();
        }

        private void ResetFilterValues()
        {
            StartDate = DateTime.Now.Date.AddDays(-90);
            EndDate = DateTime.Now.Date;
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(NotificationSortColumns.RecordId, nameof(AppResources.RecordId).Translate()),
                new SortColumnItem(NotificationSortColumns.Date, nameof(AppResources.Date).Translate()),
                new SortColumnItem(NotificationSortColumns.Read, nameof(AppResources.Read).Translate()),
                new SortColumnItem(NotificationSortColumns.Type, nameof(AppResources.Type).Translate()),
                };
            SelectedSortColumn = _sortColumns[0];
            Ascending = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            SearchCommand?.Execute(new NotificationFilter
            {
                StartDate = _startDate,
                EndDate = _endDate,
                SortColumn = (NotificationSortColumns) _selectedSortColumn.Key,
                Ascending = _ascending
            });
        }

    }

    public class NotificationFilter
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Ascending { get; set; }
        public NotificationSortColumns SortColumn { get; set; }
    }

    public enum NotificationSortColumns
    {
        RecordId,
        Date,
        Read,
        Type
    }
}