using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.Interfaces;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.PriceLetters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PriceLettersPage : ContentPage
    {
        private readonly PriceLettersPageViewModel _vm;

        public PriceLettersPage()
        {
            InitializeComponent();
            BindingContext = _vm = new PriceLettersPageViewModel();

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PriceLettersPageViewModel : TruliteBaseViewModel
    {

        private static byte[] priceLettterBytes;

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

        public async Task Load()
        {

            try
            {

                IsBusy = true;
                if (priceLettterBytes == null)
                {
                    priceLettterBytes = await Api.GetPriceLetterCopy();
                }
                PdfStream = new MemoryStream(priceLettterBytes);
                
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