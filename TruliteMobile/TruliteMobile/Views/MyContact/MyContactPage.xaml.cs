using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.MyContact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyContactPage : ContentPage
    {
        private readonly MyContactPageViewModel _vm;

        public MyContactPage()
        {
            InitializeComponent();
            BindingContext = _vm = new MyContactPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }


    }

    public class MyContactPageViewModel : TruliteBaseViewModel
    {
        private CustomerContact _contactInfo;

        public CustomerContact ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                _contactInfo = value;
                RaisePropertyChanged();
            }
        }

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
        public MyContactPageViewModel()
        {
            OpenContactCommand = new AsyncDelegateCommand<ContactTypeEnum>(OnOpenContact);
            OpenMapCommand = new AsyncDelegateCommand<string>(OnOpenPlantMap);
            CorporateAddress = "403 West Park Court Suite 201"
                               + Environment.NewLine
                               + "Peachtree City, GA 30269";
            CorporatePhone = "1-800-432-8132";
        }

        private async Task OnOpenPlantMap(string arg)
        {
            Placemark placemark;
            MapLaunchOptions options;
            if (arg == "corporate")
            {

                placemark = new Placemark
                {
                    Thoroughfare = CorporateAddress
                };
                options = new MapLaunchOptions { Name = "Trulite Glass & Aluminum Solutions" };
            }
            else
            {
                placemark = new Placemark
                {
                    Thoroughfare = _contactInfo.BranchAddress,
                };
                options = new MapLaunchOptions { Name = "Plant" };
            }
            await Map.OpenAsync(placemark, options);
        }

        private async Task OnOpenContact(ContactTypeEnum contactType)
        {
            switch (contactType)
            {
                case ContactTypeEnum.SalesEmail:
                    await SendEmail(_contactInfo.SalesPersonEmail);
                    break;
                case ContactTypeEnum.SalesPhone:
                    await MakeCall(_contactInfo.SalesPersonPhone);
                    break;
                case ContactTypeEnum.CreditEmail:
                    await SendEmail(_contactInfo.CreditRepEmail);
                    break;
                case ContactTypeEnum.CreditPhone:
                    await MakeCall(_contactInfo.CreditRepPhone);
                    break;
                case ContactTypeEnum.PlantPhone:
                    await MakeCall(_contactInfo.BranchPhone);
                    break;
                case ContactTypeEnum.CorporatePhone:
                    await MakeCall(_corporatePhone);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(contactType), contactType, null);
            }

        }

        private async Task MakeCall(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)) return;
            await Launcher.OpenAsync(new Uri($"tel:{phoneNumber}"));
        }

        private async Task SendEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return;
            await Launcher.OpenAsync(new Uri($"mailto:{email}"));
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;

                var result = await Api.GetCustomerTruliteContact();

                ContactInfo = result.Data;

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

    public enum ContactTypeEnum
    {
        SalesEmail,
        SalesPhone,
        CreditEmail,
        CreditPhone,
        PlantPhone,
        CorporatePhone

    }
}