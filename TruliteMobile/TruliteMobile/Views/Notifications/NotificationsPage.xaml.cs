using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Notifications
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationsPage : ContentPage
    {
        private readonly NotificationsPageViewModel _vm;

        public NotificationsPage()
        {
            InitializeComponent();
            BindingContext = _vm = new NotificationsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }
    public class NotificationsPageViewModel : TruliteBaseViewModel
    {

        private ObservableCollection<CustomerNotification> _list;
        private SortColumnItem _previousSortColumn;

        public ObservableCollection<CustomerNotification> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }

        public ICommand FilterChangeCommand { get; }
        public ICommand MarkReadCommand { get; }
        public ICommand SearchCommand { get; }

        public NotificationsPageViewModel()
        {
            MarkReadCommand = new AsyncDelegateCommand<CustomerNotification>(OnMarkRead);
            SearchCommand = new AsyncDelegateCommand<NotificationFilter>(OnSearch);
            FilterChangeCommand = new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
        }

        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                if (arg == null) return;
                IsBusy = true;
                var sortedList = SortList(arg, _list);
                List = new ObservableCollection<CustomerNotification>(sortedList);
                _previousSortColumn = arg;

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

        private static ICollection<CustomerNotification> SortList(SortColumnItem sortOrder, ICollection<CustomerNotification> list)
        {
            switch (sortOrder.Key.ObjectToEnum<NotificationSortColumns>())
            {

                case NotificationSortColumns.RecordId:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.RefRecId).ToList()
                        : list.OrderByDescending(p => p.RefRecId).ToList();

                    break;
                case NotificationSortColumns.Date:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.DateTime.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateTime.GetValueOrDefault()).ToList();
                    break;
                case NotificationSortColumns.Read:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.IsRead.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.IsRead.GetValueOrDefault()).ToList();
                    break;
                case NotificationSortColumns.Type:
                    list = sortOrder.Ascending ? list.OrderBy(p => p.NotificationType).ToList()
                        : list.OrderByDescending(p => p.NotificationType).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return list;
        }
        private async Task OnSearch(NotificationFilter arg)
        {
            await Load(arg.StartDate, arg.EndDate, _previousSortColumn);
            ShowFilter = false;
        }


        private async Task OnMarkRead(CustomerNotification arg)
        {
            try
            {
                if (arg == null) return;
                var isRead = arg.IsRead.GetValueOrDefault();
                var message = isRead
                    ? nameof(AppResources.MarkNotReadMessage).Translate()
                    : nameof(AppResources.MarkReadMessage).Translate();

                var confirmation = await Alert
                    .ShowMessageConfirmation(message,
                        null,
                        nameof(AppResources.Yes).Translate(),
                        nameof(AppResources.No).Translate());

                if (!confirmation) return;
                IsBusy = true;
                arg.IsRead = !isRead;
                var notificationRead = await Api.MarkNotificationRead(arg);
                if (notificationRead.Successful.GetValueOrDefault())
                {
                    await Load();
                    return;
                }

                await Alert.ShowMessage(notificationRead.ExceptionMessage);

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



        public async Task Load(DateTime? startTime = null, DateTime? endTime = null, SortColumnItem sortColumn = null)
        {
            try
            {
                IsBusy = true;
                if (sortColumn == null)
                {
                    sortColumn = new SortColumnItem(NotificationSortColumns.RecordId, null);
                }
                var context = new CustomerNotificationsQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    FromDate = startTime ?? DateTime.Now.AddMonths(-3),
                    ToDate = endTime ?? DateTimeOffset.Now
                };
                var notificationsResponse = await Api.GetNotifications(context);
                if (!notificationsResponse.Successful.GetValueOrDefault())
                {
                    await Alert.ShowMessage(notificationsResponse.ExceptionMessage);

                    return;
                }
                var sortedList = SortList(sortColumn, notificationsResponse.Data);
                List = new ObservableCollection<CustomerNotification>(sortedList);
                NoResults = !_list.Any();

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
}