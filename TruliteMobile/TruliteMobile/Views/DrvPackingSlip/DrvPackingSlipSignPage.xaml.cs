using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using SignaturePad.Forms;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.DrvSurvey;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvPackingSlipSignPage : ContentPage
    {
        private readonly DrvPackingSlipSignPageViewModel _vm;

        public DrvPackingSlipSignPage(IEnumerable<PackingSlip> packingSlips)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvPackingSlipSignPageViewModel(packingSlips, signatureView)
                {RootGrid = root};
        }
    }


    public class DrvPackingSlipSignPageViewModel : TruliteBaseViewModel
    {
        #region Properties


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

        private readonly SignaturePadView _signatureView;

        private readonly List<PackingSlip> _packingSlips;

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

        private string _printedName;

        public string PrintedName
        {
            get { return _printedName; }
            set
            {
                _printedName = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<SignatureImage> _pictureList;

        public ObservableCollection<SignatureImage> PictureList
        {
            get { return _pictureList; }
            set
            {
                _pictureList = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Commands

        public ICommand ClearCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand SubmitCommand { get; }
        public ICommand ChoosePicturesCommand { get; }
        public ICommand DeletePictureCommand { get; }

        #endregion
        public DrvPackingSlipSignPageViewModel(IEnumerable<PackingSlip> packingSlips, SignaturePadView signatureView)
        {
            _signatureView = signatureView;
            _packingSlips = packingSlips.ToList();
            ClearCommand = new Command(OnClear);
            SubmitCommand = new AsyncDelegateCommand(OnSubmit);
            CloseCommand = new AsyncDelegateCommand(OnClose);
            ChoosePicturesCommand = new AsyncDelegateCommand(OnChoosePicture);
            DeletePictureCommand = new Command<SignatureImage>(OnDeleteImage);
            PictureList= new ObservableCollection<SignatureImage>();
            Title = string.Format(nameof(AppResources.SignatureForPackingSlips).Translate(),
                GetFlattenedPackingSlipList(_packingSlips));

        }



        private static string GetFlattenedPackingSlipList(List<PackingSlip> list)
        {
            if ((!list?.Any()) ?? true)
            {
                return " - ";
            }

            if (list.Count == 1)
            {
                return list[0].Key;
            }
            var sb= new StringBuilder();
            foreach (var packingSlip in list)
            {
                sb.Append(packingSlip.Key);
                if(packingSlip==list.Last())
                {
                    continue;
                }

                sb.Append(", ");
            }

            return sb.ToString();
        }

        private void OnDeleteImage(SignatureImage picture)
        {
            PictureList.Remove(picture);
            RaisePropertyChanged(nameof(PictureList));
        }


        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }

        private async Task OnSubmit()
        {

            try
            {
                IsBusy = true;

                var signatureStream = await _signatureView.GetImageStreamAsync(SignatureImageFormat.Jpeg, Color.Black);
                var imageData = new byte[signatureStream.Length];
                await signatureStream.WriteAsync(imageData, 0, (int)signatureStream.Length);

                var signatureData = Convert.ToBase64String(imageData);
                foreach (var packingSlip in _packingSlips)
                {
                    var context = new SignatureQueryContext
                    {
                        CustomerInfo = Api.GetCustomerContext(),
                        Branch = packingSlip.Branch.Code,
                        Email = _email,
                        PackingSlipId = packingSlip.Key,
                        PackingSlipDate = packingSlip.PackingSlipDate,
                        PrintedName = _printedName,
                        SalesOrderId = packingSlip.CustomerPurchaseOrderNo,
                        SignatureBase64 =signatureData,
                        Images = new List<SignatureImage>(_pictureList)
                    };

                    var response = await Api.PostSignature(context);

                    if (!response.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
                            Translate.Get(nameof(AppResources.DrvSignPageError1)));
                    }
                }

                IsBusy = false;
                await ShowToast();
                await NavigateTo(new DrvSurveyPage(_packingSlips), true);
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e, Translate.Get(nameof(AppResources.ServerError)));
            }
            finally
            {
                IsBusy = false;
            }


        }

        private  void OnClear()
        {
            _signatureView.Clear();
            PrintedName = string.Empty;
            Email = string.Empty;
            PictureList= new ObservableCollection<SignatureImage>();
        }

        #region Picture Selection and Processing

        private async Task OnChoosePicture()
        {
            try
            {
                var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
                var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);

                if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
                {
                    var statuses = await CrossPermissions.Current.RequestPermissionsAsync(new Permission[]
                        {Permission.Camera, Permission.Storage});
                }

                var b = await CrossMedia.Current.Initialize();


                string cameraStr = Translate.Get(nameof(AppResources.Camera));
                string galleryStr = Translate.Get(nameof(AppResources.Gallery));
                string cancelStr = Translate.Get(nameof(AppResources.Cancel));

                var sourceChoice = await AlertService.Instance.DisplayActionSheet(
                    Translate.Get(nameof(AppResources.SelectSource)),
                    cancelStr, null, new[] {cameraStr, galleryStr});

                if (sourceChoice == cancelStr)
                {
                    return;
                }

                var mediaFile = (sourceChoice == cameraStr)
                    ? await TakePhoto()
                    : await PickFromGallery();

                if (mediaFile == null)
                {
                    return;
                }

                IsBusy = true;

                var image = new SignatureImage
                {
                    Base64Content = GetBase64Data(mediaFile),
                    FileName = Path.GetFileName(mediaFile.Path)
                };
                PictureList.Add(image);
                RaisePropertyChanged(nameof(PictureList));

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


        private string GetBase64Data(MediaFile file)
        {
            var imageStream = file.GetStream();
            var dataBytes = new byte[imageStream.Length];
            //Read block of bytes from stream into the byte array
            imageStream.Read(dataBytes, 0, System.Convert.ToInt32(imageStream.Length));
            return Convert.ToBase64String(dataBytes);

        }

        private async Task<MediaFile> PickFromGallery()
        {

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await Alert.ShowMessage(nameof(AppResources.GalleryNotSupportedMessage).Translate());
                return null;
            }
            var mediaFile =
                await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions { PhotoSize = PhotoSize.Small });

            return mediaFile;


        }

        private async Task<MediaFile> TakePhoto()
        {

            if (!CrossMedia.Current.IsTakePhotoSupported)
            {
                await Alert.ShowMessage(nameof(AppResources.NoSupportForPhotosMessage).Translate());
                return null;
            }

            var mediaFile = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    DefaultCamera = CameraDevice.Rear,
                    SaveToAlbum = false,
                });
            return mediaFile;

        }

        #endregion
    }
}