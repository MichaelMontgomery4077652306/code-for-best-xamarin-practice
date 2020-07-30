using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using Plugin.FilePicker;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.SupportTickets;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.LienWaiver
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LienWaiverPage : ContentPage
    {
        private readonly LienWaiverPageViewModel _vm;

        public LienWaiverPage(List<InvoiceModel> selectedInvoices)
        {
            InitializeComponent();
            BindingContext = _vm = new LienWaiverPageViewModel(selectedInvoices);

        }
        public LienWaiverPage()
        {
            InitializeComponent();
            BindingContext = _vm = new LienWaiverPageViewModel();

        }
        protected override async void OnAppearing()
        {
            await _vm.Load();

        }
    }

    public class LienWaiverPageViewModel : TruliteBaseViewModel
    {

        #region Properties


        private ObservableCollection<KeyNameModelOfString> _stateList;

        public ObservableCollection<KeyNameModelOfString> StateList
        {
            get { return _stateList; }
            set
            {
                _stateList = value;
                RaisePropertyChanged();
            }
        }


        private LienWaiverScreenModel _model;

        public LienWaiverScreenModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<WaiverType> _waiverTypeList;

        public ObservableCollection<WaiverType> WaiverTypeList
        {
            get { return _waiverTypeList; }
            set
            {
                _waiverTypeList = value;
                RaisePropertyChanged();
            }
        }

        private WaiverType _selectedWaiverType;

        public WaiverType SelectedWaiverType
        {
            get { return _selectedWaiverType; }
            set
            {
                _selectedWaiverType = value;
                RaisePropertyChanged();
            }
        }


        private SupportTicketUploadFileInformationModel _selectedFile;

        public SupportTicketUploadFileInformationModel SelectedFile
        {
            get { return _selectedFile; }
            set
            {
                _selectedFile = value;
                RaisePropertyChanged();
            }
        }

        #endregion


        #region Commands

        public ICommand DownloadBlankCommand { get; }
        public ICommand SelectFileToUploadCommand { get; }
        public ICommand SubmitCommand { get; }

        public ICommand AddInvoiceNumberCommand { get; }

        public ICommand RemoveInvoiceNumberCommand { get; }

        public ICommand RemoveAttachedFileCommand { get; }
        #endregion

        public LienWaiverPageViewModel(List<InvoiceModel> selectedInvoices=null)
        {
            DownloadBlankCommand = new AsyncDelegateCommand(OnDownloadBlank);
            SelectFileToUploadCommand = new AsyncDelegateCommand(OnSelectFileToUpload);
            SubmitCommand = new AsyncDelegateCommand(OnSubmit);
            AddInvoiceNumberCommand = new Command(OnAddInvoiceNumber);
            RemoveInvoiceNumberCommand = new Command<KeyValuePair<int, string>>(OnRemoveInvoiceNumber);
            RemoveAttachedFileCommand = new Command(OnRemoveAttachedFile);


            var invoiceList = new List<KeyValuePair<int, string>>();
            if (selectedInvoices != null)
            {
                for (int i = 0; i < selectedInvoices.Count; i++)
                {
                    if (i > 9) break;
                    invoiceList.Add(new KeyValuePair<int, string>(i, selectedInvoices[i].Key));
                }
            }

            Model = new LienWaiverScreenModel
            {
                CustomerName = Settings.MyInfo.CustomerInfo.Name,
                Email = Settings.MyInfo.CurrentUser.LoginId,
                ProjectAccountNumber = Settings.MyInfo.CustomerInfo.Key,
                InvoiceNumberList = new ObservableCollection<KeyValuePair<int, string>>(invoiceList)
            };


        }

        private void OnRemoveAttachedFile()
        {
            SelectedFile = null;
        }

        private void OnRemoveInvoiceNumber(KeyValuePair<int, string> arg)
        {
            Model.InvoiceNumberList.RemoveAt(arg.Key);
        }

        private void OnAddInvoiceNumber()
        {

            Model.InvoiceNumberList.Add(new KeyValuePair<int, string>(_model.InvoiceNumberList.Count, string.Empty));
        }

        private async Task OnSubmit()
        {

            try
            {
                IsBusy = true;

                Services.LienWaiverModel model = GetApiInputModel();
                var submitResponse = await Api.AddLienWaiver(model);

                if (!submitResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(nameof(AppResources.SubmissionError).Translate(), submitResponse.ValidationErrors);
                    return;
                }

            }
            catch (Exception e)
            {
                await Alert.DisplayError(e,
                    nameof(AppResources.ServerError).Translate());
            }
            finally
            {

                IsBusy = false;
            }

        }

        private LienWaiverModel GetApiInputModel()
        {

            var model = new LienWaiverModel
            {
                CustomerName = _model.CustomerName,
                EmailAddress = _model.Email,
                PhoneNumber = _model.Phone,
                ProjectName = _model.ProjectName,
                ProjectAccountNo = _model.ProjectAccountNumber,
                ProjectAddress = _model.ProjectAddress,
                ProjectCity = _model.ProjectCity,
                ProjectState = _model.ProjectState?.Key,
                ProjectZip = _model.ProjectZip,
                DollarAmount = _model.DollarAmountStr?.ToDouble(),
                Invoices = _model.InvoiceNumberList.Select(p => p.Value).ToList(),
                MailedWaiverAddress = _model.MailingAddress,
                MailedWaiverCity = _model.MailingCity,
                MailedWaiverState = _model.MailingState?.Key,
                MailedWaiverZip = _model.MailingZip,
                SpecialInstrutions = _model.SpecialInstructions,
                WaiverType = _selectedWaiverType
            };




            return model;
        }

        private async Task OnSelectFileToUpload()
        {

            var file = await CrossFilePicker.Current.PickFile();
            if (file == null) return;

            if (Path.GetExtension(file.FileName).ToLower() != ".pdf")
            {
                await Alert.ShowMessage("We only allow PDF files to be uploaded");
                return;
            }

            SelectedFile = new SupportTicketUploadFileInformationModel
            {
                Filename = file.FileName,
                FilePath = file.FilePath,
                FileData = file.DataArray,
            };
        }

        private async Task OnDownloadBlank()
        {
        }

        public async Task Load()
        {

            try
            {
                IsBusy = true;

                var statesResponse = await Api.GetListOfUsStates();

                if (!statesResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(statesResponse.ExceptionMessage,
                        statesResponse.ValidationErrors, nameof(AppResources.LienWaiverError1).Translate());
                    return;
                }

                StateList = new ObservableCollection<KeyNameModelOfString>(statesResponse.Data);

                var waiverTypesResponse = await Api.GetWaiverTypes();
                if (!waiverTypesResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(waiverTypesResponse.ExceptionMessage,
                        waiverTypesResponse.ValidationErrors, nameof(AppResources.LienWaiverError2).Translate());
                    return;
                }

                WaiverTypeList = new ObservableCollection<WaiverType>(waiverTypesResponse.Data);


            }
            catch (Exception e)
            {
                await Alert.DisplayError(e,
                    nameof(AppResources.ServerError).Translate());
            }
            finally
            {

                IsBusy = false;
            }
        }
    }


    public class LienWaiverScreenModel : ObservableObject
    {
        private ObservableCollection<KeyValuePair<int, string>> _invoiceNumberList;

        public ObservableCollection<KeyValuePair<int, string>> InvoiceNumberList
        {
            get { return _invoiceNumberList; }
            set
            {
                _invoiceNumberList = value;
                RaisePropertyChanged();
            }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                RaisePropertyChanged();
            }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                RaisePropertyChanged();
            }
        }

        private string _projectName;

        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                _projectName = value;
                RaisePropertyChanged();
            }
        }

        private string _projectAccountNumber;

        public string ProjectAccountNumber
        {
            get { return _projectAccountNumber; }
            set
            {
                _projectAccountNumber = value;
                RaisePropertyChanged();
            }
        }

        private string _dollarAmountStr;

        public string DollarAmountStr
        {
            get { return _dollarAmountStr; }
            set
            {
                _dollarAmountStr = value;
                RaisePropertyChanged();
            }
        }


        private DateTime _throughDateWaiver;

        public DateTime ThroughDateWaiver
        {
            get { return _throughDateWaiver; }
            set
            {
                _throughDateWaiver = value;
                RaisePropertyChanged();
            }
        }

        private string _projectAddress;

        public string ProjectAddress
        {
            get { return _projectAddress; }
            set
            {
                _projectAddress = value;
                RaisePropertyChanged();
            }
        }


        private string _projectCity;

        public string ProjectCity
        {
            get { return _projectCity; }
            set
            {
                _projectCity = value;
                RaisePropertyChanged();
            }
        }

        private KeyNameModelOfString _projectState;

        public KeyNameModelOfString ProjectState
        {
            get { return _projectState; }
            set
            {
                _projectState = value;
                RaisePropertyChanged();
            }
        }

        private string _projectZip;

        public string ProjectZip
        {
            get { return _projectZip; }
            set
            {
                _projectZip = value;
                RaisePropertyChanged();
            }
        }


        private string _mailingAddress;

        public string MailingAddress
        {
            get { return _mailingAddress; }
            set
            {
                _mailingAddress = value;
                RaisePropertyChanged();
            }
        }


        private string _mailingCity;

        public string MailingCity
        {
            get { return _mailingCity; }
            set
            {
                _mailingCity = value;
                RaisePropertyChanged();
            }
        }

        private KeyNameModelOfString _mailingState;

        public KeyNameModelOfString MailingState
        {
            get { return _mailingState; }
            set
            {
                _mailingState = value;
                RaisePropertyChanged();
            }
        }

        private string _mailingZip;

        public string MailingZip
        {
            get { return _mailingZip; }
            set
            {
                _mailingZip = value;
                RaisePropertyChanged();
            }
        }


        private string _specialInstructions;

        public string SpecialInstructions
        {
            get { return _specialInstructions; }
            set
            {
                _specialInstructions = value;
                RaisePropertyChanged();
            }
        }

        public LienWaiverScreenModel()
        {
            InvoiceNumberList = new ObservableCollection<KeyValuePair<int, string>>();
        }

    }


}