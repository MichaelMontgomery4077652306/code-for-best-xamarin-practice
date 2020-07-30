using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdfView : ContentView
    {

        public static readonly BindableProperty PdfDocumentStreamProperty =
            BindableProperty.Create("PdfDocumentStream", typeof(Stream), typeof(PdfView), default(Stream));

        public Stream PdfDocumentStream
        {
            get { return (Stream) GetValue(PdfDocumentStreamProperty); }
            set { SetValue(PdfDocumentStreamProperty, value); }
        }

        public PdfView()
        {
            InitializeComponent();
        }
    }
}