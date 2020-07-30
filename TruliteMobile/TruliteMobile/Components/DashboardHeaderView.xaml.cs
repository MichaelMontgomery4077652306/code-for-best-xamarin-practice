using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExTrack.Services;
using GalaSoft.MvvmLight.Messaging;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.Views.Invoices;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.RetunedOrders;
using TruliteMobile.Views.SupportTickets;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardHeaderView : ContentView
    {

        public static readonly BindableProperty HeaderTypeProperty =
            BindableProperty.Create("HeaderType", typeof(DashboardHeaderTypeEnum), typeof(DashboardHeaderView), default(DashboardHeaderTypeEnum), BindingMode.Default, null, HeaderTypePropertyChanged);

        private static async void HeaderTypePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var ctr = (DashboardHeaderView)bindable;
            await ctr.Refresh();
        }

        public DashboardHeaderTypeEnum HeaderType
        {
            get { return (DashboardHeaderTypeEnum)GetValue(HeaderTypeProperty); }
            set { SetValue(HeaderTypeProperty, value); }
        }


        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }


        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public DashboardHeaderView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
            IsBusy = true;
            Messenger.Default.Register<RefreshDashboardMessage>(this, async (m) => await Refresh());
        }

        private async Task Refresh()
        {
            try
            {
                if (_isBusy) return;
                IsBusy = true;
                switch (HeaderType)
                {
                    case DashboardHeaderTypeEnum.Invoices:
                        Text = (await ApiService.Instance.GetOpenInvoicesAmount()).ToString("C");
                        break;
                    case DashboardHeaderTypeEnum.Orders:
                        Text = (await ApiService.Instance.GetOpenSalesOrdersCount()).ToString();
                        break;
                    case DashboardHeaderTypeEnum.Support:
                        {
                            var result = await ApiService.Instance.GetSupportTicketsCount();
                            if (result.Successful.GetValueOrDefault()
                            && result.Data.HasValue)
                            {
                                Text = result.Data.Value.ToString();
                            }
                            else
                            {
                                await AlertService.Instance.DisplayApiCallError(result.ExceptionMessage,
                                    result.ValidationErrors);
                            }
                        }
                        break;
                    case DashboardHeaderTypeEnum.Returns:
                        Text = (await ApiService.Instance.GetOpenReturnOrdersCount()).ToString();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e)
            {
#if DEBUG
                await AlertService.Instance.DisplayError(e);
#endif
            }
            finally
            {
                IsBusy = false;
            }


        }

        protected override async void OnBindingContextChanged()
        {
            await Refresh();
        }

        private async void ShowHelpMessage_Tapped(object sender, EventArgs e)
        {
            switch (HeaderType)
            {
                case DashboardHeaderTypeEnum.Invoices:
                    await AlertService.Instance.ShowMessage("Due invoices in the last two years", "Invoices");
                    break;
                case DashboardHeaderTypeEnum.Orders:
                    await AlertService.Instance.ShowMessage("New Sales Orders Count", "Sales Orders");
                    break;
                case DashboardHeaderTypeEnum.Support:
                    await AlertService.Instance.ShowMessage("New Support Tickets Count", "Support Tickets");
                    break;
                case DashboardHeaderTypeEnum.Returns:
                    await AlertService.Instance.ShowMessage("Pending Returns Count", "Pending Returns");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async void ViewDetails_Tapped(object sender, EventArgs e)
        {
            switch (HeaderType)
            {
                case DashboardHeaderTypeEnum.Invoices:
                    await NavigationService.Instance.NavigateTo(new InvoicesPage());
                    break;
                case DashboardHeaderTypeEnum.Orders:
                    await NavigationService.Instance.NavigateTo(new OrdersPage());
                    break;
                case DashboardHeaderTypeEnum.Support:
                    await NavigationService.Instance.NavigateTo(new SupportTicketsPage());
                    break;
                case DashboardHeaderTypeEnum.Returns:
                    await NavigationService.Instance.NavigateTo(new ReturnedOrdersPage());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public enum DashboardHeaderTypeEnum
    {
        Invoices,
        Orders,
        Support,
        Returns
    }
}