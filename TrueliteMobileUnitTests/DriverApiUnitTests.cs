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
    public class DriverApiUnitTests
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
            token = await Api.GetToken("Drv101", "bassam",true);
            SettingsService.Instance.Token = token.access_token;
            SettingsService.Instance.TokenExpiration = DateTime.Now.AddSeconds(token.expires_in);

            var infoResult = await ApiService.Instance.GetMyInfo();
            var infoData = infoResult.Data;
            SettingsService.Instance.AxCustomerId = infoData.CustomerInfo.Key;
            SettingsService.Instance.MyInfo = infoData;
        }


        [TestMethod]
        public async Task GetTokenForPortalUser()
        {
            token = await Api.GetToken("Drv101", "bassam", true);
            Assert.IsFalse(string.IsNullOrWhiteSpace(token?.access_token));

        }

        [TestMethod]
        public async Task GetCustomerInfo()
        {
            var info = await Api.GetMyInfo();
            Assert.IsTrue(info?.Successful.GetValueOrDefault() ?? false);

        }


        [TestMethod]
        public async Task GetRoutes()
        {
            var result = await Api.GetDriverRoutes();
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);

        }

        [TestMethod]
        public async Task GetPackingSlipsNotInvoiced()
        {
            var filter = new PackingSlipsQueryContext
            {
                SelectedQty = 50,
                CustomerInfo = Api.GetCustomerContext(),
                InventLocationId = SettingsService.Instance.MyInfo.CurrentUser.UserBranchCode
            };
            var result = await Api.GetPackingSlipsNotInvoiced(filter);
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);

        }


        [TestMethod]
        public async Task GetManifests()
        {
            ShipManifestHeadersQueryContext context = new ShipManifestHeadersQueryContext
            {
                ShippingDate = DateTimeOffset.Now,
                InventLocationId = SettingsService.Instance.MyInfo.CurrentUser.SiteBranchCode
            };
            var result = await Api.GetShipManifestHeaders(context);
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);

        }


    }
}
