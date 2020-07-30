using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Enums;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Feedback
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GiveFeedbackPage : ContentPage
    {
        public GiveFeedbackPage()
        {
            InitializeComponent();
            BindingContext = new GiveFeedbackPageViewModel();
        }
    }

    public class GiveFeedbackPageViewModel : TruliteBaseViewModel
    {
        private ObservableCollection<FeedbackTypeEnum> _feebackTypesList;

        public ObservableCollection<FeedbackTypeEnum> FeebackTypesList
        {
            get { return _feebackTypesList; }
            set
            {
                _feebackTypesList = value;
                RaisePropertyChanged();
            }
        }

        private FeedbackTypeEnum _selectedType;

        public FeedbackTypeEnum SelectedType
        {
            get { return _selectedType; }
            set
            {
                _selectedType = value;
                RaisePropertyChanged();
            }
        }


        public ICommand CloseCommand { get; }
        public ICommand SubmitCommand { get; }

        public GiveFeedbackPageViewModel()
        {

            CloseCommand = new AsyncDelegateCommand(OnClose);
            SubmitCommand = new AsyncDelegateCommand(OnSubmit);

            FeebackTypesList = new ObservableCollection<FeedbackTypeEnum>
            {
                 FeedbackTypeEnum.None,
                 FeedbackTypeEnum.Issue,
                 FeedbackTypeEnum.Suggestion,
            };
            SelectedType = _feebackTypesList.First();


        }

        private async Task OnSubmit()
        {

            try
            {
                IsBusy = true;
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

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }
    }
}