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
using TruliteMobile.Views.RetunedOrders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Settlements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettlementsFilterView : ContentView
    {

        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create("SearchCommand", typeof(ICommand), typeof(SettlementsFilterView), default(ICommand));

        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }



        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(SettlementsFilterView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand)GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }



        private SettlementsFilterModel _filter;

        public SettlementsFilterModel Filter
        {
            get { return _filter; }
            set
            {
                _filter = value;
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


        private ObservableCollection<SortColumnItem> _sortColumns;


        public SettlementsFilterView()
        {
            InitializeComponent();
            Filter = new SettlementsFilterModel();

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(SettlementsSortColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(SettlementsSortColumns.Account, nameof(AppResources.Account).Translate()),
                new SortColumnItem(SettlementsSortColumns.PaidBy, nameof(AppResources.PaidBy).Translate()),
                new SortColumnItem(SettlementsSortColumns.Date, nameof(AppResources.Date).Translate()),
                new SortColumnItem(SettlementsSortColumns.MoneyOnAccount, nameof(AppResources.MoneyOnAccount).Translate()),
                new SortColumnItem(SettlementsSortColumns.Note, nameof(AppResources.Note).Translate()),

            };
            Children[0].BindingContext = this;
            Filter.SelectedSortColumn = _sortColumns[3];

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Filter.StartDate == null)
            {
                await AlertService.Instance.ShowMessage(nameof(AppResources.FromDateCannotBeNull).Translate());
                return;
            }
            if (Filter.EndDate == null)
            {
                await AlertService.Instance.ShowMessage(nameof(AppResources.ToDateCannotBeNull).Translate());
                return;
            }
            SearchCommand?.Execute(_filter.CloneJson());
        }

        private void ResetFormView_Tapped(object sender, EventArgs e)
        {

            if (SettingsService.Instance.ApplicationMode == ApplicationModeEnum.Pipeline)
            {
                Filter = new SettlementsFilterModel
                {
                    StartDate = null,
                    EndDate = null
                };
            }
            else
            {
                Filter = new SettlementsFilterModel();
            }

        }
    }

    public enum SettlementsSortColumns
    {
        AccountNumber,
        Account,
        PaidBy,
        Date,
        MoneyOnAccount,
        Note,
    }



    public class SettlementsFilterModel : ObservableObject
    {
        private DateTime? _startDate;

        public DateTime? StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _endDate;

        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                RaisePropertyChanged();
            }
        }

        public SettlementsFilterModel()
        {
            if (SettingsService.Instance.ApplicationMode == ApplicationModeEnum.Pipeline)
            {
                StartDate = DateTime.Today.AddMonths(-2);
            }
            else
            {
                StartDate = DateTime.Today.AddDays(-14);
            }
            EndDate = DateTime.Today;
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
    }
}