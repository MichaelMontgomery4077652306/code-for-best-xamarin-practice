using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using TruliteMobile.Enums;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.Views.DrvRoutes;
using TruliteMobile.Views.Invoices;
using TruliteMobile.Views.Pipeline;
using TruliteMobile.Views.PipelineAccounts;
using TruliteMobile.Views.SuperuserAccounts;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1(MainPageMode mode = MainPageMode.Default)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            Messenger.Default.Register<MenuItemSelectedMessage>(this, OnMenuItemSelected);


            switch (SettingsService.Instance.ApplicationMode)
            {
                case ApplicationModeEnum.Portal:
                    if (mode == MainPageMode.PortalSuperUser)
                    {
                        Detail = new NavigationPage(new SuperUserAccountsPage());
                    }
                    else
                    {
                        Detail = new NavigationPage(new MasterDetailPage1Detail());
                    }

                    break;
                case ApplicationModeEnum.Driver:
                    Detail = new NavigationPage(new DrvRoutesPage());
                    break;
                case ApplicationModeEnum.Pipeline:
                    if (mode == MainPageMode.CalledFromPipelineCustomerScreen)
                    {
                        Detail = new NavigationPage(new MasterDetailPage1Detail());
                    }
                    else
                    {
                        Detail = mode == MainPageMode.OpenInPipelineAccounts ? 
                            new NavigationPage(new PipelineAccountsPage()) 
                            : new NavigationPage(new PipelinePage());
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnMenuItemSelected(MenuItemSelectedMessage message)
        {
            IsPresented = false;
            if (message.Page != null)
            {
                Detail = message.Page;
            }
        }

    }
}