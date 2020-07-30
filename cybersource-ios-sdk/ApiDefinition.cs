using System;
using System.Runtime.InteropServices;
using Foundation;
using InAppSDK;
using ObjCRuntime;

namespace InAppSDK
{




    [Static]
    partial interface Constants
    {
        // extern double InAppSDKVersionNumber;
        [Field("InAppSDKVersionNumber", "__Internal")]
        double InAppSDKVersionNumber { get; }

        //// extern const unsigned char[] InAppSDKVersionString;
        [Field("InAppSDKVersionString", "__Internal")]
        IntPtr InAppSDKVersionString { get; }

    }

    // @interface InAppSDKSettings : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface InAppSDKSettings : INSCoding
    {
        // @property (assign, nonatomic) INAPPSDK_ENVIRONMENT inAppSDKEnvironment;
        [Export("inAppSDKEnvironment", ArgumentSemantic.Assign)]
        InappsdkEnvironment InAppSDKEnvironment { get; set; }

        // +(InAppSDKSettings *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        InAppSDKSettings SharedInstance { get; }

        // -(void)setServerURL:(NSString *)serverURL;
        [Export("setServerURL:")]
        void SetServerURL(string serverURL);

        // @property (assign, nonatomic) NSTimeInterval timeOut;
        [Export("timeOut")]
        double TimeOut { get; set; }

        // @property (assign, nonatomic) BOOL enableLog;
        [Export("enableLog")]
        bool EnableLog { get; set; }

        // -(BOOL)saveSettings;
        [Export("saveSettings")]
        bool SaveSettings();

        // +(void)removeSettings;
        [Static]
        [Export("removeSettings")]
        void RemoveSettings();
    }

    // @protocol InAppSDKGatewayDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface InAppSDKGatewayDelegate
    {
        // @optional -(void)encryptPaymentDataServiceFinishedWithGatewayResponse:(InAppSDKGatewayResponse *)paramResponseData withError:(InAppSDKError *)paramError;
        [Export("encryptPaymentDataServiceFinishedWithGatewayResponse:withError:")]
        void EncryptPaymentDataServiceFinishedWithGatewayResponse(InAppSDKGatewayResponse paramResponseData, InAppSDKError paramError);
    }

    // @interface InAppSDKTransactionObject : NSObject
    [BaseType(typeof(NSObject))]
    interface InAppSDKTransactionObject
    {
        // @property (atomic, strong) InAppSDKMerchant * merchant;
        [Export("merchant", ArgumentSemantic.Strong)]
        InAppSDKMerchant Merchant { get; set; }

        // @property (atomic, strong) InAppSDKCardData * cardData;
        [Export("cardData", ArgumentSemantic.Strong)]
        InAppSDKCardData CardData { get; set; }

        // @property (atomic, strong) InAppSDKAddress * billTo;
        [Export("billTo", ArgumentSemantic.Strong)]
        InAppSDKAddress BillTo { get; set; }

        // @property (atomic) InAppSDKTransactionType transactionType;
        [Export("transactionType", ArgumentSemantic.Assign)]
        InAppSDKTransactionType TransactionType { get; set; }
    }

    // @interface InAppSDKGateway : NSObject
    [BaseType(typeof(NSObject))]
    interface InAppSDKGateway
    {
        // +(InAppSDKGateway *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        InAppSDKGateway SharedInstance { get; }

        // -(BOOL)performPaymentDataEncryption:(InAppSDKTransactionObject *)aTransactoinObject withDelegate:(id<InAppSDKGatewayDelegate>)aDelegate;
        [Export("performPaymentDataEncryption:withDelegate:")]
        bool PerformPaymentDataEncryption(InAppSDKTransactionObject aTransactoinObject, InAppSDKGatewayDelegate aDelegate);
    }

    // @interface InAppSDKEncryptedPayment : NSObject
    [BaseType(typeof(NSObject))]
    interface InAppSDKEncryptedPayment
    {
        // @property (nonatomic, strong) NSString * data;
        [Export("data", ArgumentSemantic.Strong)]
        string Data { get; set; }
    }

