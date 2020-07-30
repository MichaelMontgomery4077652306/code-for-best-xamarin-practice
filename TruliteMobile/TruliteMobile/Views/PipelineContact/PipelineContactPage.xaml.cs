using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.MyContact;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.PipelineContact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineContactPage : ContentPage
    {
        private readonly PipelineContactPageViewModel _vm;

        public PipelineContactPage()
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineContactPageViewModel();
        }


    }

    public class PipelineContactPageViewModel : TruliteBaseViewModel
    {


        private string _corporateAddress;

        public string CorporateAddress
        {
            get { return _corporateAddress; }
            set
            {
                _corporateAddress = value;
                RaisePropertyChanged();
            }
        }

        private string _corporatePhone;

        public string CorporatePhone
        {
            get { return _corporatePhone; }
            set
            {
                _corporatePhone = value;
                RaisePropertyChanged();
            }
        }


        public ICommand OpenContactCommand { get; }
        public ICommand OpenMapCommand { get; }

        public PipelineContactPageViewModel()
        {
            OpenContactCommand = new AsyncDelegateCommand<ContactTypeEnum>(OnOpenContact);
            OpenMapCommand = new AsyncDelegateCommand<string>(OnOpenPlantMap);
            CorporateAddress = "403 West Park Court Suite 201"
                               + Environment.NewLine
                               + "Peachtree City, GA 30269";
            CorporatePhone = "1-800-432-8132";
        }

        private async Task OnOpenContact(ContactTypeEnum contactType)
        {
            await MakeCall(_corporatePhone);

        }
        private async Task OnOpenPlantMap(string arg)
        {
            var placemark = new Placemark
            {
                Thoroughfare = CorporateAddress
            };
            var options = new MapLaunchOptions { Name = "Trulite Glass & Aluminum Solutions" };

            await Map.OpenAsync(placemark, options);
        }

        private async Task MakeCall(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)) return;
            await Launcher.OpenAsync(new Uri($"tel:{phoneNumber}"));
        }

    }
}