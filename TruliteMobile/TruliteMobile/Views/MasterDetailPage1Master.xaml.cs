using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ExTrack.Services;
using GalaSoft.MvvmLight.Messaging;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Interfaces;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Models.Messages;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.CreditCards;
using TruliteMobile.Views.Documents;
using TruliteMobile.Views.DrvManifests;
using TruliteMobile.Views.DrvReportIssue;
using TruliteMobile.Views.DrvRoutes;
using TruliteMobile.Views.FinancialStatement;
using TruliteMobile.Views.InvoicePayment;
using TruliteMobile.Views.Invoices;
using TruliteMobile.Views.LienWaiver;
using TruliteMobile.Views.MyAccount;
using TruliteMobile.Views.MyContact;
using TruliteMobile.Views.Notifications;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.PackingSlips;
using TruliteMobile.Views.PaymentCreditCard;
using TruliteMobile.Views.Pipeline;
using TruliteMobile.Views.PipelineAccounts;
using TruliteMobile.Views.PipelineContact;
using TruliteMobile.Views.PipelinePayments;
using TruliteMobile.Views.PriceLetters;
using TruliteMobile.Views.Quotes;
using TruliteMobile.Views.ReadMe;
using TruliteMobile.Views.Settings;
using TruliteMobile.Views.Settlements;
using TruliteMobile.Views.SuperuserAccounts;
using TruliteMobile.Views.SupportTickets;
using TruliteMobile.Views.Users;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public readonly ListView ListView;
        private readonly MasterDetailPage1MasterMasterViewModel _vm;

        public MasterDetailPage1Master()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new MasterDetailPage1MasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class MasterDetailPage1MasterMasterViewModel : TruliteBaseViewModel, ILoadableViewModel
    {

        private MenuItemModel _selectedItemModel;
        private ObservableCollection<MenuItemModel> _menuItems;


        public ObservableCollection<MenuItemModel> MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; RaisePropertyChanged(); }
        }

        private MenuItemModel _selectedItem;

        public MenuItemModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged();
            }
        }


        public ICommand ItemSelectedCommand { get; }

        public MasterDetailPage1MasterMasterViewModel()
        {
            ItemSelectedCommand = new AsyncDelegateCommand<MenuItemModel>(OnItemSelected);
        }

        private async Task OnItemSelected(MenuItemModel item)
        {
            if (item == null)
                return;
            if (item.IsSeparator)
            {
                SelectedItem = null;
                return;
            }
            if (item.IsWebLink)
            {
                await Launcher.OpenAsync(new Uri(item.Link));
                SelectedItem = null;
                MessengerInstance.Send(new MenuItemSelectedMessage());
                return;
            }
            //Logout
            if (item.TargetType == typeof(LoginPage))
            {
                App.Current.MainPage = new NavigationPage(new LoginPage());
                return;
            }
            if (item.Id == 16)//When in pipeline or portal super user mode return
            {
                try
                {
                    if (IsBusy) return;
                    IsBusy = true;
                    var settings = SettingsService.Instance;
                    settings.AxCustomerId = settings.MasterAxCustomerId;
                    settings.Token = settings.MasterToken;
                    settings.TokenExpiration = settings.MasterTokenExpiration;
                    settings.IsImpersonatingCustomer = false;
                    var infoResult = await ApiService.Instance.GetMyInfo(Api.GetCustomerContext());
                    if (infoResult.Data == null)
                    {
                        await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotReceiveInformationFromServer)));
                        return;
                    }
                    Settings.MyPreferences = infoResult.Data.AppPreferences;
                    Device.BeginInvokeOnMainThread(() =>
                        {
                            Page mainPage = null;
                            Messenger.Reset();
                            mainPage = new NavigationPage(new MasterDetailPage1(MainPageMode.OpenInPipelineAccounts));
                            App.Current.MainPage = mainPage;

                        }
                    );
                    return;

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

            if (item.Id == 116)//When in pipeline or portal super user mode return
            {
                try
                {
                    if (IsBusy) return;
                    IsBusy = true;
                    var settings = SettingsService.Instance;
                    settings.AxCustomerId = settings.MasterAxCustomerId;
                    settings.Token = settings.MasterToken;
                    settings.TokenExpiration = settings.MasterTokenExpiration;
                    settings.IsImpersonatingCustomer = false;
                    var infoResult = await ApiService.Instance.GetMyInfo(Api.GetCustomerContext());
                    if (infoResult.Data == null)
                    {
                        await Alert.ShowMessage(Translate.Get(nameof(AppResources.CouldNotReceiveInformationFromServer)));
                        return;
                    }
                    Settings.MyPreferences = infoResult.Data.AppPreferences;
                    Device.BeginInvokeOnMainThread(() =>
                        {
                            Page mainPage = null;
                            Messenger.Reset();
                            mainPage = new NavigationPage(new MasterDetailPage1(MainPageMode.PortalSuperUser));
                            App.Current.MainPage = mainPage;
                        }
                    );
                    return;

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
            Page page;
            if (item.Id == 3 || item.Id == 30)
            {
                page = new InvoicesPage
                {
                    InvoicePageDefaultMode = (InvoicePageDefaultMode)item.Tag
                };
                page.Title = $"Invoices - {item.Title}";
            }
            else if (item.Id == 9999)
            {
                page = new InvoicePaymentPage(item.Tag as List<InvoiceModel>, PaymentRequest.FullPayment);

            }
            else
            {
                page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;
            }

            MessengerInstance.Send(new MenuItemSelectedMessage
            {
                Page = new NavigationPage(page)
            });
            SelectedItem = null;

        }

        private async Task RefreshNotificationBalloons()
        {
            decimal invoiceAmount = await Api.GetOpenInvoicesAmount();
            long orderCount = await Api.GetOpenSalesOrdersCount();

            MenuItems[1].ExtraInfo = orderCount > 0 ? $"{orderCount}" : null;
            MenuItems[3].ExtraInfo = invoiceAmount > 0 ? $"{invoiceAmount:c}" : null;
        }
        #region Get menu items


        private ObservableCollection<MenuItemModel> GetPortalSuperUserMenuList()
        {
            return new ObservableCollection<MenuItemModel>(new[]
           {
                    new MenuItemModel { Id = 107, Title = Translate.Get(nameof(AppResources.Documents)),
                        TargetType = typeof(DocumentsPage),
                        IconText = "\uf15c"
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 14, Title = Translate.Get(nameof(AppResources.MyContact)),
                        TargetType = typeof(MyContactPage),
                        IconText = "\uf095",
                    },

                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 101, Title = Translate.Get(nameof(AppResources.Accounts)),
                        TargetType = typeof(SuperUserAccountsPage),
                        IconText = "\uf03a",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 9, Title = "Trulite",
                        IsWebLink = true, Link = "http://www.trulite.com/", Icon ="logoSmall.png"},
                    new MenuItemModel { Id = 10, Title = Translate.Get(AppResources.Knowledgebase),
                        IsWebLink = true, Link ="http://knowledgebase.trulite.com/",Icon ="logoSmall.png" },
                      new MenuItemModel { Id = 11, Title = Translate.Get(nameof(AppResources.ReadMe)),
                        TargetType = typeof(ReadMePage),
                        IconText = "\uf0eb"
                    }
                      ,
                      new MenuItemModel {
                          IsSeparator = true
                      },
                      new MenuItemModel { Id = 113, Title = Translate.Get(nameof(AppResources.Logout)),
                          TargetType = typeof(LoginPage),
                          IconText = "\uf2f5",
                      },
        });

        }


        private ObservableCollection<MenuItemModel> GetPipelineSuperUserMenuList()
        {
            return new ObservableCollection<MenuItemModel>(new[]
           {
                    new MenuItemModel { Id = 107, Title = Translate.Get(nameof(AppResources.Documents)),
                        TargetType = typeof(DocumentsPage),
                        IconText = "\uf15c"
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 112, Title = Translate.Get(nameof(AppResources.MyContact)),
                        TargetType = typeof(PipelineContactPage),
                        IconText = "\uf095",
                    },
                    new MenuItemModel { Id = 15, Title = Translate.Get(nameof(AppResources.MyUsers)),
                        TargetType = typeof(UsersPage),
                        IconText = "\uf0c0"
                    },
                    new MenuItemModel { Id = 14, Title = Translate.Get(nameof(AppResources.MyContact)),
                        TargetType = typeof(MyContactPage),
                        IconText = "\uf095",
                    },

                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 101, Title = Translate.Get(nameof(AppResources.Accounts)),
                        TargetType = typeof(PipelineAccountsPage),
                        IconText = "\uf03a",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                     new MenuItemModel { Id = 200,Title = $"{nameof(AppResources.Payments).Translate()}",
                        IconText = "\uf09d",
                        HasExtraInfo = true,
                        SubMenuList = new ObservableCollection<MenuItemModel>
                        {
                            new MenuItemModel { Id = 201,Title = $"{nameof(AppResources.Payments).Translate()}",
                                TargetType = typeof(PipelinePaymentsPage),
                                Tag = InvoicePageDefaultMode.Open,
                                HasExtraInfo = true
                            },
                            new MenuItemModel { Id = 202, Title = $"{nameof(AppResources.CreditCards).Translate()}",
                                TargetType = typeof(PaymentCreditCardPage),
                                Tag = InvoicePageDefaultMode.Open,
                                HasExtraInfo = true
                            },
                        }
                    },new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 9, Title = "Trulite",
                        IsWebLink = true, Link = "http://www.trulite.com/", Icon ="logoSmall.png"},
                    new MenuItemModel { Id = 10, Title = Translate.Get(AppResources.Knowledgebase),
                        IsWebLink = true, Link ="http://knowledgebase.trulite.com/",Icon ="logoSmall.png" },
                      new MenuItemModel { Id = 11, Title = Translate.Get(nameof(AppResources.ReadMe)),
                        TargetType = typeof(ReadMePage),
                        IconText = "\uf0eb"
                    }
                      ,
                      new MenuItemModel {
                          IsSeparator = true
                      },
                      new MenuItemModel { Id = 113, Title = Translate.Get(nameof(AppResources.Logout)),
                          TargetType = typeof(LoginPage),
                          IconText = "\uf2f5",
                      },
        });

        }


        private ObservableCollection<MenuItemModel> GetPortalMenuList()
        {
            var menuList = new ObservableCollection<MenuItemModel>(new[]
            {
                    new MenuItemModel { Id = 13, Title =  Translate.Get(nameof(AppResources.Dashboard)),
                    TargetType = typeof(MasterDetailPage1Detail),
                    IconText ="\uf3fd" },
                    new MenuItemModel { Id = 0, Title =  Translate.Get(nameof(AppResources.Quotes)),
                        TargetType = typeof(QuotesPage),
                        IconText ="\uf10e" },
                    new MenuItemModel { Id = 1, Title = Translate.Get(nameof(AppResources.Orders)),
                        TargetType = typeof(OrdersPage),
                        IconText = "\uf07a",
                        HasExtraInfo = true
                    },
                    new MenuItemModel
                    {
                        Id = 2, Title = Translate.Get(nameof(AppResources.PackingSlips)) ,
                        TargetType = typeof(PackingSlipsPage),
                        IconText = "\uf0d1"
                    },
                    new MenuItemModel { Id = 300,Title = $"{nameof(AppResources.Invoices).Translate()}",
                        IconText = "\uf155",
                        HasExtraInfo = true,
                        SubMenuList = new ObservableCollection<MenuItemModel>
                        {
                            new MenuItemModel { Id = 3,Title = $"{nameof(AppResources.All).Translate()}",
                                TargetType = typeof(InvoicesPage),
                                Tag = InvoicePageDefaultMode.All,
                                HasExtraInfo = true
                            },
                            new MenuItemModel { Id = 30, Title = $"{nameof(AppResources.InvoiceStatusOpen).Translate()}",
                                TargetType = typeof(InvoicesPage),
                                Tag = InvoicePageDefaultMode.Open,
                                HasExtraInfo = true
                            },
                        }
                    },
                    new MenuItemModel { Id = 12, Title = Translate.Get(nameof(AppResources.Settlements)),
                        TargetType = typeof(SettlementsPage),
                        IconText = "\uf09d",
                    },
                    new MenuItemModel { Id = 20, Title = Translate.Get(nameof(AppResources.CreditCards)),
                        TargetType = typeof(CreditCardPage),
                        IconText = "\uf0d6",
                    },
                    new MenuItemModel { Id = 4, Title = Translate.Get(nameof(AppResources.FinancialStatements)),
                        TargetType = typeof(FinancialStatementPage),
                        IconText = "\uf080",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },

                    new MenuItemModel { Id = 6, Title =Translate.Get( nameof(AppResources.PriceLetters)),
                        TargetType = typeof(PriceLettersPage),
                        IconText = "\uf002"
                    },
                    new MenuItemModel { Id = 7, Title = Translate.Get(nameof(AppResources.Documents)),
                        TargetType = typeof(DocumentsPage),
                        IconText = "\uf15c"
                    },
                    new MenuItemModel { Id = 8, Title = Translate.Get(nameof(AppResources.LienWaiver)),
                        TargetType = typeof(LienWaiverPage),
                        IconText = "\uf303",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 15, Title = Translate.Get(nameof(AppResources.MyUsers)),
                        TargetType = typeof(UsersPage),
                        IconText = "\uf0c0"
                    },
                    new MenuItemModel { Id = 14, Title = Translate.Get(nameof(AppResources.MyContact)),
                        TargetType = typeof(MyContactPage),
                        IconText = "\uf095",
                    },
                    new MenuItemModel { Id = 19, Title = Translate.Get(nameof(AppResources.MyAccount)),
                        TargetType = typeof(MyAccountPage),
                        IconText = "\uf013",
                    },
                    new MenuItemModel { Id = 8, Title = Translate.Get(nameof(AppResources.Notifications)),
                        TargetType = typeof(NotificationsPage),
                        IconText = "\uf0f3",
                        NotificationBalloonColor = Color.Red,
                        HasExtraInfo = true
                    },

                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 9, Title = "Trulite",
                        IsWebLink = true, Link = "http://www.trulite.com/", Icon ="logoSmall.png"},
                    new MenuItemModel { Id = 10, Title = Translate.Get(AppResources.Knowledgebase),
                        IsWebLink = true, Link ="http://knowledgebase.trulite.com/",Icon ="logoSmall.png" },
                    new MenuItemModel { Id = 11, Title = Translate.Get(nameof(AppResources.ReadMe)),
                        TargetType = typeof(ReadMePage),
                        IconText = "\uf0eb",

                    },
                 

                });

            if (!Settings.IsImpersonatingCustomer)
            {

                //Support tickets - should not appear when impersonating user 
                menuList.Insert(9, new MenuItemModel
                {
                    Id = 5,
                    Title = nameof(AppResources.SupportTickets).Translate(),
                    TargetType = typeof(SupportTicketsPage),
                    IconText = "\uf1cd"
                });
                menuList.Add(new MenuItemModel
                {
                    IsSeparator = true
                });
                menuList.Add(
                    new MenuItemModel
                    {
                        Id = 18,
                        Title = Translate.Get(nameof(AppResources.Logout)),
                        TargetType = typeof(LoginPage),
                        IconText = "\uf2f5",
                    });
                return menuList;
            }

            if (Settings.IsPortalSuperUser)
            {
                menuList.Add(new MenuItemModel
                {
                    IsSeparator = true
                });

                // String should be defined . 
             
                menuList.Add(new MenuItemModel
                {
                    Id = 116,
                    Title = nameof(AppResources.BackToCustomerSelection).Translate(),
                    IconText = "\uf053",
                });
                return menuList;
            }
            //PipelineSuperuser

            menuList.Add(new MenuItemModel
            {
                IsSeparator = true
            });

            menuList.Add(new MenuItemModel
            {
                Id = 16,
                Title = nameof(AppResources.BackToCustomerSelection).Translate(),
                IconText = "\uf053",
            });
            return menuList;



        }

        private ObservableCollection<MenuItemModel> GetDriverMenuList()
        {
            return new ObservableCollection<MenuItemModel>(new[]
            {
                    new MenuItemModel { Id = 200, Title = Translate.Get(nameof(AppResources.Routes)),
                        TargetType = typeof(DrvRoutesPage), IconText ="\uf124" },
                    new MenuItemModel { Id = 201, Title =  Translate.Get(nameof(AppResources.Manifests)),
                        TargetType = typeof(DrvManifestsPage), IconText = "\uf21a",

                    },
                    new MenuItemModel { Id = 202, Title = Translate.Get(nameof(AppResources.ReportIssue)),
                        TargetType = typeof(DrvReportIssuePage), IconText = "\uf0e0",

                    },
                    new MenuItemModel { Id = 203, Title = Translate.Get(nameof(AppResources.Notifications)),
                        TargetType = typeof(NotificationsPage),
                        IconText = "\uf0f3",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 204, Title = "Trulite",
                        TargetType = typeof(DocumentsPage), IsWebLink = true, Link = "http://www.trulite.com/", Icon ="logoSmall.png"},
                    new MenuItemModel { Id = 205, Title =  Translate.Get(AppResources.Knowledgebase),
                        IsWebLink = true, Link ="http://knowledgebase.trulite.com/",Icon ="logoSmall.png" },

                    new MenuItemModel { Id = 206, Title = Translate.Get(nameof(AppResources.ReadMe)),
                        TargetType = typeof(ReadMePage),
                        IconText = "\uf0eb"},
                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id =207, Title = Translate.Get(nameof(AppResources.Logout)),
                        TargetType = typeof(LoginPage),
                        IconText = "\uf2f5",
                    },}
               );
        }

        private ObservableCollection<MenuItemModel> GetPipelineMenuList()
        {
            return new ObservableCollection<MenuItemModel>(new[]
            {
                new MenuItemModel { Id = 107, Title = Translate.Get(nameof(AppResources.Documents)),
                    TargetType = typeof(DocumentsPage),
                    IconText = "\uf15c"
                },
                new MenuItemModel {
                    IsSeparator = true
                },
                new MenuItemModel { Id = 112, Title = Translate.Get(nameof(AppResources.MyContact)),
                    TargetType = typeof(PipelineContactPage),
                    IconText = "\uf095",
                },
                    new MenuItemModel { Id = 100, Title = Translate.Get(nameof(AppResources.Pipeline)),
                        TargetType = typeof(PipelinePage), IconText ="\uf070" },


                    new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 101, Title = Translate.Get(nameof(AppResources.Accounts)),
                        TargetType = typeof(PipelineAccountsPage),
                        IconText = "\uf03a",
                    },
                    new MenuItemModel {
                        IsSeparator = true
                    },
                     new MenuItemModel { Id = 200,Title = $"{nameof(AppResources.Payments).Translate()}",
                        IconText = "\uf09d",
                        HasExtraInfo = true,
                        SubMenuList = new ObservableCollection<MenuItemModel>
                        {
                            new MenuItemModel { Id = 201,Title = $"{nameof(AppResources.Payments).Translate()}",
                                TargetType = typeof(PipelinePaymentsPage),
                                Tag = InvoicePageDefaultMode.Open,
                                HasExtraInfo = true
                            },
                            new MenuItemModel { Id = 202, Title = $"{nameof(AppResources.CreditCards).Translate()}",
                                TargetType = typeof(PaymentCreditCardPage),
                                Tag = InvoicePageDefaultMode.Open,
                                HasExtraInfo = true
                            },
                        }
                    },new MenuItemModel {
                        IsSeparator = true
                    },
                    new MenuItemModel { Id = 9, Title = "Trulite",
                        IsWebLink = true, Link = "http://www.trulite.com/", Icon ="logoSmall.png"},
                    new MenuItemModel { Id = 10, Title = Translate.Get(AppResources.Knowledgebase),
                        IsWebLink = true, Link ="http://knowledgebase.trulite.com/",Icon ="logoSmall.png" },
                      new MenuItemModel { Id = 11, Title = Translate.Get(nameof(AppResources.ReadMe)),
                        TargetType = typeof(ReadMePage),
                        IconText = "\uf0eb"
                    }
                      ,
                      new MenuItemModel {
                          IsSeparator = true
                      },
                      new MenuItemModel { Id = 113, Title = Translate.Get(nameof(AppResources.Logout)),
                          TargetType = typeof(LoginPage),
                          IconText = "\uf2f5",
                      },
        });
        }



        #endregion

        private bool _hasCheckedOverdueInvoices;
        public async Task Load()
        {
            try
            {
                IsBusy = true;
                switch (SettingsService.Instance.ApplicationMode)
                {
                    case ApplicationModeEnum.Portal:

                        if (!Settings.IsImpersonatingCustomer && Settings.IsPortalSuperUser)
                        {
                            MenuItems = GetPortalSuperUserMenuList();

                        }
                        else
                        {
                            MenuItems = GetPortalMenuList();

                            //If a user has an overdue invoice we redirect to the invoice payment page.
                            if (!_hasCheckedOverdueInvoices)
                            {
                                var overdueInvoices = await GetOverdueInvoices();
                                _hasCheckedOverdueInvoices = true;
                                if (overdueInvoices?.Data?.Any() ?? false)
                                {
                                    await Alert.ShowMessage(nameof(AppResources.OverdueInvoicesMessage)
                                        .Translate());

                                    var invoicePaymentPage = new MenuItemModel
                                    {
                                        Id = 9999,
                                        TargetType = typeof(InvoicePaymentPage),
                                        Tag = overdueInvoices.Data
                                            .Select(p => p.CloneToType<InvoiceModel, Invoice>())
                                            .ToList()
                                    };

                                    await OnItemSelected(invoicePaymentPage);
                                }

                            }
                            await RefreshNotificationBalloons();
                        }

                        break;
                    case ApplicationModeEnum.Driver:
                        MenuItems = GetDriverMenuList();
                        break;
                    case ApplicationModeEnum.Pipeline:
                        if (Settings.IsImpersonatingCustomer)
                        {
                            if (SettingsService.Instance.IsImpersonatingCustomer)
                            {
                                MenuItems = GetPortalMenuList();
                            }
                            else
                            {
                                MenuItems = GetPipelineSuperUserMenuList();
                            }
                            await RefreshNotificationBalloons();
                        }
                        else
                        {
                            MenuItems = GetPipelineMenuList();
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }


            }
            catch (Exception e)
            {
#if DEBUG
                await Alert.DisplayError(e);
#endif
            }
            finally
            {
                IsBusy = false;
            }
        }

        private Task<ApiResponseOfListOfInvoice> GetOverdueInvoices()
        {
            var filter = new InvoicesFilterModel
            {
                SelectedQty = 1,
                EndDate = DateTime.Today.AddDays(-1),
                Status = new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.NotPaid, null)
            };
            return Api.GetInvoiceList(filter);
        }
    }
}