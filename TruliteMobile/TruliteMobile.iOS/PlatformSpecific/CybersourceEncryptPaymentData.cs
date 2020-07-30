//using System;
//using System.Threading.Tasks;
//using InAppSDK;
//using TruliteMobile.Interfaces;
//using TruliteMobile.iOS.PlatformSpecific;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(CybersourceEncryptPaymentData))]
//namespace TruliteMobile.iOS.PlatformSpecific
//{
//    public class CybersourceEncryptPaymentData : ICybersourceEncryptPaymentData
//    {
       
//        public async Task<GatewayDelegateResponse> PerformPaymentDataEncryption(bool envTest, MerchantData merchantData, AddressData addressData, CardData cardData)
//        {
//            bool result;

//            //Initialize the InAppSDK for CYBS Gateway Environtment.
//            InAppSDKSettings.SharedInstance.InAppSDKEnvironment = envTest ? InappsdkEnvironment.Test : InappsdkEnvironment.Live;


//            InAppSDKSettings.SharedInstance.EnableLog = true;

//            //Initialize the transaction object which collects all the required information for the encrypt service.
//            //Refer: InAppSDKTransactionObject.h
//            InAppSDKTransactionObject transactionObject = new InAppSDKTransactionObject();


//            //Set First Name, Last Name and Postal Code. These are optional Values, not mandatory.
//            //Refer: InAppSDKAddress.h
//            transactionObject.BillTo = GetBillToData(addressData);

//            //Get and Set the Merchant specific credentials [merchantID, Signature, merchant Reference code etc.] 
//            //Refer: InAppSDKMerchant.h
//            transactionObject.Merchant = GetMerchantData(merchantData);

//            //Get and Set the Card specific details[ cardNumber, expirationMonth, expirationYear and cvNumber.] 
//            //Refer: InAppSDKCardData.h
//            transactionObject.CardData = GetCardData(cardData);

//            //Initialize the InAppSDK Gateway and call performPaymentDataEncryption and implement the Delegate.
//            InAppSDKGateway gateway = InAppSDKGateway.SharedInstance;

//            var gatewayDelegate = new SDKGatewayDelegate();
//            result = gateway.PerformPaymentDataEncryption(transactionObject, gatewayDelegate);

//            if (result)
//            {
//                return await gatewayDelegate.ResponseTaskCompletionSource.Task.ConfigureAwait(false);
//            }
//            else
//            {
//                return new GatewayDelegateResponse()
//                {
//                    IsAccepted = false,
//                    ErrorMessage = "Request is NOT Accepted. Verify the input values if any one is invalid."
//                };
//            }
//        }

//        private InAppSDKAddress GetBillToData(AddressData addressData)
//        {
//            InAppSDKAddress billToInfo = new InAppSDKAddress();
//            billToInfo.FirstName = addressData.FirstName;
//            billToInfo.LastName = addressData.LastName;
//            billToInfo.PostalCode = addressData.PostalCode;

//            return billToInfo;
//        }

//        private InAppSDKCardData GetCardData(CardData theCardData)
//        {
//            InAppSDKCardData cardData = new InAppSDKCardData();
//            cardData.AccountNumber = theCardData.AccountNumber;
//            cardData.ExpirationMonth = theCardData.ExpirationMonth;
//            cardData.ExpirationYear = theCardData.ExpirationYear;
//            cardData.CvNumber = theCardData.CvNumber;

//            return cardData;
//        }

//        private InAppSDKMerchant GetMerchantData(MerchantData theMerchantData)
//        {
//            InAppSDKMerchant merchantData = new InAppSDKMerchant();
//            merchantData.UserName = theMerchantData.UserName;
//            merchantData.MerchantID = theMerchantData.MerchantID;
//            merchantData.MerchantReferenceCode = theMerchantData.MerchantReferenceCode;
//            merchantData.PasswordDigest = theMerchantData.PasswordDigest;
//            return merchantData;
//        }


//        private class SDKGatewayDelegate : InAppSDK.InAppSDKGatewayDelegate
//        {
//            public TaskCompletionSource<GatewayDelegateResponse> ResponseTaskCompletionSource { get; private set; }
//            public SDKGatewayDelegate()
//            {
//                ResponseTaskCompletionSource = new TaskCompletionSource<GatewayDelegateResponse>();
//            }

//            public override void EncryptPaymentDataServiceFinishedWithGatewayResponse(InAppSDKGatewayResponse paramResponseData, InAppSDKError paramError)
//            {
//                if (paramError == null && paramResponseData != null)
//                {
//                    ResponseTaskCompletionSource.TrySetResult(new GatewayDelegateResponse()
//                    {
//                        RequestId = paramResponseData.RequestId,
//                        ResultCode = paramResponseData.ResultCode,
//                        EncryptedPaymentData = paramResponseData.EncryptedPayment == null ? null: paramResponseData.EncryptedPayment.Data,
//                        IsAccepted = paramResponseData.IsAccepted(),
//                        ErrorMessage = null
//                    });
//                }
//                else if (paramError != null) {
//                    ResponseTaskCompletionSource.TrySetResult(new GatewayDelegateResponse()
//                    {
//                        IsAccepted = false,
//                        ErrorMessage = paramError.LocalizedDescription
//                    });
//                }
//            }
//        }
//    }
//}
