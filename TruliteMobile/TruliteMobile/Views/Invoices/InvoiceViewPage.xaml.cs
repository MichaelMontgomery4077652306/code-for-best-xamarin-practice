using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Invoices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoiceViewPage : ContentPage
    {
        private readonly InvoiceViewPageViewModel _vm;

        public InvoiceViewPage(Invoice invoice, bool loadFromServer = false)
        {
            InitializeComponent();
            BindingContext = _vm = new InvoiceViewPageViewModel(invoice, loadFromServer);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class InvoiceViewPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private readonly bool _loadFromServer;

        private Invoice _invoice;

        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                _invoice = value;
                RaisePropertyChanged();
            }
        }

        private bool _showHeaderFrame;

        public bool ShowHeaderFrame
        {
            get { return _showHeaderFrame; }
            set
            {
                _showHeaderFrame = value;
                RaisePropertyChanged();
            }
        }

        private bool _showLines;

        public bool ShowLines
        {
            get { return _showLines; }
            set
            {
                _showLines = value;
                RaisePropertyChanged();
            }
        }


        private bool _showTotals;

        public bool ShowTotals
        {
            get { return _showTotals; }
            set
            {
                _showTotals = value;
                RaisePropertyChanged();
            }
        }

        private bool _showBillingShipping;
        private InvoiceSettlement _settlement;

        public bool ShowBillingShipping
        {
            get { return _showBillingShipping; }
            set
            {
                _showBillingShipping = value;
                RaisePropertyChanged();
            }
        }


        private bool _showSettlement;

        public bool ShowSettlement
        {
            get { return _showSettlement; }
            set
            {
                _showSettlement = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<InvoiceSettlement> _settlements;

        public ObservableCollection<InvoiceSettlement> Settlements
        {
            get { return _settlements; }
            set
            {
                _settlements = value;
                RaisePropertyChanged();
            }
        }

        private bool _showActionsFrame;

        public bool ShowActionsFrame
        {
            get { return _showActionsFrame; }
            set
            {
                _showActionsFrame = value;
                RaisePropertyChanged();
            }
        }



        private ObservableCollection<SortColumnItem> _sortColumns;
        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
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

        #endregion
        #region Commands

        public ICommand ViewPdfCommand { get; }
        public ICommand DownloadPdfCommand { get; }
        public ICommand ToggleHeaderFrameCommand { get; }

        public ICommand OpenSalesOrderCommand { get; }

        public ICommand ToggleLinesCommand { get; }

        public ICommand ToggleTotalsCommand { get; }
        public ICommand ToggleBillingShippingCommand { get; }

        public ICommand ToggleSettlementCommand { get; }
        public ICommand ToggleActionsFrameCommand { get; }
        public ICommand FilterTriggerCommand { get; }
        #endregion
        public InvoiceViewPageViewModel(Invoice invoice, bool loadFromServer)
        {
            _loadFromServer = loadFromServer;
            Invoice = invoice;
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            DownloadPdfCommand = new AsyncDelegateCommand(OnDownloadPdf);
            ToggleHeaderFrameCommand = new Command(() => ShowHeaderFrame = !_showHeaderFrame);
            OpenSalesOrderCommand = new AsyncDelegateCommand(OnOpenSalesOrder);
            ToggleLinesCommand = new Command<bool>((b) => ShowLines = b);
            ToggleTotalsCommand = new Command<bool>((b) => ShowTotals = b);
            ToggleBillingShippingCommand = new Command<bool>((b) => ShowBillingShipping = b);
            ToggleSettlementCommand = new Command<bool>((b) => ShowSettlement = b);
            ToggleActionsFrameCommand = new Command<bool>((isExpanded) => ShowActionsFrame = isExpanded);
            
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(InvoiceSettlementSortColumns.AccountNo,
                    nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(InvoiceSettlementSortColumns.Account,
                nameof(AppResources.Account).Translate()),
                new SortColumnItem(InvoiceSettlementSortColumns.InvoiceId,
                    nameof(AppResources.InvoiceId).Translate()),
                new SortColumnItem(InvoiceSettlementSortColumns.Date,
                    nameof(AppResources.Date).Translate()),
                new SortColumnItem(InvoiceSettlementSortColumns.Amount,
                    nameof(AppResources.Amount).Translate()),
                new SortColumnItem(InvoiceSettlementSortColumns.Text,
                    nameof(AppResources.Text).Translate()),
            };
            SelectedSortColumn = _sortColumns[0];
            FilterTriggerCommand = new Command<SortColumnItem>(OnSort);

        }

        private void OnSort(SortColumnItem sortColumn)
        {
            if (sortColumn == null) return;
            var list = _settlements.ToList();
            switch (sortColumn.Key.ObjectToEnum<InvoiceSettlementSortColumns>())
            {
                case InvoiceSettlementSortColumns.AccountNo:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CustomerId).ToList()
                        : list.OrderByDescending(p => p.CustomerId).ToList();
                    break;
                case InvoiceSettlementSortColumns.Account:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CustomerName).ToList()
                        : list.OrderByDescending(p => p.CustomerName).ToList();
                    break;
                case InvoiceSettlementSortColumns.InvoiceId:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.InvoiceId).ToList()
                        : list.OrderByDescending(p => p.InvoiceId).ToList();
                    break;
                case InvoiceSettlementSortColumns.Date:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.TransactionDate.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.TransactionDate.GetValueOrDefault()).ToList();
                    break;
                case InvoiceSettlementSortColumns.Amount:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.SettlementAmount).ToList()
                        : list.OrderByDescending(p => p.SettlementAmount).ToList();
                    break;
                case InvoiceSettlementSortColumns.Text:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.SettlementTransactionText).ToList()
                        : list.OrderByDescending(p => p.SettlementTransactionText).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Settlements = new ObservableCollection<InvoiceSettlement>(list);
        }


        private async Task OnOpenSalesOrder()
        {
            await NavigateTo(new OrderDetailLinesPage(_invoice.Order));
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                if (_loadFromServer)
                {
                    InvoicesFilterModel filter = new InvoicesFilterModel
                    {
                        Number = _invoice.Key,
                        Status= new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.None,null)
                    };

                    var result = await Api.GetInvoiceList(filter);

                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                        return;
                    }


                    if ((!result.Data?.Any()) ?? true)
                    {
                        await Alert.ShowMessage("Server did not return an invoice");
                        return;

                    }

                    var invoice = result.Data.First().CloneToType<InvoiceModel, Invoice>();
                    Invoice = invoice;
                }
                var listResponse = await Api.GetInvoiceLines(_invoice);
                Invoice.Lines = listResponse.Data;



                long.TryParse(_invoice.RecId, out var invoiceLongId);
                InvoiceSettlementsQueryContext settlementContext = new InvoiceSettlementsQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    InvoiceRecId = invoiceLongId
                };
                var settlementResult = await Api.GetInvoiceSettlements(settlementContext);
                if (!settlementResult.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(settlementResult.ExceptionMessage, settlementResult.ValidationErrors);
                    return;
                }

                Settlements = new ObservableCollection<InvoiceSettlement>(settlementResult.Data);
                NoResults = !_settlements.Any();

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



        private async Task OnDownloadPdf()
        {

            try
            {
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetInvoiceCopy(_invoice.Key);
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile($"Invoice{_invoice.Key}.pdf");
                Debug.WriteLine(path);
                File.WriteAllBytes(path, data);
                await Alert.ShowMessage($"File saved to: {path}");

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

        private async Task OnViewPdf()
        {
            try
            {
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetInvoiceCopy(_invoice.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Invoice {_invoice.Key}"));
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

    public enum InvoiceSettlementSortColumns
    {
        AccountNo,
        Account,
        InvoiceId,
        Date,
        Amount,
        Text
    }
}