using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderRequestDateChangePage : ContentPage
    {
        private readonly OrderRequestDateChangePageViewModel _vm;

        public OrderRequestDateChangePage(SalesOrder order)
        {
            InitializeComponent();
            BindingContext = _vm = new OrderRequestDateChangePageViewModel(order);
        }
    }

    public class OrderRequestDateChangePageViewModel : TruliteBaseViewModel
    {
        #region Properties

        private SalesOrder _order;

        private DateTime _currentDate;

        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set
            {
                _currentDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _newDate;

        public DateTime? NewDate
        {
            get { return _newDate; }
            set
            {
                _newDate = value;
                RaisePropertyChanged();
            }
        }

        private string _notes;

        public string Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                RaisePropertyChanged();
            }
        }

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
        public SalesOrder Order
        {
            get { return _order; }
            set { _order = value; RaisePropertyChanged(); }
        }

        #endregion

        #region Commands
        public ICommand CancelCommand { get; }
        public ICommand SubmitCommand { get; }


        #endregion
        public OrderRequestDateChangePageViewModel(SalesOrder order)
        {

            CancelCommand= new AsyncDelegateCommand(OnCancel);
            SubmitCommand= new AsyncDelegateCommand(OnSubmit);
            Order = order;
            if (order.DeliveryDate.HasValue)
            {
                CurrentDate = order.DeliveryDate.Value.DateTime;
            }
            Title = $"{nameof(AppResources.RequestDateChangeFor).Translate()} {order.Key}";

        }

        private async Task OnSubmit()
        {
            try
            {
                IsBusy = true;
                RequestOrderDateChangeViewModel context = new RequestOrderDateChangeViewModel
                {
                    CustomerAccountNumber = Settings.MyInfo.CustomerInfo.Key,
                    Comments = _notes,
                    SalesOrder = _order,
                    FullName = Settings.MyInfo.CurrentUser.FullName,
                    NewDeliveryDate = _newDate,
                    BranchCode = _order.InventLocationId

                };
                var result= await Api.RequestDateChange(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                await Nav.Nav.PopAsync();

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

        private async Task OnCancel()
        {
            await Nav.Nav.PopAsync();
        }
    }


}