    // @interface InAppSDKGatewayResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface InAppSDKGatewayResponse
    {
        // @property (assign, nonatomic) InAppSDKGatewayResponseDecisionType decision;
        [Export("decision", ArgumentSemantic.Assign)]
        InAppSDKGatewayResponseDecisionType Decision { get; set; }

        // @property (nonatomic, strong) NSString * requestId;
        [Export("requestId", ArgumentSemantic.Strong)]
        string RequestId { get; set; }

        // @property (nonatomic, strong) NSString * resultCode;
        [Export("resultCode", ArgumentSemantic.Strong)]
        string ResultCode { get; set; }

        // @property (atomic, strong) InAppSDKEncryptedPayment * encryptedPayment;
        [Export("encryptedPayment", ArgumentSemantic.Strong)]
        InAppSDKEncryptedPayment EncryptedPayment { get; set; }

        // @property (assign, nonatomic) InAppSDKGatewayApiType type;
        [Export("type", ArgumentSemantic.Assign)]
        InAppSDKGatewayApiType Type { get; set; }

        // @property (nonatomic, strong) NSDate * date;
        [Export("date", ArgumentSemantic.Strong)]
        NSDate Date { get; set; }

        // -(BOOL)isAccepted;
        [Export("isAccepted")]
        bool IsAccepted();
    }

    // @interface InAppSDKCardData : NSObject
    [BaseType(typeof(NSObject))]
    interface InAppSDKCardData
    {
        // @property (copy, nonatomic) NSString * accountNumber;
        [Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (copy, nonatomic) NSString * expirationMonth;
        [Export("expirationMonth")]
        string ExpirationMonth { get; set; }

        // @property (copy, nonatomic) NSString * expirationYear;
        [Export("expirationYear")]
        string ExpirationYear { get; set; }

        // @property (copy, nonatomic) NSString * cvNumber;
        [Export("cvNumber")]
        string CvNumber { get; set; }
    }

    // @interface InAppSDKMerchant : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface InAppSDKMerchant : INSCopying
    {
        // @property (copy, nonatomic) NSString * merchantID;
        [Export("merchantID")]
        string MerchantID { get; set; }

        // @property (copy, nonatomic) NSString * merchantReferenceCode;
        [Export("merchantReferenceCode")]
        string MerchantReferenceCode { get; set; }

        // @property (copy, nonatomic) NSString * passwordDigest;
        [Export("passwordDigest")]
        string PasswordDigest { get; set; }

        // @property (copy, nonatomic) NSString * userName;
        [Export("userName")]
        string UserName { get; set; }
    }

    // @interface InAppSDKError : NSError
    [BaseType(typeof(NSError))]
    interface InAppSDKError
    {
        // @property (copy, nonatomic) NSString * extraMessage;
        [Export("extraMessage")]
        string ExtraMessage { get; set; }

        // +(id)errorWithCode:(NSInteger)paramCode;
        [Static]
        [Export("errorWithCode:")]
        NSObject ErrorWithCode(nint paramCode);

        // +(NSDictionary *)userInfoWithErrorCode:(NSInteger)paramCode;
        [Static]
        [Export("userInfoWithErrorCode:")]
        NSDictionary UserInfoWithErrorCode(nint paramCode);

        // +(NSString *)stringWithError:(NSError *)paramError;
        [Static]
        [Export("stringWithError:")]
        string StringWithError(NSError paramError);
    }

    // @interface InAppSDKGatewayError : InAppSDKError
    [BaseType(typeof(InAppSDKError))]
    interface InAppSDKGatewayError
    {
        // +(BOOL)isGatewayErrorCode:(NSInteger)paramErrorCode;
        [Static]
        [Export("isGatewayErrorCode:")]
        bool IsGatewayErrorCode(nint paramErrorCode);
    }

    // @interface InAppSDKAddress : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface InAppSDKAddress : INSCopying
    {
        // @property (copy, nonatomic) NSString * firstName;
        [Export("firstName")]
        string FirstName { get; set; }

        // @property (copy, nonatomic) NSString * lastName;
        [Export("lastName")]
        string LastName { get; set; }

        // @property (copy, nonatomic) NSString * postalCode;
        [Export("postalCode")]
        string PostalCode { get; set; }
    }
}


