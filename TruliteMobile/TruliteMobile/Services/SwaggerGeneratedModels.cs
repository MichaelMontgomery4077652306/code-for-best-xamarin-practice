using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GalaSoft.MvvmLight;

namespace TruliteMobile.Services
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfDictionaryOfStringAndBoolean : ObservableObject
    {
        private System.Collections.Generic.IDictionary<string, bool> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, bool> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


      
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoiceReceiptContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.Guid? _paymentId;
        private System.Collections.Generic.ICollection<string> _recipients;


        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PaymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? PaymentId
        {
            get { return _paymentId; }
            set
            {
                if (_paymentId != value)
                {
                    _paymentId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Recipients", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Recipients
        {
            get { return _recipients; }
            set
            {
                if (_recipients != value)
                {
                    _recipients = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfReceiptModel : ObservableObject
    {
        private ReceiptModel _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReceiptModel Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


     

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReceiptModel : ObservableObject
    {
        private bool? _approved;
        private string _authorizationCode;
        private System.Collections.Generic.ICollection<InvoicePaymentRecord> _invoices;
        private InvoicePayment _invoicePayment;
        private string _transactionId;
        private string _aXTransaction;
        private double? _invoicesAmount;
        private string _paidByEmail;
        private bool? _hasFees;
        private bool? _isMoneyOnAccountRequest;
        private string _creditCardType;
        private string _cardNumber;

        [Newtonsoft.Json.JsonProperty("Approved", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Approved
        {
            get { return _approved; }
            set
            {
                if (_approved != value)
                {
                    _approved = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AuthorizationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorizationCode
        {
            get { return _authorizationCode; }
            set
            {
                if (_authorizationCode != value)
                {
                    _authorizationCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Invoices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoicePaymentRecord> Invoices
        {
            get { return _invoices; }
            set
            {
                if (_invoices != value)
                {
                    _invoices = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoicePayment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InvoicePayment InvoicePayment
        {
            get { return _invoicePayment; }
            set
            {
                if (_invoicePayment != value)
                {
                    _invoicePayment = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TransactionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId
        {
            get { return _transactionId; }
            set
            {
                if (_transactionId != value)
                {
                    _transactionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AXTransaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXTransaction
        {
            get { return _aXTransaction; }
            set
            {
                if (_aXTransaction != value)
                {
                    _aXTransaction = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoicesAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InvoicesAmount
        {
            get { return _invoicesAmount; }
            set
            {
                if (_invoicesAmount != value)
                {
                    _invoicesAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PaidByEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaidByEmail
        {
            get { return _paidByEmail; }
            set
            {
                if (_paidByEmail != value)
                {
                    _paidByEmail = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("HasFees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasFees
        {
            get { return _hasFees; }
            set
            {
                if (_hasFees != value)
                {
                    _hasFees = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsMoneyOnAccountRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsMoneyOnAccountRequest
        {
            get { return _isMoneyOnAccountRequest; }
            set
            {
                if (_isMoneyOnAccountRequest != value)
                {
                    _isMoneyOnAccountRequest = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreditCardType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditCardType
        {
            get { return _creditCardType; }
            set
            {
                if (_creditCardType != value)
                {
                    _creditCardType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CardNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (_cardNumber != value)
                {
                    _cardNumber = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoicePaymentRecord : ObservableObject
    {
        private string _accountNo;
        private string _invoiceKey;
        private string _recId;
        private string _feesText;
        private double? _feesPercentage;
        private double? _feesAmount;
        private double? _totalBalanceAmount;
        private double? _invoiceAmount;
        private double? _amount;
        private string _note;

        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceKey
        {
            get { return _invoiceKey; }
            set
            {
                if (_invoiceKey != value)
                {
                    _invoiceKey = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FeesText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FeesText
        {
            get { return _feesText; }
            set
            {
                if (_feesText != value)
                {
                    _feesText = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FeesPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FeesPercentage
        {
            get { return _feesPercentage; }
            set
            {
                if (_feesPercentage != value)
                {
                    _feesPercentage = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FeesAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FeesAmount
        {
            get { return _feesAmount; }
            set
            {
                if (_feesAmount != value)
                {
                    _feesAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TotalBalanceAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalBalanceAmount
        {
            get { return _totalBalanceAmount; }
            set
            {
                if (_totalBalanceAmount != value)
                {
                    _totalBalanceAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InvoiceAmount
        {
            get { return _invoiceAmount; }
            set
            {
                if (_invoiceAmount != value)
                {
                    _invoiceAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }



    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUser : ObservableObject
    {
        private System.Guid? _appUserId;
        private System.Guid? _customerId;
        private Customer _customer;
        private string _firstName;
        private string _lastName;
        private string _loginId;
        private string _password;
        private System.Guid? _accountStatusId;
        private AccountStatus _accountStatus;
        private System.DateTimeOffset? _dateCreated;
        private int? _invalidLoginTries;
        private System.Collections.Generic.ICollection<AppPermission> _permissions;
        private System.Collections.Generic.ICollection<AppUserCustomer> _appUserCustomers;
        private System.Collections.Generic.ICollection<DocumentUploadCustomer> _documents;
        private System.Collections.Generic.ICollection<LoginHistory> _loginHistoryRecords;
        private System.Collections.Generic.ICollection<AppUserCreditCardToken> _creditCardTokens;
        private AppUserDetail _appUserDetail;
        private bool? _isAdmin;
        private bool? _viewedSiteTutorial;
        private string _preferences;
        private string _gridPreferences;
        private string _filterPreferences;
        private System.Guid? _systemTimeZoneId;
        private SystemTimeZone _systemTimeZone;
        private string _phoneNumber;
        private string _normalizedPhoneNumber;
        private bool? _isPhoneNumberVerified;
        private bool? _isAutoVerifyPhoneOptedOut;
        private string _language;

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Customer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("LoginId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginId
        {
            get { return _loginId; }
            set
            {
                if (_loginId != value)
                {
                    _loginId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountStatusId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AccountStatusId
        {
            get { return _accountStatusId; }
            set
            {
                if (_accountStatusId != value)
                {
                    _accountStatusId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountStatus AccountStatus
        {
            get { return _accountStatus; }
            set
            {
                if (_accountStatus != value)
                {
                    _accountStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvalidLoginTries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InvalidLoginTries
        {
            get { return _invalidLoginTries; }
            set
            {
                if (_invalidLoginTries != value)
                {
                    _invalidLoginTries = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Permissions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppPermission> Permissions
        {
            get { return _permissions; }
            set
            {
                if (_permissions != value)
                {
                    _permissions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserCustomers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUserCustomer> AppUserCustomers
        {
            get { return _appUserCustomers; }
            set
            {
                if (_appUserCustomers != value)
                {
                    _appUserCustomers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Documents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DocumentUploadCustomer> Documents
        {
            get { return _documents; }
            set
            {
                if (_documents != value)
                {
                    _documents = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("LoginHistoryRecords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LoginHistory> LoginHistoryRecords
        {
            get { return _loginHistoryRecords; }
            set
            {
                if (_loginHistoryRecords != value)
                {
                    _loginHistoryRecords = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreditCardTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUserCreditCardToken> CreditCardTokens
        {
            get { return _creditCardTokens; }
            set
            {
                if (_creditCardTokens != value)
                {
                    _creditCardTokens = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserDetail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUserDetail AppUserDetail
        {
            get { return _appUserDetail; }
            set
            {
                if (_appUserDetail != value)
                {
                    _appUserDetail = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsAdmin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ViewedSiteTutorial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ViewedSiteTutorial
        {
            get { return _viewedSiteTutorial; }
            set
            {
                if (_viewedSiteTutorial != value)
                {
                    _viewedSiteTutorial = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Preferences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Preferences
        {
            get { return _preferences; }
            set
            {
                if (_preferences != value)
                {
                    _preferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("GridPreferences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GridPreferences
        {
            get { return _gridPreferences; }
            set
            {
                if (_gridPreferences != value)
                {
                    _gridPreferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FilterPreferences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterPreferences
        {
            get { return _filterPreferences; }
            set
            {
                if (_filterPreferences != value)
                {
                    _filterPreferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SystemTimeZoneId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? SystemTimeZoneId
        {
            get { return _systemTimeZoneId; }
            set
            {
                if (_systemTimeZoneId != value)
                {
                    _systemTimeZoneId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SystemTimeZone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SystemTimeZone SystemTimeZone
        {
            get { return _systemTimeZone; }
            set
            {
                if (_systemTimeZone != value)
                {
                    _systemTimeZone = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("NormalizedPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedPhoneNumber
        {
            get { return _normalizedPhoneNumber; }
            set
            {
                if (_normalizedPhoneNumber != value)
                {
                    _normalizedPhoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsPhoneNumberVerified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPhoneNumberVerified
        {
            get { return _isPhoneNumberVerified; }
            set
            {
                if (_isPhoneNumberVerified != value)
                {
                    _isPhoneNumberVerified = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsAutoVerifyPhoneOptedOut", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAutoVerifyPhoneOptedOut
        {
            get { return _isAutoVerifyPhoneOptedOut; }
            set
            {
                if (_isAutoVerifyPhoneOptedOut != value)
                {
                    _isAutoVerifyPhoneOptedOut = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum AppUserDetailRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Viewer")]
        Plant_Viewer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Admin")]
        Plant_Admin = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sales_Rep")]
        Sales_Rep = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserDetail : ObservableObject
    {
        private System.Guid? _appUserId;
        private AppUser _appUser;
        private AppUserDetailRole? _role;
        private System.Guid? _branchId;
        private Branch _branch;
        private string _salesRepTag;

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser AppUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AppUserDetailRole? Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesRepTag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesRepTag
        {
            get { return _salesRepTag; }
            set
            {
                if (_salesRepTag != value)
                {
                    _salesRepTag = value;
                    RaisePropertyChanged();
                }
            }
        }


      

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SystemTimeZone : ObservableObject
    {
        private System.Guid? _systemTimeZoneId;
        private string _name;
        private string _stanardName;
        private string _abbreviation;

        [Newtonsoft.Json.JsonProperty("SystemTimeZoneId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? SystemTimeZoneId
        {
            get { return _systemTimeZoneId; }
            set
            {
                if (_systemTimeZoneId != value)
                {
                    _systemTimeZoneId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("StanardName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StanardName
        {
            get { return _stanardName; }
            set
            {
                if (_stanardName != value)
                {
                    _stanardName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Abbreviation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Abbreviation
        {
            get { return _abbreviation; }
            set
            {
                if (_abbreviation != value)
                {
                    _abbreviation = value;
                    RaisePropertyChanged();
                }
            }
        }



    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserCreditCardToken : ObservableObject
    {
        private System.Guid? _appUserCreditCardTokenId;
        private System.Guid? _appUserId;
        private AppUser _appUser;
        private string _token;
        private string _cardType;
        private string _friendlyName;
        private System.DateTimeOffset? _expiryDate;
        private System.DateTimeOffset? _dateCreated;
        private System.DateTimeOffset? _dateUpdated;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _countryCode;

        [Newtonsoft.Json.JsonProperty("AppUserCreditCardTokenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserCreditCardTokenId
        {
            get { return _appUserCreditCardTokenId; }
            set
            {
                if (_appUserCreditCardTokenId != value)
                {
                    _appUserCreditCardTokenId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser AppUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token
        {
            get { return _token; }
            set
            {
                if (_token != value)
                {
                    _token = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CardType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardType
        {
            get { return _cardType; }
            set
            {
                if (_cardType != value)
                {
                    _cardType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FriendlyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FriendlyName
        {
            get { return _friendlyName; }
            set
            {
                if (_friendlyName != value)
                {
                    _friendlyName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateUpdated
        {
            get { return _dateUpdated; }
            set
            {
                if (_dateUpdated != value)
                {
                    _dateUpdated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CountryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AccountStatus : ObservableObject
    {
        private System.Guid? _accountStatusId;
        private string _name;
        private string _description;

        [Newtonsoft.Json.JsonProperty("AccountStatusId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AccountStatusId
        {
            get { return _accountStatusId; }
            set
            {
                if (_accountStatusId != value)
                {
                    _accountStatusId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }


    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppPermission : ObservableObject
    {
        private System.Guid? _appPermissionId;
        private string _name;
        private string _description;
        private bool? _active;
        private System.Collections.Generic.ICollection<AppUser> _appUsers;
        private AppPermissionType? _type;

        [Newtonsoft.Json.JsonProperty("AppPermissionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppPermissionId
        {
            get { return _appPermissionId; }
            set
            {
                if (_appPermissionId != value)
                {
                    _appPermissionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUsers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUser> AppUsers
        {
            get { return _appUsers; }
            set
            {
                if (_appUsers != value)
                {
                    _appUsers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AppPermissionType? Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }


   
    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum InvoicePaymentStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Pending")]
        Pending = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Completed")]
        Completed = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Void")]
        Void = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum AppPermissionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"TruliteUser")]
        TruliteUser = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CustomerUser")]
        CustomerUser = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"TruliteAndCustomerUser")]
        TruliteAndCustomerUser = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserCustomer : ObservableObject
    {
        private System.Guid? _appUserId;
        private AppUser _appUser;
        private System.Guid? _customerId;
        private Customer _customer;
        private bool? _isAdmin;
        private string _permissions;
        private System.DateTimeOffset? _expiresAt;

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser AppUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Customer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsAdmin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Permissions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Permissions
        {
            get { return _permissions; }
            set
            {
                if (_permissions != value)
                {
                    _permissions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ExpiresAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiresAt
        {
            get { return _expiresAt; }
            set
            {
                if (_expiresAt != value)
                {
                    _expiresAt = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DocumentUploadCustomer : ObservableObject
    {
        private System.Guid? _documentUploadCustomerId;
        private string _name;
        private System.Guid? _customerId;
        private Customer _customer;
        private System.Guid? _appUserId;
        private AppUser _appUser;
        private string _originalFileName;
        private System.DateTimeOffset? _dateCreated;

        [Newtonsoft.Json.JsonProperty("DocumentUploadCustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? DocumentUploadCustomerId
        {
            get { return _documentUploadCustomerId; }
            set
            {
                if (_documentUploadCustomerId != value)
                {
                    _documentUploadCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Customer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser AppUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("OriginalFileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalFileName
        {
            get { return _originalFileName; }
            set
            {
                if (_originalFileName != value)
                {
                    _originalFileName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class LoginHistory :ObservableObject
    {
        private System.Guid? _loginHistoryId;
        private System.Guid? _appUserId;
        private AppUser _appUser;
        private bool? _successful;
        private string _iPAddress;
        private System.DateTimeOffset? _dateCreated;

        [Newtonsoft.Json.JsonProperty("LoginHistoryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? LoginHistoryId
        {
            get { return _loginHistoryId; }
            set
            {
                if (_loginHistoryId != value)
                {
                    _loginHistoryId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser AppUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IPAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IPAddress
        {
            get { return _iPAddress; }
            set
            {
                if (_iPAddress != value)
                {
                    _iPAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Customer : ObservableObject
    {
        private System.Guid? _customerId;
        private bool? _isPermissionOverriden;
        private bool? _syncSubAccounts;
        private string _aXCustomerId;
        private string _name;
        private string _permissions;
        private bool? _groupJobAccounts;
        private System.Collections.Generic.ICollection<AppUser> _appUsers;
        private System.Collections.Generic.ICollection<DocumentUploadCustomer> _documents;
        private Branch _branch;
        private System.Guid? _branchId;

        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsPermissionOverriden", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPermissionOverriden
        {
            get { return _isPermissionOverriden; }
            set
            {
                if (_isPermissionOverriden != value)
                {
                    _isPermissionOverriden = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SyncSubAccounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SyncSubAccounts
        {
            get { return _syncSubAccounts; }
            set
            {
                if (_syncSubAccounts != value)
                {
                    _syncSubAccounts = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Permissions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Permissions
        {
            get { return _permissions; }
            set
            {
                if (_permissions != value)
                {
                    _permissions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("GroupJobAccounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? GroupJobAccounts
        {
            get { return _groupJobAccounts; }
            set
            {
                if (_groupJobAccounts != value)
                {
                    _groupJobAccounts = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUsers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUser> AppUsers
        {
            get { return _appUsers; }
            set
            {
                if (_appUsers != value)
                {
                    _appUsers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Documents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DocumentUploadCustomer> Documents
        {
            get { return _documents; }
            set
            {
                if (_documents != value)
                {
                    _documents = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoicePayment : ObservableObject
    {
        private System.Guid? _invoicePaymentId;
        private System.Guid? _paidById;
        private AppUser _paidBy;
        private System.Guid? _customerId;
        private Customer _customer;
        private InvoicePaymentStatus? _invoicePaymentStatus;
        private System.DateTimeOffset? _dateCreated;
        private double? _invoiceAmount;
        private string _aXTransaction;
        private string _signedVals;
        private string _invoiceNumbers;
        private System.DateTimeOffset? _dateProcessed;
        private string _authorizationCode;
        private string _authorizationResponse;
        private string _transactionType;
        private string _copyEmailAddress;
        private bool? _settled;
        private string _note;
        private bool? _isMoneyOnAccountRequest;
        private string _partialInvoicesContext;

        [Newtonsoft.Json.JsonProperty("InvoicePaymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? InvoicePaymentId
        {
            get { return _invoicePaymentId; }
            set
            {
                if (_invoicePaymentId != value)
                {
                    _invoicePaymentId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PaidById", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? PaidById
        {
            get { return _paidById; }
            set
            {
                if (_paidById != value)
                {
                    _paidById = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PaidBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUser PaidBy
        {
            get { return _paidBy; }
            set
            {
                if (_paidBy != value)
                {
                    _paidBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Customer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoicePaymentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvoicePaymentStatus? InvoicePaymentStatus
        {
            get { return _invoicePaymentStatus; }
            set
            {
                if (_invoicePaymentStatus != value)
                {
                    _invoicePaymentStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InvoiceAmount
        {
            get { return _invoiceAmount; }
            set
            {
                if (_invoiceAmount != value)
                {
                    _invoiceAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AXTransaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXTransaction
        {
            get { return _aXTransaction; }
            set
            {
                if (_aXTransaction != value)
                {
                    _aXTransaction = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SignedVals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SignedVals
        {
            get { return _signedVals; }
            set
            {
                if (_signedVals != value)
                {
                    _signedVals = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceNumbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceNumbers
        {
            get { return _invoiceNumbers; }
            set
            {
                if (_invoiceNumbers != value)
                {
                    _invoiceNumbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateProcessed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateProcessed
        {
            get { return _dateProcessed; }
            set
            {
                if (_dateProcessed != value)
                {
                    _dateProcessed = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AuthorizationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorizationCode
        {
            get { return _authorizationCode; }
            set
            {
                if (_authorizationCode != value)
                {
                    _authorizationCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AuthorizationResponse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorizationResponse
        {
            get { return _authorizationResponse; }
            set
            {
                if (_authorizationResponse != value)
                {
                    _authorizationResponse = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TransactionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionType
        {
            get { return _transactionType; }
            set
            {
                if (_transactionType != value)
                {
                    _transactionType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CopyEmailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CopyEmailAddress
        {
            get { return _copyEmailAddress; }
            set
            {
                if (_copyEmailAddress != value)
                {
                    _copyEmailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Settled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Settled
        {
            get { return _settled; }
            set
            {
                if (_settled != value)
                {
                    _settled = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsMoneyOnAccountRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsMoneyOnAccountRequest
        {
            get { return _isMoneyOnAccountRequest; }
            set
            {
                if (_isMoneyOnAccountRequest != value)
                {
                    _isMoneyOnAccountRequest = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PartialInvoicesContext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PartialInvoicesContext
        {
            get { return _partialInvoicesContext; }
            set
            {
                if (_partialInvoicesContext != value)
                {
                    _partialInvoicesContext = value;
                    RaisePropertyChanged();
                }
            }
        }



    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum NewUserAppUserLanguage
    {
        [System.Runtime.Serialization.EnumMember(Value = @"English")]
        English = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"French")]
        French = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Spanish")]
        Spanish = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class NewUser : ObservableObject
    {
        private string _userId;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _accountNo;
        private string _invoiceNo;
        private string _inviteCode;
        private string _company;
        private NewUserAppUserLanguage? _appUserLanguage;

        [Newtonsoft.Json.JsonProperty("UserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set
            {
                if (_invoiceNo != value)
                {
                    _invoiceNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InviteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InviteCode
        {
            get { return _inviteCode; }
            set
            {
                if (_inviteCode != value)
                {
                    _inviteCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Company", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Company
        {
            get { return _company; }
            set
            {
                if (_company != value)
                {
                    _company = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NewUserAppUserLanguage? AppUserLanguage
        {
            get { return _appUserLanguage; }
            set
            {
                if (_appUserLanguage != value)
                {
                    _appUserLanguage = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfNewUserCreationResult : ObservableObject
    {
        private NewUserCreationResult _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        private string _successfulMessage;

        /// <summary>Message</summary>
        [Newtonsoft.Json.JsonProperty("SuccessfulMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SuccessfulMessage
        {
            get { return _successfulMessage; }
            set
            {
                if (_successfulMessage != value)
                {
                    _successfulMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NewUserCreationResult Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class NewUserCreationResult :ObservableObject
    {
        private System.Collections.Generic.IDictionary<string, object> _extraData;
        private System.Collections.Generic.ICollection<string> _messages;
        private bool? _successful;
        private object _result;
        private string _successfulMessage;


        /// <summary>Message</summary>
        [Newtonsoft.Json.JsonProperty("SuccessfulMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SuccessfulMessage
        {
            get { return _successfulMessage; }
            set
            {
                if (_successfulMessage != value)
                {
                    _successfulMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ExtraData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, object> ExtraData
        {
            get { return _extraData; }
            set
            {
                if (_extraData != value)
                {
                    _extraData = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Messages
        {
            get { return _messages; }
            set
            {
                if (_messages != value)
                {
                    _messages = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    RaisePropertyChanged();
                }
            }
        }



    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum UpcomingDeliveriesQueryContextStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class UpcomingDeliveriesQueryContext :ObservableObject
    {
        private System.DateTimeOffset? _startDate;
        private string _filterAccountNo;
        private string _emailAddress;
        private System.Collections.Generic.ICollection<string> _selectedOrders;
        private System.DateTimeOffset? _endDate;
        private UpcomingDeliveriesQueryContextStatus? _status;

        /// <summary>Start Date</summary>
        [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>FIlter Accoutn No</summary>
        [Newtonsoft.Json.JsonProperty("FilterAccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterAccountNo
        {
            get { return _filterAccountNo; }
            set
            {
                if (_filterAccountNo != value)
                {
                    _filterAccountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Email Address</summary>
        [Newtonsoft.Json.JsonProperty("EmailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Selected Orders</summary>
        [Newtonsoft.Json.JsonProperty("SelectedOrders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SelectedOrders
        {
            get { return _selectedOrders; }
            set
            {
                if (_selectedOrders != value)
                {
                    _selectedOrders = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range query.</summary>
        [Newtonsoft.Json.JsonProperty("EndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UpcomingDeliveriesQueryContextStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfProofOfDeliveryViewModel : ObservableObject
    {
        private System.Collections.Generic.ICollection<ProofOfDeliveryViewModel> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProofOfDeliveryViewModel> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


      
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ProofOfDeliveryViewModel : ObservableObject
    {
        private string _barcode;
        private string _createdBy;
        private System.DateTimeOffset? _dateCreated;
        private System.DateTimeOffset? _dateModified;
        private System.DateTimeOffset? _dateScanned;
        private string _salesOrder;

        [Newtonsoft.Json.JsonProperty("Barcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Barcode
        {
            get { return _barcode; }
            set
            {
                if (_barcode != value)
                {
                    _barcode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                if (_createdBy != value)
                {
                    _createdBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateModified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateModified
        {
            get { return _dateModified; }
            set
            {
                if (_dateModified != value)
                {
                    _dateModified = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateScanned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateScanned
        {
            get { return _dateScanned; }
            set
            {
                if (_dateScanned != value)
                {
                    _dateScanned = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }


      

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ResetPasswordByAdminViewModel : ObservableObject
    {
        private System.Guid? _appUserId;
        private string _newPassword;

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("NewPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewPassword
        {
            get { return _newPassword; }
            set
            {
                if (_newPassword != value)
                {
                    _newPassword = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfStringOf : ObservableObject
    {
        private System.Collections.Generic.ICollection<string> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


       
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class UpdatePhoneQueryContext : ObservableObject
    {
        private string _phoneNumber;

        /// <summary>Phone number.</summary>
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfGuid : ObservableObject
    {
        private System.Guid? _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.2.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustomerConfirmInformation : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.Generic.ICollection<CustomerConfirmInformation> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerConfirmInformation> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.2.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerConfirmInformation : System.ComponentModel.INotifyPropertyChanged
    {
        private CustomerConfirmInformationType? _type;
        private string _friendlyCommunicationType;
        private string _communicationTypeId;
        private string _value;
        private long? _key;

        /// <summary>Confirmation type.</summary>
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CustomerConfirmInformationType? Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Communication type.</summary>
        [Newtonsoft.Json.JsonProperty("FriendlyCommunicationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FriendlyCommunicationType
        {
            get { return _friendlyCommunicationType; }
            set
            {
                if (_friendlyCommunicationType != value)
                {
                    _friendlyCommunicationType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Communication type ID.</summary>
        [Newtonsoft.Json.JsonProperty("CommunicationTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommunicationTypeId
        {
            get { return _communicationTypeId; }
            set
            {
                if (_communicationTypeId != value)
                {
                    _communicationTypeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Value of the given confirmation type.</summary>
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.2.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerConfirmInfoContext : System.ComponentModel.INotifyPropertyChanged
    {
        private CustomerContext _customerInfo;
        private string _value;
        private string _communicationTypeId;
        private string _fax;
        private string _email;
        private long? _key;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CommunicationTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommunicationTypeId
        {
            get { return _communicationTypeId; }
            set
            {
                if (_communicationTypeId != value)
                {
                    _communicationTypeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Fax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fax
        {
            get { return _fax; }
            set
            {
                if (_fax != value)
                {
                    _fax = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PasswordResetEmailQueryContext : ObservableObject
    {
        private string _emailAddress;
        private string _selectedLanguage;
        private VerifyCodeQueryContext _verification;
        private string _newPassword;

        /// <summary>Email address of the user.</summary>
        [Newtonsoft.Json.JsonProperty("EmailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The language the user selected to use in the application.</summary>
        [Newtonsoft.Json.JsonProperty("SelectedLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                if (_selectedLanguage != value)
                {
                    _selectedLanguage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Verification Code to submit for password reset.</summary>
        [Newtonsoft.Json.JsonProperty("Verification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VerifyCodeQueryContext Verification
        {
            get { return _verification; }
            set
            {
                if (_verification != value)
                {
                    _verification = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The new password to change to.</summary>
        [Newtonsoft.Json.JsonProperty("NewPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewPassword
        {
            get { return _newPassword; }
            set
            {
                if (_newPassword != value)
                {
                    _newPassword = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class VerifyCodeQueryContext : ObservableObject
    {
        private System.Guid? _verificationCodeId;
        private string _code;

        /// <summary>Verification code ID.</summary>
        [Newtonsoft.Json.JsonProperty("VerificationCodeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? VerificationCodeId
        {
            get { return _verificationCodeId; }
            set
            {
                if (_verificationCodeId != value)
                {
                    _verificationCodeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Verification code.</summary>
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged();
                }
            }
        }




    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PasswordResetPhoneQueryContext : ObservableObject
    {
        private string _phoneNumber;
        private string _selectedLanguage;
        private VerifyCodeQueryContext _verification;
        private string _newPassword;

        /// <summary>Phone number of the user.</summary>
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The language the user selected to use in the application.</summary>
        [Newtonsoft.Json.JsonProperty("SelectedLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                if (_selectedLanguage != value)
                {
                    _selectedLanguage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Verification Code to submit for password reset.</summary>
        [Newtonsoft.Json.JsonProperty("Verification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VerifyCodeQueryContext Verification
        {
            get { return _verification; }
            set
            {
                if (_verification != value)
                {
                    _verification = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The new password to change to.</summary>
        [Newtonsoft.Json.JsonProperty("NewPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewPassword
        {
            get { return _newPassword; }
            set
            {
                if (_newPassword != value)
                {
                    _newPassword = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustomerCreditCardTokenViewModel : ObservableObject
    {
        private System.Collections.Generic.ICollection<CustomerCreditCardTokenViewModel> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerCreditCardTokenViewModel> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerCreditCardTokenViewModel : ObservableObject
    {
        private System.Guid? _tokenId;
        private string _token;
        private string _cardType;
        private string _friendlyName;
        private System.DateTimeOffset? _expiryDate;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _countryCode;
        private string _account;
        private string _accountNo;
        private string _createdBy;
        private string _updatedBy;
        private bool? _canDelete;
        private bool? _canEdit;
        private ObservableCollection<string> _copyReceiptEmailAddresses;
        private System.DateTimeOffset? _dateCreated;
        private System.DateTimeOffset? _dateUpdated;

        [Newtonsoft.Json.JsonProperty("TokenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? TokenId
        {
            get { return _tokenId; }
            set
            {
                if (_tokenId != value)
                {
                    _tokenId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token
        {
            get { return _token; }
            set
            {
                if (_token != value)
                {
                    _token = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CardType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardType
        {
            get { return _cardType; }
            set
            {
                if (_cardType != value)
                {
                    _cardType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FriendlyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FriendlyName
        {
            get { return _friendlyName; }
            set
            {
                if (_friendlyName != value)
                {
                    _friendlyName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CountryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                if (_createdBy != value)
                {
                    _createdBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("UpdatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UpdatedBy
        {
            get { return _updatedBy; }
            set
            {
                if (_updatedBy != value)
                {
                    _updatedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CanDelete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CanDelete
        {
            get { return _canDelete; }
            set
            {
                if (_canDelete != value)
                {
                    _canDelete = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CanEdit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CanEdit
        {
            get { return _canEdit; }
            set
            {
                if (_canEdit != value)
                {
                    _canEdit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CopyReceiptEmailAddresses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> CopyReceiptEmailAddresses
        {
            get { return _copyReceiptEmailAddresses; }
            set
            {
                if (_copyReceiptEmailAddresses != value)
                {
                    _copyReceiptEmailAddresses = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateUpdated
        {
            get { return _dateUpdated; }
            set
            {
                if (_dateUpdated != value)
                {
                    _dateUpdated = value;
                    RaisePropertyChanged();
                }
            }
        }


       

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DeleteCustomerCreditCardToken : ObservableObject
    {
        private System.Guid? _creditCardTokenId;

        [Newtonsoft.Json.JsonProperty("CreditCardTokenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CreditCardTokenId
        {
            get { return _creditCardTokenId; }
            set
            {
                if (_creditCardTokenId != value)
                {
                    _creditCardTokenId = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class UpdateCreditCardTokenContext : ObservableObject
    {
        private System.Guid? _creditCardTokenId;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _countryCode;
        private System.Collections.Generic.ICollection<string> _copyEmailAddresses;



        [Newtonsoft.Json.JsonProperty("CreditCardTokenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CreditCardTokenId
        {
            get { return _creditCardTokenId; }
            set
            {
                if (_creditCardTokenId != value)
                {
                    _creditCardTokenId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CountryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CopyEmailAddresses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> CopyEmailAddresses
        {
            get { return _copyEmailAddresses; }
            set
            {
                if (_copyEmailAddresses != value)
                {
                    _copyEmailAddresses = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfAppUserCreditCardTokenViewModel : ObservableObject
    {
        private System.Collections.Generic.ICollection<AppUserCreditCardTokenViewModel> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUserCreditCardTokenViewModel> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserCreditCardTokenViewModel : ObservableObject
    {
        private System.Guid? _tokenId;
        private string _token;
        private string _cardType;
        private string _friendlyName;
        private System.DateTimeOffset? _expiryDate;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _countryCode;
        private DateTimeOffset? _dateCreated;
        private DateTimeOffset? _dateUpdated;


        [Newtonsoft.Json.JsonProperty("TokenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? TokenId
        {
            get { return _tokenId; }
            set
            {
                if (_tokenId != value)
                {
                    _tokenId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token
        {
            get { return _token; }
            set
            {
                if (_token != value)
                {
                    _token = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CardType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardType
        {
            get { return _cardType; }
            set
            {
                if (_cardType != value)
                {
                    _cardType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FriendlyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FriendlyName
        {
            get { return _friendlyName; }
            set
            {
                if (_friendlyName != value)
                {
                    _friendlyName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CountryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateUpdated
        {
            get { return _dateUpdated; }
            set
            {
                if (_dateUpdated != value)
                {
                    _dateUpdated = value;
                    RaisePropertyChanged();
                }
            }
        }

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfDictionaryStringBool : ObservableObject
    {
        private Dictionary<string, bool> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Dictionary<string, bool> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfInvoicePaymentView : ObservableObject
    {
        private System.Collections.Generic.ICollection<InvoicePaymentView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoicePaymentView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum InvoicePaymentViewInvoicePaymentStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Pending")]
        Pending = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Completed")]
        Completed = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Void")]
        Void = 3,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoicePaymentView : ObservableObject
    {
        private string _aXTransaction;
        private bool? _settled;
        private System.Guid? _invoicePaymentId;
        private string _customerName;
        private string _paidBy;
        private System.DateTimeOffset? _dateCreated;
        private System.DateTimeOffset? _dateProcessed;
        private InvoicePaymentViewInvoicePaymentStatus? _invoicePaymentStatus;
        private string _authorizationCode;
        private string _invoiceNumbers;
        private double? _amount;
        private string _aXCustomerId;
        private string _transactionType;
        private string _invoiceKey;
        private bool? _isMoneyOnAccountRequest;
        private string _note;

        [Newtonsoft.Json.JsonProperty("AXTransaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXTransaction
        {
            get { return _aXTransaction; }
            set
            {
                if (_aXTransaction != value)
                {
                    _aXTransaction = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Settled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Settled
        {
            get { return _settled; }
            set
            {
                if (_settled != value)
                {
                    _settled = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoicePaymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? InvoicePaymentId
        {
            get { return _invoicePaymentId; }
            set
            {
                if (_invoicePaymentId != value)
                {
                    _invoicePaymentId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PaidBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaidBy
        {
            get { return _paidBy; }
            set
            {
                if (_paidBy != value)
                {
                    _paidBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateProcessed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateProcessed
        {
            get { return _dateProcessed; }
            set
            {
                if (_dateProcessed != value)
                {
                    _dateProcessed = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoicePaymentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvoicePaymentViewInvoicePaymentStatus? InvoicePaymentStatus
        {
            get { return _invoicePaymentStatus; }
            set
            {
                if (_invoicePaymentStatus != value)
                {
                    _invoicePaymentStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AuthorizationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorizationCode
        {
            get { return _authorizationCode; }
            set
            {
                if (_authorizationCode != value)
                {
                    _authorizationCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceNumbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceNumbers
        {
            get { return _invoiceNumbers; }
            set
            {
                if (_invoiceNumbers != value)
                {
                    _invoiceNumbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TransactionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionType
        {
            get { return _transactionType; }
            set
            {
                if (_transactionType != value)
                {
                    _transactionType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceKey
        {
            get { return _invoiceKey; }
            set
            {
                if (_invoiceKey != value)
                {
                    _invoiceKey = value;
                    RaisePropertyChanged();
                }
            }
        }


        [Newtonsoft.Json.JsonProperty("IsMoneyOnAccountRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsMoneyOnAccountRequest
        {
            get { return _isMoneyOnAccountRequest; }
            set
            {
                if (_isMoneyOnAccountRequest != value)
                {
                    _isMoneyOnAccountRequest = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CreditCardPaymentsQueryContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.DateTimeOffset? _fromDate;
        private System.DateTimeOffset? _toDate;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range to query.</summary>
        [Newtonsoft.Json.JsonProperty("FromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    _fromDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range to query.</summary>
        [Newtonsoft.Json.JsonProperty("ToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    _toDate = value;
                    RaisePropertyChanged();
                }
            }
        }

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MarkRouteCompletedContext : ObservableObject
    {
        private string _key;
        private string _name;
        private string _site;

        /// <summary>Key</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the sales pool.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Site of the sales pool.</summary>
        [Newtonsoft.Json.JsonProperty("Site", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Site
        {
            get { return _site; }
            set
            {
                if (_site != value)
                {
                    _site = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfResponse : ObservableObject
    {
        private Response _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Response Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Response : ObservableObject
    {
        private System.Collections.Generic.IDictionary<string, object> _extraData;
        private System.Collections.Generic.ICollection<string> _messages;
        private bool? _successful;
        private object _result;

        [Newtonsoft.Json.JsonProperty("ExtraData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, object> ExtraData
        {
            get { return _extraData; }
            set
            {
                if (_extraData != value)
                {
                    _extraData = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Messages
        {
            get { return _messages; }
            set
            {
                if (_messages != value)
                {
                    _messages = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    RaisePropertyChanged();
                }
            }
        }


    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustomerCreditLimit : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<CustomerCreditLimit> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerCreditLimit> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerCreditLimit : GalaSoft.MvvmLight.ObservableObject
    {
        private string _customerId;
        private string _customerName;
        private double? _creditLimit;
        private double? _availableCredit;

        /// <summary>Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer name.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Credit limit of the customer.</summary>
        [Newtonsoft.Json.JsonProperty("CreditLimit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditLimit
        {
            get { return _creditLimit; }
            set
            {
                if (_creditLimit != value)
                {
                    _creditLimit = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Available credit of the customer.</summary>
        [Newtonsoft.Json.JsonProperty("AvailableCredit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailableCredit
        {
            get { return _availableCredit; }
            set
            {
                if (_availableCredit != value)
                {
                    _availableCredit = value;
                    RaisePropertyChanged();
                }
            }
        }







    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoiceSettlementsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.DateTimeOffset? _fromDate;
        private System.DateTimeOffset? _toDate;
        private long? _invoiceRecId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range.</summary>
        [Newtonsoft.Json.JsonProperty("FromDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    _fromDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range.</summary>
        [Newtonsoft.Json.JsonProperty("ToDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    _toDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice record ID. If supplied, the query will return settlements for that invoice only.</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceRecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? InvoiceRecId
        {
            get { return _invoiceRecId; }
            set
            {
                if (_invoiceRecId != value)
                {
                    _invoiceRecId = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfInvoiceSettlement : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<InvoiceSettlement> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoiceSettlement> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoiceSettlement : GalaSoft.MvvmLight.ObservableObject
    {
        private string _customerId;
        private string _customerName;
        private string _invoiceId;
        private System.DateTimeOffset? _transactionDate;
        private string _settlementAmount;
        private string _settlementTransactionText;

        /// <summary>AX Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer Name.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice ID.</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceId
        {
            get { return _invoiceId; }
            set
            {
                if (_invoiceId != value)
                {
                    _invoiceId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transaction date.</summary>
        [Newtonsoft.Json.JsonProperty("TransactionDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransactionDate
        {
            get { return _transactionDate; }
            set
            {
                if (_transactionDate != value)
                {
                    _transactionDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Settlement amount.</summary>
        [Newtonsoft.Json.JsonProperty("SettlementAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SettlementAmount
        {
            get { return _settlementAmount; }
            set
            {
                if (_settlementAmount != value)
                {
                    _settlementAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Settlement text.</summary>
        [Newtonsoft.Json.JsonProperty("SettlementTransactionText", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SettlementTransactionText
        {
            get { return _settlementTransactionText; }
            set
            {
                if (_settlementTransactionText != value)
                {
                    _settlementTransactionText = value;
                    RaisePropertyChanged();
                }
            }
        }







    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfItemInfo : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ItemInfo> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ItemInfo> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ItemInfo : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private string _sortOrder;
        private double? _thickness;
        private string _displayThickness;
        private string _key;

        /// <summary>Name of the item.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sort Order.</summary>
        [Newtonsoft.Json.JsonProperty("SortOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortOrder
        {
            get { return _sortOrder; }
            set
            {
                if (_sortOrder != value)
                {
                    _sortOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Type of the thickness.</summary>
        [Newtonsoft.Json.JsonProperty("Thickness", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Thickness
        {
            get { return _thickness; }
            set
            {
                if (_thickness != value)
                {
                    _thickness = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Displayed name of the tickness.</summary>
        [Newtonsoft.Json.JsonProperty("DisplayThickness", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayThickness
        {
            get { return _displayThickness; }
            set
            {
                if (_displayThickness != value)
                {
                    _displayThickness = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ValiationError : GalaSoft.MvvmLight.ObservableObject
    {
        private string _propertyName;
        private string _errorMessage;

        /// <summary>Name of the invalid property.</summary>
        [Newtonsoft.Json.JsonProperty("PropertyName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PropertyName
        {
            get { return _propertyName; }
            set
            {
                if (_propertyName != value)
                {
                    _propertyName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation message associated with the invalid property.</summary>
        [Newtonsoft.Json.JsonProperty("ErrorMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    /// <summary>Filter properties for packing slip queries.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackingSlipsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;
        private string _salesOrderId;
        private string _customerPurchaseOrderNo;
        private System.DateTimeOffset? _fromShipDate;
        private System.DateTimeOffset? _toShipDate;
        private System.DateTimeOffset? _packingSlipDate;
        private string _salesPoolId;
        private string _inventLocationId;
        private string _salesGroupId;
        private string _status;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range of the shipping date to query.</summary>
        [Newtonsoft.Json.JsonProperty("FromShipDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromShipDate
        {
            get { return _fromShipDate; }
            set
            {
                if (_fromShipDate != value)
                {
                    _fromShipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range of the shipping date to query.</summary>
        [Newtonsoft.Json.JsonProperty("ToShipDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToShipDate
        {
            get { return _toShipDate; }
            set
            {
                if (_toShipDate != value)
                {
                    _toShipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date when the packing slip was created.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PackingSlipDate
        {
            get { return _packingSlipDate; }
            set
            {
                if (_packingSlipDate != value)
                {
                    _packingSlipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales pool ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesPoolId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPoolId
        {
            get { return _salesPoolId; }
            set
            {
                if (_salesPoolId != value)
                {
                    _salesPoolId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location ID (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group ID&amp;gt;</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroupId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroupId
        {
            get { return _salesGroupId; }
            set
            {
                if (_salesGroupId != value)
                {
                    _salesGroupId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the packing slip.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerContext : GalaSoft.MvvmLight.ObservableObject
    {
        private bool? _groupJobAccounts;
        private System.Guid? _customerId;
        private string _aXCustomerId;
        private string _customerName;

        [Newtonsoft.Json.JsonProperty("GroupJobAccounts", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? GroupJobAccounts
        {
            get { return _groupJobAccounts; }
            set
            {
                if (_groupJobAccounts != value)
                {
                    _groupJobAccounts = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The customer ID in Microsoft Dynamics NAV.</summary>
        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the customer.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

    }






    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfPackingSlip : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<PackingSlip> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackingSlip> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackingSlip : ObservableObject
    {
        private SalesOrder _order;
        private Account _account;
        private System.DateTimeOffset? _shipDate;
        private string _voucher;
        private string _customerPhoneNumber;
        private string _customerName;
        private Branch _branch;
        private int? _linesCount;
        private string _customerPurchaseOrderNo;
        private System.DateTimeOffset? _orderDate;
        private string _routing;
        private System.DateTimeOffset? _dateWanted;
        private System.DateTimeOffset? _dateShipped;
        private string _terms;
        private double? _totalWeight;
        private double? _totalSqft;
        private double? _totalPieces;
        private string _customerRef;
        private System.Collections.Generic.ICollection<PackingSlipLine> _lines;
        private string _salesPerson;
        private System.DateTimeOffset? _packingSlipDate;
        private string _inventLocationName;
        private string _recId;
        private Address _custAddress;
        private bool? _canBeInvoiced;
        private string _status;
        private string _safetyIndicator;
        private string _custSpecialRequest;
        private string _salesPersonName;
        private System.DateTimeOffset? _clockInDateTime;
        private System.DateTimeOffset? _clockOutDateTime;
        private bool? _showProductionTracking;
        private string _key;

        /// <summary>Show PRoduction Tracking on this Account.</summary>
        [Newtonsoft.Json.JsonProperty("ShowProductionTracking", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowProductionTracking
        {
            get { return _showProductionTracking; }
            set
            {
                if (_showProductionTracking != value)
                {
                    _showProductionTracking = value;
                    RaisePropertyChanged();
                }
            }
        }


        /// <summary>Sales Order</summary>
        [Newtonsoft.Json.JsonProperty("Order", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder Order
        {
            get { return _order; }
            set
            {
                if (_order != value)
                {
                    _order = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account.</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date the items was shipped.</summary>
        [Newtonsoft.Json.JsonProperty("ShipDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ShipDate
        {
            get { return _shipDate; }
            set
            {
                if (_shipDate != value)
                {
                    _shipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Voucher</summary>
        [Newtonsoft.Json.JsonProperty("Voucher", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Voucher
        {
            get { return _voucher; }
            set
            {
                if (_voucher != value)
                {
                    _voucher = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer phone number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPhoneNumber
        {
            get { return _customerPhoneNumber; }
            set
            {
                if (_customerPhoneNumber != value)
                {
                    _customerPhoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the customer.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch for this packing slips.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The count of line items.</summary>
        [Newtonsoft.Json.JsonProperty("LinesCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinesCount
        {
            get { return _linesCount; }
            set
            {
                if (_linesCount != value)
                {
                    _linesCount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date the sales order was placed.</summary>
        [Newtonsoft.Json.JsonProperty("OrderDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OrderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate != value)
                {
                    _orderDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Routing.</summary>
        [Newtonsoft.Json.JsonProperty("Routing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Routing
        {
            get { return _routing; }
            set
            {
                if (_routing != value)
                {
                    _routing = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date requested by the customer.</summary>
        [Newtonsoft.Json.JsonProperty("DateWanted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateWanted
        {
            get { return _dateWanted; }
            set
            {
                if (_dateWanted != value)
                {
                    _dateWanted = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the item was shipped.</summary>
        [Newtonsoft.Json.JsonProperty("DateShipped", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateShipped
        {
            get { return _dateShipped; }
            set
            {
                if (_dateShipped != value)
                {
                    _dateShipped = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Terms.</summary>
        [Newtonsoft.Json.JsonProperty("Terms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Terms
        {
            get { return _terms; }
            set
            {
                if (_terms != value)
                {
                    _terms = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total weight of the item.</summary>
        [Newtonsoft.Json.JsonProperty("TotalWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalWeight
        {
            get { return _totalWeight; }
            set
            {
                if (_totalWeight != value)
                {
                    _totalWeight = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total square feet of the item.</summary>
        [Newtonsoft.Json.JsonProperty("TotalSqft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSqft
        {
            get { return _totalSqft; }
            set
            {
                if (_totalSqft != value)
                {
                    _totalSqft = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total pieces in the item.</summary>
        [Newtonsoft.Json.JsonProperty("TotalPieces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalPieces
        {
            get { return _totalPieces; }
            set
            {
                if (_totalPieces != value)
                {
                    _totalPieces = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Line items of this packing slip.</summary>
        [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackingSlipLine> Lines
        {
            get { return _lines; }
            set
            {
                if (_lines != value)
                {
                    _lines = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales person.</summary>
        [Newtonsoft.Json.JsonProperty("SalesPerson", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPerson
        {
            get { return _salesPerson; }
            set
            {
                if (_salesPerson != value)
                {
                    _salesPerson = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date when the packing slip was created.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PackingSlipDate
        {
            get { return _packingSlipDate; }
            set
            {
                if (_packingSlipDate != value)
                {
                    _packingSlipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location name (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationName
        {
            get { return _inventLocationName; }
            set
            {
                if (_inventLocationName != value)
                {
                    _inventLocationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Record ID.</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's address.</summary>
        [Newtonsoft.Json.JsonProperty("CustAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address CustAddress
        {
            get { return _custAddress; }
            set
            {
                if (_custAddress != value)
                {
                    _custAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Gets whether this item can be invoices.</summary>
        [Newtonsoft.Json.JsonProperty("CanBeInvoiced", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CanBeInvoiced
        {
            get { return _canBeInvoiced; }
            set
            {
                if (_canBeInvoiced != value)
                {
                    _canBeInvoiced = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the packing slip.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Safety indicator.</summary>
        [Newtonsoft.Json.JsonProperty("SafetyIndicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SafetyIndicator
        {
            get { return _safetyIndicator; }
            set
            {
                if (_safetyIndicator != value)
                {
                    _safetyIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustSpecialRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustSpecialRequest
        {
            get { return _custSpecialRequest; }
            set
            {
                if (_custSpecialRequest != value)
                {
                    _custSpecialRequest = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales Person Name</summary>
        [Newtonsoft.Json.JsonProperty("SalesPersonName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonName
        {
            get { return _salesPersonName; }
            set
            {
                if (_salesPersonName != value)
                {
                    _salesPersonName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>DateTime when the packing slip has been clocked in by the driver</summary>
        [Newtonsoft.Json.JsonProperty("ClockInDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClockInDateTime
        {
            get { return _clockInDateTime; }
            set
            {
                if (_clockInDateTime != value)
                {
                    _clockInDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>DateTime when the packing slip has been clocked out by the driver</summary>
        [Newtonsoft.Json.JsonProperty("ClockOutDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClockOutDateTime
        {
            get { return _clockOutDateTime; }
            set
            {
                if (_clockOutDateTime != value)
                {
                    _clockOutDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }

    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesOrder : GalaSoft.MvvmLight.ObservableObject
    {
        private SalesOrderCurrency? _currency;
        private System.DateTimeOffset? _orderDate;
        private double? _netAmount;
        private int? _linesCount;
        private string _customerPurchaseOrderNo;
        private SalesOrderStatus? _salesOrderStatus;
        private SalesOrderDeliveryMethod? _deliveryMethod;
        private System.DateTimeOffset? _deliveryDate;
        private System.Collections.Generic.ICollection<Invoice> _invoices;
        private System.Collections.Generic.ICollection<PackingSlip> _packingSlips;
        private Account _account;
        private bool? _dateChanged;
        private string _customerRef;
        private System.Collections.Generic.ICollection<SalesOrderLine> _lines;
        private string _inventLocationName;
        private string _salesPersonName;
        private string _inventLocationId;
        private string _salesPerson;
        private string _key;

        /// <summary>Currency of the order.</summary>
        [Newtonsoft.Json.JsonProperty("Currency", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesOrderCurrency? Currency
        {
            get { return _currency; }
            set
            {
                if (_currency != value)
                {
                    _currency = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Order date.</summary>
        [Newtonsoft.Json.JsonProperty("OrderDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OrderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate != value)
                {
                    _orderDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total amount of the order.</summary>
        [Newtonsoft.Json.JsonProperty("NetAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NetAmount
        {
            get { return _netAmount; }
            set
            {
                if (_netAmount != value)
                {
                    _netAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The count of line items.</summary>
        [Newtonsoft.Json.JsonProperty("LinesCount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinesCount
        {
            get { return _linesCount; }
            set
            {
                if (_linesCount != value)
                {
                    _linesCount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The status of the order.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderStatus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesOrderStatus? SalesOrderStatus
        {
            get { return _salesOrderStatus; }
            set
            {
                if (_salesOrderStatus != value)
                {
                    _salesOrderStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The delivery method of the order.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryMethod", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesOrderDeliveryMethod? DeliveryMethod
        {
            get { return _deliveryMethod; }
            set
            {
                if (_deliveryMethod != value)
                {
                    _deliveryMethod = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Delivery date of the order.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeliveryDate
        {
            get { return _deliveryDate; }
            set
            {
                if (_deliveryDate != value)
                {
                    _deliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoices created from this order.</summary>
        [Newtonsoft.Json.JsonProperty("Invoices", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice> Invoices
        {
            get { return _invoices; }
            set
            {
                if (_invoices != value)
                {
                    _invoices = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slips of this order.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlips", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackingSlip> PackingSlips
        {
            get { return _packingSlips; }
            set
            {
                if (_packingSlips != value)
                {
                    _packingSlips = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account associated with this order.</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date when the order was changed.</summary>
        [Newtonsoft.Json.JsonProperty("DateChanged", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DateChanged
        {
            get { return _dateChanged; }
            set
            {
                if (_dateChanged != value)
                {
                    _dateChanged = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The customer's reference.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The line items of this order.</summary>
        [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesOrderLine> Lines
        {
            get { return _lines; }
            set
            {
                if (_lines != value)
                {
                    _lines = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location name (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationName
        {
            get { return _inventLocationName; }
            set
            {
                if (_inventLocationName != value)
                {
                    _inventLocationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales Person Name</summary>
        [Newtonsoft.Json.JsonProperty("SalesPersonName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonName
        {
            get { return _salesPersonName; }
            set
            {
                if (_salesPersonName != value)
                {
                    _salesPersonName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch W#</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesPerson", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPerson
        {
            get { return _salesPerson; }
            set
            {
                if (_salesPerson != value)
                {
                    _salesPerson = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Account : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private string _key;

        /// <summary>Name of the account.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Branch : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _branchId;
        private string _code;
        private string _description;
        private string _phone;
        private string _fax;
        private string _street;
        private string _state;
        private string _city;
        private string _zipCode;
        private string _deskUrl;
        private string _deskAPIKey;
        private bool? _viewSupportTickets;
        private bool? _addSupportTickets;
        private bool? _createTicketsForNewQuotes;
        private bool? _showReducedLogoOption;
        private string _number;
        private System.Collections.Generic.ICollection<BranchBusinessUnit> _branchBusinessUnits;
        private System.Collections.Generic.ICollection<BranchBoxingType> _branchBoxingTypes;
        private System.Collections.Generic.ICollection<BranchDisabledShape> _disabledShapes;
        private System.Collections.Generic.ICollection<BranchCoating> _branchCoatings;

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Fax", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fax
        {
            get { return _fax; }
            set
            {
                if (_fax != value)
                {
                    _fax = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DeskUrl", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeskUrl
        {
            get { return _deskUrl; }
            set
            {
                if (_deskUrl != value)
                {
                    _deskUrl = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DeskAPIKey", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeskAPIKey
        {
            get { return _deskAPIKey; }
            set
            {
                if (_deskAPIKey != value)
                {
                    _deskAPIKey = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ViewSupportTickets", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ViewSupportTickets
        {
            get { return _viewSupportTickets; }
            set
            {
                if (_viewSupportTickets != value)
                {
                    _viewSupportTickets = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AddSupportTickets", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AddSupportTickets
        {
            get { return _addSupportTickets; }
            set
            {
                if (_addSupportTickets != value)
                {
                    _addSupportTickets = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreateTicketsForNewQuotes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CreateTicketsForNewQuotes
        {
            get { return _createTicketsForNewQuotes; }
            set
            {
                if (_createTicketsForNewQuotes != value)
                {
                    _createTicketsForNewQuotes = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowReducedLogoOption", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowReducedLogoOption
        {
            get { return _showReducedLogoOption; }
            set
            {
                if (_showReducedLogoOption != value)
                {
                    _showReducedLogoOption = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Number
        {
            get { return _number; }
            set
            {
                if (_number != value)
                {
                    _number = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchBusinessUnits", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BranchBusinessUnit> BranchBusinessUnits
        {
            get { return _branchBusinessUnits; }
            set
            {
                if (_branchBusinessUnits != value)
                {
                    _branchBusinessUnits = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchBoxingTypes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BranchBoxingType> BranchBoxingTypes
        {
            get { return _branchBoxingTypes; }
            set
            {
                if (_branchBoxingTypes != value)
                {
                    _branchBoxingTypes = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DisabledShapes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BranchDisabledShape> DisabledShapes
        {
            get { return _disabledShapes; }
            set
            {
                if (_disabledShapes != value)
                {
                    _disabledShapes = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchCoatings", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BranchCoating> BranchCoatings
        {
            get { return _branchCoatings; }
            set
            {
                if (_branchCoatings != value)
                {
                    _branchCoatings = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackingSlipLine : GalaSoft.MvvmLight.ObservableObject
    {
        private PackingSlip _packingSlip;
        private string _inventTransId;
        private string _workOrder;
        private double? _quantityOrdered;
        private string _unit;
        private string _description;
        private double? _listSqftLit;
        private double? _shippedQuantity;
        private double? _backorderedQuantity;
        private System.Collections.Generic.ICollection<PackingSlipLineAddon> _addOns;
        private string _safetyIndicator;
        private string _key;

        [Newtonsoft.Json.JsonProperty("PackingSlip", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PackingSlip PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                if (_packingSlip != value)
                {
                    _packingSlip = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InventTransId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventTransId
        {
            get { return _inventTransId; }
            set
            {
                if (_inventTransId != value)
                {
                    _inventTransId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Work order.</summary>
        [Newtonsoft.Json.JsonProperty("WorkOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkOrder
        {
            get { return _workOrder; }
            set
            {
                if (_workOrder != value)
                {
                    _workOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quantity ordered.</summary>
        [Newtonsoft.Json.JsonProperty("QuantityOrdered", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityOrdered
        {
            get { return _quantityOrdered; }
            set
            {
                if (_quantityOrdered != value)
                {
                    _quantityOrdered = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Unit of measure.</summary>
        [Newtonsoft.Json.JsonProperty("Unit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit
        {
            get { return _unit; }
            set
            {
                if (_unit != value)
                {
                    _unit = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Square feet of the list.</summary>
        [Newtonsoft.Json.JsonProperty("ListSqftLit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ListSqftLit
        {
            get { return _listSqftLit; }
            set
            {
                if (_listSqftLit != value)
                {
                    _listSqftLit = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quantity shipped.</summary>
        [Newtonsoft.Json.JsonProperty("ShippedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippedQuantity
        {
            get { return _shippedQuantity; }
            set
            {
                if (_shippedQuantity != value)
                {
                    _shippedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quantity backordered.</summary>
        [Newtonsoft.Json.JsonProperty("BackorderedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BackorderedQuantity
        {
            get { return _backorderedQuantity; }
            set
            {
                if (_backorderedQuantity != value)
                {
                    _backorderedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Add-ons for this packing slip line item.</summary>
        [Newtonsoft.Json.JsonProperty("AddOns", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackingSlipLineAddon> AddOns
        {
            get { return _addOns; }
            set
            {
                if (_addOns != value)
                {
                    _addOns = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Safety indicator.</summary>
        [Newtonsoft.Json.JsonProperty("SafetyIndicator", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SafetyIndicator
        {
            get { return _safetyIndicator; }
            set
            {
                if (_safetyIndicator != value)
                {
                    _safetyIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Address : GalaSoft.MvvmLight.ObservableObject
    {
        private string _street;
        private string _state;
        private string _city;
        private string _zipCode;
        private bool? _isEmpty;
        private string _name;
        private string _account;
        private string _packedAddress;
        private string _key;

        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsEmpty", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsEmpty
        {
            get { return _isEmpty; }
            set
            {
                if (_isEmpty != value)
                {
                    _isEmpty = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PackedAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackedAddress
        {
            get { return _packedAddress; }
            set
            {
                if (_packedAddress != value)
                {
                    _packedAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Invoice : GalaSoft.MvvmLight.ObservableObject
    {
        private Branch _branch;
        private string _customerReference;
        private string _salesPerson;
        private string _routing;
        private string _customerPurchaseOrderNo;
        private string _terms;
        private double? _amount;
        private System.Collections.Generic.ICollection<InvoiceLine> _lines;
        private System.DateTimeOffset? _invoiceDate;
        private System.DateTimeOffset? _cashDiscountDate;
        private System.DateTimeOffset? _dueDate;
        private InvoiceStatus? _invoiceStatus;
        private Account _account;
        private SalesOrder _order;
        private Address _shipToAddress;
        private string _shipToPhoneNumber;
        private Address _billToAddress;
        private double? _totalWeight;
        private double? _totalSqft;
        private double? _salesBalance;
        private double? _energySurcharge;
        private double? _sandSurcharge;
        private double? _shippingCharge;
        private double? _salesTax;
        private double? _totalDue;
        private string _customerRef;
        private double? _totalDueCalculated;
        private string _inventLocationName;
        private string _recId;
        private bool? _isPaymentPendingOrCompleted;
        private System.DateTimeOffset? _specialDiscDate;
        private string _specialDiscPct;
        private string _salesGroup;
        private double? _totalInvoiceAmount;
        private string _key;

        /// <summary>Branch associated with this invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's reference.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerReference", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerReference
        {
            get { return _customerReference; }
            set
            {
                if (_customerReference != value)
                {
                    _customerReference = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales person.</summary>
        [Newtonsoft.Json.JsonProperty("SalesPerson", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPerson
        {
            get { return _salesPerson; }
            set
            {
                if (_salesPerson != value)
                {
                    _salesPerson = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Routing.</summary>
        [Newtonsoft.Json.JsonProperty("Routing", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Routing
        {
            get { return _routing; }
            set
            {
                if (_routing != value)
                {
                    _routing = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Terms of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Terms", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Terms
        {
            get { return _terms; }
            set
            {
                if (_terms != value)
                {
                    _terms = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Amount of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Line items of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoiceLine> Lines
        {
            get { return _lines; }
            set
            {
                if (_lines != value)
                {
                    _lines = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the invoice was created.</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? InvoiceDate
        {
            get { return _invoiceDate; }
            set
            {
                if (_invoiceDate != value)
                {
                    _invoiceDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date cash discount was given.</summary>
        [Newtonsoft.Json.JsonProperty("CashDiscountDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CashDiscountDate
        {
            get { return _cashDiscountDate; }
            set
            {
                if (_cashDiscountDate != value)
                {
                    _cashDiscountDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Due date.</summary>
        [Newtonsoft.Json.JsonProperty("DueDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DueDate
        {
            get { return _dueDate; }
            set
            {
                if (_dueDate != value)
                {
                    _dueDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceStatus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvoiceStatus? InvoiceStatus
        {
            get { return _invoiceStatus; }
            set
            {
                if (_invoiceStatus != value)
                {
                    _invoiceStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account associated with this invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales orders associated with this invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Order", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder Order
        {
            get { return _order; }
            set
            {
                if (_order != value)
                {
                    _order = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Ship to address.</summary>
        [Newtonsoft.Json.JsonProperty("ShipToAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address ShipToAddress
        {
            get { return _shipToAddress; }
            set
            {
                if (_shipToAddress != value)
                {
                    _shipToAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Ship to phone number.</summary>
        [Newtonsoft.Json.JsonProperty("ShipToPhoneNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipToPhoneNumber
        {
            get { return _shipToPhoneNumber; }
            set
            {
                if (_shipToPhoneNumber != value)
                {
                    _shipToPhoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Bill to address.</summary>
        [Newtonsoft.Json.JsonProperty("BillToAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address BillToAddress
        {
            get { return _billToAddress; }
            set
            {
                if (_billToAddress != value)
                {
                    _billToAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total weight of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("TotalWeight", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalWeight
        {
            get { return _totalWeight; }
            set
            {
                if (_totalWeight != value)
                {
                    _totalWeight = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total square feet of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("TotalSqft", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSqft
        {
            get { return _totalSqft; }
            set
            {
                if (_totalSqft != value)
                {
                    _totalSqft = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales balance.</summary>
        [Newtonsoft.Json.JsonProperty("SalesBalance", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalesBalance
        {
            get { return _salesBalance; }
            set
            {
                if (_salesBalance != value)
                {
                    _salesBalance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Energy surcharge</summary>
        [Newtonsoft.Json.JsonProperty("EnergySurcharge", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EnergySurcharge
        {
            get { return _energySurcharge; }
            set
            {
                if (_energySurcharge != value)
                {
                    _energySurcharge = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sand surcharge</summary>
        [Newtonsoft.Json.JsonProperty("SandSurcharge", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SandSurcharge
        {
            get { return _sandSurcharge; }
            set
            {
                if (_sandSurcharge != value)
                {
                    _sandSurcharge = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Shipping charge.</summary>
        [Newtonsoft.Json.JsonProperty("ShippingCharge", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippingCharge
        {
            get { return _shippingCharge; }
            set
            {
                if (_shippingCharge != value)
                {
                    _shippingCharge = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales tax.</summary>
        [Newtonsoft.Json.JsonProperty("SalesTax", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalesTax
        {
            get { return _salesTax; }
            set
            {
                if (_salesTax != value)
                {
                    _salesTax = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total amount due.</summary>
        [Newtonsoft.Json.JsonProperty("TotalDue", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDue
        {
            get { return _totalDue; }
            set
            {
                if (_totalDue != value)
                {
                    _totalDue = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's reference.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TotalDueCalculated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDueCalculated
        {
            get { return _totalDueCalculated; }
            set
            {
                if (_totalDueCalculated != value)
                {
                    _totalDueCalculated = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location name (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationName
        {
            get { return _inventLocationName; }
            set
            {
                if (_inventLocationName != value)
                {
                    _inventLocationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Record ID.</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the payment is pending or completed.</summary>
        [Newtonsoft.Json.JsonProperty("IsPaymentPendingOrCompleted", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPaymentPendingOrCompleted
        {
            get { return _isPaymentPendingOrCompleted; }
            set
            {
                if (_isPaymentPendingOrCompleted != value)
                {
                    _isPaymentPendingOrCompleted = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SpecialDiscDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SpecialDiscDate
        {
            get { return _specialDiscDate; }
            set
            {
                if (_specialDiscDate != value)
                {
                    _specialDiscDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SpecialDiscPct", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpecialDiscPct
        {
            get { return _specialDiscPct; }
            set
            {
                if (_specialDiscPct != value)
                {
                    _specialDiscPct = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesGroup", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroup
        {
            get { return _salesGroup; }
            set
            {
                if (_salesGroup != value)
                {
                    _salesGroup = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TotalInvoiceAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalInvoiceAmount
        {
            get { return _totalInvoiceAmount; }
            set
            {
                if (_totalInvoiceAmount != value)
                {
                    _totalInvoiceAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesOrderLine : GalaSoft.MvvmLight.ObservableObject
    {
        private SalesOrder _salesOrder;
        private string _itemId;
        private string _itemName;
        private double? _discount;
        private double? _price;
        private string _inventTransId;
        private bool? _dateChanged;
        private double? _quantity;
        private double? _unitPrice;
        private System.DateTimeOffset? _shippingDateRequested;
        private string _key;

        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Discount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Discount
        {
            get { return _discount; }
            set
            {
                if (_discount != value)
                {
                    _discount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Price", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InventTransId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventTransId
        {
            get { return _inventTransId; }
            set
            {
                if (_inventTransId != value)
                {
                    _inventTransId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateChanged", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DateChanged
        {
            get { return _dateChanged; }
            set
            {
                if (_dateChanged != value)
                {
                    _dateChanged = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("UnitPrice", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (_unitPrice != value)
                {
                    _unitPrice = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippingDateRequested", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ShippingDateRequested
        {
            get { return _shippingDateRequested; }
            set
            {
                if (_shippingDateRequested != value)
                {
                    _shippingDateRequested = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchBusinessUnit : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _branchBusinessUnitId;
        private System.Guid? _branchId;
        private bool? _default;
        private string _businessUnitDisplay;
        private Branch _branch;
        private string _businessUnit;

        [Newtonsoft.Json.JsonProperty("BranchBusinessUnitId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchBusinessUnitId
        {
            get { return _branchBusinessUnitId; }
            set
            {
                if (_branchBusinessUnitId != value)
                {
                    _branchBusinessUnitId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Default", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Default
        {
            get { return _default; }
            set
            {
                if (_default != value)
                {
                    _default = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BusinessUnitDisplay", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUnitDisplay
        {
            get { return _businessUnitDisplay; }
            set
            {
                if (_businessUnitDisplay != value)
                {
                    _businessUnitDisplay = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BusinessUnit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUnit
        {
            get { return _businessUnit; }
            set
            {
                if (_businessUnit != value)
                {
                    _businessUnit = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchBoxingType : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _branchBoxingTypeId;
        private Branch _branch;
        private System.Guid? _branchId;
        private BoxingType _boxingType;
        private System.Guid? _boxingTypeId;

        [Newtonsoft.Json.JsonProperty("BranchBoxingTypeId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchBoxingTypeId
        {
            get { return _branchBoxingTypeId; }
            set
            {
                if (_branchBoxingTypeId != value)
                {
                    _branchBoxingTypeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BoxingType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BoxingType BoxingType
        {
            get { return _boxingType; }
            set
            {
                if (_boxingType != value)
                {
                    _boxingType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BoxingTypeId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BoxingTypeId
        {
            get { return _boxingTypeId; }
            set
            {
                if (_boxingTypeId != value)
                {
                    _boxingTypeId = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchDisabledShape : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _branchDisabledShapeId;
        private Branch _branch;
        private System.Guid? _branchId;
        private int? _shapeNumber;

        [Newtonsoft.Json.JsonProperty("BranchDisabledShapeId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchDisabledShapeId
        {
            get { return _branchDisabledShapeId; }
            set
            {
                if (_branchDisabledShapeId != value)
                {
                    _branchDisabledShapeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShapeNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ShapeNumber
        {
            get { return _shapeNumber; }
            set
            {
                if (_shapeNumber != value)
                {
                    _shapeNumber = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchCoating : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _branchCoatingId;
        private BranchCoatingInternalType? _internalType;
        private Branch _branch;
        private System.Guid? _branchId;
        private string _itemId;
        private string _glassType;
        private string _thicknessId;
        private string _description;
        private string _type;

        [Newtonsoft.Json.JsonProperty("BranchCoatingId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchCoatingId
        {
            get { return _branchCoatingId; }
            set
            {
                if (_branchCoatingId != value)
                {
                    _branchCoatingId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InternalType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BranchCoatingInternalType? InternalType
        {
            get { return _internalType; }
            set
            {
                if (_internalType != value)
                {
                    _internalType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("GlassType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GlassType
        {
            get { return _glassType; }
            set
            {
                if (_glassType != value)
                {
                    _glassType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ThicknessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThicknessId
        {
            get { return _thicknessId; }
            set
            {
                if (_thicknessId != value)
                {
                    _thicknessId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackingSlipLineAddon : GalaSoft.MvvmLight.ObservableObject
    {
        private double? _quantityOrdered;
        private string _unit;
        private string _description;
        private double? _listSqftLit;
        private double? _shippedQuantity;
        private double? _backorderedQuantity;
        private string _key;

        [Newtonsoft.Json.JsonProperty("QuantityOrdered", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityOrdered
        {
            get { return _quantityOrdered; }
            set
            {
                if (_quantityOrdered != value)
                {
                    _quantityOrdered = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Unit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit
        {
            get { return _unit; }
            set
            {
                if (_unit != value)
                {
                    _unit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ListSqftLit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ListSqftLit
        {
            get { return _listSqftLit; }
            set
            {
                if (_listSqftLit != value)
                {
                    _listSqftLit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippedQuantity
        {
            get { return _shippedQuantity; }
            set
            {
                if (_shippedQuantity != value)
                {
                    _shippedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BackorderedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BackorderedQuantity
        {
            get { return _backorderedQuantity; }
            set
            {
                if (_backorderedQuantity != value)
                {
                    _backorderedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoiceLine : GalaSoft.MvvmLight.ObservableObject
    {
        private string _inventTransId;
        private double? _quantityOrdered;
        private string _unit;
        private System.DateTimeOffset? _deliveryDate;
        private double? _listSqftLit;
        private double? _discountPriceSqft;
        private double? _priceEach;
        private double? _shippedQuantity;
        private Invoice _invoice;
        private double? _amount;
        private double? _totalWithAddons;
        private System.Collections.Generic.ICollection<InvoiceAddon> _invoiceAddOns;
        private string _itemId;
        private string _itemName;
        private string _key;

        [Newtonsoft.Json.JsonProperty("InventTransId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventTransId
        {
            get { return _inventTransId; }
            set
            {
                if (_inventTransId != value)
                {
                    _inventTransId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("QuantityOrdered", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityOrdered
        {
            get { return _quantityOrdered; }
            set
            {
                if (_quantityOrdered != value)
                {
                    _quantityOrdered = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Unit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit
        {
            get { return _unit; }
            set
            {
                if (_unit != value)
                {
                    _unit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DeliveryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeliveryDate
        {
            get { return _deliveryDate; }
            set
            {
                if (_deliveryDate != value)
                {
                    _deliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ListSqftLit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ListSqftLit
        {
            get { return _listSqftLit; }
            set
            {
                if (_listSqftLit != value)
                {
                    _listSqftLit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DiscountPriceSqft", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiscountPriceSqft
        {
            get { return _discountPriceSqft; }
            set
            {
                if (_discountPriceSqft != value)
                {
                    _discountPriceSqft = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PriceEach", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEach
        {
            get { return _priceEach; }
            set
            {
                if (_priceEach != value)
                {
                    _priceEach = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippedQuantity
        {
            get { return _shippedQuantity; }
            set
            {
                if (_shippedQuantity != value)
                {
                    _shippedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Invoice", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                if (_invoice != value)
                {
                    _invoice = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TotalWithAddons", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalWithAddons
        {
            get { return _totalWithAddons; }
            set
            {
                if (_totalWithAddons != value)
                {
                    _totalWithAddons = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvoiceAddOns", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoiceAddon> InvoiceAddOns
        {
            get { return _invoiceAddOns; }
            set
            {
                if (_invoiceAddOns != value)
                {
                    _invoiceAddOns = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BoxingType : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _boxingTypeId;
        private string _type;
        private string _description;

        [Newtonsoft.Json.JsonProperty("BoxingTypeId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BoxingTypeId
        {
            get { return _boxingTypeId; }
            set
            {
                if (_boxingTypeId != value)
                {
                    _boxingTypeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoiceAddon : GalaSoft.MvvmLight.ObservableObject
    {
        private string _description;
        private string _listSqftLit;
        private double? _discountPriceSqft;
        private double? _priceEach;
        private double? _shippedQuantity;
        private double? _amount;
        private string _key;

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ListSqftLit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ListSqftLit
        {
            get { return _listSqftLit; }
            set
            {
                if (_listSqftLit != value)
                {
                    _listSqftLit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DiscountPriceSqft", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DiscountPriceSqft
        {
            get { return _discountPriceSqft; }
            set
            {
                if (_discountPriceSqft != value)
                {
                    _discountPriceSqft = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PriceEach", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEach
        {
            get { return _priceEach; }
            set
            {
                if (_priceEach != value)
                {
                    _priceEach = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippedQuantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippedQuantity
        {
            get { return _shippedQuantity; }
            set
            {
                if (_shippedQuantity != value)
                {
                    _shippedQuantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackingSlipLineQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;
        private System.DateTimeOffset? _packingSlipDate;
        private string _salesOrderId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date when packing slip was created.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PackingSlipDate
        {
            get { return _packingSlipDate; }
            set
            {
                if (_packingSlipDate != value)
                {
                    _packingSlipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID of the packing slip.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfPackingSlipLine : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<PackingSlipLine> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackingSlipLine> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfKeyNameModelOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<KeyNameModelOfString> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyNameModelOfString> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class KeyNameModelOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private string _key;

        /// <summary>Name of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class LostQuotationQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private string _quotationId;
        private string _reasonId;

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("QuotationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotationId
        {
            get { return _quotationId; }
            set
            {
                if (_quotationId != value)
                {
                    _quotationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Reason ID.</summary>
        [Newtonsoft.Json.JsonProperty("ReasonId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReasonId
        {
            get { return _reasonId; }
            set
            {
                if (_reasonId != value)
                {
                    _reasonId = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfBoolean : GalaSoft.MvvmLight.ObservableObject
    {
        private bool? _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private string _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;
        private string _name;
        private string _type;
        private QuotationsQueryContextStatus? _status;
        private string _salesOrderId;
        private System.DateTimeOffset? _fromExpiryDate;
        private System.DateTimeOffset? _toExpiryDate;
        private string _salesGroupId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation ID&amp;gt;</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation name.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation type.</summary>
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public QuotationsQueryContextStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID for this quotation.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the expiry date range.</summary>
        [Newtonsoft.Json.JsonProperty("FromExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromExpiryDate
        {
            get { return _fromExpiryDate; }
            set
            {
                if (_fromExpiryDate != value)
                {
                    _fromExpiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the expiry date range.</summary>
        [Newtonsoft.Json.JsonProperty("ToExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToExpiryDate
        {
            get { return _toExpiryDate; }
            set
            {
                if (_toExpiryDate != value)
                {
                    _toExpiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroupId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroupId
        {
            get { return _salesGroupId; }
            set
            {
                if (_salesGroupId != value)
                {
                    _salesGroupId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfQuotation : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<Quotation> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Quotation> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Quotation : GalaSoft.MvvmLight.ObservableObject
    {
        private string _custPurchaseOrder;
        private Account _account;
        private string _contact;
        private QuotationStatus? _status;
        private string _type;
        private SalesOrder _order;
        private System.DateTimeOffset? _expiryDate;
        private string _name;
        private string _deliveryName;
        private string _customerRef;
        private string _deliveryAddress;
        private System.DateTimeOffset? _confirmationDate;
        private System.DateTimeOffset? _requestedShipDate;
        private System.DateTimeOffset? _requestedReceiptDate;
        private string _currency;
        private int? _linesCount;
        private System.Collections.Generic.ICollection<QuotationLine> _lines;
        private string _inventLocationId;
        private bool? _showPricing;
        private string _inventLocationName;
        private string _custPaymTermId;
        private string _key;

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustPurchaseOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustPurchaseOrder
        {
            get { return _custPurchaseOrder; }
            set
            {
                if (_custPurchaseOrder != value)
                {
                    _custPurchaseOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Account Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Person to contact.</summary>
        [Newtonsoft.Json.JsonProperty("Contact", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Contact
        {
            get { return _contact; }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotatiin status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public QuotationStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation type.</summary>
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order for this quotation.</summary>
        [Newtonsoft.Json.JsonProperty("Order", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder Order
        {
            get { return _order; }
            set
            {
                if (_order != value)
                {
                    _order = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Expiry date.</summary>
        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the quotation.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of th site to deliver.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryName
        {
            get { return _deliveryName; }
            set
            {
                if (_deliveryName != value)
                {
                    _deliveryName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer reference.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Delivery address.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set
            {
                if (_deliveryAddress != value)
                {
                    _deliveryAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Confirmation date.</summary>
        [Newtonsoft.Json.JsonProperty("ConfirmationDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ConfirmationDate
        {
            get { return _confirmationDate; }
            set
            {
                if (_confirmationDate != value)
                {
                    _confirmationDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Requested date to ship the products.</summary>
        [Newtonsoft.Json.JsonProperty("RequestedShipDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RequestedShipDate
        {
            get { return _requestedShipDate; }
            set
            {
                if (_requestedShipDate != value)
                {
                    _requestedShipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Requested date to receive the products.</summary>
        [Newtonsoft.Json.JsonProperty("RequestedReceiptDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RequestedReceiptDate
        {
            get { return _requestedReceiptDate; }
            set
            {
                if (_requestedReceiptDate != value)
                {
                    _requestedReceiptDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transaction currency.</summary>
        [Newtonsoft.Json.JsonProperty("Currency", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency
        {
            get { return _currency; }
            set
            {
                if (_currency != value)
                {
                    _currency = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Count of the line items.</summary>
        [Newtonsoft.Json.JsonProperty("LinesCount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinesCount
        {
            get { return _linesCount; }
            set
            {
                if (_linesCount != value)
                {
                    _linesCount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<QuotationLine> Lines
        {
            get { return _lines; }
            set
            {
                if (_lines != value)
                {
                    _lines = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location ID (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether to show the pricing.</summary>
        [Newtonsoft.Json.JsonProperty("ShowPricing", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowPricing
        {
            get { return _showPricing; }
            set
            {
                if (_showPricing != value)
                {
                    _showPricing = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Namve of the inventory location (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationName
        {
            get { return _inventLocationName; }
            set
            {
                if (_inventLocationName != value)
                {
                    _inventLocationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's payment term ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustPaymTermId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustPaymTermId
        {
            get { return _custPaymTermId; }
            set
            {
                if (_custPaymTermId != value)
                {
                    _custPaymTermId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationLine : GalaSoft.MvvmLight.ObservableObject
    {
        private string _inventTransId;
        private Quotation _quotation;
        private string _itemNumber;
        private string _itemName;
        private double? _quantity;
        private string _unit;
        private double? _unitPrice;
        private double? _discount;
        private string _currency;
        private double? _amount;
        private string _key;

        /// <summary>Inventory trans ID.</summary>
        [Newtonsoft.Json.JsonProperty("InventTransId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventTransId
        {
            get { return _inventTransId; }
            set
            {
                if (_inventTransId != value)
                {
                    _inventTransId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation for this line item.</summary>
        [Newtonsoft.Json.JsonProperty("Quotation", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Quotation Quotation
        {
            get { return _quotation; }
            set
            {
                if (_quotation != value)
                {
                    _quotation = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Item number.</summary>
        [Newtonsoft.Json.JsonProperty("ItemNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemNumber
        {
            get { return _itemNumber; }
            set
            {
                if (_itemNumber != value)
                {
                    _itemNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Nam of the item.</summary>
        [Newtonsoft.Json.JsonProperty("ItemName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quantity.</summary>
        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Unit of measure.</summary>
        [Newtonsoft.Json.JsonProperty("Unit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit
        {
            get { return _unit; }
            set
            {
                if (_unit != value)
                {
                    _unit = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Unit price.</summary>
        [Newtonsoft.Json.JsonProperty("UnitPrice", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (_unitPrice != value)
                {
                    _unitPrice = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Discount.</summary>
        [Newtonsoft.Json.JsonProperty("Discount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Discount
        {
            get { return _discount; }
            set
            {
                if (_discount != value)
                {
                    _discount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Currency for this quotation line item.</summary>
        [Newtonsoft.Json.JsonProperty("Currency", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency
        {
            get { return _currency; }
            set
            {
                if (_currency != value)
                {
                    _currency = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total amount for this line item.</summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationLinesQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfQuotationLine : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<QuotationLine> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<QuotationLine> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationHeaderContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _customerPONumber;
        private string _inventSiteId;
        private string _customerRefNumber;
        private System.DateTimeOffset? _requestedDate;
        private Address _address;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerPONumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPONumber
        {
            get { return _customerPONumber; }
            set
            {
                if (_customerPONumber != value)
                {
                    _customerPONumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InventSiteId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventSiteId
        {
            get { return _inventSiteId; }
            set
            {
                if (_inventSiteId != value)
                {
                    _inventSiteId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerRefNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRefNumber
        {
            get { return _customerRefNumber; }
            set
            {
                if (_customerRefNumber != value)
                {
                    _customerRefNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("RequestedDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RequestedDate
        {
            get { return _requestedDate; }
            set
            {
                if (_requestedDate != value)
                {
                    _requestedDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CreateQuoteLineContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _itemId;
        private string _quotationNo;
        private double? _quantity;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("QuotationNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotationNo
        {
            get { return _quotationNo; }
            set
            {
                if (_quotationNo != value)
                {
                    _quotationNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesInquiryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private string _inventSiteId;
        private SalesInquiryContextLeadTime? _leadTime;
        private double? _probability;
        private SalesInquiryContextFilter? _filter;
        private string _salesGroup;
        private string _salesResponsible;
        private string _accountNo;
        private string _accountName;
        private string _customerRef;
        private System.DateTimeOffset? _fromExpiryDate;
        private System.DateTimeOffset? _toExpiryDate;
        private double? _fromAmount;
        private double? _toAmount;

        /// <summary>Inventory site ID.</summary>
        [Newtonsoft.Json.JsonProperty("InventSiteId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventSiteId
        {
            get { return _inventSiteId; }
            set
            {
                if (_inventSiteId != value)
                {
                    _inventSiteId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Lead time.</summary>
        [Newtonsoft.Json.JsonProperty("LeadTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesInquiryContextLeadTime? LeadTime
        {
            get { return _leadTime; }
            set
            {
                if (_leadTime != value)
                {
                    _leadTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Probability.</summary>
        [Newtonsoft.Json.JsonProperty("Probability", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Probability
        {
            get { return _probability; }
            set
            {
                if (_probability != value)
                {
                    _probability = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation status filter.</summary>
        [Newtonsoft.Json.JsonProperty("Filter", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesInquiryContextFilter? Filter
        {
            get { return _filter; }
            set
            {
                if (_filter != value)
                {
                    _filter = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group.</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroup", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroup
        {
            get { return _salesGroup; }
            set
            {
                if (_salesGroup != value)
                {
                    _salesGroup = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales representative.</summary>
        [Newtonsoft.Json.JsonProperty("SalesResponsible", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesResponsible
        {
            get { return _salesResponsible; }
            set
            {
                if (_salesResponsible != value)
                {
                    _salesResponsible = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account number.</summary>
        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonProperty("AccountName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountName
        {
            get { return _accountName; }
            set
            {
                if (_accountName != value)
                {
                    _accountName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer reference number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the expiry date range.</summary>
        [Newtonsoft.Json.JsonProperty("FromExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromExpiryDate
        {
            get { return _fromExpiryDate; }
            set
            {
                if (_fromExpiryDate != value)
                {
                    _fromExpiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the expiry date range.</summary>
        [Newtonsoft.Json.JsonProperty("ToExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToExpiryDate
        {
            get { return _toExpiryDate; }
            set
            {
                if (_toExpiryDate != value)
                {
                    _toExpiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the amount range query.</summary>
        [Newtonsoft.Json.JsonProperty("FromAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FromAmount
        {
            get { return _fromAmount; }
            set
            {
                if (_fromAmount != value)
                {
                    _fromAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the amount range query.</summary>
        [Newtonsoft.Json.JsonProperty("ToAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToAmount
        {
            get { return _toAmount; }
            set
            {
                if (_toAmount != value)
                {
                    _toAmount = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfSalesQuotationInquiry : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<SalesQuotationInquiry> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesQuotationInquiry> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesQuotationInquiry : GalaSoft.MvvmLight.ObservableObject
    {
        private string _quotationId;
        private string _quotationName;
        private string _status;
        private System.DateTimeOffset? _expiryDate;
        private string _currencyCode;
        private int? _linesQty;
        private string _custAccount;
        private string _custName;
        private string _customerRef;
        private string _inventLocationId;
        private string _inventLocationName;
        private string _inventSiteId;
        private double? _totalInvoiceAmount;
        private string _custPurchaseOrder;
        private string _note;
        private string _salesResponsible;
        private string _salesGroup;
        private string _leadTime;
        private double? _probability;
        private string _contactName;
        private System.DateTimeOffset? _dateCreated;
        private string _salesPersonName;

        private System.DateTimeOffset _followUpDate;
        [Newtonsoft.Json.JsonProperty("FollowUpDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset FollowUpDate
        {
            get { return _followUpDate; }
            set
            {
                _followUpDate = value;
                RaisePropertyChanged();
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesPersonName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonName
        {
            get { return _salesPersonName; }
            set
            {
                _salesPersonName = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("QuotationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotationId
        {
            get { return _quotationId; }
            set
            {
                if (_quotationId != value)
                {
                    _quotationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation Name.</summary>
        [Newtonsoft.Json.JsonProperty("QuotationName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotationName
        {
            get { return _quotationName; }
            set
            {
                if (_quotationName != value)
                {
                    _quotationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Expiry date.</summary>
        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation currency code.</summary>
        [Newtonsoft.Json.JsonProperty("CurrencyCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set
            {
                if (_currencyCode != value)
                {
                    _currencyCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quantity of line items.</summary>
        [Newtonsoft.Json.JsonProperty("LinesQty", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinesQty
        {
            get { return _linesQty; }
            set
            {
                if (_linesQty != value)
                {
                    _linesQty = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer account.</summary>
        [Newtonsoft.Json.JsonProperty("CustAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                if (_custAccount != value)
                {
                    _custAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer name.</summary>
        [Newtonsoft.Json.JsonProperty("CustName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustName
        {
            get { return _custName; }
            set
            {
                if (_custName != value)
                {
                    _custName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer reference number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerRef", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerRef
        {
            get { return _customerRef; }
            set
            {
                if (_customerRef != value)
                {
                    _customerRef = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location ID (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory location name (branch).</summary>
        [Newtonsoft.Json.JsonProperty("InventLocationName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationName
        {
            get { return _inventLocationName; }
            set
            {
                if (_inventLocationName != value)
                {
                    _inventLocationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Inventory site ID.</summary>
        [Newtonsoft.Json.JsonProperty("InventSiteId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventSiteId
        {
            get { return _inventSiteId; }
            set
            {
                if (_inventSiteId != value)
                {
                    _inventSiteId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Total amount to invoice.</summary>
        [Newtonsoft.Json.JsonProperty("TotalInvoiceAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalInvoiceAmount
        {
            get { return _totalInvoiceAmount; }
            set
            {
                if (_totalInvoiceAmount != value)
                {
                    _totalInvoiceAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustPurchaseOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustPurchaseOrder
        {
            get { return _custPurchaseOrder; }
            set
            {
                if (_custPurchaseOrder != value)
                {
                    _custPurchaseOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Comments.</summary>
        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales representative.</summary>
        [Newtonsoft.Json.JsonProperty("SalesResponsible", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesResponsible
        {
            get { return _salesResponsible; }
            set
            {
                if (_salesResponsible != value)
                {
                    _salesResponsible = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group.</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroup", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroup
        {
            get { return _salesGroup; }
            set
            {
                if (_salesGroup != value)
                {
                    _salesGroup = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Lead time.</summary>
        [Newtonsoft.Json.JsonProperty("LeadTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LeadTime
        {
            get { return _leadTime; }
            set
            {
                if (_leadTime != value)
                {
                    _leadTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Probability.</summary>
        [Newtonsoft.Json.JsonProperty("Probability", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Probability
        {
            get { return _probability; }
            set
            {
                if (_probability != value)
                {
                    _probability = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the contact.</summary>
        [Newtonsoft.Json.JsonProperty("ContactName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                if (_contactName != value)
                {
                    _contactName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date created.</summary>
        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }





    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationUpdateQueryContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;
        private string _custAccount;
        private double? _percent;
        private QuotationUpdateQueryContextLeadTime? _leadTime;
        private string _notes;
        private System.DateTimeOffset? _expiryDate;
        private System.DateTimeOffset? _followUpDate;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer account.</summary>
        [Newtonsoft.Json.JsonProperty("CustAccount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                if (_custAccount != value)
                {
                    _custAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Percentage.</summary>
        [Newtonsoft.Json.JsonProperty("Percent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Percent
        {
            get { return _percent; }
            set
            {
                if (_percent != value)
                {
                    _percent = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Lead time.</summary>
        [Newtonsoft.Json.JsonProperty("LeadTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public QuotationUpdateQueryContextLeadTime? LeadTime
        {
            get { return _leadTime; }
            set
            {
                if (_leadTime != value)
                {
                    _leadTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Note/comments.</summary>
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Expiry date.</summary>
        [Newtonsoft.Json.JsonProperty("ExpiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Follow Up Date</summary>
        [Newtonsoft.Json.JsonProperty("FollowUpDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FollowUpDate
        {
            get { return _followUpDate; }
            set
            {
                if (_followUpDate != value)
                {
                    _followUpDate = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationNotesQueryContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _id;
        private string _custAccount;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customers account.</summary>
        [Newtonsoft.Json.JsonProperty("CustAccount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                if (_custAccount != value)
                {
                    _custAccount = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfQuotationNote : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<QuotationNote> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<QuotationNote> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class QuotationNote : GalaSoft.MvvmLight.ObservableObject
    {
        private string _quotationId;
        private string _user;
        private string _notes;
        private System.DateTimeOffset? _dateTime;

        /// <summary>Quotation ID.</summary>
        [Newtonsoft.Json.JsonProperty("QuotationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotationId
        {
            get { return _quotationId; }
            set
            {
                if (_quotationId != value)
                {
                    _quotationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>User who created the note.</summary>
        [Newtonsoft.Json.JsonProperty("User", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Notes/Comments.</summary>
        [Newtonsoft.Json.JsonProperty("Notes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the note was created.</summary>
        [Newtonsoft.Json.JsonProperty("DateTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateTime
        {
            get { return _dateTime; }
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesOrderSummaryQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.DateTimeOffset? _endDate;
        private System.DateTimeOffset? _startDate;
        private SalesOrderSummaryQueryContextSummaryPeriod? _summaryPeriod;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range.</summary>
        [Newtonsoft.Json.JsonProperty("EndDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range.</summary>
        [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order summary period.</summary>
        [Newtonsoft.Json.JsonProperty("SummaryPeriod", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesOrderSummaryQueryContextSummaryPeriod? SummaryPeriod
        {
            get { return _summaryPeriod; }
            set
            {
                if (_summaryPeriod != value)
                {
                    _summaryPeriod = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfChartDataPointOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ChartDataPointOfString> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChartDataPointOfString> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ChartDataPointOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private string _label;
        private double? _value;

        /// <summary>Label on the chart.</summary>
        [Newtonsoft.Json.JsonProperty("Label", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Label
        {
            get { return _label; }
            set
            {
                if (_label != value)
                {
                    _label = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Value of the label.</summary>
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfSalesPool : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<SalesPool> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesPool> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesPool : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private string _site;
        private string _key;

        /// <summary>Name of the sales pool.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Site of the sales pool.</summary>
        [Newtonsoft.Json.JsonProperty("Site", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Site
        {
            get { return _site; }
            set
            {
                if (_site != value)
                {
                    _site = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoicesQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _invoiceId;
        private string _salesOrderId;
        private System.DateTimeOffset? _fromDueDate;
        private System.DateTimeOffset? _toDueDate;
        private System.DateTimeOffset? _fromInvoiceDate;
        private System.DateTimeOffset? _toInvoiceDate;
        private InvoicesQueryContextStatus? _status;
        private string _customerPurchaseOrderNo;
        private string _salesGroupId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice ID.</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceId
        {
            get { return _invoiceId; }
            set
            {
                if (_invoiceId != value)
                {
                    _invoiceId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the due date range.</summary>
        [Newtonsoft.Json.JsonProperty("FromDueDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromDueDate
        {
            get { return _fromDueDate; }
            set
            {
                if (_fromDueDate != value)
                {
                    _fromDueDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the due date range.</summary>
        [Newtonsoft.Json.JsonProperty("ToDueDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToDueDate
        {
            get { return _toDueDate; }
            set
            {
                if (_toDueDate != value)
                {
                    _toDueDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the invoice date range.</summary>
        [Newtonsoft.Json.JsonProperty("FromInvoiceDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromInvoiceDate
        {
            get { return _fromInvoiceDate; }
            set
            {
                if (_fromInvoiceDate != value)
                {
                    _fromInvoiceDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the invoice date range.</summary>
        [Newtonsoft.Json.JsonProperty("ToInvoiceDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToInvoiceDate
        {
            get { return _toInvoiceDate; }
            set
            {
                if (_toInvoiceDate != value)
                {
                    _toInvoiceDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the invoice.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvoicesQueryContextStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroupId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroupId
        {
            get { return _salesGroupId; }
            set
            {
                if (_salesGroupId != value)
                {
                    _salesGroupId = value;
                    RaisePropertyChanged();
                }
            }
        }





    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesOrderQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _salesOrderNo;
        private string _customerPurchaseOrderNo;
        private System.DateTimeOffset? _startDate;
        private System.DateTimeOffset? _endDate;
        private SalesOrderQueryContextStatus? _status;
        private string _salesGroupId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order number (key).</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderNo
        {
            get { return _salesOrderNo; }
            set
            {
                if (_salesOrderNo != value)
                {
                    _salesOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's purchase order number.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPurchaseOrderNo
        {
            get { return _customerPurchaseOrderNo; }
            set
            {
                if (_customerPurchaseOrderNo != value)
                {
                    _customerPurchaseOrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range query.</summary>
        [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range query.</summary>
        [Newtonsoft.Json.JsonProperty("EndDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalesOrderQueryContextStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales group ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesGroupId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroupId
        {
            get { return _salesGroupId; }
            set
            {
                if (_salesGroupId != value)
                {
                    _salesGroupId = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfString : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<string> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfSalesOrder : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<SalesOrder> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesOrder> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ProductsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _thicknessId;
        private string _inventSiteId;
        private string _processId;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ThicknessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThicknessId
        {
            get { return _thicknessId; }
            set
            {
                if (_thicknessId != value)
                {
                    _thicknessId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InventSiteId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventSiteId
        {
            get { return _inventSiteId; }
            set
            {
                if (_inventSiteId != value)
                {
                    _inventSiteId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ProcessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProcessId
        {
            get { return _processId; }
            set
            {
                if (_processId != value)
                {
                    _processId = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfProduct : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<Product> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Product> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Product : GalaSoft.MvvmLight.ObservableObject
    {
        private string _itemName;
        private string _searchName;
        private string _salesUnit;
        private double? _netWeight;
        private double? _grossWeight;
        private double? _depth;
        private double? _width;
        private double? _height;
        private string _category;
        private string _thicknessId;
        private string _processId;
        private string _processName;
        private string _colorId;
        private string _colorName;
        private string _imageUrl;
        private string _reflective;
        private string _itemReportGroupName;
        private string _itemGroupId;
        private string _key;

        [Newtonsoft.Json.JsonProperty("ItemName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SearchName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                if (_searchName != value)
                {
                    _searchName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesUnit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesUnit
        {
            get { return _salesUnit; }
            set
            {
                if (_salesUnit != value)
                {
                    _salesUnit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("NetWeight", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NetWeight
        {
            get { return _netWeight; }
            set
            {
                if (_netWeight != value)
                {
                    _netWeight = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("GrossWeight", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GrossWeight
        {
            get { return _grossWeight; }
            set
            {
                if (_grossWeight != value)
                {
                    _grossWeight = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Depth", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Depth
        {
            get { return _depth; }
            set
            {
                if (_depth != value)
                {
                    _depth = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Width", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Width
        {
            get { return _width; }
            set
            {
                if (_width != value)
                {
                    _width = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Category", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ThicknessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThicknessId
        {
            get { return _thicknessId; }
            set
            {
                if (_thicknessId != value)
                {
                    _thicknessId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ProcessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProcessId
        {
            get { return _processId; }
            set
            {
                if (_processId != value)
                {
                    _processId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ProcessName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProcessName
        {
            get { return _processName; }
            set
            {
                if (_processName != value)
                {
                    _processName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ColorId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColorId
        {
            get { return _colorId; }
            set
            {
                if (_colorId != value)
                {
                    _colorId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ColorName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColorName
        {
            get { return _colorName; }
            set
            {
                if (_colorName != value)
                {
                    _colorName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ImageUrl", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                if (_imageUrl != value)
                {
                    _imageUrl = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Reflective", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reflective
        {
            get { return _reflective; }
            set
            {
                if (_reflective != value)
                {
                    _reflective = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemReportGroupName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemReportGroupName
        {
            get { return _itemReportGroupName; }
            set
            {
                if (_itemReportGroupName != value)
                {
                    _itemReportGroupName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemGroupId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemGroupId
        {
            get { return _itemGroupId; }
            set
            {
                if (_itemGroupId != value)
                {
                    _itemGroupId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfInvoice : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<Invoice> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SalesOrderLineQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private SalesOrder _salesOrder;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfSalesOrderLine : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<SalesOrderLine> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SalesOrderLine> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InvoicesQueryLineContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private Invoice _invoice;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Invoice", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                if (_invoice != value)
                {
                    _invoice = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfInvoiceLine : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<InvoiceLine> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InvoiceLine> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfChartDataPointOfDateTime : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ChartDataPointOfDateTime> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChartDataPointOfDateTime> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ChartDataPointOfDateTime : GalaSoft.MvvmLight.ObservableObject
    {
        private System.DateTimeOffset? _label;
        private double? _value;

        /// <summary>Label on the chart.</summary>
        [Newtonsoft.Json.JsonProperty("Label", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Label
        {
            get { return _label; }
            set
            {
                if (_label != value)
                {
                    _label = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Value of the label.</summary>
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReturnOrderQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private System.DateTimeOffset? _startDate;
        private System.DateTimeOffset? _endDate;
        private string _salesOrderId;
        private CustomerContext _customerInfo;
        private ReturnOrderQueryContextStatus? _status;

        [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("EndDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReturnOrderQueryContextStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfReturnOrder : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ReturnOrder> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReturnOrder> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReturnOrder : GalaSoft.MvvmLight.ObservableObject
    {
        private SalesOrder _salesOrder;
        private Invoice _invoice;
        private double? _amount;
        private string _orderNo;
        private ReturnOrderStatus? _status;
        private string _deliveryTerm;
        private string _site;
        private string _warehouse;
        private System.DateTimeOffset? _returnDate;
        private int? _linesCount;
        private System.Collections.Generic.ICollection<ReturnOrderLine> _lines;
        private string _key;

        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Invoice", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                if (_invoice != value)
                {
                    _invoice = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("OrderNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderNo
        {
            get { return _orderNo; }
            set
            {
                if (_orderNo != value)
                {
                    _orderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReturnOrderStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DeliveryTerm", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryTerm
        {
            get { return _deliveryTerm; }
            set
            {
                if (_deliveryTerm != value)
                {
                    _deliveryTerm = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Site", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Site
        {
            get { return _site; }
            set
            {
                if (_site != value)
                {
                    _site = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Warehouse", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Warehouse
        {
            get { return _warehouse; }
            set
            {
                if (_warehouse != value)
                {
                    _warehouse = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ReturnDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReturnDate
        {
            get { return _returnDate; }
            set
            {
                if (_returnDate != value)
                {
                    _returnDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("LinesCount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinesCount
        {
            get { return _linesCount; }
            set
            {
                if (_linesCount != value)
                {
                    _linesCount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReturnOrderLine> Lines
        {
            get { return _lines; }
            set
            {
                if (_lines != value)
                {
                    _lines = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReturnOrderLine : GalaSoft.MvvmLight.ObservableObject
    {
        private ReturnOrder _returnOrder;
        private double? _amount;
        private string _itemName;
        private string _itemId;
        private double? _quantity;
        private string _returnReason;
        private System.DateTimeOffset? _returnDate;
        private ReturnOrderLineStatus? _status;
        private string _key;

        [Newtonsoft.Json.JsonProperty("ReturnOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReturnOrder ReturnOrder
        {
            get { return _returnOrder; }
            set
            {
                if (_returnOrder != value)
                {
                    _returnOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ItemId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ReturnReason", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnReason
        {
            get { return _returnReason; }
            set
            {
                if (_returnReason != value)
                {
                    _returnReason = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ReturnDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReturnDate
        {
            get { return _returnDate; }
            set
            {
                if (_returnDate != value)
                {
                    _returnDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReturnOrderLineStatus? Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReturnOrderLineQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _salesOrderId;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfReturnOrderLine : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ReturnOrderLine> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReturnOrderLine> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfDouble : GalaSoft.MvvmLight.ObservableObject
    {
        private double? _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfInt64 : GalaSoft.MvvmLight.ObservableObject
    {
        private long? _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfAddress : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<Address> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Address> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfDynamicCustomer : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<DynamicCustomer> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DynamicCustomer> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DynamicCustomer : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private string _emailAddress;
        private string _contactPhone;
        private string _address;
        private string _key;
        private string _phoneNumber;
        private string _contactName;
        private string _contactEmail;
        private string _timeZone;
        private string _inviteCode;
        private string _salesGroup;
        private string _warehouseNo;

        [Newtonsoft.Json.JsonProperty("SalesGroup", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesGroup
        {
            get { return _salesGroup; }
            set
            {
                if (_salesGroup != value)
                {
                    _salesGroup = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("WarehouseNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WarehouseNo
        {
            get { return _warehouseNo; }
            set
            {
                if (_warehouseNo != value)
                {
                    _warehouseNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("EmailAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ContactPhone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactPhone
        {
            get { return _contactPhone; }
            set
            {
                if (_contactPhone != value)
                {
                    _contactPhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ContactName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                if (_contactName != value)
                {
                    _contactName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ContactEmail", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactEmail
        {
            get { return _contactEmail; }
            set
            {
                if (_contactEmail != value)
                {
                    _contactEmail = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("TimeZone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeZone
        {
            get { return _timeZone; }
            set
            {
                if (_timeZone != value)
                {
                    _timeZone = value;
                    RaisePropertyChanged();
                }
            }
        }



        [Newtonsoft.Json.JsonProperty("InviteCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InviteCode
        {
            get { return _inviteCode; }
            set
            {
                if (_inviteCode != value)
                {
                    _inviteCode = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class GetCustomersSearchContext : GalaSoft.MvvmLight.ObservableObject
    {
        private string _aXCustomerId;
        private string _branchCode;
        private string _salesRepTag;
        private string _customerName;
        private int? _pageSize;
        private int? _startPage;
        private string _sortBy;
        private bool? _isDescendingSort;

        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchCode
        {
            get { return _branchCode; }
            set
            {
                if (_branchCode != value)
                {
                    _branchCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesRepTag", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesRepTag
        {
            get { return _salesRepTag; }
            set
            {
                if (_salesRepTag != value)
                {
                    _salesRepTag = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PageSize", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageSize
        {
            get { return _pageSize; }
            set
            {
                if (_pageSize != value)
                {
                    _pageSize = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("StartPage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StartPage
        {
            get { return _startPage; }
            set
            {
                if (_startPage != value)
                {
                    _startPage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The column name to sort by. You can sort by all property names in the {Trulite.CustomerPortal.Common.Models.DynamicCustomer} object.</summary>
        [Newtonsoft.Json.JsonProperty("SortBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy
        {
            get { return _sortBy; }
            set
            {
                if (_sortBy != value)
                {
                    _sortBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the sorting should be done in descending order. The default is false (ascending order).</summary>
        [Newtonsoft.Json.JsonProperty("IsDescendingSort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDescendingSort
        {
            get { return _isDescendingSort; }
            set
            {
                if (_isDescendingSort != value)
                {
                    _isDescendingSort = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfCustomerContact : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContact _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContact Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerContact : GalaSoft.MvvmLight.ObservableObject
    {
        private string _salesPersonName;
        private string _salesPersonEmail;
        private string _salesPersonPhone;
        private string _branchPhone;
        private string _branchAddress;
        private string _branchFax;
        private string _creditRepEmail;
        private string _creditRepName;
        private string _creditRepPhone;
        private string _key;

        [Newtonsoft.Json.JsonProperty("SalesPersonName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonName
        {
            get { return _salesPersonName; }
            set
            {
                if (_salesPersonName != value)
                {
                    _salesPersonName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesPersonEmail", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonEmail
        {
            get { return _salesPersonEmail; }
            set
            {
                if (_salesPersonEmail != value)
                {
                    _salesPersonEmail = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesPersonPhone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPersonPhone
        {
            get { return _salesPersonPhone; }
            set
            {
                if (_salesPersonPhone != value)
                {
                    _salesPersonPhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchPhone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchPhone
        {
            get { return _branchPhone; }
            set
            {
                if (_branchPhone != value)
                {
                    _branchPhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchAddress
        {
            get { return _branchAddress; }
            set
            {
                if (_branchAddress != value)
                {
                    _branchAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchFax", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchFax
        {
            get { return _branchFax; }
            set
            {
                if (_branchFax != value)
                {
                    _branchFax = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreditRepEmail", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditRepEmail
        {
            get { return _creditRepEmail; }
            set
            {
                if (_creditRepEmail != value)
                {
                    _creditRepEmail = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreditRepName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditRepName
        {
            get { return _creditRepName; }
            set
            {
                if (_creditRepName != value)
                {
                    _creditRepName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreditRepPhone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditRepPhone
        {
            get { return _creditRepPhone; }
            set
            {
                if (_creditRepPhone != value)
                {
                    _creditRepPhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfDynamicCustomer : GalaSoft.MvvmLight.ObservableObject
    {
        private DynamicCustomer _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DynamicCustomer Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfInventSite : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<InventSite> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InventSite> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class InventSite : GalaSoft.MvvmLight.ObservableObject
    {
        private string _description;
        private string _key;

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerStatementQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class EdgeworkItemContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _thicknessId;
        private string _inventLocationId;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ThicknessId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThicknessId
        {
            get { return _thicknessId; }
            set
            {
                if (_thicknessId != value)
                {
                    _thicknessId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfEdgeworkItem : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<EdgeworkItem> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<EdgeworkItem> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class EdgeworkItem : GalaSoft.MvvmLight.ObservableObject
    {
        private string _description;
        private string _key;

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfRackTracking : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<RackTracking> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RackTracking> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class RackTracking : GalaSoft.MvvmLight.ObservableObject
    {
        private string _rackType;
        private string _customerAccount;
        private string _deliveryAddress;
        private System.DateTimeOffset? _checkoutDate;
        private string _salesId;
        private string _customerPO;
        private string _key;

        [Newtonsoft.Json.JsonProperty("RackType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RackType
        {
            get { return _rackType; }
            set
            {
                if (_rackType != value)
                {
                    _rackType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerAccount
        {
            get { return _customerAccount; }
            set
            {
                if (_customerAccount != value)
                {
                    _customerAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DeliveryAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set
            {
                if (_deliveryAddress != value)
                {
                    _deliveryAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CheckoutDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CheckoutDate
        {
            get { return _checkoutDate; }
            set
            {
                if (_checkoutDate != value)
                {
                    _checkoutDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesId
        {
            get { return _salesId; }
            set
            {
                if (_salesId != value)
                {
                    _salesId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerPO", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPO
        {
            get { return _customerPO; }
            set
            {
                if (_customerPO != value)
                {
                    _customerPO = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ShipManifestHeadersQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private string _inventLocationId;
        private string _salesPoolId;
        private System.DateTimeOffset? _shippingDate;
        private string _driver;

        [Newtonsoft.Json.JsonProperty("InventLocationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InventLocationId
        {
            get { return _inventLocationId; }
            set
            {
                if (_inventLocationId != value)
                {
                    _inventLocationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SalesPoolId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPoolId
        {
            get { return _salesPoolId; }
            set
            {
                if (_salesPoolId != value)
                {
                    _salesPoolId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippingDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ShippingDate
        {
            get { return _shippingDate; }
            set
            {
                if (_shippingDate != value)
                {
                    _shippingDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Driver", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Driver
        {
            get { return _driver; }
            set
            {
                if (_driver != value)
                {
                    _driver = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfShipManifestHeader : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ShipManifestHeader> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipManifestHeader> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ShipManifestHeader : GalaSoft.MvvmLight.ObservableObject
    {
        private string _salesPoolId;
        private string _status;
        private DateTimeOffset _shippingDate;
        private string _driverName;
        private string _key;

        [Newtonsoft.Json.JsonProperty("SalesPoolId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesPoolId
        {
            get { return _salesPoolId; }
            set
            {
                if (_salesPoolId != value)
                {
                    _salesPoolId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShippingDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTimeOffset ShippingDate
        {
            get { return _shippingDate; }
            set
            {
                if (_shippingDate != value)
                {
                    _shippingDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DriverName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DriverName
        {
            get { return _driverName; }
            set
            {
                if (_driverName != value)
                {
                    _driverName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfShipManifestDetail : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<ShipManifestDetail> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipManifestDetail> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ShipManifestDetail : GalaSoft.MvvmLight.ObservableObject
    {
        private string _deliveryDate;
        private string _custAccount;
        private string _custName;
        private string _zipCode;
        private string _country;
        private string _state;
        private string _county;
        private string _city;
        private string _street;
        private string _status;
        private string _packingSlipId;
        private string _salesOrderId;
        private string _safetyIndicator;
        private string _stopNumber;
        private string _recId;
        private string _branch;
        private System.DateTimeOffset? _clockInDateTime;
        private System.DateTimeOffset? _clockOutDateTime;
        private string _custPurchaseOrder;
        private string _key;

        /// <summary>Delivery date.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryDate
        {
            get { return _deliveryDate; }
            set
            {
                if (_deliveryDate != value)
                {
                    _deliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer account.</summary>
        [Newtonsoft.Json.JsonProperty("CustAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                if (_custAccount != value)
                {
                    _custAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer name.</summary>
        [Newtonsoft.Json.JsonProperty("CustName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustName
        {
            get { return _custName; }
            set
            {
                if (_custName != value)
                {
                    _custName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Zip code.</summary>
        [Newtonsoft.Json.JsonProperty("ZipCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Country.</summary>
        [Newtonsoft.Json.JsonProperty("Country", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>State</summary>
        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>County.</summary>
        [Newtonsoft.Json.JsonProperty("County", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string County
        {
            get { return _county; }
            set
            {
                if (_county != value)
                {
                    _county = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>City.</summary>
        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Street.</summary>
        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status.</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipId
        {
            get { return _packingSlipId; }
            set
            {
                if (_packingSlipId != value)
                {
                    _packingSlipId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Safety indicator.</summary>
        [Newtonsoft.Json.JsonProperty("SafetyIndicator", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SafetyIndicator
        {
            get { return _safetyIndicator; }
            set
            {
                if (_safetyIndicator != value)
                {
                    _safetyIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Stop Number.</summary>
        [Newtonsoft.Json.JsonProperty("StopNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopNumber
        {
            get { return _stopNumber; }
            set
            {
                if (_stopNumber != value)
                {
                    _stopNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Rec Id</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch W Number.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time the driver clocked in.</summary>
        [Newtonsoft.Json.JsonProperty("ClockInDateTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClockInDateTime
        {
            get { return _clockInDateTime; }
            set
            {
                if (_clockInDateTime != value)
                {
                    _clockInDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time the driver clocked out.</summary>
        [Newtonsoft.Json.JsonProperty("ClockOutDateTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClockOutDateTime
        {
            get { return _clockOutDateTime; }
            set
            {
                if (_clockOutDateTime != value)
                {
                    _clockOutDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer Purchase Order No</summary>
        [Newtonsoft.Json.JsonProperty("CustPurchaseOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustPurchaseOrder
        {
            get { return _custPurchaseOrder; }
            set
            {
                if (_custPurchaseOrder != value)
                {
                    _custPurchaseOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustomerBranchView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<CustomerBranchView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerBranchView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    /// <summary>Represents a customer's branch with its list of business units and support tickets.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerBranchView : GalaSoft.MvvmLight.ObservableObject
    {
        private string _branch;
        private System.Guid? _branchId;
        private System.Guid? _customerBranchId;
        private System.Collections.Generic.ICollection<BuisnessUnitView> _buisnessUnits;




        private string _branchCode;

        public string BranchCode
        {
            get { return _branchCode; }
            set
            {
                _branchCode = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>Branch name.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch ID.</summary>
        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer's Branch ID. This is different than {Trulite.CustomerPortal.Common.Models.Views.CustomerBranchView.BranchId}.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerBranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerBranchId
        {
            get { return _customerBranchId; }
            set
            {
                if (_customerBranchId != value)
                {
                    _customerBranchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch business units.</summary>
        [Newtonsoft.Json.JsonProperty("BuisnessUnits", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BuisnessUnitView> BuisnessUnits
        {
            get { return _buisnessUnits; }
            set
            {
                if (_buisnessUnits != value)
                {
                    _buisnessUnits = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BuisnessUnitView : GalaSoft.MvvmLight.ObservableObject
    {
        private string _businessUnitDisplay;
        private string _businessUnit;
        private bool? _default;

        [Newtonsoft.Json.JsonProperty("BusinessUnitDisplay", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUnitDisplay
        {
            get { return _businessUnitDisplay; }
            set
            {
                if (_businessUnitDisplay != value)
                {
                    _businessUnitDisplay = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BusinessUnit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUnit
        {
            get { return _businessUnit; }
            set
            {
                if (_businessUnit != value)
                {
                    _businessUnit = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Default", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Default
        {
            get { return _default; }
            set
            {
                if (_default != value)
                {
                    _default = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchTicketsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.Guid? _customerBranchId;
        private string _businessUnit;
        private string _viewName;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer branch ID. This is not the same as branch ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerBranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerBranchId
        {
            get { return _customerBranchId; }
            set
            {
                if (_customerBranchId != value)
                {
                    _customerBranchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Business unit.</summary>
        [Newtonsoft.Json.JsonProperty("BusinessUnit", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BusinessUnit
        {
            get { return _businessUnit; }
            set
            {
                if (_businessUnit != value)
                {
                    _businessUnit = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the view or type of the tickets to query.</summary>
        [Newtonsoft.Json.JsonProperty("ViewName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ViewName
        {
            get { return _viewName; }
            set
            {
                if (_viewName != value)
                {
                    _viewName = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfTruDeskItem : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<TruDeskItem> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TruDeskItem> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class TruDeskItem : GalaSoft.MvvmLight.ObservableObject
    {
        private string _statusId;
        private string _id;
        private string _status;
        private string _subject;
        private string _priority;
        private bool? _isOverDue;
        private string _userTimeFormat;
        private string _contact;
        private System.DateTimeOffset? _updatedTime;
        private string _supportRep;

        /// <summary>Status ID.</summary>
        [Newtonsoft.Json.JsonProperty("StatusId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusId
        {
            get { return _statusId; }
            set
            {
                if (_statusId != value)
                {
                    _statusId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Ticket ID</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the ticket such as Open, Closed, Resolve etc..</summary>
        [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subject that appears in the ticket.</summary>
        [Newtonsoft.Json.JsonProperty("Subject", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subject
        {
            get { return _subject; }
            set
            {
                if (_subject != value)
                {
                    _subject = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Ticket priority.</summary>
        [Newtonsoft.Json.JsonProperty("Priority", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Priority
        {
            get { return _priority; }
            set
            {
                if (_priority != value)
                {
                    _priority = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the ticket is overdue.</summary>
        [Newtonsoft.Json.JsonProperty("IsOverDue", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsOverDue
        {
            get { return _isOverDue; }
            set
            {
                if (_isOverDue != value)
                {
                    _isOverDue = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time format of the user. For example, the value can be "MMM d, yyyy hh:mm a".</summary>
        [Newtonsoft.Json.JsonProperty("UserTimeFormat", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserTimeFormat
        {
            get { return _userTimeFormat; }
            set
            {
                if (_userTimeFormat != value)
                {
                    _userTimeFormat = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Person to contact for this ticket.</summary>
        [Newtonsoft.Json.JsonProperty("Contact", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Contact
        {
            get { return _contact; }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the ticket was updated.</summary>
        [Newtonsoft.Json.JsonProperty("UpdatedTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedTime
        {
            get { return _updatedTime; }
            set
            {
                if (_updatedTime != value)
                {
                    _updatedTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Support representative.</summary>
        [Newtonsoft.Json.JsonProperty("SupportRep", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupportRep
        {
            get { return _supportRep; }
            set
            {
                if (_supportRep != value)
                {
                    _supportRep = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfDocumentUploadView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<DocumentUploadView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DocumentUploadView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DocumentUploadView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _id;
        private string _createdBy;
        private System.DateTimeOffset? _dateCreated;
        private string _name;
        private string _originalName;
        private bool? _hasCustomer;


        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CreatedBy", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                if (_createdBy != value)
                {
                    _createdBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("OriginalName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalName
        {
            get { return _originalName; }
            set
            {
                if (_originalName != value)
                {
                    _originalName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("HasCustomer", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasCustomer
        {
            get { return _hasCustomer; }
            set
            {
                if (_hasCustomer != value)
                {
                    _hasCustomer = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DocumentDownloadQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.Guid? _documentId;

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DocumentId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? DocumentId
        {
            get { return _documentId; }
            set
            {
                if (_documentId != value)
                {
                    _documentId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfMyInfoViewModel : GalaSoft.MvvmLight.ObservableObject
    {
        private MyInfoViewModel _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MyInfoViewModel Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MyInfoViewModel : GalaSoft.MvvmLight.ObservableObject
    {
        private LoggedUserInfo _currentUser;
        private DynamicCustomer _customerInfo;
        private LoggedUserInfo _impersonatedBy;
        private AppUserPreferencesViewModel _appPreferences;
        private System.Collections.Generic.ICollection<CustomerConfirmInformation> _customerConfirms;
        private bool? _canEditCustomerConfirms;

        [Newtonsoft.Json.JsonProperty("CurrentUser", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LoggedUserInfo CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (_currentUser != value)
                {
                    _currentUser = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DynamicCustomer CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ImpersonatedBy", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LoggedUserInfo ImpersonatedBy
        {
            get { return _impersonatedBy; }
            set
            {
                if (_impersonatedBy != value)
                {
                    _impersonatedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppPreferences", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUserPreferencesViewModel AppPreferences
        {
            get { return _appPreferences; }
            set
            {
                if (_appPreferences != value)
                {
                    _appPreferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerConfirms", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerConfirmInformation> CustomerConfirms
        {
            get { return _customerConfirms; }
            set
            {
                if (_customerConfirms != value)
                {
                    _customerConfirms = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CanEditCustomerConfirms", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CanEditCustomerConfirms
        {
            get { return _canEditCustomerConfirms; }
            set
            {
                if (_canEditCustomerConfirms != value)
                {
                    _canEditCustomerConfirms = value;
                    RaisePropertyChanged();
                }
            }
        }







    }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class LoggedUserInfo : ObservableObject
    {
        private string _timeZone;
        private System.Guid? _appUserId;
        private string _firstName;
        private string _lastName;
        private string _accountStatusName;
        private string _loginId;
        private string _phoneNumber;
        private bool? _isPhoneNumberVerified;
        private bool? _isAutoVerifyPhoneOptedOut;
        private int? _invalidLoginTries;
        private bool? _isAdmin;
        private bool? _hasAgreedToTerms;
        private bool? _isActiveCustomerUserOwner;
        private System.Guid? _activeCustomerId;
        private string _activeAccountNo;
        private string _activeAccountName;
        private AppUserPreferencesViewModel _preferences;
        private System.Guid? _impersonatedBy;
        private string _fullName;
        private System.Guid? _ownerCustomerId;
        private System.Guid? _branchId;
        private string _userBranchCode;
        private string _siteBranchCode;
        private LoggedUserInfoRole? _role;
        private string _salesRepTag;
        private bool? _viewedSiteTutorial;
        private bool? _isSalesRep;
        private bool? _isDriver;
        private string _language;


        private bool _isTruliteUser;

        public bool IsTruliteUser
        {
            get { return _isTruliteUser; }
            set
            {
                _isTruliteUser = value;
                RaisePropertyChanged();
            }
        }



        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonProperty("TimeZone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeZone
        {
            get { return _timeZone; }
            set
            {
                if (_timeZone != value)
                {
                    _timeZone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>User ID.</summary>
        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Fist name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account status name.</summary>
        [Newtonsoft.Json.JsonProperty("AccountStatusName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountStatusName
        {
            get { return _accountStatusName; }
            set
            {
                if (_accountStatusName != value)
                {
                    _accountStatusName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Login ID.</summary>
        [Newtonsoft.Json.JsonProperty("LoginId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginId
        {
            get { return _loginId; }
            set
            {
                if (_loginId != value)
                {
                    _loginId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Phone Number.</summary>
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the phone number was verified.</summary>
        [Newtonsoft.Json.JsonProperty("IsPhoneNumberVerified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPhoneNumberVerified
        {
            get { return _isPhoneNumberVerified; }
            set
            {
                if (_isPhoneNumberVerified != value)
                {
                    _isPhoneNumberVerified = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user chose to not be automatically asked to verify his or her phone number.</summary>
        [Newtonsoft.Json.JsonProperty("IsAutoVerifyPhoneOptedOut", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAutoVerifyPhoneOptedOut
        {
            get { return _isAutoVerifyPhoneOptedOut; }
            set
            {
                if (_isAutoVerifyPhoneOptedOut != value)
                {
                    _isAutoVerifyPhoneOptedOut = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invalid login attempts.</summary>
        [Newtonsoft.Json.JsonProperty("InvalidLoginTries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InvalidLoginTries
        {
            get { return _invalidLoginTries; }
            set
            {
                if (_invalidLoginTries != value)
                {
                    _invalidLoginTries = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user is admin.</summary>
        [Newtonsoft.Json.JsonProperty("IsAdmin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user agreed the application terms.</summary>
        [Newtonsoft.Json.JsonProperty("HasAgreedToTerms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasAgreedToTerms
        {
            get { return _hasAgreedToTerms; }
            set
            {
                if (_hasAgreedToTerms != value)
                {
                    _hasAgreedToTerms = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsActiveCustomerUserOwner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsActiveCustomerUserOwner
        {
            get { return _isActiveCustomerUserOwner; }
            set
            {
                if (_isActiveCustomerUserOwner != value)
                {
                    _isActiveCustomerUserOwner = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Active customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("ActiveCustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? ActiveCustomerId
        {
            get { return _activeCustomerId; }
            set
            {
                if (_activeCustomerId != value)
                {
                    _activeCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Active Account NO</summary>
        [Newtonsoft.Json.JsonProperty("ActiveAccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActiveAccountNo
        {
            get { return _activeAccountNo; }
            set
            {
                if (_activeAccountNo != value)
                {
                    _activeAccountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Active Account Name</summary>
        [Newtonsoft.Json.JsonProperty("ActiveAccountName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActiveAccountName
        {
            get { return _activeAccountName; }
            set
            {
                if (_activeAccountName != value)
                {
                    _activeAccountName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Preferences.</summary>
        [Newtonsoft.Json.JsonProperty("Preferences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUserPreferencesViewModel Preferences
        {
            get { return _preferences; }
            set
            {
                if (_preferences != value)
                {
                    _preferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The user ID of the user who impersonated this user account.</summary>
        [Newtonsoft.Json.JsonProperty("ImpersonatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? ImpersonatedBy
        {
            get { return _impersonatedBy; }
            set
            {
                if (_impersonatedBy != value)
                {
                    _impersonatedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Owner customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("OwnerCustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? OwnerCustomerId
        {
            get { return _ownerCustomerId; }
            set
            {
                if (_ownerCustomerId != value)
                {
                    _ownerCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch ID.</summary>
        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch code.</summary>
        [Newtonsoft.Json.JsonProperty("UserBranchCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserBranchCode
        {
            get { return _userBranchCode; }
            set
            {
                if (_userBranchCode != value)
                {
                    _userBranchCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SiteBranchCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SiteBranchCode
        {
            get { return _siteBranchCode; }
            set
            {
                if (_siteBranchCode != value)
                {
                    _siteBranchCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Role.</summary>
        [Newtonsoft.Json.JsonProperty("Role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LoggedUserInfoRole? Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales representative tag.</summary>
        [Newtonsoft.Json.JsonProperty("SalesRepTag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesRepTag
        {
            get { return _salesRepTag; }
            set
            {
                if (_salesRepTag != value)
                {
                    _salesRepTag = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user should see the site tutorial.</summary>
        [Newtonsoft.Json.JsonProperty("ViewedSiteTutorial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ViewedSiteTutorial
        {
            get { return _viewedSiteTutorial; }
            set
            {
                if (_viewedSiteTutorial != value)
                {
                    _viewedSiteTutorial = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsSalesRep", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsSalesRep
        {
            get { return _isSalesRep; }
            set
            {
                if (_isSalesRep != value)
                {
                    _isSalesRep = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsDriver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDriver
        {
            get { return _isDriver; }
            set
            {
                if (_isDriver != value)
                {
                    _isDriver = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language
        {
            get { return _language; }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    RaisePropertyChanged();
                }
            }
        }




    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.2.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class RequestOrderDateChangeViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        private SalesOrder _salesOrder;
        private System.DateTimeOffset? _newDeliveryDate;
        private string _customerAccountNumber;
        private string _fullName;
        private string _branchCode;
        private string _comments;

        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesOrder SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("NewDeliveryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? NewDeliveryDate
        {
            get { return _newDeliveryDate; }
            set
            {
                if (_newDeliveryDate != value)
                {
                    _newDeliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerAccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerAccountNumber
        {
            get { return _customerAccountNumber; }
            set
            {
                if (_customerAccountNumber != value)
                {
                    _customerAccountNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BranchCode
        {
            get { return _branchCode; }
            set
            {
                if (_branchCode != value)
                {
                    _branchCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comments
        {
            get { return _comments; }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    RaisePropertyChanged();
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserPreferencesViewModel : GalaSoft.MvvmLight.ObservableObject
    {
        private bool? _isDarkTheme;
        private bool? _collapseAccount;
        private bool? _collapseActiveAccount;
        private bool? _isTraceEnabled;
        private string _theme;
        private bool? _isFixed;
        private int? _siteTimeout;
        private bool? _isCollapsed;
        private bool? _showOrdersDaily;
        private bool? _showOrdersMonthly;
        private bool? _showOrdersYearly;
        private int? _dashboardRefreshInSeconds;
        private bool? _showInvoicesQuarterly;
        private bool? _showInvoicesMonthly;
        private bool? _showInvoicesDaily;
        private bool? _showReturnsMonthly;
        private bool? _showSalesOrdersSummaryByStatus;
        private bool? _singleAccountView;
        private bool? _showBadges;
        private int? _countVisibleCharts;

        private bool _showCustomerCreditLimits;

        public bool ShowCustomerCreditLimits
        {
            get { return _showCustomerCreditLimits; }
            set
            {
                _showCustomerCreditLimits = value;
                RaisePropertyChanged();
            }
        }

        [Newtonsoft.Json.JsonProperty("IsDarkTheme", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDarkTheme
        {
            get { return _isDarkTheme; }
            set
            {
                if (_isDarkTheme != value)
                {
                    _isDarkTheme = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CollapseAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CollapseAccount
        {
            get { return _collapseAccount; }
            set
            {
                if (_collapseAccount != value)
                {
                    _collapseAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CollapseActiveAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CollapseActiveAccount
        {
            get { return _collapseActiveAccount; }
            set
            {
                if (_collapseActiveAccount != value)
                {
                    _collapseActiveAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsTraceEnabled", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsTraceEnabled
        {
            get { return _isTraceEnabled; }
            set
            {
                if (_isTraceEnabled != value)
                {
                    _isTraceEnabled = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Theme", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Theme
        {
            get { return _theme; }
            set
            {
                if (_theme != value)
                {
                    _theme = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsFixed", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFixed
        {
            get { return _isFixed; }
            set
            {
                if (_isFixed != value)
                {
                    _isFixed = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SiteTimeout", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SiteTimeout
        {
            get { return _siteTimeout; }
            set
            {
                if (_siteTimeout != value)
                {
                    _siteTimeout = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsCollapsed", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsCollapsed
        {
            get { return _isCollapsed; }
            set
            {
                if (_isCollapsed != value)
                {
                    _isCollapsed = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowOrdersDaily", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowOrdersDaily
        {
            get { return _showOrdersDaily; }
            set
            {
                if (_showOrdersDaily != value)
                {
                    _showOrdersDaily = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowOrdersMonthly", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowOrdersMonthly
        {
            get { return _showOrdersMonthly; }
            set
            {
                if (_showOrdersMonthly != value)
                {
                    _showOrdersMonthly = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowOrdersYearly", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowOrdersYearly
        {
            get { return _showOrdersYearly; }
            set
            {
                if (_showOrdersYearly != value)
                {
                    _showOrdersYearly = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DashboardRefreshInSeconds", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DashboardRefreshInSeconds
        {
            get { return _dashboardRefreshInSeconds; }
            set
            {
                if (_dashboardRefreshInSeconds != value)
                {
                    _dashboardRefreshInSeconds = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowInvoicesQuarterly", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowInvoicesQuarterly
        {
            get { return _showInvoicesQuarterly; }
            set
            {
                if (_showInvoicesQuarterly != value)
                {
                    _showInvoicesQuarterly = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowInvoicesMonthly", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowInvoicesMonthly
        {
            get { return _showInvoicesMonthly; }
            set
            {
                if (_showInvoicesMonthly != value)
                {
                    _showInvoicesMonthly = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowInvoicesDaily", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowInvoicesDaily
        {
            get { return _showInvoicesDaily; }
            set
            {
                if (_showInvoicesDaily != value)
                {
                    _showInvoicesDaily = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowReturnsMonthly", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowReturnsMonthly
        {
            get { return _showReturnsMonthly; }
            set
            {
                if (_showReturnsMonthly != value)
                {
                    _showReturnsMonthly = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowSalesOrdersSummaryByStatus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowSalesOrdersSummaryByStatus
        {
            get { return _showSalesOrdersSummaryByStatus; }
            set
            {
                if (_showSalesOrdersSummaryByStatus != value)
                {
                    _showSalesOrdersSummaryByStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SingleAccountView", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SingleAccountView
        {
            get { return _singleAccountView; }
            set
            {
                if (_singleAccountView != value)
                {
                    _singleAccountView = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ShowBadges", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowBadges
        {
            get { return _showBadges; }
            set
            {
                if (_showBadges != value)
                {
                    _showBadges = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CountVisibleCharts", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CountVisibleCharts
        {
            get { return _countVisibleCharts; }
            set
            {
                if (_countVisibleCharts != value)
                {
                    _countVisibleCharts = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesOrderCurrency
    {
        [System.Runtime.Serialization.EnumMember(Value = @"USD")]
        USD = 0,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesOrderStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesOrderDeliveryMethod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Pickup")]
        Pickup = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Arch")]
        Arch = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UPS")]
        UPS = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum InvoiceStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Paid")]
        Paid = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NotPaid")]
        NotPaid = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Void")]
        Void = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum BranchCoatingInternalType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Opacicoat")]
        Opacicoat = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Frit")]
        Frit = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum QuotationsQueryContextStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Sent")]
        Sent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Created")]
        Created = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Confirmed")]
        Confirmed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Lost")]
        Lost = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum QuotationStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Sent")]
        Sent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Created")]
        Created = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Confirmed")]
        Confirmed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Lost")]
        Lost = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesInquiryContextLeadTime
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Month1")]
        Month1 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Month3")]
        Month3 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Month6")]
        Month6 = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Month9")]
        Month9 = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Month12")]
        Month12 = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Month24")]
        Month24 = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"MonthMax")]
        MonthMax = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"FailedParsing")]
        FailedParsing = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesInquiryContextFilter
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Created")]
        Created = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Sent")]
        Sent = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Confirmed")]
        Confirmed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Lost")]
        Lost = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancelled")]
        Cancelled = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"All")]
        All = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"FailedParsing")]
        FailedParsing = 7,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum QuotationUpdateQueryContextLeadTime
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Month1")]
        Month1 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Month3")]
        Month3 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Month6")]
        Month6 = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Month9")]
        Month9 = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Month12")]
        Month12 = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Month24")]
        Month24 = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"MonthMax")]
        MonthMax = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"FailedParsing")]
        FailedParsing = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesOrderSummaryQueryContextSummaryPeriod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Day")]
        Day = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Week")]
        Week = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Month")]
        Month = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Quarter")]
        Quarter = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Year")]
        Year = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum InvoicesQueryContextStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Paid")]
        Paid = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NotPaid")]
        NotPaid = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Void")]
        Void = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SalesOrderQueryContextStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum ReturnOrderQueryContextStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum ReturnOrderStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum ReturnOrderLineStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"BackOrder")]
        BackOrder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Delivered")]
        Delivered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoiced")]
        Invoiced = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum CustomerConfirmInformationType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Unknown")]
        Unknown = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ASN")]
        ASN = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Conf")]
        Conf = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Quote")]
        Quote = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Invoice")]
        Invoice = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum LoggedUserInfoRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Viewer")]
        Plant_Viewer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Admin")]
        Plant_Admin = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sales_Rep")]
        Sales_Rep = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag",
        "13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>
        > Headers
        { get; private set; }

        public SwaggerException(string message, int statusCode, string response,
            System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>>
                headers, System.Exception innerException)
            : base(
                message + "\n\nStatus: " + statusCode + "\nResponse: \n" +
                response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag",
        "13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response,
            System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>>
                headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerNotificationsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.DateTimeOffset? _fromDate;
        private System.DateTimeOffset? _toDate;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Start of the date range to query.</summary>
        [Newtonsoft.Json.JsonProperty("FromDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    _fromDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>End of the date range to query.</summary>
        [Newtonsoft.Json.JsonProperty("ToDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    _toDate = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustomerNotification : GalaSoft.MvvmLight.ObservableObject
    {
        private string _customerId;
        private System.DateTimeOffset? _dateTime;
        private string _notificationType;
        private string _notification;
        private string _refRecId;
        private bool? _isRead;
        private bool? _isSent;
        private string _key;

        /// <summary>Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date of the notification.</summary>
        [Newtonsoft.Json.JsonProperty("DateTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateTime
        {
            get { return _dateTime; }
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Type of the notification.</summary>
        [Newtonsoft.Json.JsonProperty("NotificationType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NotificationType
        {
            get { return _notificationType; }
            set
            {
                if (_notificationType != value)
                {
                    _notificationType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Content.</summary>
        [Newtonsoft.Json.JsonProperty("Notification", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notification
        {
            get { return _notification; }
            set
            {
                if (_notification != value)
                {
                    _notification = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Referenced recod ID.</summary>
        [Newtonsoft.Json.JsonProperty("RefRecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefRecId
        {
            get { return _refRecId; }
            set
            {
                if (_refRecId != value)
                {
                    _refRecId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsRead", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsRead
        {
            get { return _isRead; }
            set
            {
                if (_isRead != value)
                {
                    _isRead = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IsSent", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsSent
        {
            get { return _isSent; }
            set
            {
                if (_isSent != value)
                {
                    _isSent = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustomerNotification : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<CustomerNotification> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustomerNotification> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfBranchView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<BranchView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BranchView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class BranchView : GalaSoft.MvvmLight.ObservableObject
    {
        private string _code;
        private string _description;
        private System.Guid? _branchId;

        /// <summary>Branch name.</summary>
        [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch ID.</summary>
        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }


        public string DisplayText
        {
            get
            {
                return $"{Code} - {Description}";
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CreateCustNotificationDeviceContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private System.DateTimeOffset? _timeStamp;
        private string _device;
        private string _userName;
        private string _pnsHandle;
        private string _registrationId;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time stamp of this record.</summary>
        [Newtonsoft.Json.JsonProperty("TimeStamp", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TimeStamp
        {
            get { return _timeStamp; }
            set
            {
                if (_timeStamp != value)
                {
                    _timeStamp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Device name.</summary>
        [Newtonsoft.Json.JsonProperty("Device", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Device
        {
            get { return _device; }
            set
            {
                if (_device != value)
                {
                    _device = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Username.</summary>
        [Newtonsoft.Json.JsonProperty("UserName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Pns Handle</summary>
        [Newtonsoft.Json.JsonProperty("PnsHandle", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PnsHandle
        {
            get { return _pnsHandle; }
            set
            {
                if (_pnsHandle != value)
                {
                    _pnsHandle = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Registration Id</summary>
        [Newtonsoft.Json.JsonProperty("RegistrationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegistrationId
        {
            get { return _registrationId; }
            set
            {
                if (_registrationId != value)
                {
                    _registrationId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class UpdateDeleteCustNotificationDeviceContext : GalaSoft.MvvmLight.ObservableObject
    {
        private System.DateTimeOffset? _timeStamp;
        private long? _recId;
        private string _pnsHandle;
        private string _registrationId;

        /// <summary>Time stamp of this record.</summary>
        [Newtonsoft.Json.JsonProperty("TimeStamp", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TimeStamp
        {
            get { return _timeStamp; }
            set
            {
                if (_timeStamp != value)
                {
                    _timeStamp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>ID of this record.</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Pns Handle</summary>
        [Newtonsoft.Json.JsonProperty("PnsHandle", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PnsHandle
        {
            get { return _pnsHandle; }
            set
            {
                if (_pnsHandle != value)
                {
                    _pnsHandle = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Registration Id</summary>
        [Newtonsoft.Json.JsonProperty("RegistrationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegistrationId
        {
            get { return _registrationId; }
            set
            {
                if (_registrationId != value)
                {
                    _registrationId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCustNotificationDevice : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<CustNotificationDevice> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CustNotificationDevice> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CustNotificationDevice : GalaSoft.MvvmLight.ObservableObject
    {
        private string _custAccount;
        private string _userName;
        private string _deviceId;
        private System.DateTimeOffset? _lastTimeStamp;
        private long? _recId;

        /// <summary>Customer account.</summary>
        [Newtonsoft.Json.JsonProperty("CustAccount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                if (_custAccount != value)
                {
                    _custAccount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Username.</summary>
        [Newtonsoft.Json.JsonProperty("UserName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Device ID.</summary>
        [Newtonsoft.Json.JsonProperty("DeviceId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeviceId
        {
            get { return _deviceId; }
            set
            {
                if (_deviceId != value)
                {
                    _deviceId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last time stamp of this record.</summary>
        [Newtonsoft.Json.JsonProperty("LastTimeStamp", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastTimeStamp
        {
            get { return _lastTimeStamp; }
            set
            {
                if (_lastTimeStamp != value)
                {
                    _lastTimeStamp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>ID of this record.</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ReportIssueQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _note;
        private string _imageBase64;
        private string _salesOrderId;
        private string _packingSlipId;
        private string _branch;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Note/Comments describing the issue.</summary>
        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Base64 encoded image.</summary>
        [Newtonsoft.Json.JsonProperty("ImageBase64", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageBase64
        {
            get { return _imageBase64; }
            set
            {
                if (_imageBase64 != value)
                {
                    _imageBase64 = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales Order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing Slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipId
        {
            get { return _packingSlipId; }
            set
            {
                if (_packingSlipId != value)
                {
                    _packingSlipId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch Code.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum AppUsersQueryContextRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Viewer")]
        Plant_Viewer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Admin")]
        Plant_Admin = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sales_Rep")]
        Sales_Rep = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 4,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PortalSettingsQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum PortalSettingType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"String")]
        String = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Number")]
        Number = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Date")]
        Date = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Decimal")]
        Decimal = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Email")]
        Email = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"MultipleEmail")]
        MultipleEmail = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Boolean")]
        Boolean = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PortalSetting : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _portalSettingId;
        private string _name;
        private string _description;
        private string _value;
        private PortalSettingType? _type;

        /// <summary>ID of the setting.</summary>
        [Newtonsoft.Json.JsonProperty("PortalSettingId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? PortalSettingId
        {
            get { return _portalSettingId; }
            set
            {
                if (_portalSettingId != value)
                {
                    _portalSettingId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Desciption.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Setting value.</summary>
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Type.</summary>
        [Newtonsoft.Json.JsonProperty("Type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PortalSettingType? Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfKeyNameModelOfGuid : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<KeyNameModelOfGuid> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyNameModelOfGuid> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class KeyNameModelOfGuid : GalaSoft.MvvmLight.ObservableObject
    {
        private string _name;
        private System.Guid? _key;

        /// <summary>Name of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Key of this object.</summary>
        [Newtonsoft.Json.JsonProperty("Key", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfAppPermissionView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<AppPermissionView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppPermissionView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppPermissionView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _appPermissionId;
        private string _name;
        private string _description;
        private bool? _active;

        /// <summary>Permissions ID.</summary>
        [Newtonsoft.Json.JsonProperty("AppPermissionId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppPermissionId
        {
            get { return _appPermissionId; }
            set
            {
                if (_appPermissionId != value)
                {
                    _appPermissionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the permissions is active / included.</summary>
        [Newtonsoft.Json.JsonProperty("Active", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUsersQueryContext : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _id;
        private string _firstName;
        private string _lastName;
        private string _loginId;
        private System.Guid? _accountStatusId;
        private System.Guid? _customerId;
        private string _aXCustomerId;
        private bool? _excludeDrivers;
        private AppUsersQueryContextRole? _role;

        /// <summary>ID of the user to query.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>First name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Login ID / username.</summary>
        [Newtonsoft.Json.JsonProperty("LoginId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginId
        {
            get { return _loginId; }
            set
            {
                if (_loginId != value)
                {
                    _loginId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account status ID.</summary>
        [Newtonsoft.Json.JsonProperty("AccountStatusId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AccountStatusId
        {
            get { return _accountStatusId; }
            set
            {
                if (_accountStatusId != value)
                {
                    _accountStatusId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The customer ID in Microsoft Dynamics NAV.</summary>
        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether to exclude drivers from the query.</summary>
        [Newtonsoft.Json.JsonProperty("ExcludeDrivers", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ExcludeDrivers
        {
            get { return _excludeDrivers; }
            set
            {
                if (_excludeDrivers != value)
                {
                    _excludeDrivers = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Role of this user.</summary>
        [Newtonsoft.Json.JsonProperty("Role", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AppUsersQueryContextRole? Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfAppUserView : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<AppUserView> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppUserView> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppUserView : GalaSoft.MvvmLight.ObservableObject
    {
        private string _firstName;
        private string _lastName;
        private KeyNameModelOfGuid _accountStatus;
        private System.DateTimeOffset? _dateCreated;
        private string _loginId;
        private System.Guid? _appUserId;
        private bool? _isAdmin;
        private bool? _showSiteTutorial;
        private AppUserViewRole? _role;
        private string _aXCustomerId;
        private string _salesRepTag;
        private KeyNameModelOfGuid _timeZone;
        private BranchView _branch;
        private System.Collections.Generic.ICollection<AppPermissionView> _permissions;


        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged();
            }
        }

        private string _language;

        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>First name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account status.</summary>
        [Newtonsoft.Json.JsonProperty("AccountStatus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeyNameModelOfGuid AccountStatus
        {
            get { return _accountStatus; }
            set
            {
                if (_accountStatus != value)
                {
                    _accountStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the record was created.</summary>
        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Login ID / username.</summary>
        [Newtonsoft.Json.JsonProperty("LoginId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginId
        {
            get { return _loginId; }
            set
            {
                if (_loginId != value)
                {
                    _loginId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>User ID.</summary>
        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user is an admin.</summary>
        [Newtonsoft.Json.JsonProperty("IsAdmin", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether to show the site tutorial.</summary>
        [Newtonsoft.Json.JsonProperty("ShowSiteTutorial", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowSiteTutorial
        {
            get { return _showSiteTutorial; }
            set
            {
                if (_showSiteTutorial != value)
                {
                    _showSiteTutorial = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Role of this user.</summary>
        [Newtonsoft.Json.JsonProperty("Role", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AppUserViewRole? Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The customer ID in Microsoft Dynamics NAV.</summary>
        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales representative tag.</summary>
        [Newtonsoft.Json.JsonProperty("SalesRepTag", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesRepTag
        {
            get { return _salesRepTag; }
            set
            {
                if (_salesRepTag != value)
                {
                    _salesRepTag = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time zone of this user.</summary>
        [Newtonsoft.Json.JsonProperty("TimeZone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeyNameModelOfGuid TimeZone
        {
            get { return _timeZone; }
            set
            {
                if (_timeZone != value)
                {
                    _timeZone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch / plant that this user belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BranchView Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Permissions of this user.</summary>
        [Newtonsoft.Json.JsonProperty("Permissions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppPermissionView> Permissions
        {
            get { return _permissions; }
            set
            {
                if (_permissions != value)
                {
                    _permissions = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfAppUserView : GalaSoft.MvvmLight.ObservableObject
    {
        private AppUserView _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppUserView Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AddAppUserView : GalaSoft.MvvmLight.ObservableObject
    {
        private string _password;
        private string _confirmPassword;
        private string _firstName;
        private string _lastName;
        private KeyNameModelOfGuid _accountStatus;
        private System.DateTimeOffset? _dateCreated;
        private string _loginId;
        private System.Guid? _appUserId;
        private bool? _isAdmin;
        private bool? _showSiteTutorial;
        private AddAppUserViewRole? _role;
        private string _aXCustomerId;
        private string _salesRepTag;
        private KeyNameModelOfGuid _timeZone;
        private BranchView _branch;
        private System.Collections.Generic.ICollection<AppPermissionView> _permissions;

        /// <summary>Password.</summary>
        [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Confirm password. Must match with the Password property.</summary>
        [Newtonsoft.Json.JsonProperty("ConfirmPassword", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                if (_confirmPassword != value)
                {
                    _confirmPassword = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>First name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Account status.</summary>
        [Newtonsoft.Json.JsonProperty("AccountStatus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeyNameModelOfGuid AccountStatus
        {
            get { return _accountStatus; }
            set
            {
                if (_accountStatus != value)
                {
                    _accountStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the record was created.</summary>
        [Newtonsoft.Json.JsonProperty("DateCreated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Login ID / username.</summary>
        [Newtonsoft.Json.JsonProperty("LoginId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoginId
        {
            get { return _loginId; }
            set
            {
                if (_loginId != value)
                {
                    _loginId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>User ID.</summary>
        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user is an admin.</summary>
        [Newtonsoft.Json.JsonProperty("IsAdmin", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether to show the site tutorial.</summary>
        [Newtonsoft.Json.JsonProperty("ShowSiteTutorial", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ShowSiteTutorial
        {
            get { return _showSiteTutorial; }
            set
            {
                if (_showSiteTutorial != value)
                {
                    _showSiteTutorial = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Role of this user.</summary>
        [Newtonsoft.Json.JsonProperty("Role", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AddAppUserViewRole? Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The customer ID in Microsoft Dynamics NAV.</summary>
        [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXCustomerId
        {
            get { return _aXCustomerId; }
            set
            {
                if (_aXCustomerId != value)
                {
                    _aXCustomerId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales representative tag.</summary>
        [Newtonsoft.Json.JsonProperty("SalesRepTag", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesRepTag
        {
            get { return _salesRepTag; }
            set
            {
                if (_salesRepTag != value)
                {
                    _salesRepTag = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time zone of this user.</summary>
        [Newtonsoft.Json.JsonProperty("TimeZone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeyNameModelOfGuid TimeZone
        {
            get { return _timeZone; }
            set
            {
                if (_timeZone != value)
                {
                    _timeZone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch / plant that this user belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BranchView Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Permissions of this user.</summary>
        [Newtonsoft.Json.JsonProperty("Permissions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppPermissionView> Permissions
        {
            get { return _permissions; }
            set
            {
                if (_permissions != value)
                {
                    _permissions = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum AppUserViewRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Viewer")]
        Plant_Viewer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Admin")]
        Plant_Admin = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sales_Rep")]
        Sales_Rep = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum AddAppUserViewRole
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Viewer")]
        Plant_Viewer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Plant_Admin")]
        Plant_Admin = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sales_Rep")]
        Sales_Rep = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Driver")]
        Driver = 4,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SurveyViewModelFriendliness
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VeryDissatisfied")]
        VeryDissatisfied = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Dissatisfied")]
        Dissatisfied = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Satisfied")]
        Satisfied = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"VerySatisfied")]
        VerySatisfied = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SurveyViewModelOnTime
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VeryDissatisfied")]
        VeryDissatisfied = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Dissatisfied")]
        Dissatisfied = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Satisfied")]
        Satisfied = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"VerySatisfied")]
        VerySatisfied = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SurveyViewModelHelpfulness
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VeryDissatisfied")]
        VeryDissatisfied = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Dissatisfied")]
        Dissatisfied = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Satisfied")]
        Satisfied = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"VerySatisfied")]
        VerySatisfied = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum SurveyViewModelRepresentingTruliteBrand
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VeryDissatisfied")]
        VeryDissatisfied = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Dissatisfied")]
        Dissatisfied = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Satisfied")]
        Satisfied = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"VerySatisfied")]
        VerySatisfied = 3,

    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SurveyViewModel : GalaSoft.MvvmLight.ObservableObject
    {
        private string _packingSlip;
        private string _accountNumber;
        private string _account;
        private string _branch;
        private string _salesOrderId;
        private SurveyViewModelFriendliness? _friendliness;
        private SurveyViewModelOnTime? _onTime;
        private SurveyViewModelHelpfulness? _helpfulness;
        private SurveyViewModelRepresentingTruliteBrand? _representingTruliteBrand;
        private bool? _safetyQualities;
        private bool? _deliveryProblemResolution;
        private string _comments;
        private bool? _surveySkipped;
        private string _skipReason;

        /// <summary>Packing slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlip", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                if (_packingSlip != value)
                {
                    _packingSlip = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>AX Customer ID.</summary>
        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>AX customer name.</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch code.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for the friendliness question.</summary>
        [Newtonsoft.Json.JsonProperty("Friendliness", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurveyViewModelFriendliness? Friendliness
        {
            get { return _friendliness; }
            set
            {
                if (_friendliness != value)
                {
                    _friendliness = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for the on-time question.</summary>
        [Newtonsoft.Json.JsonProperty("OnTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurveyViewModelOnTime? OnTime
        {
            get { return _onTime; }
            set
            {
                if (_onTime != value)
                {
                    _onTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for the helpfullness question.</summary>
        [Newtonsoft.Json.JsonProperty("Helpfulness", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurveyViewModelHelpfulness? Helpfulness
        {
            get { return _helpfulness; }
            set
            {
                if (_helpfulness != value)
                {
                    _helpfulness = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for representing the Trulite brand question.</summary>
        [Newtonsoft.Json.JsonProperty("RepresentingTruliteBrand", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurveyViewModelRepresentingTruliteBrand? RepresentingTruliteBrand
        {
            get { return _representingTruliteBrand; }
            set
            {
                if (_representingTruliteBrand != value)
                {
                    _representingTruliteBrand = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for the driver's safety qualities question.</summary>
        [Newtonsoft.Json.JsonProperty("SafetyQualities", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SafetyQualities
        {
            get { return _safetyQualities; }
            set
            {
                if (_safetyQualities != value)
                {
                    _safetyQualities = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Answer for the driver's ability to resolve problems if there were any.</summary>
        [Newtonsoft.Json.JsonProperty("DeliveryProblemResolution", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DeliveryProblemResolution
        {
            get { return _deliveryProblemResolution; }
            set
            {
                if (_deliveryProblemResolution != value)
                {
                    _deliveryProblemResolution = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Comments.</summary>
        [Newtonsoft.Json.JsonProperty("Comments", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comments
        {
            get { return _comments; }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the user decided to skip the survey.</summary>
        [Newtonsoft.Json.JsonProperty("SurveySkipped", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SurveySkipped
        {
            get { return _surveySkipped; }
            set
            {
                if (_surveySkipped != value)
                {
                    _surveySkipped = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The reason why the survey was skipped. The options are "Customer Declined" and "Customer Skipped"</summary>
        [Newtonsoft.Json.JsonProperty("SkipReason", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SkipReason
        {
            get { return _skipReason; }
            set
            {
                if (_skipReason != value)
                {
                    _skipReason = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class RepackRequestModel : GalaSoft.MvvmLight.ObservableObject
    {
        private string _account;
        private string _salesOrder;
        private string _note;
        private string _packingSlip;
        private string _branch;
        private long? _recId;
        private System.Collections.Generic.ICollection<RepackModel> _data;

        /// <summary>Accout number.</summary>
        [Newtonsoft.Json.JsonProperty("Account", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrder", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                if (_salesOrder != value)
                {
                    _salesOrder = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Repack note.</summary>
        [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing Slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlip", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                if (_packingSlip != value)
                {
                    _packingSlip = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch code.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slip record ID.</summary>
        [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RecId
        {
            get { return _recId; }
            set
            {
                if (_recId != value)
                {
                    _recId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Repack items.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RepackModel> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class RepackModel : GalaSoft.MvvmLight.ObservableObject
    {
        private string _lineItem;
        private System.Collections.Generic.ICollection<PackReason> _reasons;

        /// <summary>Packing slip line item key.</summary>
        [Newtonsoft.Json.JsonProperty("LineItem", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineItem
        {
            get { return _lineItem; }
            set
            {
                if (_lineItem != value)
                {
                    _lineItem = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Repack reasons.</summary>
        [Newtonsoft.Json.JsonProperty("Reasons", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PackReason> Reasons
        {
            get { return _reasons; }
            set
            {
                if (_reasons != value)
                {
                    _reasons = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PackReason : GalaSoft.MvvmLight.ObservableObject
    {
        private int? _quantity;
        private string _action;
        private string _reason;
        private int? _inventTransId;

        /// <summary>Quantity.</summary>
        [Newtonsoft.Json.JsonProperty("Quantity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Action. Please use the repack actions lookup.</summary>
        [Newtonsoft.Json.JsonProperty("Action", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Action
        {
            get { return _action; }
            set
            {
                if (_action != value)
                {
                    _action = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Reason. Please use the repack reasons lookup.</summary>
        [Newtonsoft.Json.JsonProperty("Reason", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason
        {
            get { return _reason; }
            set
            {
                if (_reason != value)
                {
                    _reason = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invetory transaction ID.</summary>
        [Newtonsoft.Json.JsonProperty("InventTransId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InventTransId
        {
            get { return _inventTransId; }
            set
            {
                if (_inventTransId != value)
                {
                    _inventTransId = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfWaiverType : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<WaiverType> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<WaiverType> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class WaiverType : GalaSoft.MvvmLight.ObservableObject
    {
        private int? _correlationId;
        private string _description;
        private System.DateTimeOffset? _throughDate;
        private bool? _supportsDate;

        /// <summary>Correlation ID. This property is the ID of this object.</summary>
        [Newtonsoft.Json.JsonProperty("CorrelationId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CorrelationId
        {
            get { return _correlationId; }
            set
            {
                if (_correlationId != value)
                {
                    _correlationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Through date of waiver</summary>
        [Newtonsoft.Json.JsonProperty("ThroughDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ThroughDate
        {
            get { return _throughDate; }
            set
            {
                if (_throughDate != value)
                {
                    _throughDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells whether the waiver type supports date ({Trulite.CustomerPortal.Common.Models.WaiverType.ThroughDate}).</summary>
        [Newtonsoft.Json.JsonProperty("SupportsDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SupportsDate
        {
            get { return _supportsDate; }
            set
            {
                if (_supportsDate != value)
                {
                    _supportsDate = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class LienWaiverModel : GalaSoft.MvvmLight.ObservableObject
    {
        private string _phoneNumber;
        private string _emailAddress;
        private string _customerName;
        private string _projectName;
        private string _projectAccountNo;
        private System.Collections.Generic.ICollection<string> _invoices;
        private WaiverType _waiverType;
        private double? _dollarAmount;
        private string _projectAddress;
        private string _projectCity;
        private string _projectState;
        private string _projectZip;
        private string _mailedWaiverAddress;
        private string _mailedWaiverCity;
        private string _mailedWaiverState;
        private string _mailedWaiverZip;
        private string _specialInstrutions;
        private WaiverFile _file;

        /// <summary>Phone number.</summary>
        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Email address.</summary>
        [Newtonsoft.Json.JsonProperty("EmailAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Customer name.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project name.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                if (_projectName != value)
                {
                    _projectName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project account number.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectAccountNo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectAccountNo
        {
            get { return _projectAccountNo; }
            set
            {
                if (_projectAccountNo != value)
                {
                    _projectAccountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>List of invoices.</summary>
        [Newtonsoft.Json.JsonProperty("Invoices", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Invoices
        {
            get { return _invoices; }
            set
            {
                if (_invoices != value)
                {
                    _invoices = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Waiver type.</summary>
        [Newtonsoft.Json.JsonProperty("WaiverType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WaiverType WaiverType
        {
            get { return _waiverType; }
            set
            {
                if (_waiverType != value)
                {
                    _waiverType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Requested dollar amount.</summary>
        [Newtonsoft.Json.JsonProperty("DollarAmount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DollarAmount
        {
            get { return _dollarAmount; }
            set
            {
                if (_dollarAmount != value)
                {
                    _dollarAmount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project address.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectAddress
        {
            get { return _projectAddress; }
            set
            {
                if (_projectAddress != value)
                {
                    _projectAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project city.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectCity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectCity
        {
            get { return _projectCity; }
            set
            {
                if (_projectCity != value)
                {
                    _projectCity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project state. Please use the states lookup for this property.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectState", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectState
        {
            get { return _projectState; }
            set
            {
                if (_projectState != value)
                {
                    _projectState = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Project zip code.</summary>
        [Newtonsoft.Json.JsonProperty("ProjectZip", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectZip
        {
            get { return _projectZip; }
            set
            {
                if (_projectZip != value)
                {
                    _projectZip = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Mailed waiver address.</summary>
        [Newtonsoft.Json.JsonProperty("MailedWaiverAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MailedWaiverAddress
        {
            get { return _mailedWaiverAddress; }
            set
            {
                if (_mailedWaiverAddress != value)
                {
                    _mailedWaiverAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Mailed waiver city.</summary>
        [Newtonsoft.Json.JsonProperty("MailedWaiverCity", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MailedWaiverCity
        {
            get { return _mailedWaiverCity; }
            set
            {
                if (_mailedWaiverCity != value)
                {
                    _mailedWaiverCity = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Mailed waiver state. Please use the states lookup for this property.</summary>
        [Newtonsoft.Json.JsonProperty("MailedWaiverState", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MailedWaiverState
        {
            get { return _mailedWaiverState; }
            set
            {
                if (_mailedWaiverState != value)
                {
                    _mailedWaiverState = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Mailed waiver zip code.</summary>
        [Newtonsoft.Json.JsonProperty("MailedWaiverZip", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MailedWaiverZip
        {
            get { return _mailedWaiverZip; }
            set
            {
                if (_mailedWaiverZip != value)
                {
                    _mailedWaiverZip = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Special instructions.</summary>
        [Newtonsoft.Json.JsonProperty("SpecialInstrutions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpecialInstrutions
        {
            get { return _specialInstrutions; }
            set
            {
                if (_specialInstrutions != value)
                {
                    _specialInstrutions = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Uploaded additional file.</summary>
        [Newtonsoft.Json.JsonProperty("File", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WaiverFile File
        {
            get { return _file; }
            set
            {
                if (_file != value)
                {
                    _file = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class WaiverFile : GalaSoft.MvvmLight.ObservableObject
    {
        private string _fileName;
        private string _contentBase64;

        /// <summary>File name.</summary>
        [Newtonsoft.Json.JsonProperty("FileName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Base64 encoded file content.</summary>
        [Newtonsoft.Json.JsonProperty("ContentBase64", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContentBase64
        {
            get { return _contentBase64; }
            set
            {
                if (_contentBase64 != value)
                {
                    _contentBase64 = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfMobileSignatureResponse : GalaSoft.MvvmLight.ObservableObject
    {
        private MobileSignatureResponse _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MobileSignatureResponse Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MobileSignatureResponse : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Guid? _invoicePaymentId;
        private string _merchantReferenceNumber;
        private string _signature;
        private string _merchantId;

        /// <summary>Invoice payment ID.</summary>
        [Newtonsoft.Json.JsonProperty("InvoicePaymentId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? InvoicePaymentId
        {
            get { return _invoicePaymentId; }
            set
            {
                if (_invoicePaymentId != value)
                {
                    _invoicePaymentId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Merchant Reference Number.</summary>
        [Newtonsoft.Json.JsonProperty("MerchantReferenceNumber", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerchantReferenceNumber
        {
            get { return _merchantReferenceNumber; }
            set
            {
                if (_merchantReferenceNumber != value)
                {
                    _merchantReferenceNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Generated signature.</summary>
        [Newtonsoft.Json.JsonProperty("Signature", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Signature
        {
            get { return _signature; }
            set
            {
                if (_signature != value)
                {
                    _signature = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Merchant ID.</summary>
        [Newtonsoft.Json.JsonProperty("MerchantId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerchantId
        {
            get { return _merchantId; }
            set
            {
                if (_merchantId != value)
                {
                    _merchantId = value;
                    RaisePropertyChanged();
                }
            }
        }






    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MobileSignatureRequest : GalaSoft.MvvmLight.ObservableObject
    {
        private double? _amount;
        private MobileSignatureRequestTransactionType? _transactionType;
        private System.Collections.Generic.ICollection<string> _invoiceKeys;

        /// <summary>Payment amount.</summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transaction type.</summary>
        [Newtonsoft.Json.JsonProperty("TransactionType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MobileSignatureRequestTransactionType? TransactionType
        {
            get { return _transactionType; }
            set
            {
                if (_transactionType != value)
                {
                    _transactionType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice Keys</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceKeys", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> InvoiceKeys
        {
            get { return _invoiceKeys; }
            set
            {
                if (_invoiceKeys != value)
                {
                    _invoiceKeys = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MobilePaymentRequest : GalaSoft.MvvmLight.ObservableObject
    {
        private string _firstName;
        private string _lastName;
        private string _street;
        private string _city;
        private string _state;
        private string _address;
        private string _postalCode;
        private string _email;
        private string _iPAddress;
        private string _ecryptedPayment;
        private string _currency;
        private string _country;
        private double? _amount;
        private System.Collections.Generic.ICollection<string> _invoiceKeys;
        private MobilePaymentRequestTransactionType? _transactionType;
        private System.Guid? _invoicePaymentId;
        private string _aXTransaction;
        private string _cardType;

        /// <summary>First Name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last Name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Address street.</summary>
        [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Address city.</summary>
        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Address state.</summary>
        [Newtonsoft.Json.JsonProperty("State", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Address postal code.</summary>
        [Newtonsoft.Json.JsonProperty("PostalCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (_postalCode != value)
                {
                    _postalCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Email address.</summary>
        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>IP Address.</summary>
        [Newtonsoft.Json.JsonProperty("IPAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IPAddress
        {
            get { return _iPAddress; }
            set
            {
                if (_iPAddress != value)
                {
                    _iPAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Encrypted payment signature.</summary>
        [Newtonsoft.Json.JsonProperty("EcryptedPayment", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EcryptedPayment
        {
            get { return _ecryptedPayment; }
            set
            {
                if (_ecryptedPayment != value)
                {
                    _ecryptedPayment = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Payment currency.</summary>
        [Newtonsoft.Json.JsonProperty("Currency", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency
        {
            get { return _currency; }
            set
            {
                if (_currency != value)
                {
                    _currency = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Country</summary>
        [Newtonsoft.Json.JsonProperty("Country", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Payment amount.</summary>
        [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice Keys</summary>
        [Newtonsoft.Json.JsonProperty("InvoiceKeys", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> InvoiceKeys
        {
            get { return _invoiceKeys; }
            set
            {
                if (_invoiceKeys != value)
                {
                    _invoiceKeys = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transaction type.</summary>
        [Newtonsoft.Json.JsonProperty("TransactionType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MobilePaymentRequestTransactionType? TransactionType
        {
            get { return _transactionType; }
            set
            {
                if (_transactionType != value)
                {
                    _transactionType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Invoice payment ID.</summary>
        [Newtonsoft.Json.JsonProperty("InvoicePaymentId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? InvoicePaymentId
        {
            get { return _invoicePaymentId; }
            set
            {
                if (_invoicePaymentId != value)
                {
                    _invoicePaymentId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>AX Transaction.</summary>
        [Newtonsoft.Json.JsonProperty("AXTransaction", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AXTransaction
        {
            get { return _aXTransaction; }
            set
            {
                if (_aXTransaction != value)
                {
                    _aXTransaction = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Card Type</summary>
        [Newtonsoft.Json.JsonProperty("CardType", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CardType
        {
            get { return _cardType; }
            set
            {
                if (_cardType != value)
                {
                    _cardType = value;
                    RaisePropertyChanged();
                }
            }
        }







    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfMobilePaymentResponse : GalaSoft.MvvmLight.ObservableObject
    {
        private MobilePaymentResponse _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MobilePaymentResponse Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class MobilePaymentResponse : GalaSoft.MvvmLight.ObservableObject
    {
        private string _requestToken;
        private string _reasonCode;
        private string _authIndicator;
        private string _accountReference;
        private string _requestID;
        private string _decision;
        private System.Collections.Generic.ICollection<string> _missingFields;
        private System.Collections.Generic.ICollection<string> _invalidFields;
        private string _issuerMessage;
        private string _errorMessage;

        [Newtonsoft.Json.JsonProperty("RequestToken", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestToken
        {
            get { return _requestToken; }
            set
            {
                if (_requestToken != value)
                {
                    _requestToken = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ReasonCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReasonCode
        {
            get { return _reasonCode; }
            set
            {
                if (_reasonCode != value)
                {
                    _reasonCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AuthIndicator", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthIndicator
        {
            get { return _authIndicator; }
            set
            {
                if (_authIndicator != value)
                {
                    _authIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountReference", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountReference
        {
            get { return _accountReference; }
            set
            {
                if (_accountReference != value)
                {
                    _accountReference = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("RequestID", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestID
        {
            get { return _requestID; }
            set
            {
                if (_requestID != value)
                {
                    _requestID = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Decision", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Decision
        {
            get { return _decision; }
            set
            {
                if (_decision != value)
                {
                    _decision = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("MissingFields", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> MissingFields
        {
            get { return _missingFields; }
            set
            {
                if (_missingFields != value)
                {
                    _missingFields = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("InvalidFields", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> InvalidFields
        {
            get { return _invalidFields; }
            set
            {
                if (_invalidFields != value)
                {
                    _invalidFields = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("IssuerMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IssuerMessage
        {
            get { return _issuerMessage; }
            set
            {
                if (_issuerMessage != value)
                {
                    _issuerMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ErrorMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum MobileSignatureRequestTransactionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CreditCardToken")]
        CreditCardToken = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ECheck")]
        ECheck = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"ECheckToken")]
        ECheckToken = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum MobilePaymentRequestTransactionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CreditCardToken")]
        CreditCardToken = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ECheck")]
        ECheck = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"ECheckToken")]
        ECheckToken = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfCfmDlvDateTracking : GalaSoft.MvvmLight.ObservableObject
    {
        private System.Collections.Generic.ICollection<CfmDlvDateTracking> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CfmDlvDateTracking> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class CfmDlvDateTracking : GalaSoft.MvvmLight.ObservableObject
    {
        private System.DateTimeOffset? _oldDeliveryDate;
        private System.DateTimeOffset? _newDeliveryDate;
        private string _reasonCode;
        private System.DateTimeOffset? _createdDateTime;
        private string _createdBy;
        private string _salesId;
        private string _lineNum;

        /// <summary>Old delivery date.</summary>
        [Newtonsoft.Json.JsonProperty("OldDeliveryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OldDeliveryDate
        {
            get { return _oldDeliveryDate; }
            set
            {
                if (_oldDeliveryDate != value)
                {
                    _oldDeliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>New Delivery date.</summary>
        [Newtonsoft.Json.JsonProperty("NewDeliveryDate", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? NewDeliveryDate
        {
            get { return _newDeliveryDate; }
            set
            {
                if (_newDeliveryDate != value)
                {
                    _newDeliveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Reason code.</summary>
        [Newtonsoft.Json.JsonProperty("ReasonCode", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReasonCode
        {
            get { return _reasonCode; }
            set
            {
                if (_reasonCode != value)
                {
                    _reasonCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the record was created.</summary>
        [Newtonsoft.Json.JsonProperty("CreatedDateTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedDateTime
        {
            get { return _createdDateTime; }
            set
            {
                if (_createdDateTime != value)
                {
                    _createdDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Created by user.</summary>
        [Newtonsoft.Json.JsonProperty("CreatedBy", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                if (_createdBy != value)
                {
                    _createdBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales oder ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesId", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesId
        {
            get { return _salesId; }
            set
            {
                if (_salesId != value)
                {
                    _salesId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Line number.</summary>
        [Newtonsoft.Json.JsonProperty("LineNum", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineNum
        {
            get { return _lineNum; }
            set
            {
                if (_lineNum != value)
                {
                    _lineNum = value;
                    RaisePropertyChanged();
                }
            }
        }






    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfInt32 : GalaSoft.MvvmLight.ObservableObject
    {
        private int? _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }





    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ClockInTimeQueryContext : ObservableObject
    {
        private string _manifestId;
        private int? _stopNumber;
        private System.DateTimeOffset? _dateTime;

        /// <summary>Manifest ID.</summary>
        [Newtonsoft.Json.JsonProperty("ManifestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ManifestId
        {
            get { return _manifestId; }
            set
            {
                if (_manifestId != value)
                {
                    _manifestId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Stop number.</summary>
        [Newtonsoft.Json.JsonProperty("StopNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StopNumber
        {
            get { return _stopNumber; }
            set
            {
                if (_stopNumber != value)
                {
                    _stopNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date and time to be recorded.</summary>
        [Newtonsoft.Json.JsonProperty("DateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateTime
        {
            get { return _dateTime; }
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SignatureQueryContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _signatureBase64;
        private string _email;
        private string _packingSlipId;
        private string _salesOrderId;
        private System.DateTimeOffset? _packingSlipDate;
        private string _branch;
        private string _printedName;
        private System.Collections.Generic.ICollection<SignatureImage> _images;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Base64 encoded string signature.</summary>
        [Newtonsoft.Json.JsonProperty("SignatureBase64", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SignatureBase64
        {
            get { return _signatureBase64; }
            set
            {
                if (_signatureBase64 != value)
                {
                    _signatureBase64 = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Email address to send the singature copy.</summary>
        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Packing slip ID.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipId
        {
            get { return _packingSlipId; }
            set
            {
                if (_packingSlipId != value)
                {
                    _packingSlipId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Sales order ID.</summary>
        [Newtonsoft.Json.JsonProperty("SalesOrderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesOrderId
        {
            get { return _salesOrderId; }
            set
            {
                if (_salesOrderId != value)
                {
                    _salesOrderId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date the packing slip was created.</summary>
        [Newtonsoft.Json.JsonProperty("PackingSlipDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PackingSlipDate
        {
            get { return _packingSlipDate; }
            set
            {
                if (_packingSlipDate != value)
                {
                    _packingSlipDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch code.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of the person signing.</summary>
        [Newtonsoft.Json.JsonProperty("PrintedName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrintedName
        {
            get { return _printedName; }
            set
            {
                if (_printedName != value)
                {
                    _printedName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Images associated with the signature.</summary>
        [Newtonsoft.Json.JsonProperty("Images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SignatureImage> Images
        {
            get { return _images; }
            set
            {
                if (_images != value)
                {
                    _images = value;
                    RaisePropertyChanged();
                }
            }
        }




    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class SignatureImage : ObservableObject
    {
        private string _fileName;
        private string _base64Content;

        /// <summary>File name.</summary>
        [Newtonsoft.Json.JsonProperty("FileName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Base64 encoded image content.</summary>
        [Newtonsoft.Json.JsonProperty("Base64Content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Base64Content
        {
            get { return _base64Content; }
            set
            {
                if (_base64Content != value)
                {
                    _base64Content = value;
                    RaisePropertyChanged();
                }
            }
        }


      

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class GetDriverClockInsContext : ObservableObject
    {
        private string _filterAccountNo;
        private string _packingSlipKey;
        private string _filterAppUserName;
        private System.DateTimeOffset? _fromClockInDateTime;
        private System.DateTimeOffset? _toClockInDateTime;

        [Newtonsoft.Json.JsonProperty("FilterAccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterAccountNo
        {
            get { return _filterAccountNo; }
            set
            {
                if (_filterAccountNo != value)
                {
                    _filterAccountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PackingSlipKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipKey
        {
            get { return _packingSlipKey; }
            set
            {
                if (_packingSlipKey != value)
                {
                    _packingSlipKey = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FilterAppUserName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterAppUserName
        {
            get { return _filterAppUserName; }
            set
            {
                if (_filterAppUserName != value)
                {
                    _filterAppUserName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("FromClockInDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromClockInDateTime
        {
            get { return _fromClockInDateTime; }
            set
            {
                if (_fromClockInDateTime != value)
                {
                    _fromClockInDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ToClockInDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToClockInDateTime
        {
            get { return _toClockInDateTime; }
            set
            {
                if (_toClockInDateTime != value)
                {
                    _toClockInDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfListOfDriverRouteClockInOutViewModel : ObservableObject
    {
        private System.Collections.Generic.ICollection<DriverRouteClockInOutViewModel> _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DriverRouteClockInOutViewModel> Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


      

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class DriverRouteClockInOutViewModel : ObservableObject
    {
        private System.Guid? _driverRouteClockInOutId;
        private System.Guid? _appUserId;
        private System.Guid? _branchId;
        private string _accountNo;
        private string _accountName;
        private string _packingSlipKey;
        private string _jobName;
        private string _jobAddress;
        private System.DateTimeOffset _clockInDateTime;
        private System.DateTimeOffset? _clockOutDateTime;
        private bool? _active;

        [Newtonsoft.Json.JsonProperty("DriverRouteClockInOutId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? DriverRouteClockInOutId
        {
            get { return _driverRouteClockInOutId; }
            set
            {
                if (_driverRouteClockInOutId != value)
                {
                    _driverRouteClockInOutId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AppUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? AppUserId
        {
            get { return _appUserId; }
            set
            {
                if (_appUserId != value)
                {
                    _appUserId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("BranchId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? BranchId
        {
            get { return _branchId; }
            set
            {
                if (_branchId != value)
                {
                    _branchId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountName
        {
            get { return _accountName; }
            set
            {
                if (_accountName != value)
                {
                    _accountName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PackingSlipKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipKey
        {
            get { return _packingSlipKey; }
            set
            {
                if (_packingSlipKey != value)
                {
                    _packingSlipKey = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("JobName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JobName
        {
            get { return _jobName; }
            set
            {
                if (_jobName != value)
                {
                    _jobName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("JobAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JobAddress
        {
            get { return _jobAddress; }
            set
            {
                if (_jobAddress != value)
                {
                    _jobAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ClockInDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ClockInDateTime
        {
            get { return _clockInDateTime; }
            set
            {
                if (_clockInDateTime != value)
                {
                    _clockInDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ClockOutDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClockOutDateTime
        {
            get { return _clockOutDateTime; }
            set
            {
                if (_clockOutDateTime != value)
                {
                    _clockOutDateTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class PostDriverClockInOutContext : ObservableObject
    {
        private string _accountNo;
        private string _packingSlipKey;
        private PostDriverClockInOutContextClockInOutAction? _clockInOutAction;

        [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                if (_accountNo != value)
                {
                    _accountNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PackingSlipKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackingSlipKey
        {
            get { return _packingSlipKey; }
            set
            {
                if (_packingSlipKey != value)
                {
                    _packingSlipKey = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ClockInOutAction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PostDriverClockInOutContextClockInOutAction? ClockInOutAction
        {
            get { return _clockInOutAction; }
            set
            {
                if (_clockInOutAction != value)
                {
                    _clockInOutAction = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public enum PostDriverClockInOutContextClockInOutAction
  {
    [System.Runtime.Serialization.EnumMember(Value = @"ClockIn")]
    ClockIn = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"ClockOut")]
    ClockOut = 1,

  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public enum MobilePaymentSSORequestRequestType
  {
    [System.Runtime.Serialization.EnumMember(Value = @"FullPayment")]
    FullPayment = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"PartialPayment")]
    PartialPayment = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"MoneyOnAccount")]
    MoneyOnAccount = 2,

  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public enum MobilePaymentSSORequestLanguage
  {
    [System.Runtime.Serialization.EnumMember(Value = @"English")]
    English = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"French")]
    French = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Spanish")]
    Spanish = 2,

  }
  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public partial class MobilePaymentSSORequest : ObservableObject
  {
    private MobilePaymentSSORequestRequestType? _requestType;
    private System.Collections.Generic.ICollection<PartialInvoicePaymentLineItem> _lines;
    private MobilePaymentSSORequestLanguage? _language;
    private bool? _isDarkTheme;
    private double? _extraAmount;
    private string _note;
    private CustomerContext _customerInfo;

    [Newtonsoft.Json.JsonProperty("RequestType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public MobilePaymentSSORequestRequestType? RequestType
    {
      get { return _requestType; }
      set
      {
        if (_requestType != value)
        {
          _requestType = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<PartialInvoicePaymentLineItem> Lines
    {
      get { return _lines; }
      set
      {
        if (_lines != value)
        {
          _lines = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public MobilePaymentSSORequestLanguage? Language
    {
      get { return _language; }
      set
      {
        if (_language != value)
        {
          _language = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("IsDarkTheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? IsDarkTheme
    {
      get { return _isDarkTheme; }
      set
      {
        if (_isDarkTheme != value)
        {
          _isDarkTheme = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("ExtraAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? ExtraAmount
    {
      get { return _extraAmount; }
      set
      {
        if (_extraAmount != value)
        {
          _extraAmount = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Note
    {
      get { return _note; }
      set
      {
        if (_note != value)
        {
          _note = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public CustomerContext CustomerInfo
    {
      get { return _customerInfo; }
      set
      {
        if (_customerInfo != value)
        {
          _customerInfo = value;
          RaisePropertyChanged();
        }
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public partial class PartialInvoicePaymentLineItem : ObservableObject
  {
    private string _aXCustomerId;
    private string _invoiceKey;
    private string _recId;
    private double? _amount;
    private double? _partialAmount;
    private string _note;

    [Newtonsoft.Json.JsonProperty("AXCustomerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string AXCustomerId
    {
      get { return _aXCustomerId; }
      set
      {
        if (_aXCustomerId != value)
        {
          _aXCustomerId = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("InvoiceKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string InvoiceKey
    {
      get { return _invoiceKey; }
      set
      {
        if (_invoiceKey != value)
        {
          _invoiceKey = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("RecId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string RecId
    {
      get { return _recId; }
      set
      {
        if (_recId != value)
        {
          _recId = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("Amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? Amount
    {
      get { return _amount; }
      set
      {
        if (_amount != value)
        {
          _amount = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("PartialAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? PartialAmount
    {
      get { return _partialAmount; }
      set
      {
        if (_partialAmount != value)
        {
          _partialAmount = value;
          RaisePropertyChanged();
        }
      }
    }

    [Newtonsoft.Json.JsonProperty("Note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Note
    {
      get { return _note; }
      set
      {
        if (_note != value)
        {
          _note = value;
          RaisePropertyChanged();
        }
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v10.0.0.0)")]
  public partial class ApiResponseOfNullableOfGuid : ObservableObject
  {
    private System.Guid? _data;
    private string _exceptionMessage;
    private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
    private bool? _successful;
    private double? _executionTime;
    private string _server;
    private bool? _isValid;

    /// <summary>Data for this response.</summary>
    [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Guid? Data
    {
      get { return _data; }
      set
      {
        if (_data != value)
        {
          _data = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>The message of the exception that was thrown when the request was executing.</summary>
    [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string ExceptionMessage
    {
      get { return _exceptionMessage; }
      set
      {
        if (_exceptionMessage != value)
        {
          _exceptionMessage = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
    [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
    {
      get { return _validationErrors; }
      set
      {
        if (_validationErrors != value)
        {
          _validationErrors = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Tells wether the request exececuted successfully.</summary>
    [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? Successful
    {
      get { return _successful; }
      set
      {
        if (_successful != value)
        {
          _successful = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>The time that took to execute the request.</summary>
    [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? ExecutionTime
    {
      get { return _executionTime; }
      set
      {
        if (_executionTime != value)
        {
          _executionTime = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>The name of the server that the request was handled by.</summary>
    [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Server
    {
      get { return _server; }
      set
      {
        if (_server != value)
        {
          _server = value;
          RaisePropertyChanged();
        }
      }
    }

    /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
    [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? IsValid
    {
      get { return _isValid; }
      set
      {
        if (_isValid != value)
        {
          _isValid = value;
          RaisePropertyChanged();
        }
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v11.0.0.0)")]
  public partial class MobileNotifyCustomerSSORequest: ObservableObject
  {
    [Newtonsoft.Json.JsonProperty("AccountNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string AccountNo { get; set; }

    [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public CustomerContext CustomerInfo { get; set; }

    [Newtonsoft.Json.JsonProperty("Lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public System.Collections.Generic.ICollection<NotifyCustomerLineItem> Lines { get; set; }

    [Newtonsoft.Json.JsonProperty("Language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public MobileNotifyCustomerSSORequestLanguage? Language { get; set; }

    [Newtonsoft.Json.JsonProperty("IsDarkTheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool? IsDarkTheme { get; set; }
  }


  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v11.0.0.0)")]
  public partial class NotifyCustomerLineItem: ObservableObject
  {
    [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Id { get; set; }

    [Newtonsoft.Json.JsonProperty("CustomerPurchaseOrderNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CustomerPurchaseOrderNo { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.5.0 (Newtonsoft.Json v11.0.0.0)")]
  public enum MobileNotifyCustomerSSORequestLanguage
  {
    [System.Runtime.Serialization.EnumMember(Value = @"English")]
    English = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"French")]
    French = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Spanish")]
    Spanish = 2,

  }

  /// <summary>language</summary>
  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
  public enum Language
  {
      [System.Runtime.Serialization.EnumMember(Value = @"English")]
      English = 0,

      [System.Runtime.Serialization.EnumMember(Value = @"French")]
      French = 1,

      [System.Runtime.Serialization.EnumMember(Value = @"Spanish")]
      Spanish = 2,

  }
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfAgreeToTermsViewModel : ObservableObject
    {
        private AgreeToTermsViewModel _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgreeToTermsViewModel Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


      

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.7.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AgreeToTermsViewModel : ObservableObject
    {
        private string _text;
        private System.DateTimeOffset? _policyDate;
        private bool? _agree;
        private string _returnToUrl;

        [Newtonsoft.Json.JsonProperty("Text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PolicyDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PolicyDate
        {
            get { return _policyDate; }
            set
            {
                if (_policyDate != value)
                {
                    _policyDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Agree", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Agree
        {
            get { return _agree; }
            set
            {
                if (_agree != value)
                {
                    _agree = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ReturnToUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnToUrl
        {
            get { return _returnToUrl; }
            set
            {
                if (_returnToUrl != value)
                {
                    _returnToUrl = value;
                    RaisePropertyChanged();
                }
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.11.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class ApiResponseOfNotifyCustomerViewModel : ObservableObject
    {
        private NotifyCustomerViewModel _data;
        private string _exceptionMessage;
        private System.Collections.Generic.ICollection<ValiationError> _validationErrors;
        private bool? _successful;
        private double? _executionTime;
        private string _server;
        private bool? _isValid;

        /// <summary>Data for this response.</summary>
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NotifyCustomerViewModel Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The message of the exception that was thrown when the request was executing.</summary>
        [Newtonsoft.Json.JsonProperty("ExceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                if (_exceptionMessage != value)
                {
                    _exceptionMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Validation errors associated with the request. For example, this property may have errors if the API return 400 HTTP status code.</summary>
        [Newtonsoft.Json.JsonProperty("ValidationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValiationError> ValidationErrors
        {
            get { return _validationErrors; }
            set
            {
                if (_validationErrors != value)
                {
                    _validationErrors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Tells wether the request exececuted successfully.</summary>
        [Newtonsoft.Json.JsonProperty("Successful", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Successful
        {
            get { return _successful; }
            set
            {
                if (_successful != value)
                {
                    _successful = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time that took to execute the request.</summary>
        [Newtonsoft.Json.JsonProperty("ExecutionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                if (_executionTime != value)
                {
                    _executionTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the server that the request was handled by.</summary>
        [Newtonsoft.Json.JsonProperty("Server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server
        {
            get { return _server; }
            set
            {
                if (_server != value)
                {
                    _server = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates wether ValidationErrors property has any errors.</summary>
        [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsValid
        {
            get { return _isValid; }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    RaisePropertyChanged();
                }
            }
        }


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.11.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class NotifyCustomerViewModel : ObservableObject
    {
        private System.Collections.Generic.ICollection<string> _packingSlipIds;
        private System.Collections.Generic.ICollection<string> _customerPoNumbers;
        private string _selectedDurationEstimate;
        private string _phoneNumber;
        private string _dearLine;
        private string _standardMessageBody;
        private string _customerPoNumbersLine;
        private string _additionalComments;
        private string _signature;
        private string _driverAddress;
        private string _customerAddress;
        private System.Collections.Generic.ICollection<string> _selectedButtonActions;
        private System.Collections.Generic.ICollection<KeyNameModelOfString> _buttonActions;
        private string _accountNumber;
        private string _accountName;

        [Newtonsoft.Json.JsonProperty("PackingSlipIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PackingSlipIds
        {
            get { return _packingSlipIds; }
            set
            {
                if (_packingSlipIds != value)
                {
                    _packingSlipIds = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerPoNumbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> CustomerPoNumbers
        {
            get { return _customerPoNumbers; }
            set
            {
                if (_customerPoNumbers != value)
                {
                    _customerPoNumbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SelectedDurationEstimate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SelectedDurationEstimate
        {
            get { return _selectedDurationEstimate; }
            set
            {
                if (_selectedDurationEstimate != value)
                {
                    _selectedDurationEstimate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DearLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DearLine
        {
            get { return _dearLine; }
            set
            {
                if (_dearLine != value)
                {
                    _dearLine = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("StandardMessageBody", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StandardMessageBody
        {
            get { return _standardMessageBody; }
            set
            {
                if (_standardMessageBody != value)
                {
                    _standardMessageBody = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerPoNumbersLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerPoNumbersLine
        {
            get { return _customerPoNumbersLine; }
            set
            {
                if (_customerPoNumbersLine != value)
                {
                    _customerPoNumbersLine = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AdditionalComments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdditionalComments
        {
            get { return _additionalComments; }
            set
            {
                if (_additionalComments != value)
                {
                    _additionalComments = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Signature", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Signature
        {
            get { return _signature; }
            set
            {
                if (_signature != value)
                {
                    _signature = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("DriverAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DriverAddress
        {
            get { return _driverAddress; }
            set
            {
                if (_driverAddress != value)
                {
                    _driverAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("CustomerAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerAddress
        {
            get { return _customerAddress; }
            set
            {
                if (_customerAddress != value)
                {
                    _customerAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("SelectedButtonActions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SelectedButtonActions
        {
            get { return _selectedButtonActions; }
            set
            {
                if (_selectedButtonActions != value)
                {
                    _selectedButtonActions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ButtonActions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyNameModelOfString> ButtonActions
        {
            get { return _buttonActions; }
            set
            {
                if (_buttonActions != value)
                {
                    _buttonActions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AccountName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountName
        {
            get { return _accountName; }
            set
            {
                if (_accountName != value)
                {
                    _accountName = value;
                    RaisePropertyChanged();
                }
            }
        }



    }


}
