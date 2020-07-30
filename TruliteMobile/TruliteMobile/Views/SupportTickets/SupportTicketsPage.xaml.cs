using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.SupportTickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportTicketsPage : ContentPage
    {
        private readonly SupportTicketsPageViewModel _vm;

        public SupportTicketsPage()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new SupportTicketsPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class SupportTicketsPageViewModel : TruliteBaseViewModel
    {

        private ObservableCollection<ExtendedCustomerBranchView> _branchList;

        public ObservableCollection<ExtendedCustomerBranchView> BranchList
        {
            get { return _branchList; }
            set
            {
                _branchList = value;
                RaisePropertyChanged();
            }
        }




        private ObservableCollection<TruDeskItem> _list;

        public ObservableCollection<TruDeskItem> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }


        public ICommand AddSupportTicketCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FilterChangeCommand { get; }

        public SupportTicketsPageViewModel()
        {
            AddSupportTicketCommand = new AsyncDelegateCommand(OnAddTicket);
            SearchCommand = new AsyncDelegateCommand<SupportTicketsFilterModel>(OnSearch);
            //FilterChangeCommand= new AsyncDelegateCommand<SortColumnItem>(OnFilterChanged);
        }

        private async Task OnFilterChanged(SortColumnItem arg)
        {
            try
            {
                IsBusy = true;
                await LoadSupportTickets(_previousFilter, arg);
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

        private async Task OnSearch(SupportTicketsFilterModel arg)
        {
            try
            {
                IsBusy = true;
                await LoadSupportTickets(new BranchTicketsQueryContext
                {
                    CustomerBranchId = arg.SelectedBranch.CustomerBranchId,
                    CustomerInfo = Api.GetCustomerContext(),
                    BusinessUnit = arg.SelectedBranch.BusinessUnit.BusinessUnit,
                    ViewName = arg.Status.Value
                }, arg.SortColumn);
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

        private async Task OnAddTicket()
        {
            await Nav.NavigateTo(new AddSupportTicketPage());
        }

        public async Task Load(BranchTicketsQueryContext filter = null)
        {
            try
            {
                IsBusy = true;
                var plantsResult = await Api.GetTicketBranches();
                if (!plantsResult.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(plantsResult.ExceptionMessage, plantsResult.ValidationErrors, nameof(AppResources.ServerError).Translate());
                    return;
                }


                var extendedBranches = new List<ExtendedCustomerBranchView>();

                foreach (var customerBranchView in plantsResult.Data.Select(p => p.CloneToType<ExtendedCustomerBranchView, CustomerBranchView>()))
                {
                    foreach (var businessUnit in customerBranchView.BuisnessUnits)
                    {
                        var newBranch = customerBranchView.CloneJson();
                        newBranch.BusinessUnit = businessUnit;
                        extendedBranches.Add(newBranch);
                    }


                }
                BranchList = new ObservableCollection<ExtendedCustomerBranchView>(extendedBranches);


                filter = filter ?? new BranchTicketsQueryContext
                {
                    CustomerInfo = Api.GetCustomerContext(),
                    CustomerBranchId = _branchList.FirstOrDefault()?.CustomerBranchId,
                    ViewName = "All Requests",
                    BusinessUnit = _branchList.FirstOrDefault()?.BusinessUnit.BusinessUnit,

                };

                await LoadSupportTickets(filter, new SortColumnItem(SupportTicketsSortableColumns.LastUpdated, "Last Updated"){Ascending = true});


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


        private BranchTicketsQueryContext _previousFilter;


        private bool IsFilterDifferentFromLast(BranchTicketsQueryContext currentFilter)
        {
            if (_previousFilter == null) return true;
            if (_previousFilter.BusinessUnit != currentFilter.BusinessUnit) return true;
            if (_previousFilter.ViewName != currentFilter.ViewName) return true;
            if (_previousFilter.CustomerBranchId != currentFilter.CustomerBranchId) return true;
            return false;

        }


        public async Task LoadSupportTickets(BranchTicketsQueryContext filter, SortColumnItem sortOrder)
        {


            IsBusy = true;
            ICollection<TruDeskItem> list;
            if (IsFilterDifferentFromLast(filter))
            {
                _previousFilter = filter;

                list = await Api.GetBranchTickets(filter);
                if (list == null)
                {
                    List.Clear();
                    await Alert.ShowMessage("No support ticket found");
                    return;
                }
            }
            else
            {
                list = _list;
            }

            List = new ObservableCollection<TruDeskItem>(SortList(sortOrder, list));
        }

        private static List<TruDeskItem> SortList(SortColumnItem sortOrder, ICollection<TruDeskItem> list)
        {
            List<TruDeskItem> orderedList;
            switch ((SupportTicketsSortableColumns) Enum.ToObject(typeof(SupportTicketsSortableColumns),sortOrder.Key))
            {

                case SupportTicketsSortableColumns.Id:
                {
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.Id).ToList() : list.OrderByDescending(p => p.Id).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.Status:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.Status).ToList()
                        : list.OrderByDescending(p => p.Status).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.Subject:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.Subject).ToList()
                        : list.OrderByDescending(p => p.Subject).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.Contact:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.Contact).ToList()
                        : list.OrderByDescending(p => p.Contact).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.LastUpdated:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.UpdatedTime).ToList()
                        : list.OrderByDescending(p => p.UpdatedTime).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.SupportRep:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.SupportRep).ToList()
                        : list.OrderByDescending(p => p.SupportRep).ToList();
                }
                    break;
                case SupportTicketsSortableColumns.Priority:
                {
                    orderedList = sortOrder.Ascending
                        ? list.OrderBy(p => p.Priority).ToList()
                        : list.OrderByDescending(p => p.Priority).ToList();
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return orderedList;
        }
    }


    


    public class ExtendedCustomerBranchView : CustomerBranchView
    {
        private BuisnessUnitView _businessUnit;

        public BuisnessUnitView BusinessUnit
        {
            get { return _businessUnit; }
            set { _businessUnit = value; RaisePropertyChanged(); }
        }

        public string DisplayString
        {
            get { return $"{BranchCode} {Branch} - {_businessUnit?.BusinessUnit ?? string.Empty}"; }
        }
    }
}