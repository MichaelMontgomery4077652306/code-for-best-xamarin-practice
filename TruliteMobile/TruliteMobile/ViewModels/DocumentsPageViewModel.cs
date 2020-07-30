//using System;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using Plugin.DownloadManager;
//using TruliteMobile.Interfaces;
//using TruliteMobile.Models;
//using TruliteMobile.Services;
//using TruliteMobile.ViewModels;
//using TruliteMobile.Views.Pdf;
//using Xamarin.Forms;
//using XamarinUniversity.Infrastructure;

//namespace TruliteMobile.Views.Documents
//{
//    public class DocumentsPageViewModel : TruliteBaseViewModel
//    {
//        #region Properties
//        private ObservableCollection<DocumentUploadView> _list;

//        public ObservableCollection<DocumentUploadView> List
//        {
//            get { return _list; }
//            set
//            {
//                _list = value;
//                RaisePropertyChanged();
//            }
//        }
//        #endregion
//        #region Command

//        public ICommand DownloadDocumentCommand { get; }
//        public ICommand ViewPdfCommand { get; }
//        #endregion

//        public DocumentsPageViewModel()
//        {
//            DownloadDocumentCommand = new AsyncDelegateCommand<DocumentUploadView>(OnDownloadDocument);
//            ViewPdfCommand = new AsyncDelegateCommand<DocumentUploadView>(OnViewPdf);
//            List = new ObservableCollection<DocumentUploadView>();

//        }

//        #region CommandMethods

//        private async Task OnDownloadDocument(DocumentUploadView arg)
//        {
//            try
//            {


//                //var downloadManager = CrossDownloadManager.Current;
//                //var file = downloadManager.CreateDownloadFile(url);
//                //downloadManager.Start(file);
//                if (!(await GetStoragePermission())) return;
//                IsBusy = true;
//                var data = await Api.GetDocumentCopy(arg.Id.GetValueOrDefault());
//                var fileHelper = DependencyService.Get<IFileHelper>();
//                if (fileHelper == null) return;
//                var path = await fileHelper.GetDownloadFile(arg.OriginalName);
//                Debug.WriteLine(path);
//                File.WriteAllBytes(path, data);
                
//            }
//            catch (Exception e)
//            {
//                await Alert.DisplayError(e);
//            }
//            finally
//            {
//                IsBusy = false;
//            }


//        }

//        private async Task OnViewPdf(DocumentUploadView arg)
//        {
//            try
//            {
//                IsBusy = true;
                
//                var data = await ApiService.Instance.GetDocumentCopy(arg.Id.GetValueOrDefault());
//                await Nav.NavigateTo(new PdfPage(data, $"{arg.Name}"));

//            }
//            catch (Exception ex)
//            {
//                await Alert.DisplayError(ex);
//            }
//            finally
//            {
//                IsBusy = false;
//            }
//        }
        
//        #endregion
//        public async Task Load()
//        {
//            try
//            {
//                IsBusy = true;

//                var response = await Api.GetDocuments(Api.GetCustomerContext());

//                if (!response.Successful.GetValueOrDefault())
//                {
//                    await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
//                        Translate.Get("CouldNotGetDocumentList"));
//                    return;
//                }

//                List = new ObservableCollection<DocumentUploadView>(response.Data);
//            }
//            catch (Exception e)
//            {
//                await Alert.DisplayError(e);
//            }
//            finally
//            {
//                IsBusy = false;
//            }

//        }
//    }
//}