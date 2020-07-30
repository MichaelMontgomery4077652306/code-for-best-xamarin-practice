using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using TruliteMobile.Components;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using TruliteMobile.Views.SupportTickets;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private readonly QuotesPageViewModel _vm;

        public QuotesPage()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new QuotesPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class QuotesPageViewModel : TruliteBaseViewModel
    {
        #region Properties

        private ObservableCollection<Quotation> _list;

        public ObservableCollection<Quotation> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }


        private Quotation _selectedQuote;

        public Quotation SelectedQuote
        {
            get { return _selectedQuote; }
            set
            {
                _selectedQuote = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Commands

        public ICommand OpenLinesCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterChangeCommand { get; }

        #endregion
        public QuotesPageViewModel()
        {

            OpenLinesCommand = new AsyncDelegateCommand(OnOpenLines);
            SearchCommand = new AsyncDelegateCommand<QuoteFilter>(OnSearch);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
        }

        private SortColumnItem _previousSortColumnItem;
        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                IsBusy = true;
                await Load(_previousFilter, arg);
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task OnSearch(QuoteFilter arg)
        {
            ShowFilter = false;
            await Load(arg);

        }

        private async Task OnOpenLines()
        {
            if (_selectedQuote == null) return;
            await Nav.NavigateTo(new QuotesDetailLinePage(_selectedQuote));
        }


        private QuoteFilter _previousFilter;


        private bool IsFilterDifferentFromLast(QuoteFilter currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.Number != currentFilter.Number) return true;
            if (_previousFilter.AccountNumber != currentFilter.AccountNumber) return true;
            if (_previousFilter.SalesOrderNumber != currentFilter.SalesOrderNumber) return true;
            if (_previousFilter.EndDate != currentFilter.EndDate) return true;
            if (_previousFilter.StartDate != currentFilter.StartDate) return true;
            if (_previousFilter.SelectedStatus.Key != currentFilter.SelectedStatus.Key) return true;
            if (_previousFilter.SelectedQty != currentFilter.SelectedQty) return true;

            return false;

        }
        public async Task Load(QuoteFilter filter = null, SortColumnItem sortColumnItem = null)
        {
            try
            {
                IsBusy = true;
                ShowFilter = false;
                filter = filter ?? _previousFilter ?? new QuoteFilter
                {
                    StartDate = DateTime.Today.AddDays(-900),
                    EndDate = DateTime.Today
                };
                var sortColumn = sortColumnItem
                                ?? _previousSortColumnItem
                    ?? new SortColumnItem(QuotesSortableColumns.Quotation, null)
                    {
                        Ascending = true
                    };

                IEnumerable<Quotation> lines;
                if (IsFilterDifferentFromLast(filter))
                {

                    lines = await Api.GetQuotes(filter);
                    _previousFilter = filter;
                }
                else
                {
                    lines = _list;
                }
                var sortedLines = SortList(sortColumn, lines.ToList())
                    .Take(filter.SelectedQty)
                    .ToList();


                List = new ObservableCollection<Quotation>(sortedLines);
                NoResults = !sortedLines.Any();

            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private static ICollection<Quotation> SortList(SortColumnItem sortOrder, ICollection<Quotation> list)
        {
            switch (sortOrder.Key.ObjectToEnum<QuotesSortableColumns>())
            {

                case QuotesSortableColumns.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Key).ToList()
                        : list.OrderByDescending(p => p.Account.Key).ToList();

                    break;
                case QuotesSortableColumns.Account:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Name).ToList()
                        : list.OrderByDescending(p => p.Account.Name).ToList();
                    break;
                case QuotesSortableColumns.Quotation:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;
                case QuotesSortableColumns.Name:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DeliveryName).ToList()
                        : list.OrderByDescending(p => p.DeliveryName).ToList();
                    break;
                case QuotesSortableColumns.PurchaseOrder:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustPurchaseOrder).ToList()
                        : list.OrderByDescending(p => p.CustPurchaseOrder).ToList();
                    break;
                case QuotesSortableColumns.JobName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerRef).ToList()
                        : list.OrderByDescending(p => p.CustomerRef).ToList();
                    break;
                case QuotesSortableColumns.Plant:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.InventLocationName).ToList()
                        : list.OrderByDescending(p => p.InventLocationName).ToList();
                    break;
                case QuotesSortableColumns.Status:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Status).ToList()
                        : list.OrderByDescending(p => p.Status).ToList();
                    break;
                case QuotesSortableColumns.OrderNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Order?.Key).ToList()
                        : list.OrderByDescending(p => p.Order?.Key).ToList();
                    break;
                case QuotesSortableColumns.ExpiryDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ExpiryDate).ToList()
                        : list.OrderByDescending(p => p.ExpiryDate).ToList();
                    break;
                case QuotesSortableColumns.DeliveryAddress:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DeliveryAddress).ToList()
                        : list.OrderByDescending(p => p.DeliveryAddress).ToList();
                    break;
                case QuotesSortableColumns.ConfirmationDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ConfirmationDate).ToList()
                        : list.OrderByDescending(p => p.ConfirmationDate).ToList();
                    break;
                case QuotesSortableColumns.RequestedShipDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.RequestedShipDate).ToList()
                        : list.OrderByDescending(p => p.RequestedShipDate).ToList();
                    break;
                case QuotesSortableColumns.Lines:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.LinesCount).ToList()
                        : list.OrderByDescending(p => p.LinesCount).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
    }
}