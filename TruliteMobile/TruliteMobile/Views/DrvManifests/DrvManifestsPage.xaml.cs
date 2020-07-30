using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvManifests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvManifestsPage : ContentPage
    {
        private readonly DrvManifestsPageViewModel _vm;

        public DrvManifestsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new DrvManifestsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvManifestsPageViewModel : TruliteBaseViewModel
    {
        private ObservableCollection<ShipManifestHeader> _manifests;

        public ObservableCollection<ShipManifestHeader> Manifests
        {
            get { return _manifests; }
            set
            {
                _manifests = value;
                RaisePropertyChanged();
            }
        }


        private ShipManifestHeader _selectedManifest;

        public ShipManifestHeader SelectedManifest
        {
            get { return _selectedManifest; }
            set
            {
                _selectedManifest = value;
                RaisePropertyChanged();
            }
        }


        private string _filterDriverName;

        public string FilterDriverName
        {
            get { return _filterDriverName; }
            set
            {
                _filterDriverName = value;
                RaisePropertyChanged();
            }
        }

        private bool _ascending;
        private ObservableCollection<SortColumnItem> _sortColumns;

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
                RaisePropertyChanged();
            }
        }

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



        public ICommand ResetFilterCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterTriggerCommand { get; }
        public ICommand OpenLinesCommand { get; }
        public DrvManifestsPageViewModel()
        {
            ResetFilterCommand = new AsyncDelegateCommand(OnReset);
            SearchCommand = new AsyncDelegateCommand(Load);
            OpenLinesCommand = new AsyncDelegateCommand(OnOpenLineItem);
            FilterTriggerCommand = new Command<SortColumnItem>(OnFilterChanged);
            FilterDriverName = Settings.MyInfo.CurrentUser.FullName;
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(ManifestSortColumns.SalesPool, nameof(AppResources.SalesPool).Translate()),
                new SortColumnItem(ManifestSortColumns.Manifest, nameof(AppResources.Manifest_CamelCase).Translate()),
                new SortColumnItem(ManifestSortColumns.DriverName, nameof(AppResources.DriverName).Translate()),
                new SortColumnItem(ManifestSortColumns.ShippingDate, nameof(AppResources.ShippingDate).Translate()),
            };
            SelectedSortColumn = _sortColumns[1];
            Ascending = true;

        }

        
        private void OnFilterChanged(SortColumnItem arg)
        {
            if(_manifests==null|| arg==null)return;
            SelectedSortColumn = arg;
            Manifests= new ObservableCollection<ShipManifestHeader>(SortList(arg, _manifests));
        }

        private static ICollection<ShipManifestHeader> SortList(SortColumnItem sortOrder, ICollection<ShipManifestHeader> list)
        {
            switch (sortOrder.Key.ObjectToEnum<ManifestSortColumns>())
            {
                case ManifestSortColumns.SalesPool:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.SalesPoolId).ToList()
                        : list.OrderByDescending(p => p.SalesPoolId).ToList();
                    break;
                case ManifestSortColumns.Manifest:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.Key).ToList()
                        : list.OrderByDescending(p => p.Key).ToList();
                    break;
                case ManifestSortColumns.DriverName:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DriverName).ToList()
                        : list.OrderByDescending(p => p.DriverName).ToList();
                    break;
                case ManifestSortColumns.ShippingDate:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.ShippingDate).ToList()
                        : list.OrderByDescending(p => p.ShippingDate).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
        
        private async Task OnReset()
        {
            FilterDriverName = string.Empty;
            SelectedSortColumn = _sortColumns[1];
            Ascending = true;
            await Load();
        }

        private async Task OnOpenLineItem()
        {

            if (_selectedManifest == null) return;
            await Nav.NavigateTo(new DrvManifestsDetailPage(_selectedManifest.Key));

        }
        


        public async Task Load()
        {

            try
            {
                IsBusy = true;
                if (_selectedSortColumn == null)
                {
                    SelectedSortColumn = _sortColumns[1];
                }

                var context = new ShipManifestHeadersQueryContext
                {
                    ShippingDate = DateTimeOffset.UtcNow.Date,
                    InventLocationId = SettingsService.Instance.MyInfo.CurrentUser.UserBranchCode,
                    Driver = _filterDriverName
                };

                var result = await Api.GetShipManifestHeaders(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }
                Manifests = new ObservableCollection<ShipManifestHeader>(SortList(_selectedSortColumn, result.Data));
                NoResults = !_manifests.Any();
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

    public enum ManifestSortColumns
    {
        SalesPool,
        Manifest,
        DriverName,
        ShippingDate
    }
}