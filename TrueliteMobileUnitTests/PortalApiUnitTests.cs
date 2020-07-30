using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TruliteMobile.Enums;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.Views.Quotes;

namespace TrueliteMobileUnitTests
{
    [TestClass]
    public class PortalApiUnitTests
    {
        [TestInitialize]
        public async Task Init()
        {
            Api = new ApiService();
            SettingsService._instance = new TestSettings();
            await InitPortalUser();
        }


        public ApiService Api { get; set; }

        #region Token
        private GetTokenResponse token;

        public async Task InitPortalUser()
        {
            token = await Api.GetToken("tester@baal.com", "Password1234");
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
            token = await Api.GetToken("tester@baal.com", "Password1234");
            Assert.IsFalse(string.IsNullOrWhiteSpace(token?.access_token));

        }
        [TestMethod]
        public async Task GetCustomerInfo()
        {
            var info = await Api.GetMyInfo();
            Assert.IsTrue(info?.Successful.GetValueOrDefault()??false);

        }


        #endregion

        #region Orders

        [TestMethod]
        public async Task GetOrders()
        {
            var orderFilter = new OrderFilter
            {
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2019, 6, 12)
            };
            var orders = await Api.GetOrders(new OrderFilter());
            Assert.IsTrue(orders?.Successful.GetValueOrDefault()??false);

        } 



        #endregion

        #region Documents
        [TestMethod]
        public async Task GetDocuments()
        {
            var documents = await Api.GetDocuments(new CustomerContext
            {
                AXCustomerId = SettingsService.Instance.AxCustomerId
            });
         ///   Assert.IsTrue(documents.Any());

        }

        [TestMethod]
        public async Task DownloadDocument()
        {
            var data = await Api.GetDocumentCopy(Guid.Parse("0717726f-2593-e611-80c3-000d3a12ccbb"));
            Assert.IsTrue(data.Length > 0);
        } 
        #endregion


        #region Invoices

        [TestMethod]
        public async Task GetInvoices()
        {
            var responseOfListOfInvoice = await Api.GetInvoiceList(new InvoicesFilterModel());
            Assert.IsTrue(responseOfListOfInvoice.Successful.GetValueOrDefault());
        }

        [TestMethod]
        public async Task GetInvoiceLines()
        {
            var responseOfListOfInvoice = await Api.GetInvoiceList(new InvoicesFilterModel());
            Assert.IsTrue(responseOfListOfInvoice.Successful.GetValueOrDefault());
            Assert.IsTrue(responseOfListOfInvoice.Data.Any());
            var responseOfListOfInvoiceLine = await Api.GetInvoiceLines(responseOfListOfInvoice.Data.First());
            Assert.IsTrue(responseOfListOfInvoiceLine.Successful.GetValueOrDefault());

        }

        [TestMethod]
        public async Task GetInvoiceCopy()
        {
            var responseOfListOfInvoice = await Api.GetInvoiceList(new InvoicesFilterModel());
            Assert.IsTrue(responseOfListOfInvoice.Successful.GetValueOrDefault());
            Assert.IsTrue(responseOfListOfInvoice.Data.Any());
            var responseOfListOfInvoiceLine = await Api.GetInvoiceCopy(responseOfListOfInvoice.Data.First().Key);
            Assert.IsTrue(responseOfListOfInvoiceLine.Length>0);

        }

        #endregion


        #region PackingSlip
        [TestMethod]
        public async Task GetPackingSlips()
        {
            var result = await Api.GetPackingSlips(new PackingSlipsQueryContext()
            {
                CustomerInfo = Api.GetCustomerContext()
            });
            Assert.IsTrue(result?.Successful.GetValueOrDefault()??false);
            var data = result.Data;
            Assert.IsTrue(data.Any());
        }

        [TestMethod]
        public async Task GetPackingSlipsLines()
        {

            var result = await Api.GetPackingSlips(new PackingSlipsQueryContext()
            {
                CustomerInfo = Api.GetCustomerContext()
            });
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);
          
        }

        [TestMethod]
        public async Task GetPackingSlipPdf()
        {
            var result = await Api.GetPackingSlips(new PackingSlipsQueryContext
            {
                CustomerInfo = Api.GetCustomerContext()
            });
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);
            var packingSlip = result.Data.First();
            var pdfData = await Api.GetPackageSlipCopy(packingSlip.Key, packingSlip.DateShipped.GetValueOrDefault(),
                packingSlip.Order.Key);
            Assert.IsTrue(pdfData.Length > 0);
        }

        #endregion
      

        #region Menu Statistics

        [TestMethod]
        public async Task GetInvoiceAmounts()
        {
            var data = await Api.GetOpenInvoicesAmount();
            Assert.IsTrue(data > 0);
        }

        [TestMethod]
        public async Task GetSalesOrderCount()
        {
            var data = await Api.GetOpenSalesOrdersCount();
            Assert.IsTrue(data > 0);
        }

        [TestMethod]
        public async Task GetCreditLimits()
        {
            var result = await Api.GetCustomerCreditLimits();
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);

        }
        #endregion


        #region Financial Statement

        [TestMethod]
        public async Task GetFinancialStatement()
        {
            var data = await Api.GetFinancialStatement(new CustomerStatementQueryContext
            {
                CustomerInfo = Api.GetCustomerContext()
            });
            Assert.IsTrue(data.Length > 0);
        }
        #endregion

        #region Notifications


        [TestMethod]
        public async Task GetNotifications()
        {

            var result = await Api.GetNotifications(new CustomerNotificationsQueryContext
            {
                CustomerInfo = Api.GetCustomerContext(),
                FromDate = DateTimeOffset.Now.AddDays(-60),
                ToDate = DateTimeOffset.Now

            });
            Assert.IsTrue(result?.Successful.GetValueOrDefault() ?? false);

        }
        #endregion

        #region Quotations


        [TestMethod]
        public async Task GetQuotations()
        {
            var data = await Api.GetQuotes(new QuoteFilter());
            Assert.IsTrue(data.Any());
        }

        [TestMethod]
        public async Task GetQuotationsLine()
        {
            var quotes = await Api.GetQuotes(new QuoteFilter());
            var quote = quotes.First();
            var pdfData = await Api.GetQuotationCopy(quote.Key);
            Assert.IsTrue(pdfData.Length>0);
        }

        #endregion
    }
}
