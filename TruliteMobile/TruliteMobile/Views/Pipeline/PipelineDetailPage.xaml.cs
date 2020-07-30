using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Interfaces;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Pipeline
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PipelineDetailPage : ContentPage
    {
        private readonly PipelineDetailPageViewModel _vm;

        public PipelineDetailPage(SalesQuotationInquiry selectedInquiry)
        {
            InitializeComponent();
            BindingContext = _vm = new PipelineDetailPageViewModel(selectedInquiry);
        }

    }

    public class PipelineDetailPageViewModel : TruliteBaseViewModel
    {
        private SalesQuotationInquiry _inquiry;

        public SalesQuotationInquiry Inquiry
        {
            get { return _inquiry; }
            set
            {
                _inquiry = value;
                RaisePropertyChanged();
            }
        }

        private bool _showHeaderFrame;

        public bool ShowHeaderFrame
        {
            get { return _showHeaderFrame; }
            set
            {
                _showHeaderFrame = value;
                RaisePropertyChanged();
            }
        }


        private bool _showActionsFrame;
        private Func<Task> _onUpdateExpiryDate;

        public bool ShowActionsFrame
        {
            get { return _showActionsFrame; }
            set
            {
                _showActionsFrame = value;
                RaisePropertyChanged();
            }
        }



        public ICommand LoseQuotationCommand { get; }
        public ICommand ViewNotesCommand { get; }
        public ICommand AddNoteCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand UpdateFollowUpDateCommand { get; }
        public ICommand UpdateLeadTimeCommand { get; }
        public ICommand UpdateProbabilityCommand { get; }
        public ICommand UpdateExpiryDateCommand { get; }
        public ICommand ViewPdfCommand { get; }
        public ICommand DownloadPdfCommand { get; }

        public ICommand ToggleActionsFrameCommand { get; }
        public ICommand ToggleHeaderFrameCommand { get; }

        public PipelineDetailPageViewModel(SalesQuotationInquiry selectedInquiry)
        {
            Inquiry = selectedInquiry;
            ToggleHeaderFrameCommand= new Command<bool>(show=>ShowHeaderFrame=show);
            ToggleActionsFrameCommand = new Command<bool>(show => ShowActionsFrame = show);
            AddNoteCommand= new AsyncDelegateCommand(OnAddNote);
            ViewNotesCommand= new AsyncDelegateCommand(OnViewNotes);
            LoseQuotationCommand= new AsyncDelegateCommand(OnLoseQuotation);
            UpdateCommand= new AsyncDelegateCommand(OnUpdate);
            UpdateFollowUpDateCommand= new AsyncDelegateCommand(OnUpdateFollowUpDate);
            UpdateLeadTimeCommand= new AsyncDelegateCommand(OnUpdateLeadTime);
            UpdateProbabilityCommand= new AsyncDelegateCommand(OnUpdateProbability);
            UpdateExpiryDateCommand= new AsyncDelegateCommand(OnUpdateExpiryDate);
            ViewPdfCommand = new AsyncDelegateCommand(OnViewPdf);
            DownloadPdfCommand= new AsyncDelegateCommand(OnDownloadPdf);
        }

        private async Task OnUpdateExpiryDate()
        {
            await Nav.NavigateTo(new PipelineUpdateExpiryDatePage(_inquiry));
        }
      
        private async Task OnUpdateProbability()
        {
            await Nav.NavigateTo(new PipelineUpdateProbabilityPage(_inquiry));
        }

        private async Task OnUpdateLeadTime()
        {
            await Nav.NavigateTo(new PipelineUpdateLeadTimePage(_inquiry));
        }

        private async Task OnUpdateFollowUpDate()
        {
            await Nav.NavigateTo(new PipelineUpdateFollowUpDatePage(_inquiry));
        }

        private async Task OnUpdate()
        {
            await Nav.NavigateTo(new PipelineUpdatePage(_inquiry));
        }

        private async Task OnLoseQuotation()
        {
            await Nav.NavigateTo(new PipelineLoseQuotationPage(_inquiry));
        }

        private async Task OnViewNotes()
        {
            await Nav.NavigateTo(new PipelineViewNotesPage(_inquiry));
        }

        private async Task OnAddNote()
        {
            await Nav.NavigateTo(new PipelineAddNotePage(_inquiry));
        }

        private async Task OnViewPdf()
        {
            try
            {
                IsBusy = true;
                var data = await ApiService.Instance.GetQuotationCopy(_inquiry.QuotationId);
                await Nav.NavigateTo(new PdfPage(data, $"Quotation {_inquiry.QuotationId}.pdf"));

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

        private async Task OnDownloadPdf()
        {

            try
            {
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await ApiService.Instance.GetQuotationCopy(_inquiry.QuotationId);
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile($"Quotation{_inquiry.QuotationId}.pdf");
                Debug.WriteLine(path);
                File.WriteAllBytes(path, data);
                await Alert.ShowMessage($"File saved to: {path}");

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