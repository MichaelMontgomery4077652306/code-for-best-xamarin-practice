using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.FinancialStatement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialStatementPage : ContentPage
    {
        private readonly FinancialStatementPageViewModel _vm;

        public FinancialStatementPage()
        {
            InitializeComponent();
            BindingContext = _vm = new FinancialStatementPageViewModel();

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class FinancialStatementPageViewModel : TruliteBaseViewModel
    {
        private Stream _pdfStream;

        public Stream PdfStream
        {
            get { return _pdfStream; }
            set
            {
                _pdfStream = value;
                RaisePropertyChanged();
            }
        }

        public FinancialStatementPageViewModel()
        {

        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var context = new CustomerStatementQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext()
                };
                var data = await Api.GetFinancialStatement(context);
                if (data == null)
                {
                    await Alert.ShowMessage(Translate.Get(nameof(AppResources.NoFinancialStatementReturned)));
                    return;
                }
                PdfStream = new MemoryStream(data);

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