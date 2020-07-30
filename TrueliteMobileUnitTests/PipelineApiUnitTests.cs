using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TruliteMobile.Enums;
using TruliteMobile.Services;

namespace TrueliteMobileUnitTests
{
    [TestClass]
    public class PipelineApiUnitTests
    {
        public ApiService Api { get; set; }


        [TestInitialize]
        public async Task Init()
        {
            Api = new ApiService();
            SettingsService._instance = new TestSettings();
            await UnitDriverUser();
        }
        private GetTokenResponse token;
        private async Task UnitDriverUser()
        {
            token = await Api.GetToken("bs@sc.com", "bassam", false);
            SettingsService.Instance.Token = token.access_token;
            SettingsService.Instance.TokenExpiration = DateTime.Now.AddSeconds(token.expires_in);

            var infoResult = await ApiService.Instance.GetMyInfo();
            var infoData = infoResult.Data;
            SettingsService.Instance.AxCustomerId = infoData.CustomerInfo.Key;
            SettingsService.Instance.MyInfo = infoData;
        }


        [TestMethod]
        public async Task GetTokenForPipelineUser()
        {
            token = await Api.GetToken("bs@sc.com", "bassam", false);

        }

        [TestMethod]
        public async Task GetCustomerInfo()
        {
            var info = await Api.GetMyInfo();
            Assert.IsTrue(info?.Successful.GetValueOrDefault() ?? false);

        }

        [TestMethod]
        public async Task GetSalesQuotationInquiry()
        {
            var info = await Api.GetSalesQuotationInquiry(new SalesInquiryContext
            {
                SalesGroup = "204",
                FromExpiryDate = new DateTimeOffset(new DateTime(2019,05,01))
            });
            Assert.IsTrue(info?.Successful.GetValueOrDefault() ?? false);

        }

        [TestMethod]
        public async Task GetBranches()
        {
            var branchesResult = await Api.GetBranches();
            Assert.IsTrue(branchesResult?.Successful.GetValueOrDefault()??false);
        }


        [TestMethod]
        public async Task GetCustomerTruliteContact()
        {
            var info = await Api.GetCustomerTruliteContact();
            Assert.IsTrue(info?.Successful.GetValueOrDefault() ?? false);

        }

        
    }
}
