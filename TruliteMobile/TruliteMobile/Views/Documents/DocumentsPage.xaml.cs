using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.PackingSlips;
using TruliteMobile.Views.Pdf;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Documents
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DocumentsPage : ContentPage
    {
        private readonly DocumentsPageViewModel _vm;

        public DocumentsPage()
        {
            //NavigationPage.SetHasNavigationBar(this,false);
            InitializeComponent();
            BindingContext = _vm = new DocumentsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DocumentsPageViewModel : TruliteBaseViewModel
    {
        #region Properties
        private ObservableCollection<DocumentUploadView> _list;

        public ObservableCollection<DocumentUploadView> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }



        private ObservableCollection<SortColumnItem> _sortColumns;

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                RaisePropertyChanged();
            }
        }

        private SortColumnItem _selectedSortColumn;

        public SortColumnItem SelectedSortColumn
        {
            get { return _selectedSortColumn; }
            set
            {
                _selectedSortColumn = value;
                RaisePropertyChanged();
            }
        }

        #endregion
        #region Command

        public ICommand DownloadDocumentCommand { get; }
        public ICommand ViewPdfCommand { get; }

        public ICommand FilterTriggerCommand { get; }
        #endregion

        public DocumentsPageViewModel()
        {
            DownloadDocumentCommand = new AsyncDelegateCommand<DocumentUploadView>(OnDownloadDocument);
            ViewPdfCommand = new AsyncDelegateCommand<DocumentUploadView>(OnViewPdf);
            FilterTriggerCommand = new Command<SortColumnItem>(OnChangeSortOrder);
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(DocumentSortColumns.CreatedBy, nameof(AppResources.CreatedBy).Translate()),
                new SortColumnItem(DocumentSortColumns.Name, nameof(AppResources.Name).Translate()),
                new SortColumnItem(DocumentSortColumns.CreatedDate, nameof(AppResources.DateCreated).Translate()),
                new SortColumnItem(DocumentSortColumns.Global, nameof(AppResources.Global).Translate()),
            };
            SelectedSortColumn = _sortColumns[0];
            List = new ObservableCollection<DocumentUploadView>();
        }



        #region CommandMethods 
        private void OnChangeSortOrder(SortColumnItem sortColumn)
        {
            var list = _list.ToList();
            switch (sortColumn.Key.ObjectToEnum<DocumentSortColumns>())
            {
                case DocumentSortColumns.CreatedDate:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.DateCreated.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateCreated.GetValueOrDefault()).ToList();
                    break;
                case DocumentSortColumns.Name:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.Name).ToList()
                        : list.OrderByDescending(p => p.Name).ToList();
                    break;
                case DocumentSortColumns.CreatedBy:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.CreatedBy).ToList()
                        : list.OrderByDescending(p => p.CreatedBy).ToList();
                    break;
                case DocumentSortColumns.Global:
                    list = sortColumn.Ascending ? list.OrderBy(p => p.HasCustomer.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.HasCustomer.GetValueOrDefault()).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            List = new ObservableCollection<DocumentUploadView>(list);
        }
        private async Task OnDownloadDocument(DocumentUploadView arg)
        {
            try
            {


                //var downloadManager = CrossDownloadManager.Current;
                //var file = downloadManager.CreateDownloadFile(url);
                //downloadManager.Start(file);
                if (!(await GetStoragePermission())) return;
                IsBusy = true;
                var data = await Api.GetDocumentCopy(arg.Id.GetValueOrDefault());
                var fileHelper = DependencyService.Get<IFileHelper>();
                if (fileHelper == null) return;
                var path = await fileHelper.GetDownloadFile(arg.OriginalName);
                Debug.WriteLine(path);
                File.WriteAllBytes(path, data);

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

        private async Task OnViewPdf(DocumentUploadView arg)
        {
            try
            {
                IsBusy = true;
                var data = await ApiService.Instance.GetDocumentCopy(arg.Id.GetValueOrDefault());
                await Nav.NavigateTo(new PdfPage(data, $"{arg.Name}"));

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

        #endregion
        public async Task Load()
        {
            try
            {
                IsBusy = true;

                var response = await Api.GetDocuments(Api.GetCustomerContext());

                if (!response.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(response.ExceptionMessage, response.ValidationErrors,
                        Translate.Get("CouldNotGetDocumentList"));
                    return;
                }

                List = new ObservableCollection<DocumentUploadView>(response.Data.OrderByDescending(p => p.DateCreated.GetValueOrDefault()));
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

    public enum DocumentSortColumns
    {
        CreatedDate,
        Name,
        CreatedBy,
        Global


    }
}