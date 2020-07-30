using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.InvoicePayment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardView : ContentView
    {

        public static readonly BindableProperty FirstNameProperty =
            BindableProperty.Create("FirstName", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public static readonly BindableProperty FirstNameErrorProperty =
            BindableProperty.Create("FirstNameError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string FirstNameError
        {
            get
            {
                return (string)GetValue(FirstNameErrorProperty);
            }
            set
            {
                SetValue(FirstNameErrorProperty, value);
            }
        }

        public static readonly BindableProperty LastNameProperty =
            BindableProperty.Create("LastName", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public static readonly BindableProperty LastNameErrorProperty =
            BindableProperty.Create("LastNameError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string LastNameError
        {
            get { return (string)GetValue(LastNameErrorProperty); }
            set { SetValue(LastNameErrorProperty, value); }
        }

        public static readonly BindableProperty EmailProperty =
            BindableProperty.Create("Email", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public static readonly BindableProperty EmailErrorProperty =
            BindableProperty.Create("EmailError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string EmailError
        {
            get { return (string)GetValue(EmailErrorProperty); }
            set { SetValue(EmailErrorProperty, value); }
        }

        public static readonly BindableProperty AddressProperty =
            BindableProperty.Create("Address", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        public static readonly BindableProperty AddressErrorProperty =
            BindableProperty.Create("AddressError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string AddressError
        {
            get { return (string)GetValue(AddressErrorProperty); }
            set { SetValue(AddressErrorProperty, value); }
        }

        public static readonly BindableProperty CityProperty =
            BindableProperty.Create("City", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string City
        {
            get { return (string)GetValue(CityProperty); }
            set { SetValue(CityProperty, value); }
        }

        public static readonly BindableProperty CityErrorProperty =
            BindableProperty.Create("CityError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CityError
        {
            get { return (string)GetValue(CityErrorProperty); }
            set { SetValue(CityErrorProperty, value); }
        }

        public static readonly BindableProperty StateProperty =
            BindableProperty.Create("State", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string State
        {
            get { return (string)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static readonly BindableProperty StateErrorProperty =
            BindableProperty.Create("StateError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string StateError
        {
            get { return (string)GetValue(StateErrorProperty); }
            set { SetValue(StateErrorProperty, value); }
        }

        public static readonly BindableProperty CountryProperty =
            BindableProperty.Create("Country", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string Country
        {
            get { return (string)GetValue(CountryProperty); }
            set { SetValue(CountryProperty, value); }
        }

        public static readonly BindableProperty CountryErrorProperty =
            BindableProperty.Create("CountryError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CountryError
        {
            get { return (string)GetValue(CountryErrorProperty); }
            set { SetValue(CountryErrorProperty, value); }
        }

        public static readonly BindableProperty PostalCodeProperty =
            BindableProperty.Create("PostalCode", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string PostalCode
        {
            get { return (string)GetValue(PostalCodeProperty); }
            set { SetValue(PostalCodeProperty, value); }
        }

        public static readonly BindableProperty PostalCodeErrorProperty =
            BindableProperty.Create("PostalCodeError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string PostalCodeError
        {
            get { return (string)GetValue(PostalCodeErrorProperty); }
            set { SetValue(PostalCodeErrorProperty, value); }
        }

        public static readonly BindableProperty CardTypeProperty =
            BindableProperty.Create("CardType", typeof(CreditCardTypeEnum), typeof(CreditCardView), default(CreditCardTypeEnum), BindingMode.TwoWay);

        public CreditCardTypeEnum CardType
        {
            get { return (CreditCardTypeEnum)GetValue(CardTypeProperty); }
            set { SetValue(CardTypeProperty, value); }
        }

        public static readonly BindableProperty CardTypeErrorProperty =
           BindableProperty.Create("CardTypeError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CardTypeError
        {
            get { return (string)GetValue(CardTypeErrorProperty); }
            set { SetValue(CardTypeErrorProperty, value); }
        }

        public static readonly BindableProperty CVVProperty =
            BindableProperty.Create("CVV", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CVV
        {
            get { return (string)GetValue(CVVProperty); }
            set { SetValue(CVVProperty, value); }
        }

        public static readonly BindableProperty CVVErrorProperty =
            BindableProperty.Create("CVVError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CVVError
        {
            get { return (string)GetValue(CVVErrorProperty); }
            set { SetValue(CVVErrorProperty, value); }
        }

        public static readonly BindableProperty CardNumberProperty =
            BindableProperty.Create("CardNumber", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CardNumber
        {
            get { return (string)GetValue(CardNumberProperty); }
            set { SetValue(CardNumberProperty, value); }
        }

        public static readonly BindableProperty CardNumberErrorProperty =
            BindableProperty.Create("CardNumberError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string CardNumberError
        {
            get { return (string)GetValue(CardNumberErrorProperty); }
            set { SetValue(CardNumberErrorProperty, value); }
        }

        public static readonly BindableProperty ExpirationMonthProperty =
            BindableProperty.Create("ExpirationMonth", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string ExpirationMonth
        {
            get { return (string)GetValue(ExpirationMonthProperty); }
            set { SetValue(ExpirationMonthProperty, value); }
        }

        public static readonly BindableProperty ExpirationMonthErrorProperty =
            BindableProperty.Create("ExpirationMonthError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string ExpirationMonthError
        {
            get { return (string)GetValue(ExpirationMonthErrorProperty); }
            set { SetValue(ExpirationMonthErrorProperty, value); }
        }

        public static readonly BindableProperty ExpirationYearProperty =
            BindableProperty.Create("ExpirationYear", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string ExpirationYear
        {
            get { return (string)GetValue(ExpirationYearProperty); }
            set { SetValue(ExpirationYearProperty, value); }
        }

        public static readonly BindableProperty ExpirationYearErrorProperty =
            BindableProperty.Create("ExpirationYearError", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string ExpirationYearError
        {
            get { return (string)GetValue(ExpirationYearErrorProperty); }
            set { SetValue(ExpirationYearErrorProperty, value); }
        }


        public static readonly BindableProperty CreditCardTypeProperty =
            BindableProperty.Create("CreditCardType", typeof(KeyValuePair<CreditCardTypeEnum, string>), typeof(CreditCardView), default(KeyValuePair<CreditCardTypeEnum, string>), BindingMode.TwoWay);

        public KeyValuePair<CreditCardTypeEnum, string> CreditCardType
        {
            get { return (KeyValuePair<CreditCardTypeEnum, string>)GetValue(CreditCardTypeProperty); }
            set { SetValue(CreditCardTypeProperty, value); }
        }



        private ObservableCollection<string> _countryList;

        public ObservableCollection<string> CountryList
        {
            get { return _countryList; }
            set
            {
                _countryList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<KeyValuePair<CreditCardTypeEnum, string>> _creditCardTypeList;

        public ObservableCollection<KeyValuePair<CreditCardTypeEnum, string>> CreditCardTypeList
        {
            get { return _creditCardTypeList; }
            set
            {
                _creditCardTypeList = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<string> _expirationMonthList;

        public ObservableCollection<string> ExpirationMonthList
        {
            get { return _expirationMonthList; }
            set
            {
                _expirationMonthList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _expirationYearList;

        public ObservableCollection<string> ExpirationYearList
        {
            get { return _expirationYearList; }
            set
            {
                _expirationYearList = value;
                OnPropertyChanged();
            }
        }


        public static readonly BindableProperty EmailCopyReceiptProperty =
            BindableProperty.Create("EmailCopyReceipt", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string EmailCopyReceipt
        {
            get { return (string)GetValue(EmailCopyReceiptProperty); }
            set { SetValue(EmailCopyReceiptProperty, value); }
        }


        public static readonly BindableProperty PaymentNoteProperty =
            BindableProperty.Create("PaymentNote", typeof(string), typeof(CreditCardView), default(string), BindingMode.TwoWay);

        public string PaymentNote
        {
            get { return (string)GetValue(PaymentNoteProperty); }
            set { SetValue(PaymentNoteProperty, value); }
        }



        public static List<KeyValuePair<CreditCardTypeEnum, string>> CreditCardTypeListValue = new List<KeyValuePair<CreditCardTypeEnum, string>>
        {
            new KeyValuePair<CreditCardTypeEnum, string>(CreditCardTypeEnum.Select, nameof(AppResources.SelectOne).Translate()),
            new KeyValuePair<CreditCardTypeEnum, string>(CreditCardTypeEnum.Visa, "Visa"),
            new KeyValuePair<CreditCardTypeEnum, string>(CreditCardTypeEnum.MasterCard, "MasterCard"),
            new KeyValuePair<CreditCardTypeEnum, string>(CreditCardTypeEnum.AmericanExpress, "American Express"),
            new KeyValuePair<CreditCardTypeEnum, string>(CreditCardTypeEnum.Discover, "Discover"),
        };

        public CreditCardView()
        {
            InitializeComponent();
            CountryList = new ObservableCollection<string> { "United States", "Canada" };
            Country = _countryList.First();
            Email = SettingsService.Instance.Email;
            CreditCardTypeList = new ObservableCollection<KeyValuePair<CreditCardTypeEnum, string>>(CreditCardTypeListValue);
            CreditCardType = _creditCardTypeList.First();

            var monthList = new List<string>();
            for (int i = 1; i < 13; i++)
            {
                monthList.Add(i.ToString("D2"));
            }
            ExpirationMonthList = new ObservableCollection<string>(monthList);

            var year = DateTime.Today.Year;
            var expirationYearList = new List<string>();
            for (int i = 0; i < 10; i++)
            {

                expirationYearList.Add((year + i).ToString("D4"));
            }
            ExpirationYearList = new ObservableCollection<string>(expirationYearList);
            Children[0].BindingContext = this;

        }
    }

    public enum CreditCardTypeEnum
    {
        Select,
        MasterCard,
        Visa,
        AmericanExpress,
        Discover
    }


    public class CreditCardViewModel : TruliteBaseViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _firstNameError;
        public string FirstNameError
        {
            get { return _firstNameError; }
            set
            {
                _firstNameError = value;
                RaisePropertyChanged();
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _lastNameError;
        public string LastNameError
        {
            get { return _lastNameError; }
            set
            {
                _lastNameError = value;
                RaisePropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _emailError;
        public string EmailError
        {
            get { return _emailError; }
            set
            {
                _emailError = value;
                RaisePropertyChanged();
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _addressError;
        public string AddressError
        {
            get { return _addressError; }
            set
            {
                _addressError = value;
                RaisePropertyChanged();
            }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _cityError;
        public string CityError
        {
            get { return _cityError; }
            set
            {
                _cityError = value;
                RaisePropertyChanged();
            }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _stateError;
        public string StateError
        {
            get { return _stateError; }
            set
            {
                _stateError = value;
                RaisePropertyChanged();
            }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                RaisePropertyChanged();
            }
        }

        private string _countryError;
        public string CountryError
        {
            get { return _countryError; }
            set
            {
                _countryError = value;
                RaisePropertyChanged();
            }
        }

        private string _postalCode;
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _postalCodeError;
        public string PostalCodeError
        {
            get { return _postalCodeError; }
            set
            {
                _postalCodeError = value;
                RaisePropertyChanged();
            }
        }

        private CreditCardTypeEnum _cardType;
        public CreditCardTypeEnum CardType
        {
            get { return _cardType; }
            set
            {
                _cardType = value;
                RaisePropertyChanged();
            }
        }

        private string _cardTypeError;
        public string CardTypeError
        {
            get { return _cardTypeError; }
            set
            {
                _cardTypeError = value;
                RaisePropertyChanged();
            }
        }

        private KeyValuePair<CreditCardTypeEnum, string> _creditCardType;
        public KeyValuePair<CreditCardTypeEnum, string> CreditCardType
        {
            get { return _creditCardType; }
            set
            {
                _creditCardType = value;
                RaisePropertyChanged();
            }
        }

        private string _cvv;
        public string CVV
        {
            get { return _cvv; }
            set
            {
                _cvv = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _cvvError;
        public string CVVError
        {
            get { return _cvvError; }
            set
            {
                _cvvError = value;
                RaisePropertyChanged();
            }
        }

        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                _cardNumber = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _cardNumberError;
        public string CardNumberError
        {
            get { return _cardNumberError; }
            set
            {
                _cardNumberError = value;
                RaisePropertyChanged();
            }
        }

        private string _expirationMonth;
        public string ExpirationMonth
        {
            get { return _expirationMonth; }
            set
            {
                _expirationMonth = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _expirationMonthError;
        public string ExpirationMonthError
        {
            get { return _expirationMonthError; }
            set
            {
                _expirationMonthError = value;
                RaisePropertyChanged();
            }
        }

        private string _expirationYear;
        public string ExpirationYear
        {
            get { return _expirationYear; }
            set
            {
                _expirationYear = value;
                RaisePropertyChanged();
                CheckIfValid();
            }
        }

        private string _expirationYearError;
        public string ExpirationYearError
        {
            get { return _expirationYearError; }
            set
            {
                _expirationYearError = value;
                RaisePropertyChanged();
            }
        }

        public bool RunValidationCheck
        {
            get; set;
        }

        static readonly int CardNumberCharacterCountMin = 12;
        static readonly int CardNumberCharacterCountMax = 19;
        static readonly int CodeCharacterCountMin = 3;
        static readonly int CodeCharacterCountMax = 4;

        static readonly String US_ZIPCODE_REGEX = "\\b[0-9]{5}(?:-[0-9]{4})?\\b";
        static readonly String CANADA_POSTALCODE_REGEX =
                "^(?!.*[DFIOQU])[A-VXY][0-9][A-Z] ?[0-9][A-Z][0-9]$";
        static readonly String EMAIL_VALIDATION_PATTERN =
            "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9]" +
                    "(?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

        Regex USAZipCode = new Regex(US_ZIPCODE_REGEX);
        Regex CanadaPostalCode = new Regex(CANADA_POSTALCODE_REGEX);
        Regex emailRegex = new Regex(EMAIL_VALIDATION_PATTERN);

        public bool CheckIfValid()
        {
            bool returnValue = true;
            if (RunValidationCheck)
            {
                if (String.IsNullOrWhiteSpace(FirstName))
                {
                    returnValue = false;
                    FirstNameError = " ";
                }
                else
                {
                    FirstNameError = null;
                }

                if (String.IsNullOrWhiteSpace(LastName))
                {
                    returnValue = false;
                    LastNameError = " ";
                }
                else
                {
                    LastNameError = null;
                }

                if (String.IsNullOrWhiteSpace(Email) ||
                   (!String.IsNullOrWhiteSpace(Email) &&
                    !emailRegex.Match(Email).Success)
                    )
                {
                    returnValue = false;
                    EmailError = " ";
                }
                else
                {
                    EmailError = null;
                }

                if (String.IsNullOrWhiteSpace(Address))
                {
                    returnValue = false;
                    AddressError = " ";
                }
                else
                {
                    AddressError = null;
                }

                if (String.IsNullOrWhiteSpace(City))
                {
                    returnValue = false;
                    CityError = " ";
                }
                else
                {
                    CityError = null;
                }

                if (String.IsNullOrWhiteSpace(State))
                {
                    returnValue = false;
                    StateError = " ";
                }
                else
                {
                    StateError = null;
                }

                if (String.IsNullOrWhiteSpace(PostalCode) ||
                    (!String.IsNullOrWhiteSpace(PostalCode) &&
                    "canada".Equals(Country, StringComparison.InvariantCultureIgnoreCase) ?
                    !CanadaPostalCode.Match(PostalCode).Success :
                    !USAZipCode.Match(PostalCode).Success)
                    )
                {
                    returnValue = false;
                    PostalCodeError = " ";
                }
                else
                {
                    PostalCodeError = null;
                }

                if (String.IsNullOrWhiteSpace(Country))
                {
                    returnValue = false;
                    CountryError = " ";
                }
                else
                {
                    CountryError = null;
                }

                if (CardType == CreditCardTypeEnum.Select)
                {
                    returnValue = false;
                    CardTypeError = " ";
                }
                else
                {
                    CardTypeError = null;
                }

                if (String.IsNullOrWhiteSpace(CVV)
                    || CVV.Length < CodeCharacterCountMin || CVV.Length > CodeCharacterCountMax)
                {
                    returnValue = false;
                    CVVError = " ";
                }
                else
                {
                    CVVError = null;
                }

                if (String.IsNullOrWhiteSpace(CardNumber)
                    || CardNumber.Length < CardNumberCharacterCountMin || CardNumber.Length > CardNumberCharacterCountMax)
                {
                    returnValue = false;
                    CardNumberError = " ";
                }
                else
                {
                    CardNumberError = null;
                }

                if (String.IsNullOrWhiteSpace(ExpirationMonth))
                {
                    returnValue = false;
                    ExpirationMonthError = " ";
                }
                else
                {
                    ExpirationMonthError = null;
                }

                if (String.IsNullOrWhiteSpace(ExpirationYear))
                {
                    returnValue = false;
                    ExpirationYearError = " ";
                }
                else
                {
                    ExpirationYearError = null;
                }

                if (!String.IsNullOrWhiteSpace(ExpirationYear) &&
                    !String.IsNullOrWhiteSpace(ExpirationMonth))
                {
                    var now = DateTime.Now;
                    if (int.Parse(ExpirationYear) < now.Year ||
                        int.Parse(ExpirationMonth) < now.Month && int.Parse(ExpirationYear) <= now.Year)
                    {
                        returnValue = false;
                        ExpirationYearError = " ";
                        ExpirationMonthError = " ";
                    }
                    else
                    {
                        ExpirationYearError = null;
                        ExpirationMonthError = null;
                    }
                }
            }
            return returnValue;
        }

    }
}