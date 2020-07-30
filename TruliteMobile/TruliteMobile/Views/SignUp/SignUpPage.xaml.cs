using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace TruliteMobile.Views.SignUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        private readonly SignUpPageViewModel _vm;

        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = _vm = new SignUpPageViewModel();
        }
    }

    public class SignUpPageViewModel : TruliteBaseViewModel
    {
        private NewUser _newUser;

        public NewUser NewUser
        {
            get { return _newUser; }
            set
            {
                _newUser = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<NewUserAppUserLanguage, string>> _languageList;

        public ObservableCollection<KeyValuePair<NewUserAppUserLanguage, string>> LanguageList
        {
            get { return _languageList; }
            set
            {
                _languageList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<NewUserAppUserLanguage,string> _selectedLanguage;

        public KeyValuePair<NewUserAppUserLanguage,string> SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                _selectedLanguage = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<string,string>> _companyList;

        public ObservableCollection<KeyValuePair<string,string>> CompanyList
        {
            get { return _companyList; }
            set
            {
                _companyList = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<string,string> _selectedCompany;

        public KeyValuePair<string,string> SelectedCompany
        {
            get { return _selectedCompany; }
            set
            {
                _selectedCompany = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SignUpCommand { get; }

        public SignUpPageViewModel()
        {
            NewUser= new NewUser();
            LanguageList = new ObservableCollection<KeyValuePair<NewUserAppUserLanguage, string>>
            {
                new KeyValuePair<NewUserAppUserLanguage, string>(NewUserAppUserLanguage.English,
                    nameof(AppResources.English).Translate()),
                new KeyValuePair<NewUserAppUserLanguage, string>(NewUserAppUserLanguage.Spanish,
                    nameof(AppResources.Spanish).Translate()),
                new KeyValuePair<NewUserAppUserLanguage, string>(NewUserAppUserLanguage.French,
                    nameof(AppResources.French).Translate()),

            };
            SelectedLanguage = _languageList[0];
            SignUpCommand= new AsyncDelegateCommand(OnSignUp);
            CompanyList= new ObservableCollection<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("AAG","AAG"),
                new KeyValuePair<string, string>("GRE","GRE")
            };
            SelectedCompany = _companyList[0];
        }


        private static string GetInvalidFields(NewUser newUser)
        {

            var sb = new StringBuilder();
            if (newUser.UserId.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(nameof(AppResources.EmailCannotBeEmpty).Translate());
            }
            else if (!newUser.UserId.IsValidEmail())
            {
                sb.AppendLine(nameof(AppResources.PleaseEnterValidEmail).Translate());
            }

            if (newUser.FirstName.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.FirstName).Translate()));
            }

            if (newUser.LastName.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.LastName).Translate()));
            }

            if (newUser.AccountNo.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.AccountNumber).Translate()));
            }
            if (newUser.InviteCode.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.InviteCode).Translate()));
            }
            if (newUser.InvoiceNo.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.InvoiceNumber).Translate()));
            }
            if (newUser.Company.IsNullEmptyOrWhiteSpace())
            {
                sb.AppendLine(string.Format(nameof(AppResources.FieldCannotBeEmpty).Translate(),
                    nameof(AppResources.Company).Translate()));
            }
            return sb.ToString();


        }


        private async Task OnSignUp()
        {
            try
            {
                if (IsBusy) return;
                IsBusy = true;

                var invalidFields = GetInvalidFields(_newUser);
                if (!invalidFields.IsNullEmptyOrWhiteSpace())
                {
                    await Alert.ShowMessage(invalidFields);
                    return;
                }

                NewUser.AppUserLanguage = _selectedLanguage.Key;

                var result=await Api.RegisterNewUser(_newUser);
                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors,
                        $"-{Translate.Get(nameof(AppResources.ServerError))}");
                    return;
                }

                await Alert.ShowMessage(result.Data.SuccessfulMessage);
                await Nav.Nav.PopAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}