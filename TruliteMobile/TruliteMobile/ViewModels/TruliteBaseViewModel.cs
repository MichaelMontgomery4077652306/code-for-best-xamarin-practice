using System;
using ExTrack.Services;
using GalaSoft.MvvmLight;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.Views.Feedback;
using TruliteMobile.Views.Settings;
using Xamarin.Forms;
using XamarinUniversity.Commands;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.ViewModels
{
    public abstract class TruliteBaseViewModel : ViewModelBase
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged();
            }
        }

        private bool _showFilter;

        public bool ShowFilter
        {
            get { return _showFilter; }
            set
            {
                _showFilter = value;
                RaisePropertyChanged();
            }
        }


        private bool _noResults;

        public bool NoResults
        {
            get { return _noResults; }
            set
            {
                _noResults = value;
                RaisePropertyChanged();
            }
        }

        public Grid RootGrid { get; set; }

        public AlertService Alert => AlertService.Instance;
        public ISettingsService Settings => SettingsService.Instance;
        public NavigationService Nav => NavigationService.Instance;
        public ApiService Api => ApiService.Instance;
        public TranslationService Translate => TranslationService.Instance;
        public ICommand ToggleFilterCommand { get; }
        public ICommand OpenSettingsCommand { get; }

        public TruliteBaseViewModel()
        {
            ToggleFilterCommand = new Command(() => ShowFilter = !_showFilter);
            OpenSettingsCommand = new AsyncDelegateCommand(OnGiveFeedback);
        }

        private async Task OnGiveFeedback()
        {
            await Nav.Nav.PushAsync(new SettingsPage());
        }

        public async Task Back()
        {
            await Nav.Nav.PopAsync();
        }

        protected async Task NavigateTo(ContentPage pg, bool overrideIsBusy = false)
        {
            try
            {
                if (!overrideIsBusy)
                {
                    if (IsBusy) return;
                    IsBusy = true;

                }
                await Nav.NavigateTo(pg);
            }
            catch (Exception e)
            {

                await Alert.DisplayError(e);

            }
            finally
            {
                if (!overrideIsBusy)
                {
                    IsBusy = false;

                }
            }
        }

        private ToastView _toast = null;
        protected async Task ShowToast(string message = null)
        {

            if (RootGrid == null) return;
            if (_toast == null)
            {
                 _toast = new ToastView
                {
                    Text = message ?? nameof(AppResources.SuccessToastMessage).Translate()
                };
                var columnSpan = RootGrid.ColumnDefinitions.Count == 0 ? 1 : RootGrid.ColumnDefinitions.Count;
                var rowSpan = RootGrid.RowDefinitions.Count == 0 ? 1 : RootGrid.RowDefinitions.Count;

                Grid.SetColumnSpan(_toast, columnSpan);
                Grid.SetRowSpan(_toast, rowSpan);
                RootGrid.Children.Add(_toast);
            }

            await _toast.Show();
        }
        protected async Task<bool> GetStoragePermission()
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
            if (status == PermissionStatus.Granted) return true;

            await CrossPermissions.Current.RequestPermissionsAsync(new Permission[] { Permission.Storage });
            status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
            if (status == PermissionStatus.Granted) return true;
            await Alert.ShowMessage(
                "Cound not get storage permission. This needs to be granted to save the file");
            return false;

        }


    }
}