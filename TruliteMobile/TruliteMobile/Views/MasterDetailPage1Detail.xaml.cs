using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Syncfusion.SfChart.XForms;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Chart;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        private readonly MasterDetailPage1DetailViewModel _vm;

        public MasterDetailPage1Detail()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new MasterDetailPage1DetailViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class MasterDetailPage1DetailViewModel : TruliteBaseViewModel

    {


        private bool _showInvoicesDaily;

        public bool ShowInvoicesDaily
        {
            get { return _showInvoicesDaily; }
            set
            {
                _showInvoicesDaily = value;
                RaisePropertyChanged();
            }
        }

        private bool _showInvoicesMontly;

        public bool ShowInvoicesMontly
        {
            get { return _showInvoicesMontly; }
            set
            {
                _showInvoicesMontly = value;
                RaisePropertyChanged();
            }
        }

        private bool _showInvoicesQuartely;

        public bool ShowInvoicesQuartely
        {
            get { return _showInvoicesQuartely; }
            set
            {
                _showInvoicesQuartely = value;
                RaisePropertyChanged();
            }
        }

        private bool _showSalesOrderSummary;

        public bool ShowSalesOrderSummary
        {
            get { return _showSalesOrderSummary; }
            set
            {
                _showSalesOrderSummary = value;
                RaisePropertyChanged();
            }
        }


        private bool _showOrdersDaily;

        public bool ShowOrdersDaily
        {
            get { return _showOrdersDaily; }
            set
            {
                _showOrdersDaily = value;
                RaisePropertyChanged();
            }
        }


        private bool _showOrdersMontly;

        public bool ShowOrdersMontly
        {
            get { return _showOrdersMontly; }
            set
            {
                _showOrdersMontly = value;
                RaisePropertyChanged();
            }
        }

        private bool _showOrdersYearly;

        public bool ShowOrdersYearly
        {
            get { return _showOrdersYearly; }
            set
            {
                _showOrdersYearly = value;
                RaisePropertyChanged();
            }
        }

        private string _lastRefreshed;

        public string LastRefreshed
        {
            get { return _lastRefreshed; }
            set
            {
                _lastRefreshed = value;
                RaisePropertyChanged();
            }
        }


        private bool _showSupportPanel;

        public bool ShowSupportPanel
        {
            get { return _showSupportPanel; }
            set
            {
                _showSupportPanel = value;
                RaisePropertyChanged();
            }
        }


        public ICommand RefreshCommand { get; }
        public MasterDetailPage1DetailViewModel()
        {
            RefreshCommand = new Command(() =>
             {
                 LastRefreshed = GetLastRefreshString();
                 MessengerInstance.Send(new RefreshDashboardMessage());
             });

        }


        private string GetLastRefreshString()
        {
            return $"{nameof(AppResources.LastRefreshed).Translate()}: {DateTime.Now:G}";
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                ShowInvoicesDaily = Settings.MyPreferences.ShowInvoicesDaily.GetValueOrDefault();
                ShowInvoicesMontly = Settings.MyPreferences.ShowInvoicesMonthly.GetValueOrDefault();
                ShowInvoicesQuartely = Settings.MyPreferences.ShowInvoicesQuarterly.GetValueOrDefault();
                ShowOrdersDaily = Settings.MyPreferences.ShowOrdersDaily.GetValueOrDefault();
                ShowOrdersMontly = Settings.MyPreferences.ShowOrdersMonthly.GetValueOrDefault();
                ShowOrdersYearly = Settings.MyPreferences.ShowOrdersYearly.GetValueOrDefault();
                ShowSalesOrderSummary = Settings.MyPreferences.ShowSalesOrdersSummaryByStatus.GetValueOrDefault();
                ShowSupportPanel = !Settings.IsImpersonatingCustomer;
                LastRefreshed = GetLastRefreshString();
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