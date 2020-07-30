using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvSurvey
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvSurveyPage : ContentPage
    {
        private readonly DrvSurveyPageViewModel _vm;

        public DrvSurveyPage(List<PackingSlip> packingSlips)
        {

            InitializeComponent();
            BindingContext = _vm = new DrvSurveyPageViewModel(packingSlips);
        }

    }

    public class DrvSurveyPageViewModel : TruliteBaseViewModel
    {

        private SurveyViewModel _survey;

        public SurveyViewModel Survey
        {
            get { return _survey; }
            set
            {
                _survey = value;
                RaisePropertyChanged();
            }

        }

        private ObservableCollection<KeyValuePair<int, string>> _surveyOptions;

        public ObservableCollection<KeyValuePair<int, string>> SurveyOptions
        {
            get { return _surveyOptions; }
            set
            {
                _surveyOptions = value;
                RaisePropertyChanged();
            }
        }


        private KeyValuePair<int, string> _selectedFriendlinessOption;

        public KeyValuePair<int, string> SelectedFriendlinessOption
        {
            get { return _selectedFriendlinessOption; }
            set
            {
                _selectedFriendlinessOption = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<int, string> _selectedOnTimeOption;

        public KeyValuePair<int, string> SelectedOnTimeOption
        {
            get { return _selectedOnTimeOption; }
            set
            {
                _selectedOnTimeOption = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<int, string> _selectedHelpfulnessOption;

        public KeyValuePair<int, string> SelectedHelpfulnessOption
        {
            get { return _selectedHelpfulnessOption; }
            set
            {
                _selectedHelpfulnessOption = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<int, string> _selectedRepresentingOption;
        private List<PackingSlip> _packingSlipList;

        public KeyValuePair<int, string> SelectedRepresentingOption
        {
            get { return _selectedRepresentingOption; }
            set
            {
                _selectedRepresentingOption = value;
                RaisePropertyChanged();
            }
        }



        public ICommand CloseCommand { get; }
        public ICommand SendCommand { get; }


        public DrvSurveyPageViewModel(List<PackingSlip> packingSlipList)
        {

            _packingSlipList = packingSlipList;
            Survey = new SurveyViewModel();

            SurveyOptions = new ObservableCollection<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0,Translate.Get(nameof(AppResources.VeryDissatisfied))),
                new KeyValuePair<int, string>(1,Translate.Get(nameof(AppResources.Dissatisfied))),
                new KeyValuePair<int, string>(2,Translate.Get(nameof(AppResources.Satisfied))),
                new KeyValuePair<int, string>(3,Translate.Get(nameof(AppResources.VerySatisfied))),
            };

            SendCommand = new AsyncDelegateCommand(OnSend);
            CloseCommand = new AsyncDelegateCommand(OnClose);
        }

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }


        public async Task OnSend()
        {
            try
            {
                IsBusy = true;


                foreach (var packingSlip in _packingSlipList)
                {
                    var sv = new SurveyViewModel
                    {
                        Account = packingSlip.Account.Key,
                        AccountNumber = packingSlip.Account.Key,
                        Branch = packingSlip.Branch.Code,
                        PackingSlip = packingSlip.Key,
                        SalesOrderId = packingSlip.Order.Key
                    };
                    sv.Friendliness = (SurveyViewModelFriendliness)Enum.ToObject(typeof(SurveyViewModelFriendliness),
                        _selectedFriendlinessOption.Key);
                    sv.OnTime = (SurveyViewModelOnTime)Enum.ToObject(typeof(SurveyViewModelOnTime),
                        _selectedOnTimeOption.Key);
                    sv.Helpfulness = (SurveyViewModelHelpfulness)Enum.ToObject(typeof(SurveyViewModelHelpfulness),
                        _selectedFriendlinessOption.Key);
                    sv.RepresentingTruliteBrand = (SurveyViewModelRepresentingTruliteBrand)Enum.ToObject(typeof(SurveyViewModelRepresentingTruliteBrand),
                        _selectedHelpfulnessOption.Key);

                    var result = await Api.TakeSurvey(sv);
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                        return;
                    }
                }
                await Nav.Nav.PopToRootAsync();

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