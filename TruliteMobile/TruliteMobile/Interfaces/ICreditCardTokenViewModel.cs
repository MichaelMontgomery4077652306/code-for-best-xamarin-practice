using System.Collections.ObjectModel;

namespace TruliteMobile.Services
{
    public interface ICreditCardTokenViewModel
    {
        System.Guid? TokenId { get; set; }
        string Token { get; set; }
        string CardType { get; set; }
        string FriendlyName { get; set; }
        System.DateTimeOffset? ExpiryDate { get; set; }
        string Street { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string CountryCode { get; set; }
        string Account { get; set; }
        string AccountNo { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        bool? CanDelete { get; set; }
        bool? CanEdit { get; set; }
        ObservableCollection<string> CopyReceiptEmailAddresses { get; set; }
        System.DateTimeOffset? DateCreated { get; set; }
        System.DateTimeOffset? DateUpdated { get; set; }
        string Address { get; }
        string CardTypeIcon { get; }
        string ReceiptEmailAddress { get; set; }
    }
}