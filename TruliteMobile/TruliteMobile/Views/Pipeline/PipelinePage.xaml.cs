using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.Misc;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelinePage : ContentPage
    {
        private readonly PipelinePageViewModel _vm;

        public PipelinePage()
        {
            InitializeComponent();
            BindingContext = _vm = new PipelinePageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PipelinePageViewModel : TruliteBaseViewModel
    {


        private ObservableCollection<SalesQuotationInquiry> _pipelineList;

        public ObservableCollection<SalesQuotationInquiry> PipelineList
        {
            get { return _pipelineList; }
            set
            {
                _pipelineList = value;
                RaisePropertyChanged();
            }
        }

        private SalesQuotationInquiry _selectedItem;
        private SalesInquiryContext _previousFilter;
        private SortColumnItem _sortColumn;

        public SalesQuotationInquiry SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged();
            }
        }


        private double _listHeight;

        public double ListHeight
        {
            get { return _listHeight; }
            set
            {
                _listHeight = value;
                RaisePropertyChanged();
            }
        }



        private bool _forceRefresh;

        public ICommand FilterChangeCommand { get; }
        public ICommand SearchCommand { get; }

        public ICommand OpenLinesCommand { get; }

        public PipelinePageViewModel()
        {
            SearchCommand = new AsyncDelegateCommand<SalesInquiryContext>(OnSearch);
            OpenLinesCommand = new AsyncDelegateCommand(OnOpenLines);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
            MessengerInstance.Register<RefreshPipelineScreenMessage>(this, (m) => _forceRefresh = true);
        }
        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                if (_previousFilter == null)
                {
                    return;
                }
                IsBusy = true;
                ShowFilter = false;
                await Refresh(_previousFilter, arg);

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



        private static ICollection<SalesQuotationInquiry> SortList(SortColumnItem sortOrder, ICollection<SalesQuotationInquiry> list)
        {
            switch (sortOrder.Key.ObjectToEnum<PipelineSortColumn>())
            {

                case PipelineSortColumn.AccountNumber:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustAccount).ToList()
                        : list.OrderByDescending(p => p.CustAccount).ToList();
                    break;
                case PipelineSortColumn.Plant:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.InventLocationName).ToList()
                        : list.OrderByDescending(p => p.InventLocationName).ToList();
                    break;
                case PipelineSortColumn.Quotation:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.QuotationId).ToList()
                        : list.OrderByDescending(p => p.QuotationId).ToList();
                    break;
                case PipelineSortColumn.AccountName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustName).ToList()
                        : list.OrderByDescending(p => p.CustName).ToList();
                    break;
                case PipelineSortColumn.Status:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Status).ToList()
                        : list.OrderByDescending(p => p.Status).ToList();
                    break;
                case PipelineSortColumn.Amount:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.TotalInvoiceAmount.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.TotalInvoiceAmount.GetValueOrDefault()).ToList();
                    break;
                case PipelineSortColumn.CustomerRef:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerRef).ToList()
                        : list.OrderByDescending(p => p.CustomerRef).ToList();
                    break;
                case PipelineSortColumn.Percent:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Probability.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.Probability.GetValueOrDefault()).ToList();
                    break;
                case PipelineSortColumn.LeadTime:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.LeadTime).ToList()
                        : list.OrderByDescending(p => p.LeadTime).ToList();
                    break;
                case PipelineSortColumn.DateCreated:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DateCreated.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateCreated.GetValueOrDefault()).ToList();
                    break;
                case PipelineSortColumn.SalesResponsible:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.SalesResponsible).ToList()
                        : list.OrderByDescending(p => p.SalesResponsible).ToList();
                    break;
                case PipelineSortColumn.ExpiryDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ExpiryDate.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.ExpiryDate.GetValueOrDefault()).ToList();
                    break;
                case PipelineSortColumn.Notes:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Note).ToList()
                        : list.OrderByDescending(p => p.Note).ToList();
                    break;
                case PipelineSortColumn.ContactName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ContactName).ToList()
                        : list.OrderByDescending(p => p.ContactName).ToList();
                    break;
                case PipelineSortColumn.FollowUpDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.FollowUpDate).ToList()
                        : list.OrderByDescending(p => p.FollowUpDate).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
        private async Task OnOpenLines()
        {
            if (_selectedItem == null) return;
            await Nav.NavigateTo(new PipelineDetailPage(_selectedItem));
        }

        private async Task OnSearch(SalesInquiryContext arg)
        {

            ShowFilter = false;
            await Refresh(arg);

        }

        public async Task Load()
        {

            var filter = _previousFilter ?? new SalesInquiryContext
            {
                SalesGroup = SettingsService.Instance.MyInfo.CurrentUser.SalesRepTag,
                Filter = SalesInquiryContextFilter.Active

            };

            await Refresh(filter);

        }

        private bool IsFilterDifferentFromLast(SalesInquiryContext currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.AccountName != currentFilter.AccountName) return true;
            if (_previousFilter.AccountNo != currentFilter.AccountNo) return true;
            if (_previousFilter.SalesResponsible != currentFilter.SalesResponsible) return true;
            if (_previousFilter.Filter != currentFilter.Filter) return true;
            if (_previousFilter.FromAmount != currentFilter.FromAmount) return true;
            if (_previousFilter.ToAmount != currentFilter.ToAmount) return true;
            if (_previousFilter.FromExpiryDate != currentFilter.FromExpiryDate) return true;
            if (_previousFilter.ToExpiryDate != currentFilter.ToExpiryDate) return true;
            if (_previousFilter.InventSiteId != currentFilter.InventSiteId) return true;
            if (_previousFilter.LeadTime != currentFilter.LeadTime) return true;
            if (_previousFilter.Probability != currentFilter.Probability) return true;
            return false;

        }

        private async Task Refresh(SalesInquiryContext filter, SortColumnItem sortColumnItem = null)
        {
            try
            {
                IsBusy = true;
                if (sortColumnItem == null)
                {
                    _sortColumn = new SortColumnItem(PipelineSortColumn.Plant, null)
                    {
                        Ascending = true
                    };

                }
                else
                {
                    _sortColumn = sortColumnItem.CloneJson();
                }
                IEnumerable<SalesQuotationInquiry> lines;
                if (_forceRefresh || IsFilterDifferentFromLast(filter))
                {

                    var result = await Api.GetSalesQuotationInquiry(filter);
                    if (!result.Successful.GetValueOrDefault() &&
                        !string.IsNullOrEmpty(result.ExceptionMessage))
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                        NoResults = true;
                        return;
                    }

                    lines = result.Data.ToList();
                    _previousFilter = filter;

                }
                else
                {
                    lines = _pipelineList;
                }


                var sortedLines = SortList(_sortColumn, lines.ToList())
                    .ToList();

                PipelineList = new ObservableCollection<SalesQuotationInquiry>(sortedLines);
                NoResults = !_pipelineList.Any();
                ListHeight = _pipelineList.Count * 80;
            }
            catch (Exception ex)
            {
                await Alert.DisplayError(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}