//using System;
//using System.Threading.Tasks;
//using Com.Cybersource.Inappsdk.Common.Error;
//using Com.Cybersource.Inappsdk.Connectors.Inapp;
//using Com.Cybersource.Inappsdk.Datamodel.Response;
//using Com.Cybersource.Inappsdk.Datamodel.Transaction;
//using Com.Cybersource.Inappsdk.Datamodel.Transaction.Callbacks;
//using Com.Cybersource.Inappsdk.Datamodel.Transaction.Fields;
//using TruliteMobile.Droid.PlatformSpecific;
//using TruliteMobile.Interfaces;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(CybersourceEncryptPaymentData))]
//namespace TruliteMobile.Droid.PlatformSpecific
//{
//    public class CybersourceEncryptPaymentData : ICybersourceEncryptPaymentData
//    { 
//        public async Task<GatewayDelegateResponse> PerformPaymentDataEncryption(bool envTest, MerchantData merchantData, AddressData addressData, CardData cardData)
//        {
//            // Parameters:
//            // 1) Context - current context
//            // 2) InAppSDKApiClient.Environment - CYBS ENVIRONMENT
//            // 3) API_LOGIN_ID String - merchant's API LOGIN ID
//            var apiConnectionCallback = new ApiConnectionCallback();
//            var apiClient = new InAppSDKApiClient.Builder(Android.App.Application.Context,
//                                          envTest ? InAppSDKApiClient.Environment.EnvTest : InAppSDKApiClient.Environment.EnvProd,
//                                          merchantData.MerchantID)
//                                          .SdkConnectionCallback(apiConnectionCallback)
//                                          // receive callbacks for connection results
//                                          //.SdkApiProdEndpoint(PAYMENTS_PROD_URL) // option to configure PROD Endpoint
//                                          //.SdkApiTestEndpoint(PAYMENTS_TEST_URL) // option to configure TEST Endpoint
//                                          //.SdkConnectionTimeout(5000) // optional connection time out in milliseconds
//                                          //.TransactionNamespace(TRANSACT_NAMESPACE) // optional
//                                          .Build();
//            var transactionObjectBuilder = SDKTransactionObject
//              // Type of transaction object 
//              .CreateTransactionObject(SDKTransactionType.SdkTransactionEncryption);

//            // Merchant reference code can be set to anything meaningful
//            transactionObjectBuilder.MerchantReferenceCode(merchantData.MerchantReferenceCode);
//            // Card data to be encrypted
//            transactionObjectBuilder.CardData(PrepareCardData(cardData));
//            // Optional billing info
//            transactionObjectBuilder.BillTo(PrepareBillingInfo(addressData));

//            var transactionObject = transactionObjectBuilder.Build();

//            apiClient.PerformApi(InAppSDKApiClient.Api.ApiEncryption, transactionObject, merchantData.PasswordDigest);

//            return await apiConnectionCallback.ResponseTaskCompletionSource.Task.ConfigureAwait(false);
//        }

//        private SDKBillTo PrepareBillingInfo(AddressData addressData)
//        {
//            SDKBillTo billTo = new SDKBillTo.Builder()
//                .FirstName(addressData.FirstName)
//                .LastName(addressData.LastName)
//                .PostalCode(addressData.PostalCode)
//                .Build();
//            return billTo;
//        }

//        private SDKCardData PrepareCardData(CardData cardData)
//        {
//            SDKCardData cardDataObject = new SDKCardData.Builder(cardData.AccountNumber,
//                                                cardData.ExpirationMonth , // MM
//                                                cardData.ExpirationYear) // YYYY
//                                                .CvNumber(cardData.CvNumber) // Optional
//                                                .Type(SDKCardAccountNumberType.Pan) // Optional if unencrypted. If the value is set to a token then it is not optional and must be set to SDKCardType.TOKEN
//                                                .Build();
//            return cardDataObject;
//        }

//        private class ApiConnectionCallback : Java.Lang.Object, ISDKApiConnectionCallback
//        {
//            public TaskCompletionSource<GatewayDelegateResponse> ResponseTaskCompletionSource { get; private set; }

//            public ApiConnectionCallback()
//            {
//                ResponseTaskCompletionSource = new TaskCompletionSource<GatewayDelegateResponse>();
//            }

//            public void OnApiConnectionFinished(SDKGatewayResponse p0)
//            {
//                ResponseTaskCompletionSource.TrySetResult(new GatewayDelegateResponse()
//                {
//                    RequestId = p0.RequestId,
//                    ResultCode = p0.ReasonCode.ReasonCode.ToString(),
//                    EncryptedPaymentData = p0.EncryptedPaymentData,
//                    IsAccepted = p0.Decision == SDKResponseDecision.SdkAccept,
//                    ErrorMessage = null
//                });
//            }

//            public void OnErrorReceived(ISDKError p0)
//            {
//                ResponseTaskCompletionSource.TrySetResult(new GatewayDelegateResponse()
//                {
//                    IsAccepted = false,
//                    ErrorMessage = p0.ErrorExtraMessage
//                });
//            }
//        }
//    }
//}
