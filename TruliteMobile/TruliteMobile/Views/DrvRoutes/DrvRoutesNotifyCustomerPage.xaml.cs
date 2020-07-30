using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvRoutesNotifyCustomerPage : ContentPage
    {
        private readonly DrvRoutesNotifyCustomerPageViewModel _vm;

        public DrvRoutesNotifyCustomerPage(PackingSlip packingSlip)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvRoutesNotifyCustomerPageViewModel(packingSlip);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvRoutesNotifyCustomerPageViewModel : TruliteBaseViewModel
    {
        private readonly PackingSlip _packingSlip;


        private NotifyCustomerViewModel _notify;

        public NotifyCustomerViewModel Notify
        {
            get { return _notify; }
            set
            {
                _notify = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<string, string>> _durationList;

        public ObservableCollection<KeyValuePair<string, string>> DurationList
        {
            get { return _durationList; }
            set
            {
                _durationList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string, string> _selectedDuration;

        public KeyValuePair<string, string> SelectedDuration
        {
            get { return _selectedDuration; }
            set
            {
                _selectedDuration = value;
                RaisePropertyChanged();
            }
        }



        private string _customDuration;

        public string CustomDuration
        {
            get { return _customDuration; }
            set
            {
                _customDuration = value;
                RaisePropertyChanged();
            }
        }


        public ICommand OpenAccountCommand { get; }
        public DrvRoutesNotifyCustomerPageViewModel(PackingSlip packingSlip)
        {
            _packingSlip = packingSlip;

            DurationList = new ObservableCollection<KeyValuePair<string, string>>{
                new KeyValuePair<string, string>("15",$"15 {nameof(AppResources.Minutes).Translate()}"),
                    new KeyValuePair<string, string>("30",$"30 {nameof(AppResources.Minutes).Translate()}"),
                        new KeyValuePair<string, string>("45",$"45 {nameof(AppResources.Minutes).Translate()}"),
                new KeyValuePair<string, string>("60",$"60 {nameof(AppResources.Minutes).Translate()}"),
                    new KeyValuePair<string, string>("C",nameof(AppResources.Custom).Translate()),
                    new KeyValuePair<string, string>("A",nameof(AppResources.Calculated).Translate())
            };
            SelectedDuration = _durationList[0];

        }

        public async Task Load()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;



                var response = await Api.NotifyCustomerGet(_packingSlip.Key, _packingSlip.Account.Key, _packingSlip.Order.Key);
                if (!response.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
                        Translate.Get(nameof(AppResources.CouldntGetPackingSlipLines)));
                    return;
                }

                Notify = response.Data;


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