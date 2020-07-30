using System;
using System.Collections.Generic;
using TruliteMobile.Enums;
using TruliteMobile.Services;

namespace TrueliteMobileUnitTests
{
  public class TestSettings : ISettingsService
  {
    private string _serverUrl;
    private string _email;
    private string _password;
    private string _token;
    private DateTime _tokenExpiration;
    private ApplicationModeEnum _applicationMode;
    private string _axCustomerId;
    private MyInfoViewModel _myInfo;
    private bool _isDriver;
    private string _pushNotificationToken;
    private string _pushNotificationEmail;
    private string _masterAxCustomerId;
    private bool _isImpersonatingCustomer;
    private bool _rememberMe;
    private string _masterToken;
    private DateTime _masterTokenExpiration;
    private string _registrationId;
    private string _pnsHandle;
    private Dictionary<string, bool> _accountPermissions;
    private bool _isDarkTheme;
    private string _language;
    private AppUserPreferencesViewModel _myPreferences;

    public string ServerUrl
    {
      get { return _serverUrl; }
      set { _serverUrl = value; }
    }

    public string Email
    {
      get { return _email; }
      set { _email = value; }
    }

    public string Password
    {
      get { return _password; }
      set { _password = value; }
    }

    public string Token
    {
      get { return _token; }
      set { _token = value; }
    }

    public DateTime TokenExpiration
    {
      get { return _tokenExpiration; }
      set { _tokenExpiration = value; }
    }

    public ApplicationModeEnum ApplicationMode
    {
      get { return _applicationMode; }
      set { _applicationMode = value; }
    }

    public string AxCustomerId
    {
      get { return _axCustomerId; }
      set { _axCustomerId = value; }
    }

    public MyInfoViewModel MyInfo
    {
      get { return _myInfo; }
      set { _myInfo = value; }
    }

    public bool IsDriver
    {
      get { return _isDriver; }
      set { _isDriver = value; }
    }

    public string PushNotificationToken
    {
      get { return _pushNotificationToken; }
      set { _pushNotificationToken = value; }
    }

    public string PushNotificationEmail
    {
      get { return _pushNotificationEmail; }
      set { _pushNotificationEmail = value; }
    }

    public string MasterAxCustomerId
    {
      get { return _masterAxCustomerId; }
      set { _masterAxCustomerId = value; }
    }

    public bool IsImpersonatingCustomer
    {
      get { return _isImpersonatingCustomer; }
      set { _isImpersonatingCustomer = value; }
    }

    public bool RememberMe
    {
      get { return _rememberMe; }
      set { _rememberMe = value; }
    }

    public string MasterToken
    {
      get { return _masterToken; }
      set { _masterToken = value; }
    }

    public DateTime MasterTokenExpiration
    {
      get { return _masterTokenExpiration; }
      set { _masterTokenExpiration = value; }
    }

    public string RegistrationId
    {
      get { return _registrationId; }
      set { _registrationId = value; }
    }

    public string PnsHandle
    {
      get { return _pnsHandle; }
      set { _pnsHandle = value; }
    }

    public Dictionary<string, bool> AccountPermissions
    {
      get { return _accountPermissions; }
      set { _accountPermissions = value; }
    }

    public bool IsDarkTheme
    {
      get { return _isDarkTheme; }
      set { _isDarkTheme = value; }
    }

    public string Language
    {
      get { return _language; }
      set { _language = value; }
    }

    public AppUserPreferencesViewModel MyPreferences
    {
      get { return _myPreferences; }
      set { _myPreferences = value; }
    }

    public Guid? CustomerId { get; set; }
    public string Company { get; set; }
  }
}