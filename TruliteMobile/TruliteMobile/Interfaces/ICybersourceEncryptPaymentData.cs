using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TruliteMobile.Interfaces
{
    public interface ICybersourceEncryptPaymentData
    {
        Task<GatewayDelegateResponse> PerformPaymentDataEncryption(bool envTest, MerchantData merchantData,
            AddressData addressData,
            CardData cardData
            );
    }

    public class GatewayDelegateResponse
    {
        public string RequestId { get; set; }
        public string ResultCode { get; set; }
        public string EncryptedPaymentData { get; set; }
        public bool IsAccepted { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AddressData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }

        public AddressData(string firstName, string lastName, string postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            PostalCode = postalCode;
        }
    }

    public class MerchantData
    {
        public string MerchantID { get; set; }
        public string MerchantReferenceCode { get; set; }
        public string PasswordDigest { get; set; }
        public string UserName { get; set; }

        public MerchantData(string userName, string merchantID, string merchantReferenceCode, string passwordDigest)
        {
            MerchantID = merchantID;
            MerchantReferenceCode = merchantReferenceCode;
            PasswordDigest = passwordDigest;
            UserName = userName;
        }
    }

    public class CardData
    {
        public string AccountNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string CvNumber { get; set; }

        public CardData(string accountNumber, string expirationMonth, string expirationYear, string cvNumber)
        {
            AccountNumber = accountNumber;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            CvNumber = cvNumber;
        }
    }


    public class InAppSDKDemoSignatureGenerator
    {

        public static readonly string InAppTestUserName = "testrest";
        public static readonly string InAppTestMerchantID = "testrest";
        public static readonly string InAppTestMerchantReferenceNumber = "InAppSDKDemo_12345";
        public static readonly string InAppSDKDemoTestTransactionSecretKey = "v6ine2CxLgv/0tAZaUL72RH38frW/QrkBhbTAhQiOjq2uY1Mn9zdFftQYb9YlCqXrF2sE+zrh1HMoooEHUUJ3P3S2KNQriVzSWhsxc9+kAZRsqk5lIn1YxpryXjMlhTyb8nQqKcRaQeObrzJaQ3kWB8NGJDdrKCyO6emevzKz0/YnBJW8k7w14GDLOfaEb9IC/Kz70Cb7icUwS2WVqg5JCOb676j2jrXKqMugOl/2WRBwRTlVo20QkEjk1aQTg1VTWuzHIbl3vjlFQGL1xGahyJ1ELUibQGkScrzBdRciAe3zNfyjHobl8BxFUcL6bHMMWP2o5t57ensJbjDh2PfZQ==";


        //-------WARNING!----------------
        // This part of the code that generates the Signature is present here only to show as the sample.
        // Signature generation should be done at the Merchant Server.

        public String GenerateDEMOSignature(String merchantId,
                                String transactionSecretKey,
                               String merchantReferenceCode)
        {
            String fingerprintDateString = FormatFingerprintDate();
            String merchantTransKey = transactionSecretKey;

            String fgComponents = String.Format("{0}{1}{2}{3}", StringSha1(merchantTransKey), merchantId, merchantReferenceCode, fingerprintDateString);

            Console.WriteLine("FP Components Before Hash:" + fgComponents);
            //NSLog(@"FP Components Before Hash: %@",fgComponents);

            String hashedFgComponents = StringHmacSha256(fgComponents);
            return String.Format("{0}#{1}", hashedFgComponents, fingerprintDateString);

        }

        private String FormatFingerprintDate()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        private String StringSha1(String value)
        {
            byte[] key = System.Text.Encoding.UTF8.GetBytes(value);
            byte[] bytes;
            using (SHA1 sha1 = SHA1.Create())
            {
                bytes = sha1.ComputeHash(key);
            }
            var hashString = StringHexEncode(bytes);
            //Console.WriteLine("StringSha1:" + hashString);
            return hashString;
        }

        private String StringHmacSha256(String value)
        {
            byte[] key = System.Text.Encoding.UTF8.GetBytes(value);
            byte[] bytes;
            using (HMACSHA256 sha256 = new HMACSHA256(key))
            {
                bytes = sha256.ComputeHash(key);
            }
            var hashString = StringHexEncode(bytes);

            //Console.WriteLine("StringHmacSha256:" + hashString);
            return hashString;
        }

        public string StringHexEncode(byte[] bytes)
        {
            StringBuilder hash = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
            {
                var hexInt = 0xFF & bytes[i];
                String hex = hexInt.ToString("x2");
                if (hex.Length == 1)
                {
                    hash.Append('0');
                }
                hash.Append(hex);
            }
            var hashString = hash.ToString();
            return hashString;
        }
    }
}
