using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using TruliteMobile.Interfaces;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvRoutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvRoutesPage : ContentPage
    {
        private readonly DrvRoutesPageViewModel _vm;

        public DrvRoutesPage()
        {
            InitializeComponent();
            BindingContext = _vm = new DrvRoutesPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class DrvRoutesPageViewModel : TruliteBaseViewModel, ILoadableViewModel
    {

        private ObservableCollection<SalesPool> _list;

        public ObservableCollection<SalesPool> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }

         public ICommand OpenRouteCommand { get; }


        public DrvRoutesPageViewModel()
        {
            OpenRouteCommand= new AsyncDelegateCommand<SalesPool>(OnOpenRoute);
        }

        private async Task OnOpenRoute(SalesPool arg)
        {
            await Nav.NavigateTo(new DrvRoutesPackingSlipsPage(arg));
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var result = await Api.GetDriverRoutes();
                List = new ObservableCollection<SalesPool>(result.Data);

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

    public class RouteItem : ObservableObject
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }

    }
}