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
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.SupportTickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSupportTicketPage : ContentPage
    {
        private readonly AddSupportTicketPageViewModel _vm;

        public AddSupportTicketPage()
        {
            InitializeComponent();
            BindingContext = _vm = new AddSupportTicketPageViewModel();

        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class AddSupportTicketPageViewModel : TruliteBaseViewModel
    {
        private ObservableCollection<CustomerBranchView> _plantList;

        public ObservableCollection<CustomerBranchView> PlantList
        {
            get { return _plantList; }
            set
            {
                _plantList = value;
                RaisePropertyChanged();
            }
        }

        private CustomerBranchView _selectedPlant;

        public CustomerBranchView SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                RaisePropertyChanged();
            }
        }


        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                RaisePropertyChanged();
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<SupportTicketUploadFileInformationModel> _attachedFilesList;

        public ObservableCollection<SupportTicketUploadFileInformationModel> AttachedFilesList
        {
            get { return _attachedFilesList; }
            set
            {
                _attachedFilesList = value;
                RaisePropertyChanged();
            }
        }

        public bool CanAddFile => !AttachedFilesList?.Any() ?? true;


        public ICommand CloseCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SelectFileToUploadCommand { get; }
        public ICommand RemoveAttachedFileCommand { get; }

        readonly List<string> ALLOWED_EXTENSIONS = new List<string> { ".docx", ".pdf", "doc" };

        public AddSupportTicketPageViewModel()
        {
            
            AddCommand = new AsyncDelegateCommand(OnAdd);
            CloseCommand = new AsyncDelegateCommand(OnClose);
            SelectFileToUploadCommand = new AsyncDelegateCommand(OnSelectFileToUpload);
            RemoveAttachedFileCommand = new Command<SupportTicketUploadFileInformationModel>(OnRemovedAttachedFile);
            AttachedFilesList = new ObservableCollection<SupportTicketUploadFileInformationModel>();

        }

        private void OnRemovedAttachedFile(SupportTicketUploadFileInformationModel arg)
        {
            AttachedFilesList.Remove(arg);
            RaisePropertyChanged(nameof(CanAddFile));
        }


        private async Task OnSelectFileToUpload()
        {
            var file = await CrossFilePicker.Current.PickFile();
            if (file == null) return;
            var extension = Path.GetExtension(file.FilePath).ToLower();
            if (!ALLOWED_EXTENSIONS.Contains(extension))
            {
                await Alert.ShowMessage("Only .docx, .pdf or doc files can be uploaded");
                return;
            }

            AttachedFilesList.Add(new SupportTicketUploadFileInformationModel
            {
                Filename = file.FileName,
                FilePath = file.FilePath,
                FileData = file.DataArray,
            });

            RaisePropertyChanged(nameof(CanAddFile));
        }

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }

        private async Task OnAdd()
        {
            try
            {
                IsBusy = true;



                var file = _attachedFilesList.FirstOrDefault();

                var context = new NewTruDeskItemQueryContext
                {
                    Branch = _selectedPlant.BranchId,
                    CustomerInfo = Api.GetCustomerContext(),
                    EmailAddress = Settings.Email,
                    Description = _description,
                    Subject = _subject,
                    Attachment = (file == null) ? null : Convert.ToBase64String(file.FileData),
                    AttachmentName = file?.Filename
                };

                var response = await Api.AddBranchTicket(context);
                await Nav.Nav.PopAsync();
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

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var plantsResult = await Api.GetTicketBranches();

                if (!plantsResult.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(plantsResult.ExceptionMessage, plantsResult.ValidationErrors, nameof(AppResources.ServerError).Translate());
                    return;
                }

                PlantList = new ObservableCollection<CustomerBranchView>(plantsResult.Data);
                SelectedPlant = _plantList.FirstOrDefault();
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

    public class SupportTicketUploadFileInformationModel : ObservableObject
    {

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set
            {
                _filename = value;
                RaisePropertyChanged();
            }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                RaisePropertyChanged();
            }
        }

        private byte[] _fileData;

        public byte[] FileData
        {
            get { return _fileData; }
            set
            {
                _fileData = value;
                RaisePropertyChanged();
            }
        }

    }



}