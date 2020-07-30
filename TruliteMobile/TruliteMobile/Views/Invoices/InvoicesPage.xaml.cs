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
using TruliteMobile.Views.InvoicePayment;
using TruliteMobile.Views.LienWaiver;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Pdf;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Invoices
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class InvoicesPage : ContentPage
  {
    private readonly InvoicesPageViewModel _vm;

    private InvoicePageDefaultMode _invoicePageDefaultMode;

    public InvoicesPage()
    {
      InitializeComponent();
      BindingContext = _vm = new InvoicesPageViewModel();

    }

    public InvoicePageDefaultMode InvoicePageDefaultMode
    {
      get { return _invoicePageDefaultMode; }
      set { _invoicePageDefaultMode = value; }
    }

    protected override async void OnAppearing()
    {
      _vm.DefaultMode = _invoicePageDefaultMode;
      await _vm.Load();


    }
  }

  public enum InvoicePageDefaultMode
  {
    All,
    Open
  }

  public class InvoicesPageViewModel : TruliteBaseViewModel
  {


    #region Proprieties

    private InvoicePageDefaultMode _defaultMode;

    public InvoicePageDefaultMode DefaultMode
    {
      get { return _defaultMode; }
      set
      {
        _defaultMode = value;
        RaisePropertyChanged();
      }
    }

    private ObservableCollection<InvoiceModel> _list;

    public ObservableCollection<InvoiceModel> List
    {
      get { return _list; }
      set
      {
        _list = value;
        RaisePropertyChanged();
      }
    }


    private InvoiceModel _selectedInvoice;

    public InvoiceModel SelectedInvoice
    {
      get { return _selectedInvoice; }
      set
      {
        _selectedInvoice = value;
        RaisePropertyChanged();
      }
    }


    private int _rowCount;

    public int RowCount
    {
      get { return _rowCount; }
      set
      {
        _rowCount = value;
        RaisePropertyChanged();
      }
    }

    private decimal _totalAmount;

    public decimal TotalAmount
    {
      get { return _totalAmount; }
      set
      {
        _totalAmount = value;
        RaisePropertyChanged();
      }
    }

    private bool _showLastLine;

    public bool ShowLastLine
    {
      get { return _showLastLine; }
      set
      {
        _showLastLine = value;
        RaisePropertyChanged();
      }
    }

    #endregion
    #region Command
    public ICommand PayInvoicesCommand { get; }
    public ICommand PayPartialCommand { get; }
    public ICommand AddMoneyOnAccountCommand { get; }

    public ICommand LienWaiverCommand { get; }
    public ICommand OpenInvoiceCommand { get; }
    public ICommand SearchCommand { get; }
    public ICommand FilterChangeCommand { get; }
    public ICommand IsSelectedChangedCommand { get; }
    #endregion
    public InvoicesPageViewModel()
    {
      PayInvoicesCommand = new AsyncDelegateCommand(OnPayInvoices);
      PayPartialCommand = new AsyncDelegateCommand(OnPayPartial);
      AddMoneyOnAccountCommand = new AsyncDelegateCommand(OnAddMoneyOnAccount);
      LienWaiverCommand = new AsyncDelegateCommand(OnLienWaiver);
      OpenInvoiceCommand = new AsyncDelegateCommand(OnOpenInvoice);

      SearchCommand = new AsyncDelegateCommand<InvoicesFilterModel>(OnSearch);
      FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
      IsSelectedChangedCommand = new Command<InvoiceModel>(invoiceModel => invoiceModel.IsSelected = !invoiceModel.IsSelected);
    }

    private async Task OnPayPartial()
    {
      try
      {
        if (IsBusy) return;
        IsBusy = true;
        var selectedInvoices = _list.Where(p => p.IsSelected)
            .ToList();
        if (!selectedInvoices.Any())
        {
          await Alert.ShowMessage(nameof(AppResources.InvoiceScreenMessage1).Translate());
          return;
        }
        if (selectedInvoices.Sum(p => p.Amount.GetValueOrDefault()) == 0)
        {
          await Alert.ShowMessage(nameof(AppResources.TheSelectedAmountCannotBeZero).Translate());
          return;
        }

        await Nav.NavigateTo(new InvoicePaymentPage(selectedInvoices, PaymentRequest.PartialPayment));

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

    private async Task OnAddMoneyOnAccount()
    {
      try
      {
        if (IsBusy) return;
        IsBusy = true;
        await Nav.NavigateTo(new InvoicePaymentPage(new List<InvoiceModel>(), PaymentRequest.AddMoneyOnAccount));

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

    private InvoicesFilterModel _previousFilter;
    private async Task OnFilterChanged(SortColumnItem arg)
    {
      try
      {
        ShowFilter = false;
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

    private InvoicesFilterModel GetDefaultFilter()
    {
      return (_defaultMode == InvoicePageDefaultMode.Open) ? new InvoicesFilterModel() : new InvoicesFilterModel
      {
        Status = new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.None,
               nameof(AppResources.None).Translate()),
        SelectedQty = 50,
        StartDate = DateTime.Today.AddDays(-365),
        EndDate = DateTime.Today
      };
    }


    public async Task Load(InvoicesFilterModel filter = null, SortColumnItem sortColumnItem = null)
    {
      try
      {
        IsBusy = true;
        filter = filter ?? GetDefaultFilter();

        if (sortColumnItem == null)
        {
          sortColumnItem = new SortColumnItem(InvoiceSortableColumns.InvoiceDate, null) { Ascending = true };
        }
        IEnumerable<InvoiceModel> lines;
        if (IsFilterDifferentFromLast(filter))
        {

          var result = await Api.GetInvoiceList(filter);
          if (!result.Successful.GetValueOrDefault())
          {
            await Alert.ShowMessage(result.ExceptionMessage);
            return;
          }
          lines = new List<InvoiceModel>(result.Data.Select(p => p.CloneToType<InvoiceModel, Invoice>()));
        }
        else
        {
          lines = _list;
        }
        var sortedLines = SortList(sortColumnItem, lines.ToList())
            .Take(filter.SelectedQty);

        _previousFilter = filter;
        if (_list != null)
        {
          foreach (var invoiceModel in _list)
          {
            invoiceModel.PropertyChanged -= InvoiceModel_PropertyChanged;
          }
        }


        List = new ObservableCollection<InvoiceModel>(sortedLines);

        if (_list != null)
        {
          foreach (var invoiceModel in _list)
          {
            invoiceModel.PropertyChanged += InvoiceModel_PropertyChanged;
          }
        }

        NoResults = !(_list?.Any() ?? false);
        //TotalAmount = (decimal)sortedLines.Sum(p => p.Amount.GetValueOrDefault());

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

    private void InvoiceModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if (e.PropertyName != "IsSelected") return;
      var selectedInvoices = _list.Where(p => p.IsSelected).ToList();
      ShowLastLine = selectedInvoices.Any();
      if (!_showLastLine) return;
      RowCount = selectedInvoices.Count;
      TotalAmount = (decimal)selectedInvoices.Sum(p => p.Amount.GetValueOrDefault());

    }

    private static ICollection<InvoiceModel> SortList(SortColumnItem sortOrder, ICollection<InvoiceModel> list)
    {
      switch (sortOrder.Key.ObjectToEnum<InvoiceSortableColumns>())
      {

        case InvoiceSortableColumns.AccountNumber:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Key).ToList()
              : list.OrderByDescending(p => p.Account.Key).ToList();

          break;
        case InvoiceSortableColumns.Account:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Account.Name).ToList()
              : list.OrderByDescending(p => p.Account.Name).ToList();
          break;

        case InvoiceSortableColumns.PurchaseOrder:
          list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerPurchaseOrderNo).ToList()
              : list.OrderByDescending(p => p.CustomerPurchaseOrderNo).ToList();
          break;
        case InvoiceSortableColumns.JobName:
          list = sortOrder.Ascending ? list.OrderBy(p => p.CustomerRef).ToList()
              : list.OrderByDescending(p => p.CustomerRef).ToList();
          break;
        case InvoiceSortableColumns.Plant:
          list = sortOrder.Ascending ? list.OrderBy(p => p.InventLocationName).ToList()
              : list.OrderByDescending(p => p.InventLocationName).ToList();
          break;
        case InvoiceSortableColumns.Status:
          list = sortOrder.Ascending ? list.OrderBy(p => p.InvoiceStatus).ToList()
              : list.OrderByDescending(p => p.InvoiceStatus).ToList();
          break;
        case InvoiceSortableColumns.OrderNumber:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Order.Key).ToList()
              : list.OrderByDescending(p => p.Order.Key).ToList();
          break;

        case InvoiceSortableColumns.Invoice:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
              : list.OrderByDescending(p => p.Key).ToList();
          break;
        case InvoiceSortableColumns.InvoiceDate:
          list = sortOrder.Ascending ? list.OrderBy(p => p.InvoiceDate).ToList()
              : list.OrderByDescending(p => p.InvoiceDate).ToList();
          break;
        case InvoiceSortableColumns.DueDate:
          list = sortOrder.Ascending ? list.OrderBy(p => p.DueDate).ToList()
              : list.OrderByDescending(p => p.DueDate).ToList();
          break;
        case InvoiceSortableColumns.Amount:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Amount).ToList()
              : list.OrderByDescending(p => p.Amount).ToList();
          break;
        case InvoiceSortableColumns.TotalInvoiceAmount:
          list = sortOrder.Ascending ? list.OrderBy(p => p.TotalInvoiceAmount).ToList()
              : list.OrderByDescending(p => p.TotalInvoiceAmount).ToList();
          break;
        case InvoiceSortableColumns.Terms:
          list = sortOrder.Ascending ? list.OrderBy(p => p.Terms).ToList()
              : list.OrderByDescending(p => p.Terms).ToList();
          break;
        case InvoiceSortableColumns.SalesPerson:
          list = sortOrder.Ascending ? list.OrderBy(p => p.SalesPerson).ToList()
              : list.OrderByDescending(p => p.SalesPerson).ToList();
          break;
        case InvoiceSortableColumns.Weight:
          list = sortOrder.Ascending ? list.OrderBy(p => p.TotalWeight).ToList()
              : list.OrderByDescending(p => p.TotalWeight).ToList();
          break;
        case InvoiceSortableColumns.Sqft:
          list = sortOrder.Ascending ? list.OrderBy(p => p.TotalSqft).ToList()
              : list.OrderByDescending(p => p.TotalSqft).ToList();
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }

      return list;
    }
    private bool IsFilterDifferentFromLast(InvoicesFilterModel currentFilter)
    {
      if (_previousFilter == null) return true;
      if (_previousFilter.Number != currentFilter.Number) return true;
      if (_previousFilter.SalesOrderNumber != currentFilter.SalesOrderNumber) return true;
      if (_previousFilter.EndDueDate != currentFilter.EndDueDate) return true;
      if (_previousFilter.StartDueDate != currentFilter.StartDueDate) return true;
      if (_previousFilter.EndDate != currentFilter.EndDate) return true;
      if (_previousFilter.StartDate != currentFilter.StartDate) return true;
      if (_previousFilter.PONumber != currentFilter.PONumber) return true;
      if (_previousFilter.SelectedQty != currentFilter.SelectedQty) return true;

      return false;

    }
    private async Task OnSearch(InvoicesFilterModel arg)
    {
      ShowFilter = false;
      await Load(arg);
    }

    private async Task OnOpenInvoice()
    {
      try
      {
        if (IsBusy) return;
        IsBusy = true;
        if (_selectedInvoice == null) return;
        await Nav.NavigateTo(new InvoiceViewPage(_selectedInvoice));

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

    private async Task OnLienWaiver()
    {

      var selected = _list.Where(p => p.IsSelected).ToList();
      if (!selected.Any())
      {
        await Alert.ShowMessage(nameof(AppResources.InvoiceScreenMessage2).Translate());
        return;
      }
      try
      {
        if (IsBusy) return;
        IsBusy = true;
        await Nav.NavigateTo(new LienWaiverPage(selected));

      }
      finally
      {
        IsBusy = false;
      }

    }

    private async Task OnPayInvoices()
    {
      try
      {
        if (IsBusy) return;
        IsBusy = true;
        var selectedInvoices = _list.Where(p => p.IsSelected)
            .ToList();
        if (!selectedInvoices.Any())
        {
          await Alert.ShowMessage(nameof(AppResources.InvoiceScreenMessage1).Translate());
          return;
        }
        if (selectedInvoices.Sum(p => p.Amount.GetValueOrDefault()) == 0)
        {
          await Alert.ShowMessage(nameof(AppResources.TheSelectedAmountCannotBeZero).Translate());
          return;
        }

        await Nav.NavigateTo(new InvoicePaymentPage(selectedInvoices, PaymentRequest.FullPayment));

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
  }
}