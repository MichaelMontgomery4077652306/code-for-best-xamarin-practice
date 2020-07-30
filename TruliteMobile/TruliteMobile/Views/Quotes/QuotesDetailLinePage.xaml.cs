using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesDetailLinePage : ContentPage
    {
        private readonly QuotesDetailLineViewModel _vm;

        public QuotesDetailLinePage(Quotation quotation)
        {
            //NavigationPage.SetHasNavigationBar(this,false);
            InitializeComponent();
            BindingContext =_vm= new QuotesDetailLineViewModel(quotation);

        }

        protected override async void OnAppearing()
        {
           await _vm.Load();

        }
    }

    public class QuotesDetailLineViewModel : TruliteBaseViewModel
    {


        #region Properties
        private bool _hasActions;

        public bool HasActions
        {
            get { return _hasActions; }
            set
            {
                _hasActions = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<QuotationLine> _list;

        private Quotation _quotation;

        public Quotation Quotation
        {
            get { return _quotation; }
            set
            {
                _quotation = value;
                RaisePropertyChanged();
            }
        }


        public ObservableCollection<QuotationLine> List
        {
            get { return _list; }
            set
            {
                _list = value;
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
        #endregion
        #region Commands

        public ICommand ToggleHeaderFrameCommand { get; }

        public ICommand DownloadPdfCommand { get; }
        public ICommand ViewPdfCommand { get; }

        public ICommand ConfirmCommand { get; }

        public ICommand ToggleActionsFrameCommand { get; }

        public ICommand ToggleLinesFrameCommand { get; }

        public ICommand QuoteToOrderCommand { get; }

        public ICommand OpenOrderCommand { get; } 
        #endregion
        public QuotesDetailLineViewModel(Quotation quoteModel)
        {

            Quotation = quoteModel;
            DownloadPdfCommand = new AsyncDelegateCommand(OnDownloadPdf, () => !IsBusy);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf, () => !IsBusy);
            ConfirmCommand = new AsyncDelegateCommand(OnConfirmQuote);
            ToggleActionsFrameCommand= new Command<bool>((isExpanded)=>ShowActionsFrame=isExpanded);
            ToggleHeaderFrameCommand = new Command<bool>((isExpanded) => ShowHeaderFrame = isExpanded);
            ToggleLinesFrameCommand = new Command<bool>((isExpanded) => ShowLines = isExpanded);
            QuoteToOrderCommand= new AsyncDelegateCommand(OnQuoteToOrder);
            HasActions = _quotation.Status.GetValueOrDefault() != QuotationStatus.Created;
            OpenOrderCommand = new AsyncDelegateCommand(OnOpenOrder, () => !IsBusy);
            Title = $"{nameof(AppResources.Quotation)}: {_quotation.Key}";
        }

        private async Task OnOpenOrder()
        {
            try
            {
                if(IsBusy)return;
                IsBusy = true;
                await Nav.NavigateTo(new OrderDetailLinesPage(_quotation.Order));
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task OnQuoteToOrder()
        {
            await Alert.ShowMessage("Coming soon");
        }

        private async Task OnConfirmQuote()
        {
            try
            {
                
                IsBusy = true;
                var response = await Api.ConfirmQuotation(_quotation.Key);
                _quotation.Status = QuotationStatus.Confirmed;
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

                var lines = (await Api.GetQuotesLines(_quotation.Key))
                    .ToList();

                List = new ObservableCollection<QuotationLine>(lines);
                
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

        private async Task OnViewPdf()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetQuotationCopy(_quotation.Key);
                await Nav.NavigateTo(new PdfPage(data, $"Quotation {_quotation.Key}.pdf"));

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

        private async Task OnDownloadPdf()
        {

            try
            {
                if (IsBusy) return;
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetQuotationCopy(_quotation.Key);
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile($"Quotation{_quotation.Key}.pdf");
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