using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.PackingSlips
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackingSlipsSelectProofDeliveryBarcodePage : ContentPage
    {
        private readonly PackingSlipsSelectProofDeliveryBarcodePageViewModel _vm;

        public PackingSlipsSelectProofDeliveryBarcodePage(PackingSlip packingSlip)
        {
            InitializeComponent();
            BindingContext = _vm = new PackingSlipsSelectProofDeliveryBarcodePageViewModel(packingSlip);

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PackingSlipsSelectProofDeliveryBarcodePageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private readonly PackingSlip _packingSlip;


        private ObservableCollection<ProofOfDeliveryViewModel> _barcodes;

        public ObservableCollection<ProofOfDeliveryViewModel> Barcodes
        {
            get { return _barcodes; }
            set
            {
                _barcodes = value;
                RaisePropertyChanged();
            }
        }

        private ProofOfDeliveryViewModel _selectedBarcode;

        public ProofOfDeliveryViewModel SelectedBarcode
        {
            get { return _selectedBarcode; }
            set
            {
                _selectedBarcode = value;
                RaisePropertyChanged();
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }


        private bool _isAscending;

        public bool IsAscending
        {
            get { return _isAscending; }
            set
            {
                _isAscending = value;
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
        public ICommand BarcodeSelectedCommand { get; }
        public ICommand FilterTriggerCommand { get; }
        public PackingSlipsSelectProofDeliveryBarcodePageViewModel(PackingSlip packingSlip)
        {
            _packingSlip = packingSlip;
            IsAscending = true;
            Title = $"{nameof(AppResources.ProofsOfDeliveryFor).Translate()} {_packingSlip.Order.Key}";
            BarcodeSelectedCommand = new AsyncDelegateCommand(OnBarcodeSelected);
            FilterTriggerCommand = new Command<SortColumnItem>(OnFilterTriggered);
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem("barcode", nameof(AppResources.Barcode).Translate()),
                new SortColumnItem("dateScanned", nameof(AppResources.DateScanned).Translate())
            };
            SelectedSortColumn = SortColumns[0];
        }

        private void OnFilterTriggered(SortColumnItem sortColumn)
        {
            if(!( _barcodes?.Any()??false) || sortColumn?.Key==null)return;
            //IsAscending = !_isAscending;
            if (sortColumn.Key == "barcode")
            {
                Barcodes = _isAscending ? new ObservableCollection<ProofOfDeliveryViewModel>(_barcodes.OrderBy(p => p.Barcode))
                    : new ObservableCollection<ProofOfDeliveryViewModel>(_barcodes.OrderByDescending(p => p.Barcode));
            }
            else
            {
                Barcodes = _isAscending ? new ObservableCollection<ProofOfDeliveryViewModel>(_barcodes.OrderBy(p => p.DateCreated.GetValueOrDefault()))
                    : new ObservableCollection<ProofOfDeliveryViewModel>(_barcodes.OrderByDescending(p => p.DateCreated.GetValueOrDefault()));
            }
        }

        private async Task OnBarcodeSelected()
        {
            try
            {
                IsBusy = true;
                var context = new SalesOrderQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustomerPurchaseOrderNo = _packingSlip.CustomerPurchaseOrderNo,
                    SalesOrderNo = _packingSlip.Order.Key,
                    StartDate = _packingSlip.OrderDate,
                    EndDate = _packingSlip.OrderDate,
                };
                
                var data = await Api.GetProofOfDelivery(_selectedBarcode.Barcode, context);
              
                await Nav.NavigateTo(new PdfPage(data, $"{nameof(AppResources.ProofOfDeliveryFor).Translate()} {_packingSlip.Order.Key}"));
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                SelectedBarcode = null;
                IsBusy = false;
            }
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var context = new SalesOrderQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustomerPurchaseOrderNo = _packingSlip.CustomerPurchaseOrderNo,
                    SalesOrderNo = _packingSlip.Order.Key,
                    StartDate = _packingSlip.OrderDate,
                    EndDate = _packingSlip.OrderDate,
                };

                var data = await Api.GetOrderProofOfDeliveriesAsync(context);
                IsBusy = false;
                if (data == null)
                {
                    await Alert.ShowMessage(nameof(AppResources.CouldNotFindProofOfDelivery).Translate());
                    return;
                }

                var barcodes = data.Data.OrderBy(p=>p.Barcode).ToList();
                NoResults = !barcodes.Any();
                if (NoResults)
                {
                    await Alert.ShowMessage(nameof(AppResources.NoBarcodesAvailable).Translate());
                    Barcodes = new ObservableCollection<ProofOfDeliveryViewModel>();
                    return;
                }
                Barcodes = new ObservableCollection<ProofOfDeliveryViewModel>(barcodes);
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

        private async Task ViewPdf()
        {
            // await Nav.NavigateTo(new PdfPage(data, $"{nameof(AppResources.ProofOfDeliveryFor).Translate()} {_packingSlip.Order.Key}"));

        }

    }
}