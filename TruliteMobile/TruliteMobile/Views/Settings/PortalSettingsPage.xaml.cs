using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Users;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PortalSettingsPage : ContentPage
    {
        private readonly PortalSettingsPageViewModel _vm;

        public PortalSettingsPage()
        {
            InitializeComponent();
            BindingContext= _vm=new PortalSettingsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();

        }
    }


    public class PortalSettingsPageViewModel : TruliteBaseViewModel
    {



        public async Task Load(UserFilter filter = null)
        {
            try
            {
                IsBusy = true;
                var context = new PortalSettingsQueryContext();
                var settings =await Api.GetPortalSettings(context);
                
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