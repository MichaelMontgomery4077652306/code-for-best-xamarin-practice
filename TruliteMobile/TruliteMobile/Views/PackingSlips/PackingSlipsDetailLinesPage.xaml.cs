using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
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

namespace TruliteMobile.Views.PackingSlips
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackingSlipsDetailLinesPage : ContentPage
    {
        private readonly PackingSlipsDetailLinesPageViewModel _vm;

        public PackingSlipsDetailLinesPage(PackingSlip slip, bool loadFromServer = false)
        {
            InitializeComponent();
            BindingContext = _vm = new PackingSlipsDetailLinesPageViewModel(slip, loadFromServer);

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PackingSlipsDetailLinesPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private readonly bool _loadFromServer;
        private string _title;

        private PackingSlip _packingSlip;

        public PackingSlip PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                _packingSlip = value;
                RaisePropertyChanged();
            }
        }


        public bool ShowHeaderFrame
        {
            get { return _showHeaderFrame; }
            set { _showHeaderFrame = value; RaisePropertyChanged(); }
        }


        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<int, PackingSlipLine>> _list;
        private bool _showHeaderFrame;

        public ObservableCollection<KeyValuePair<int, PackingSlipLine>> List
        {
            get { return _list; }
            set
            {
                _list = value;
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


        private bool _showActionsFrame;
        private Func<Task> _onOpenPackingSlip;

        public bool ShowActionsFrame
        {
            get { return _showActionsFrame; }
            set
            {
                _showActionsFrame = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Commands

        public ICommand ToggleHeaderFrameCommand { get; set; }
        public ICommand ViewPdfCommand { get; }
        public ICommand DownloadPdfCommand { get; }
        public ICommand ViewProofDeliveryCommand { get; }
        public ICommand ToggleLinesCommand { get; }
        public ICommand ToggleActionsFrameCommand { get; }

        public ICommand OpenOrderCommand { get; }

        #endregion
        public PackingSlipsDetailLinesPageViewModel(PackingSlip slip, bool loadFromServer)
        {
            _loadFromServer = loadFromServer;
            PackingSlip = slip;
            ToggleHeaderFrameCommand = new Command(() => ShowHeaderFrame = !_showHeaderFrame);
            DownloadPdfCommand = new AsyncDelegateCommand(OnDownloadPdf);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            ViewProofDeliveryCommand = new AsyncDelegateCommand(OnViewProofOfDelivery);
            ToggleActionsFrameCommand = new Command<bool>((isExpanded) => ShowActionsFrame = isExpanded);
            OpenOrderCommand = new AsyncDelegateCommand(OnOpenOrder);

            ToggleLinesCommand = new Command<bool>((b) =>
            {
                ShowLines = b;
            });

        }


        private async Task OnOpenOrder()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new OrderDetailLinesPage(_packingSlip.Order));
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task OnViewProofOfDelivery()
        {

            try
            {
                IsBusy = true;

                await Nav.NavigateTo(new PackingSlipsSelectProofDeliveryBarcodePage(_packingSlip));
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
        public async Task Load()
        {
            try
            {
                IsBusy = true;

                if (_loadFromServer)
                {
                    CustomerContext customerContext = (Settings.IsDriver)
                        ? new CustomerContext
                        {
                            AXCustomerId = _packingSlip.CustomerRef
                        }
                        : null;


                    var filter = new PackingSlipsQueryContext
                    {
                        Id = _packingSlip.Key,
                        CustomerInfo = customerContext
                    };
                    var packingSlipResponse = await Api.GetPackingSlips(filter);
                    if (!packingSlipResponse.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(packingSlipResponse.ExceptionMessage, packingSlipResponse.ValidationErrors);
                        return;
                    }
                    var packingSlip = packingSlipResponse.Data.Select(p => p.ToPackingSlipModel()).FirstOrDefault();
                    if (packingSlip != null)
                    {
                        PackingSlip = packingSlip.OriginalData;
                    }
                }

                var result = await Api.GetPackingSlipsLines(new PackingSlipLineQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    Id = PackingSlip.Key,
                    SalesOrderId = PackingSlip.Order.Key,
                    PackingSlipDate = PackingSlip.DateShipped
                });

                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        nameof(AppResources.PackingSlipLinesMessage).Translate());
                    return;
                }

                var lines = result.Data.ToArray();

                var list = new List<KeyValuePair<int, PackingSlipLine>>();
                for (int i = 0; i < lines.Length; i++)
                {
                    list.Add(new KeyValuePair<int, PackingSlipLine>(i + 1, lines[i]));
                }
                List = new ObservableCollection<KeyValuePair<int, PackingSlipLine>>(list);

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
                IsBusy = true;
                var data = await ApiService.Instance.GetPackageSlipCopy(_packingSlip.Key, _packingSlip.DateShipped.GetValueOrDefault(), _packingSlip.Order.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Packing Slip {_packingSlip.Key}.pdf"));

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

        //  var docView = DependencyService.Get<IDocumentView>();

        private async Task OnDownloadPdf()
        {
            try
            {
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetPackageSlipCopy(_packingSlip.Key, _packingSlip.DateShipped.GetValueOrDefault(), _packingSlip.Order.Key);
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile($"PackingSlip{_packingSlip.Key}.pdf");
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
    }

}