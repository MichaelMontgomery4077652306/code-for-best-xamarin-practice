using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Media.Abstractions;
using TruliteMobile.i18n;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.DrvRoutes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Commands;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvReportIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvReportIssuePage : ContentPage
    {
        private readonly DrvReportIssuePageViewModel _vm;

        public DrvReportIssuePage()
        {
            InitializeComponent();
            BindingContext = _vm = new DrvReportIssuePageViewModel();
        }
    }

    public class DrvReportIssuePageViewModel : TruliteBaseViewModel
    {

        #region Properties
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        private ImageSource _selectedImage;

        public ImageSource SelectedImage
        {
            get { return _selectedImage; }
            set
            {
                _selectedImage = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsImageSelected));
            }
        }

        private byte[] _selectedImageBytes;

        public bool IsImageSelected => _selectedImage != null;



        #endregion
        #region Commands
        public ICommand SendCommand { get; }
        public ICommand CancelCommand { get; }

        public ICommand SelectImageCommand { get; }


        #endregion
        public DrvReportIssuePageViewModel()
        {
            SendCommand = new AsyncDelegateCommand(OnSend);
            CancelCommand = new AsyncDelegateCommand(OnCancel);
            SelectImageCommand = new AsyncDelegateCommand(OnSelectImage);
        }


        private async Task OnCancel()
        {
            Message = string.Empty;
            SelectedImage = null;
            //Usually this screen is already the detail screen for the main
            //MasterDetailPage but to give the impression that this screen is being
            //dismissed we navigate to the default Route List screen
            if (Nav.Nav.NavigationStack.Count == 1)
            {
                MessengerInstance.Send(new MenuItemSelectedMessage
                {
                    Page = new NavigationPage(new DrvRoutesPage())
                });
                return;
            }

            await Nav.Nav.PopAsync();

        }

        private async Task OnSend()
        {

            try
            {
                IsBusy = true;
                ReportIssueQueryContext context = new ReportIssueQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    Note = Message,
                    Branch = Settings.MyInfo.CurrentUser.UserBranchCode,
                    ImageBase64 = _selectedImageBytes != null ? Convert.ToBase64String(_selectedImageBytes) : null,

                };
                var response = await Api.ReportIssue(context);
                if (response.Successful.GetValueOrDefault())
                {
                    await Alert.ShowMessage(Translate.Get(nameof(AppResources.ReportSent)),
                        Translate.Get(nameof(AppResources.Report)));
                    Message = string.Empty;
                    SelectedImage = null;
                    return;
                }

                await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
                    Translate.Get(nameof(AppResources.ReportSentError)));
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e, Translate.Get(nameof(AppResources.ReportSentError)));
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task OnSelectImage()
        {

            string cameraStr = Translate.Get(nameof(AppResources.Camera));
            string galleryStr = Translate.Get(nameof(AppResources.Gallery));
            string cancelStr = Translate.Get(nameof(AppResources.Cancel));

            await Plugin.Media.CrossMedia.Current.Initialize();
            var sourceChoice = await AlertService.Instance.DisplayActionSheet(Translate.Get(nameof(AppResources.SelectSource)),
                cancelStr, null, new[] { cameraStr, galleryStr });

            if (sourceChoice == cancelStr)
            {
                return;
            }

            if (sourceChoice == cameraStr)
            {
                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(
                    new Plugin.Media.Abstractions.StoreCameraMediaOptions
                    {
                        AllowCropping = true,
                        SaveToAlbum = true,
                        CompressionQuality = 75,
                        DefaultCamera = CameraDevice.Front
                    });

                if (photo == null) return;
                SelectedImage = photo.AlbumPath;
                using (var ms = new MemoryStream())
                {
                    await photo.GetStream().CopyToAsync(ms);
                    _selectedImageBytes = ms.ToArray();
                }

                return;
            }
            else
            {
                var photo = await Plugin.Media.CrossMedia.Current.PickPhotoAsync();
                if (photo == null) return;
                SelectedImage = photo.Path;
                using (var ms = new MemoryStream())
                {
                    await photo.GetStream().CopyToAsync(ms);
                    _selectedImageBytes = ms.ToArray();
                }
            }

        }
    }
}