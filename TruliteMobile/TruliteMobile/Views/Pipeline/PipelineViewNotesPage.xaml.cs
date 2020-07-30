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
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineViewNotesPage : ContentPage
    {
        private readonly PipelineViewNotesPageViewModel _vm;

        public PipelineViewNotesPage(SalesQuotationInquiry inquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineViewNotesPageViewModel(inquiry);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PipelineViewNotesPageViewModel : TruliteBaseViewModel
    {
        private readonly SalesQuotationInquiry _inquiry;


        private ObservableCollection<QuotationNote> _noteList;

        public ObservableCollection<QuotationNote> NoteList
        {
            get { return _noteList; }
            set
            {
                _noteList = value;
                RaisePropertyChanged();
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public PipelineViewNotesPageViewModel(SalesQuotationInquiry inquiry)
        {
            _inquiry = inquiry;
            CloseCommand = new AsyncDelegateCommand(OnClose);
            Title = $"{nameof(AppResources.NotesFor).Translate()} {_inquiry.QuotationId}";
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;

                var context = new QuotationNotesQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustAccount = _inquiry.CustAccount,
                    Id = _inquiry.QuotationId
                };
                var quotationNotes = await Api.GetQuotationNotes(context);

                if (!quotationNotes.Successful.GetValueOrDefault()
                    || quotationNotes.ValidationErrors.Any())
                {
                    await Alert.DisplayApiCallError(quotationNotes.ExceptionMessage, quotationNotes.ValidationErrors);
                    return;
                }
                NoteList = new ObservableCollection<QuotationNote>(quotationNotes.Data);
                NoResults = !_noteList.Any();
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
            await Back();
        }
    }
}