using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.PipelinePaymentCreditCard;
using TruliteMobile.Views.SupportTickets;
using Xamarin.Forms;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.PaymentCreditCard
{
    public partial class PaymentCreditCardPage : ContentPage
    {
        private readonly PaymentCreditCardPageViewModel _vm;

        public PaymentCreditCardPage()
        {
            InitializeComponent();
            BindingContext = _vm = new PaymentCreditCardPageViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class PaymentCreditCardPageViewModel : TruliteBaseViewModel
    {
        private ObservableCollection<CustomerCreditCardTokenViewModel> _creditCardList;

        public ObservableCollection<CustomerCreditCardTokenViewModel> CreditCardList
        {
            get { return _creditCardList; }
            set { _creditCardList = value; RaisePropertyChanged(); }
        }

        private CustomerCreditCardTokenViewModel _selectedCreditCard;

        public CustomerCreditCardTokenViewModel SelectedCreditCard
        {
            get { return _selectedCreditCard; }
            set
            {
                _selectedCreditCard = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<SortColumnItem> _sortColumns;

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

        public ICommand OpenCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand FilterTriggerCommand { get; }
        public PaymentCreditCardPageViewModel()
        {
            OpenCommand = new AsyncDelegateCommand<CustomerCreditCardTokenViewModel>(OnOpen);
            DeleteCommand = new AsyncDelegateCommand<CustomerCreditCardTokenViewModel>(OnDelete);
            FilterTriggerCommand = new Command<SortColumnItem>(OnFilterTriggered);

            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(CreditCardSortColumns.CardType, nameof(AppResources.CardType).Translate()),
                new SortColumnItem(CreditCardSortColumns.CardNumber, nameof(AppResources.CardNumber).Translate()),
                new SortColumnItem(CreditCardSortColumns.ExpiryDate, nameof(AppResources.ExpiryDate).Translate()),
                new SortColumnItem(CreditCardSortColumns.AccountNumber, nameof(AppResources.AccountNumber).Translate()),
                new SortColumnItem(CreditCardSortColumns.AccountName, nameof(AppResources.AccountName).Translate()),
                new SortColumnItem(CreditCardSortColumns.Address, nameof(AppResources.AddressCamelcase).Translate()),
                new SortColumnItem(CreditCardSortColumns.DateCreated, nameof(AppResources.DateCreated).Translate()),
                new SortColumnItem(CreditCardSortColumns.CreatedBy, nameof(AppResources.CreatedBy).Translate()),
                new SortColumnItem(CreditCardSortColumns.DateUpdated, nameof(AppResources.DateUpdated).Translate()),
                new SortColumnItem(CreditCardSortColumns.UpdatedBy, nameof(AppResources.UpdatedBy).Translate()),
                new SortColumnItem(CreditCardSortColumns.CopyEmailReceiptAddress, nameof(AppResources.CopyReceiptEmailAddress).Translate()),

            };
            SelectedSortColumn = _sortColumns[6];

        }

        private static List<CustomerCreditCardTokenViewModel> SortList(SortColumnItem sortOrder, ICollection<CustomerCreditCardTokenViewModel> list)
        {
            List<CustomerCreditCardTokenViewModel> orderedList;

            if ((!list?.Any()) ?? true)
            {
                return new List<CustomerCreditCardTokenViewModel>();
            }

            switch (sortOrder.Key.ObjectToEnum<CreditCardSortColumns>())
            {

                case CreditCardSortColumns.CardType:
                    {
                        orderedList = sortOrder.Ascending ?
                            list.OrderBy(p => p.CardType).ToList()
                            : list.OrderByDescending(p => p.CardType).ToList();
                    }
                    break;
                case CreditCardSortColumns.CardNumber:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.FriendlyName).ToList()
                        : list.OrderByDescending(p => p.FriendlyName).ToList();
                    break;
                case CreditCardSortColumns.ExpiryDate:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.ExpiryDate).ToList()
                        : list.OrderByDescending(p => p.ExpiryDate).ToList();
                    break;
                case CreditCardSortColumns.AccountNumber:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.AccountNo).ToList()
                        : list.OrderByDescending(p => p.AccountNo).ToList();
                    break;
                case CreditCardSortColumns.AccountName:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.Account).ToList()
                        : list.OrderByDescending(p => p.Account).ToList();
                    break;
                case CreditCardSortColumns.Address:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.Address).ToList()
                        : list.OrderByDescending(p => p.Address).ToList();
                    break;
                case CreditCardSortColumns.DateCreated:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.DateCreated.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateCreated.GetValueOrDefault()).ToList();
                    break;
                case CreditCardSortColumns.CreatedBy:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.CreatedBy).ToList()
                        : list.OrderByDescending(p => p.CreatedBy).ToList();
                    break;
                case CreditCardSortColumns.DateUpdated:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.DateUpdated.GetValueOrDefault()).ToList()
                        : list.OrderByDescending(p => p.DateUpdated.GetValueOrDefault()).ToList();
                    break;
                case CreditCardSortColumns.UpdatedBy:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.UpdatedBy).ToList()
                        : list.OrderByDescending(p => p.UpdatedBy).ToList();
                    break;
                case CreditCardSortColumns.CopyEmailReceiptAddress:
                    orderedList = sortOrder.Ascending ?
                        list.OrderBy(p => p.CopyReceiptEmailAddresses?.Count ?? 0).ToList()
                        : list.OrderByDescending(p => p.CopyReceiptEmailAddresses?.Count ?? 0).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return orderedList;
        }

        private void OnFilterTriggered(SortColumnItem obj)
        {
            if (obj == null || _creditCardList == null) return;
            CreditCardList = new ObservableCollection<CustomerCreditCardTokenViewModel>(SortList(obj, _creditCardList));
        }

        private async Task OnDelete(CustomerCreditCardTokenViewModel selectedCreditCard)
        {
            try
            {

                if (IsBusy) return;
                IsBusy = true;
                var response = await Alert.ShowMessageConfirmation(
                    string.Format(nameof(AppResources.AreYouSureYouWantToDeleteCreditCard).Translate(),
                        selectedCreditCard.FriendlyName),
                    null, nameof(AppResources.Yes).Translate(),
                    nameof(AppResources.No).Translate());
                if (!response) return;

                DeleteCustomerCreditCardToken context = new DeleteCustomerCreditCardToken
                {
                    CreditCardTokenId = selectedCreditCard.TokenId
                };
                var result = await Api.DeleteAppUserCreditCardToken(context);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        nameof(AppResources.ServerError));
                    return;
                }

                await Load();

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

        private async Task OnOpen(CustomerCreditCardTokenViewModel selectedCreditCard)
        {
            try
            {

                if (IsBusy) return;
                IsBusy = true;
                await Nav.NavigateTo(new PipelinePaymentCCEditPage(selectedCreditCard));

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



        public async Task Load()
        {
            try
            {
                IsBusy = true;

                if (Settings.AxCustomerId == null)
                {
                    var result = await Api.GetCustomerCreditCardTokens(Api.GetCustomerContext());
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                            nameof(AppResources.ServerError));
                    }
                    else if (result.Successful.GetValueOrDefault())
                    {
                        CreditCardList = new ObservableCollection<CustomerCreditCardTokenViewModel>(result.Data);
                    }
                }
                else
                {
                    var result = await Api.GetAppUserCreditCardTokens(Api.GetCustomerContext());
                    if (!result.Successful.GetValueOrDefault())
                    {
                        await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                            nameof(AppResources.ServerError));
                        return;
                    }
                    var dataList = new ObservableCollection<CustomerCreditCardTokenViewModel>();
                    foreach (var item in result.Data)
                    {
                        dataList.Add(new CustomerCreditCardTokenViewModel
                        {
                            TokenId = item.TokenId,
                            Token = item.Token,
                            CardType = item.CardType,
                            FriendlyName = item.FriendlyName,
                            ExpiryDate = item.ExpiryDate,
                            Street = item.Street,
                            City = item.City,
                            State = item.State,
                            ZipCode = item.ZipCode,
                            CountryCode = item.CountryCode,
                            Account = string.Empty,
                            AccountNo = string.Empty,
                            CreatedBy = string.Empty,
                            UpdatedBy = string.Empty
                        });
                    }
                    CreditCardList = dataList;
                }
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

    public enum CreditCardSortColumns
    {
        CardType,
        CardNumber,
        ExpiryDate,
        AccountNumber,
        AccountName,
        Address,
        DateCreated,
        CreatedBy,
        DateUpdated,
        UpdatedBy,
        CopyEmailReceiptAddress,
    }
}
