using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.PipelineMyAccount
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineMyAccount : ContentPage
    {
        private readonly PipelineMyAccountViewModel _vm;

        public PipelineMyAccount()
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineMyAccountViewModel();
        }


    }

    public class PipelineMyAccountViewModel : TruliteBaseViewModel
    {

        private AppUserPreferencesViewModel _myPreferences;

        public AppUserPreferencesViewModel MyPreferences
        {
            get { return _myPreferences; }
            set
            {
                _myPreferences = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandAccountInformation;

        public bool ExpandAccountInformation
        {
            get { return _expandAccountInformation; }
            set
            {
                _expandAccountInformation = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandCostumerInformation;

        public bool ExpandCostumerInformation
        {
            get { return _expandCostumerInformation; }
            set
            {
                _expandCostumerInformation = value;
                RaisePropertyChanged();
            }
        }


        private bool _expandPreferences;

        public bool ExpandPreferences
        {
            get { return _expandPreferences; }
            set
            {
                _expandPreferences = value;
                RaisePropertyChanged();
            }
        }


        private MyInfoViewModel _myInfo;

        public MyInfoViewModel MyInfo
        {
            get { return _myInfo; }
            set
            {
                _myInfo = value;
                RaisePropertyChanged();
            }
        }




        public ICommand ExpandAccountInformationCommand { get; }
        public ICommand ExpandCustomerInformationCommand { get; }
        public ICommand ExpandPreferencesCommand { get; }

        public PipelineMyAccountViewModel()
        {

            ExpandAccountInformationCommand = new Command<bool>((show => ExpandAccountInformation = show));
            ExpandCustomerInformationCommand = new Command<bool>((show => ExpandCostumerInformation = show));
            ExpandPreferencesCommand = new Command<bool>((show => ExpandPreferences = show));
            MyInfo = Settings.MyInfo;
            MyPreferences = Settings.MyPreferences.CloneJson();
        }
    }
}