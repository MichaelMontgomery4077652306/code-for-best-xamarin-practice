using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Pdf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdfPage : ContentPage
    {
        private readonly byte[] _pdfData;
        private readonly PdfPageViewModel _vm;

        public PdfPage(byte[] pdfData, string title="PDF View")
        {
            Title = title;
            _pdfData = pdfData;
            InitializeComponent();
            BindingContext = _vm = new PdfPageViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.Load(_pdfData);

        }
    }

    public class PdfPageViewModel : TruliteBaseViewModel
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

        public PdfPageViewModel()
        {
            
        }
        public async Task Load(byte[] pdfData)
        {
            PdfStream= new MemoryStream(pdfData);
        }
    }
}