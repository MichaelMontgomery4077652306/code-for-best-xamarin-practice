using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TruliteMobile.Enums;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Views.DrvRoutes;
using TruliteMobile.Views.Notifications;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Quotes;

namespace TruliteMobile.Services
{
    public class ApiService
    {

        private static ApiService _instance;
        public static ApiService Instance => _instance ?? (_instance = new ApiService());

        public async Task<ApiResponseOfListOfInventSite> GetCustomersBranch()
        {
            var result = await AXClient.Instance.GetCustomerBranchesAsync(Instance.GetCustomerContext());
            return result;

        }

        public async Task<ApiResponseOfListOfInvoice> GetInvoiceList(InvoicesFilterModel filter)
        {
            var result = await AXClient.Instance.GetInvoicesAsync(filter.ToInvoicesQueryContext());
            return result;
        }

        public async Task<IEnumerable<SalesOrderLine>> GetOrderLines(SalesOrder order)
        {

            var result = await AXClient.Instance.GetSalesOrderLinesAsync(new SalesOrderLineQueryContext
            {
                CustomerInfo = Instance.GetCustomerContext(),
                SalesOrder = order

            });
            if (result.Data == null)
            {
                return new List<SalesOrderLine>();
            }
            var list = new List<SalesOrderLine>(result.Data);
            return list;

        }

        public async Task<IEnumerable<Quotation>> GetQuotes(QuoteFilter filter)
        {

            var result = await AXClient.Instance.QuotationsAsync(filter.ToQueryContext());
            return result?.Data ?? new List<Quotation>();

        }

        public async Task<ApiResponseOfListOfSalesOrder> GetOrders(OrderFilter filter)
        {

            var result = await AXClient.Instance.GetSalesOrdersAsync(filter.ToQueryContext());
            return result;
        }

        public async Task<ApiResponseOfListOfDocumentUploadView> GetDocuments(CustomerContext filter)
        {
            var result = await AXClient.Instance.GetDocumentsAsync(filter)
                .ConfigureAwait(false);
            return result;

        }

        public async Task<byte[]> GetDocumentCopy(Guid documentId)
        {


            var context = new DocumentDownloadQueryContext()
            {
                CustomerInfo = this.GetCustomerContext(),
                DocumentId = documentId

            };
            var response = await AXClient.Instance.DownloadDocumentAsync(context);
            return response;
        }


        public IEnumerable<ReadMeModel> GetReadme()
        {
            List<ReadMeModel> lines = new List<ReadMeModel>();
            switch (SettingsService.Instance.ApplicationMode)
            {
                case ApplicationModeEnum.Portal:
                    {
                        lines = new List<ReadMeModel>
                    {

                        new ReadMeModel
                        {
                            FeatureId = 1,
                            Number = 1,
                            Description = "Initial version"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 2,
                            Number = 2,
                            Description = "Fixed main screen error handling"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 3,
                            Number = 3,
                            Description = "Read me will reflect version changes"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 4,
                            Number = 4,
                            Description = "Spinning wait indicator"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 5,
                            Number = 5,
                            Description = "Fixed spelling in Support Tickets screen"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 6,
                            Number = 6,
                            Description = "Implemented Financial Statement"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 7,
                            Number = 7,
                            Description = "Implemented Notifications API call"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 8,
                            Number = 8,
                            Description = "Fix for login task cancelled message"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 9,
                            Number = 9,
                            Description = "Fixed Packing Slip filter default start and end date"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 10,
                            Number = 10,
                            Description = "Implemented control to be shown when no results are found - similar to what happens in the web version"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 11,
                            Number = 11,
                            Description = "Quotes pages style updated"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 12,
                            Number = 12,
                            Description = "Multiple account switch implementation"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 13,
                            Number = 13,
                            Description = "Credit Limits added to Dashboard"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 14,
                            Number = 14,
                            Description = "Credit Limits display UI enhancements/support for multiple accounts"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 15,
                            Number = 15,
                            Description = "Returned Orders display added to Dashboard"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 16,
                            Number = 16,
                            Description = "Settlement information added to invoice detail screen"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 17,
                            Number = 17,
                            Description = "Fixed UI and filter issues with quotes pages"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 18,
                            Number = 18,
                            Description = "UI improvements on Orders and Sales Orders Line screen"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 19,
                            Number = 19,
                            Description = "Fix for Packing Slips API call error"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 20,
                            Number = 20,
                            Description = "Totals line in Invoices page will only show selected totals."
                        },
                        new ReadMeModel
                        {
                            FeatureId = 21,
                            Number = 21,
                            Description = "Invoice details page UI improvements"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 22,
                            Number = 22,
                            Description = "UI improvements on Notifications page"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 23,
                            Number = 23,
                            Description = "Push notification test"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 24,
                            Number = 24,
                            Description = "Users screens implementation"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 25,
                            Number = 25,
                            Description = "Payments implementation"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 26,
                            Number = 26,
                            Description = "UI Improvements"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 27,
                            Number = 27,
                            Description = "Orders Line Date changed implementation"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 28,
                            Number = 28,
                            Description = "UI improvements for Search Labels, Packing Slip Buttons visibility, Invoice Selection"
                        },

                    };
                    }
                    break;
                case ApplicationModeEnum.Driver:

                    {
                        lines = new List<ReadMeModel>
                    {

                        new ReadMeModel
                        {
                            FeatureId = 1,
                            Number = 1,
                            Description = "Initial version"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 2,
                            Number = 2,
                            Description = "Routes screen UI update"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 2,
                            Number = 2,
                            Description = "Implemented report packing slip issue"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 3,
                            Number = 3,
                            Description = "Implemented sign UI"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 4,
                            Number = 4,
                            Description = "Implemented manifests screens"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 5,
                            Number = 5,
                            Description = "Implemented packing slip signature page"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 6,
                            Number = 6,
                            Description = "Implemented repacking screens"
                        },
                        new ReadMeModel
                        {
                            FeatureId = 7,
                            Number = 7,
                            Description = "Implemented turn by turn navigation when opening map from packing slip"
                        },
                    };
                    }
                    break;
                case ApplicationModeEnum.Pipeline:
                    {
                        lines = new List<ReadMeModel>
                        {

                            new ReadMeModel
                            {
                                FeatureId = 1,
                                Number = 1,
                                Description = "Initial version"
                            },
                            new ReadMeModel
                            {
                                FeatureId = 2,
                                Number = 2,
                                Description = "Customers screen implementation"
                            },
                            new ReadMeModel
                            {
                                FeatureId = 3,
                                Number = 3,
                                Description = "User Switch"
                            },

                        };
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            return lines;
        }

        public async Task<ApiResponseOfListOfPackingSlip> GetPackingSlips(PackingSlipsQueryContext filter)
        {

            var result = await AXClient.Instance.PackingSlipsAsync(filter);
            return result;
        }

        public async Task<ApiResponseOfListOfPackingSlipLine> GetPackingSlipsLines(PackingSlipLineQueryContext filter)
        {
            var result = await AXClient.Instance.GetPackingSlipLinesAsync(filter);
            return result;
        }

        public HttpClient GetHttpClient(string baseUrl = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl ?? SettingsService.BASER_URL)
            };

            return client;
        }

        public async Task<GetTokenResponse> GetToken(string username, string password, bool isDriver = false, string customerId = null, string company = "AAG")
        {
            const string url = "/Token";
            try
            {
                var client = GetHttpClient();

                var values = new Dictionary<string, string>
                {
                    {"username", username},
                    {"password", password},
                    {"grant_type", "password"},
                    {"x_company", company}


                };
                if (isDriver)
                {
                    values.Add("scope", "Driver");
                }

                if (customerId != null)
                {
                    values.Add("x_ax_customer_id", customerId);
                }

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url, content);

                var responseString = await response.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                var responseObject = JsonConvert.DeserializeObject<GetTokenResponse>(responseString);
                return responseObject;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        //public async Task<IEnumerable<SalesPool>> GetDriverRoutes(string inventSiteId)
        //{

        //    var result = null;// await AXClient.Instance.GetSalesRoutesAsync(inventSiteId);
        //    return result?.Data ?? new List<SalesPool>();

        //}

        public CustomerContext GetCustomerContext()
        {
            if (string.IsNullOrWhiteSpace(SettingsService.Instance.AxCustomerId))
            {
                return null;
            }
            return new CustomerContext
            {
                AXCustomerId = SettingsService.Instance.AxCustomerId,
                GroupJobAccounts = SettingsService.Instance.GroupByAccount
            };
        }

        public async Task<decimal> GetOpenInvoicesAmount()
        {
            var returnValue = await AXClient.Instance.GetOpenInvoicesAmountAsync(GetCustomerContext())
                .ConfigureAwait(false);
            if (returnValue.Successful.GetValueOrDefault())
            {
                return (decimal)returnValue.Data.GetValueOrDefault();
            }

            return 0m;

        }



        /// <summary>
        /// Get the PDF file data for a Quotation
        /// </summary>
        /// <param name="quotationId">Id of the Invoice</param>
        /// <returns>byte array for the PDF file</returns>
        public async Task<byte[]> GetQuotationCopy(string quotationId)
        {


            var context = new QuotationsQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                Id = quotationId
            };
            var response = await AXClient.Instance.GetCopyQuotationAsync(context)
                .ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// Get the PDF file data for an Invoice
        /// </summary>
        /// <param name="invoiceId">Id of the Invoice</param>
        /// <returns>byte array for the PDF file</returns>
        public async Task<byte[]> GetInvoiceCopy(string invoiceId)
        {


            var context = new InvoicesQueryContext()
            {
                CustomerInfo = GetCustomerContext(),
                InvoiceId = invoiceId

            };
            var response = await AXClient.Instance.GetCopyInvoiceAsync(context)
                .ConfigureAwait(false);
            return response;
        }


        /// <summary>
        /// Get the PDF file data for Packing Slip
        /// </summary>
        /// <param name="id">Id of the Packing Slio</param>
        /// <param name="date">Packing Slip Shipped Date</param>
        /// <param name="salesOrderId">Packing Slip Sales Order ID</param>
        /// <returns>byte array for the PDF file</returns>
        public async Task<byte[]> GetPackageSlipCopy(string id, DateTimeOffset date, string salesOrderId)
        {


            var context = new PackingSlipsQueryContext()
            {
                CustomerInfo = GetCustomerContext(),
                Id = id,
                PackingSlipDate = date,
                SalesOrderId = salesOrderId


            };
            var response = await AXClient.Instance.GetCopyPackingSlipAsync(context)
                .ConfigureAwait(false);
            return response;
        }


        public async Task<ApiResponseOfInt32> GetSupportTicketsCount()
        {
            return await AXClient.Instance.GetOpenTicketsCountAsync()
                .ConfigureAwait(false);
        }
        public async Task<long> GetOpenSalesOrdersCount()
        {
            var returnValue = await AXClient.Instance.GetOpenSalesOrdersCountAsync(GetCustomerContext())
                .ConfigureAwait(false);
            return returnValue.Successful.GetValueOrDefault() ? returnValue.Data.GetValueOrDefault() : 0;
        }

        public async Task<long> GetOpenReturnOrdersCount()
        {
            var returnValue = await AXClient.Instance.GetOpenReturnOrdersCountAsync(GetCustomerContext())
                .ConfigureAwait(false);
            return returnValue.Successful.GetValueOrDefault() ? returnValue.Data.GetValueOrDefault() : 0;
        }

        public async Task<IEnumerable<QuotationLine>> GetQuotesLines(string quoteId)
        {
            var filter = new QuotationLinesQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                Id = quoteId
            };
            var response = await AXClient.Instance.GetQuotationLinesAsync(filter)
                .ConfigureAwait(false);
            return response.Data;
        }


        /// <summary>
        /// The date from this endpoint is used in a customer’s Dashboard page:
        /// </summary>
        /// <param name="startDateTime">Start date</param>
        /// <param name="endDateTime">End data</param>
        /// <param name="summaryPeriod">Period</param>
        /// <returns>Chart data</returns>
        public async Task<ICollection<ChartDataPointOfString>> GetSalesOrdersSummaryByStatus(DateTimeOffset startDateTime, DateTimeOffset endDateTime, SalesOrderSummaryQueryContextSummaryPeriod summaryPeriod = SalesOrderSummaryQueryContextSummaryPeriod.Day)
        {
            var response = await AXClient.Instance.GetSalesOrdersSummaryByStatusAsync(new SalesOrderSummaryQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                SummaryPeriod = summaryPeriod,
                StartDate = startDateTime,
                EndDate = endDateTime
            }).ConfigureAwait(false);
            return response.Data;
        }


        public async Task<ICollection<ChartDataPointOfDateTime>> GetSalesOrdersSummary(DateTimeOffset startDateTime, DateTimeOffset endDateTime, SalesOrderSummaryQueryContextSummaryPeriod summaryPeriod = SalesOrderSummaryQueryContextSummaryPeriod.Day)
        {
            var response = await AXClient.Instance.GetSalesOrderSummaryAsync(new SalesOrderSummaryQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                SummaryPeriod = summaryPeriod,
                StartDate = startDateTime,
                EndDate = endDateTime
            }).ConfigureAwait(false);
            return response.Data;
        }


        /// <summary>
        /// The data from this endpoint is used in the Invoices Monthly section of the Dashboard page.
        /// </summary>
        /// <param name="startDateTime"></param>
        /// <param name="endDateTime"></param>
        /// <param name="summaryPeriod"></param>
        /// <returns></returns>
        public async Task<ICollection<ChartDataPointOfDateTime>> GetInvoicesSummary(DateTimeOffset startDateTime, DateTimeOffset endDateTime, SalesOrderSummaryQueryContextSummaryPeriod summaryPeriod = SalesOrderSummaryQueryContextSummaryPeriod.Day)
        {
            var response = await AXClient.Instance.GetInvoicesSummaryAsync(new SalesOrderSummaryQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                SummaryPeriod = summaryPeriod,
                StartDate = startDateTime,
                EndDate = endDateTime
            }).ConfigureAwait(false);
            return response.Data;
        }

        public async Task<ICollection<ChartDataPointOfDateTime>> GetReturnOrderSummary(DateTimeOffset startDateTime, DateTimeOffset endDateTime, SalesOrderSummaryQueryContextSummaryPeriod summaryPeriod = SalesOrderSummaryQueryContextSummaryPeriod.Day)
        {
            var response = await AXClient.Instance.GetReturnOrderSummaryAsync(new SalesOrderSummaryQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                SummaryPeriod = summaryPeriod,
                StartDate = startDateTime,
                EndDate = endDateTime
            }).ConfigureAwait(false);
            return response.Data;
        }

        /// <summary>
        /// The data from this endpoint is used in the Price Letters page in Customer Portal.
        /// To get to the Price Letters page, please click on the Price Letters menu item on the left side navigation.
        /// </summary>
        /// <returns>PDF data</returns>
        public async Task<byte[]> GetPriceLetterCopy()
        {

            var response = await AXClient.Instance.GetCopyPriceLetterAsync(GetCustomerContext())
                .ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// This endpoint is called when a user downloads a copy of a sales order.
        /// To download a sales order copy, please to the Orders page, then click
        /// the download button (cloud icon) next to a sales order row in the grid.
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> GetConfirmationCopy(string salesOrderNo)
        {
            var context = new SalesOrderQueryContext
            {
                CustomerInfo = GetCustomerContext(),
                SalesOrderNo = salesOrderNo,

            };
            var response = await AXClient.Instance.GetCopyConfirmationAsync(context)
                .ConfigureAwait(false);
            return response;
        }


        public async Task<string> ConfirmQuotation(string quotationId)
        {
            var response = await AXClient.Instance.ConfirmQuotationAsync(quotationId, GetCustomerContext())
                .ConfigureAwait(false);
            return response.Data;
        }

        public async Task<ApiResponseOfBoolean> AddBranchTicket(NewTruDeskItemQueryContext context)
        {
            return await AXClient.Instance.AddBranchTicketAsync(context);
        }
        public async Task<ApiResponseOfListOfCustomerBranchView> GetTicketBranches()
        {
            return await AXClient.Instance.GetTicketBranchesAsync(GetCustomerContext())
                .ConfigureAwait(false);
        }

        public async Task<ICollection<TruDeskItem>> GetBranchTickets(BranchTicketsQueryContext filter)
        {
            filter.CustomerInfo = GetCustomerContext();
            var response = await AXClient.Instance.GetBranchTicketsAsync(filter)
                .ConfigureAwait(false);
            return response.Data;
        }


        public Task<ApiResponseOfMyInfoViewModel> GetMyInfo(CustomerContext context)
        {
            return MyClient.Instance.GetInfoAsync(context);
        }

        public async Task<ApiResponseOfListOfInvoiceLine> GetInvoiceLines(Invoice invoice)
        {
            var context = new InvoicesQueryLineContext
            {
                CustomerInfo = GetCustomerContext(),
                Invoice = invoice
            };


            var result = await AXClient.Instance.GetInvoiceLinesAsync(context)
                .ConfigureAwait(false);

            return result;
        }

        public async Task<ApiResponseOfCustomerContact> GetCustomerTruliteContact()
        {
            var result = await AXClient.Instance.GetCustomerTruliteContactAsync(GetCustomerContext())
                .ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResponseOfListOfSalesPool> GetDriverRoutes()
        {
            var code = SettingsService.Instance.MyInfo.CurrentUser.SiteBranchCode;
            var result = await AXClient.Instance.GetSalesRoutesAsync(code)
                .ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResponseOfListOfPackingSlip> GetPackingSlipsNotInvoiced(PackingSlipsQueryContext ctx)
        {

            var result = await AXClient.Instance.GetPackingSlipsNotInvoicedAsync(ctx)
                .ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResponseOfBoolean> PostReadyToInvoicePackingSlips(IEnumerable<long> ids)
        {
            var result = await AXClient.Instance.PostReadyToInvoicePackingSlipsAsync(ids)
                .ConfigureAwait(false);
            return result;
        }
        public async Task<ApiResponseOfBoolean> PostUndoReadyToInvoicePackingSlipsAsync(IEnumerable<long> ids)
        {
            var result = await AXClient.Instance.PostUndoReadyToInvoicePackingSlipsAsync(ids)
                .ConfigureAwait(false);
            return result;
        }


        public async Task<byte[]> GetFinancialStatement(CustomerStatementQueryContext context)
        {
            var result = await AXClient.Instance.GetCustomerAccountStatementAsync(context)
                .ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResponseOfListOfCustomerNotification> GetNotifications(CustomerNotificationsQueryContext context)
        {
            var result = await AXClient.Instance.GetCustomerNotificationsAsync(context);
            return result;
        }
        public async Task<ApiResponseOfBoolean> MarkNotificationRead(CustomerNotification context)
        {
            var result = await AXClient.Instance.CustomerNotificationReadStateAsync(context);
            return result;
        }

        public async Task<ApiResponseOfListOfDynamicCustomer> GetAccounts(CustomerContext context)
        {
            var result = await AXClient.Instance.GetCustomerAccountsAsync(context).ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResponseOfListOfDynamicCustomer> GetCustomers(GetCustomersSearchContext context)
        {

            var result = await AXClient.Instance.GetCustomersAsync(context).ConfigureAwait(false);
            return result;

        }

        public async Task<ApiResponseOfInt64> GetCustomerCount(GetCustomersSearchContext context)
        {
            return await AXClient.Instance.GetCustomersCountAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfCustomerCreditLimit> GetCustomerCreditLimits()
        {
            return await AXClient.Instance.GetCustomerCreditLimitsAsync(GetCustomerContext()).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfInvoiceSettlement> GetInvoiceSettlements(InvoiceSettlementsQueryContext context)
        {
            return await AXClient.Instance.GetInvoiceSettlementsAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfShipManifestHeader> GetShipManifestHeaders(ShipManifestHeadersQueryContext context)
        {
            return await AXClient.Instance.GetShipManifestHeadersAsync(context).ConfigureAwait(false);
        }


        public async Task<ApiResponseOfListOfSalesQuotationInquiry> GetSalesQuotationInquiry(SalesInquiryContext context)
        {

            return await AXClient.Instance.GetSalesQuotationInquiryAsync(context).ConfigureAwait(false);
        }

        public Task<ApiResponseOfListOfBranchView> GetBranches()
        {
            return AXClient.Instance.GetBranchesAsync();
        }


        public async Task<ApiResponseOfBoolean> CreateCustNotificationDevice(CreateCustNotificationDeviceContext context)
        {
            return await AXClient.Instance.CreateCustNotificationDeviceAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> DeleteCustNotificationDevice(UpdateDeleteCustNotificationDeviceContext context)
        {
            return await AXClient.Instance.DeleteCustNotificationDeviceAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> UpdateCustNotificationDevice(UpdateDeleteCustNotificationDeviceContext context)
        {
            return await AXClient.Instance.UpdateCustNotificationDeviceAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfCustNotificationDevice> GetCustNotificationDevice(CustomerContext context)
        {
            return await AXClient.Instance.GetCustNotificationDeviceAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfBoolean> ReportIssue(ReportIssueQueryContext context)
        {
            return await AXClient.Instance.ReportIssueAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfShipManifestDetail> GetShipManifestDetail(string manifestId)
        {
            return await AXClient.Instance.GetShipManifestDetailsAsync(manifestId).ConfigureAwait(false);
        }
        #region Signature

        public async Task<ApiResponseOfBoolean> PostSignature(SignatureQueryContext context)
        {
            return await AXClient.Instance.PostSignatureAsync(context).ConfigureAwait(false);
        }
        #endregion

        #region Portal Settings 

        public async Task<ICollection<PortalSetting>> GetPortalSettings(PortalSettingsQueryContext context)
        {
            return await AXClient.Instance.GetPortalSettingsAsync(context).ConfigureAwait(false);
        }

        #endregion


        #region Users
        public async Task<ApiResponseOfListOfKeyNameModelOfGuid> GetUserTimeZones()
        {
            return await AXClient.Instance.GetTimeZonesAsync()
                .ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfAppPermissionView> GetUserAppPermissions()
        {
            return await AXClient.Instance.GetAppPermissionsAsync()
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfKeyNameModelOfGuid> GetUserAccountStatuses()
        {
            return await AXClient.Instance.GetUserAccountStatusesAsync()
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfAppUserView> GetUsers(AppUsersQueryContext context)
        {
            return await AXClient.Instance.GetUsersAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfAppUserView> GetUserById(AppUsersQueryContext context)
        {
            return await AXClient.Instance.GetUserByIdAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<AppUserView> AddUser(AddAppUserView context)
        {
            return await AXClient.Instance.AddUserAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfAppUserView> EditUser(AppUserView context)
        {
            return await AXClient.Instance.EditUserAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfAppUserView> DeleteUser(AppUsersQueryContext context)
        {
            return await AXClient.Instance.DeleteUserAsync(context)
                .ConfigureAwait(false);
        }
        #endregion

        public async Task<ApiResponseOfMobileSignatureResponse> GenerateMobilePaymentSignatureAsync(MobileSignatureRequest request)
        {
            return await AXClient.Instance.GenerateMobilePaymentSignatureAsync(request).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfMobilePaymentResponse> ProcessMobilePaymentAsync(MobilePaymentRequest model)
        {
            return await AXClient.Instance.ProcessMobilePaymentAsync(model).ConfigureAwait(false);
        }


        #region Survey
        public async Task<ApiResponseOfBoolean> TakeSurvey(SurveyViewModel context)
        {
            return await AXClient.Instance.TakeSurveyAsync(context)
                .ConfigureAwait(false);
        }
        #endregion


        #region Repacking
        public async Task<ApiResponseOfListOfKeyNameModelOfString> GetRepackActions()
        {
            return await AXClient.Instance.GetRepackActionsAsync()
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfKeyNameModelOfString> GetRepackReasons()
        {
            return await AXClient.Instance.GetRepackReasonsAsync()
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfString> RepackPackingSlip(RepackRequestModel model)
        {
            return await AXClient.Instance.RepackPackingSlipAsync(model)
                .ConfigureAwait(false);
        }
        #endregion

        #region LienWaiver

        public async Task<ApiResponseOfListOfKeyNameModelOfString> GetListOfUsStates()
        {
            return await AXClient.Instance.GetStatesAsync()
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfWaiverType> GetWaiverTypes()
        {
            return await AXClient.Instance.GetWaiverTypesAsync()
                .ConfigureAwait(false);
        }

        public async Task<ApiResponseOfString> AddLienWaiver(LienWaiverModel model)
        {
            return await AXClient.Instance.AddLienWaiverAsync(model)
                .ConfigureAwait(false);
        }
        #endregion

        #region DateChanges
        public async Task<ApiResponseOfListOfCfmDlvDateTracking> GetOrderDateTrackingByOrder(string salesOrder)
        {
            return await AXClient.Instance.GetOrderDateTrackingByOrderAsync(salesOrder);
        }

        #endregion

        public async Task<ApiResponseOfResponse> MarkRouteCompleted(MarkRouteCompletedContext context)
        {
            return await AXClient.Instance.MarkRouteCompletedAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfInvoicePaymentView> GetPayments(CreditCardPaymentsQueryContext context)
        {
            return await AXClient.Instance.GetPaymentsAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfDictionaryStringBool> GetAccountPermissions()
        {
            return await AXClient.Instance.GetAccountPermissionsAsync().ConfigureAwait(false);
        }



        #region CreditCard

        public Task<ApiResponseOfListOfCustomerCreditCardTokenViewModel> GetCustomerCreditCardTokens(CustomerContext context)
        {
            return AXClient.Instance.GetCustomerCreditCardTokensAsync(context);

        }

        public async Task<ApiResponseOfBoolean> DeleteCustomerCreditCardToken(DeleteCustomerCreditCardToken context)
        {
            return await AXClient.Instance.DeleteCustomerCreditCardTokenAsync(context).ConfigureAwait(false);
        }

        public Task<ApiResponseOfBoolean> UpdateCustomerCreditCardToken(UpdateCreditCardTokenContext context)
        {
            return AXClient.Instance.UpdateCustomerCreditCardTokenAsync(context);
        }

        public async Task<ApiResponseOfListOfAppUserCreditCardTokenViewModel> GetAppUserCreditCardTokens(CustomerContext context)
        {
            return await AXClient.Instance.GetAppUserCreditCardTokensAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> UpdateAppUserCreditCardToken(UpdateCreditCardTokenContext context)
        {
            return await AXClient.Instance.UpdateAppUserCreditCardTokenAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> DeleteAppUserCreditCardToken(DeleteCustomerCreditCardToken context)
        {
            return await AXClient.Instance.DeleteAppUserCreditCardTokenAsync(context)
                .ConfigureAwait(false);
        }

        #endregion

        #region Password Reset

        public async Task<ApiResponseOfBoolean> ResetPasswordEmail(PasswordResetEmailQueryContext context)
        {
            return await AXClient.Instance.ResetPasswordEmailAsync(context).ConfigureAwait(false);
        }

        public async Task<ApiResponseOfBoolean> ResetPasswordPhone(PasswordResetPhoneQueryContext context)
        {
            return await AXClient.Instance.ResetPasswordPhoneAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfGuid> SendPasswordResetPhone(
            PasswordResetPhoneQueryContext context)
        {
            return await AXClient.Instance.SendPasswordResetPhoneAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfGuid> SendPasswordResetEmail(
            PasswordResetEmailQueryContext context)
        {
            return await AXClient.Instance.SendPasswordResetEmailAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> ResetPasswordByAdmin(
            ResetPasswordByAdminViewModel context)
        {
            return await AXClient.Instance.ResetPasswordByAdminAsync(context).ConfigureAwait(false);
        }
        //ResetPasswordByAdminAsync
        #endregion

        #region CustomerConfirmInformations
        public async Task<ApiResponseOfListOfCustomerConfirmInformation> GetCustomersConfirmInformations(CustomerContext context)
        {
            return await AXClient.Instance.GetCustomerConfirmInformationsAsync(context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfListOfCustomerConfirmInformation> GetCustomerConfirmInformation(long id, CustomerContext context)
        {
            return await AXClient.Instance.GetCustomerConfirmInformationAsync(id, context).ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> UpdateCustomerConfirm(CustomerConfirmInfoContext context)
        {
            return await AXClient.Instance.UpdateCustomerConfirmAsync(context).ConfigureAwait(false);
        }

        #endregion

        #region RequestDateChange
        public async Task<ApiResponseOfResponse> RequestDateChange(RequestOrderDateChangeViewModel context)
        {
            return await AXClient.Instance.RequestDateChangeAsync(context).ConfigureAwait(false);
        }
        #endregion

        #region Upcoming Deliveries - Driver

        //UpcomingDeliveriesAsync
        public async Task<ApiResponseOfListOfSalesOrder> UpcomingDeliveries(SalesOrderQueryContext context)
        {
            return await AXClient.Instance.UpcomingDeliveriesAsync(context)
                .ConfigureAwait(false);
        }

        public Task<ApiResponseOfDynamicCustomer> GetCustomerInfo(string account)
        {
            return AXClient.Instance.GetCustomerInfoAsync(account);
        }
        #endregion

        #region My Account - PhoneNumberEdit
        public async Task<ApiResponseOfGuid> EditUserPhoneNumber(UpdatePhoneQueryContext context)
        {
            return await AXClient.Instance.EditUserPhoneNumberAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> VerifyUserPhoneNumber(VerifyCodeQueryContext context)
        {
            return await AXClient.Instance.VerifyUserPhoneNumberAsync(context)
                .ConfigureAwait(false);
        }
        #endregion

        #region PipelineQuotationUpdate
        public async Task<ApiResponseOfBoolean> PostQuotationUpdate(QuotationUpdateQueryContext context)
        {
            return await AXClient.Instance.PostQuotationUpdateAsync(context)
                .ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfQuotationNote> GetQuotationNotes(QuotationNotesQueryContext context)
        {
            return await AXClient.Instance.GetQuotationNotesAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> LostQuotation(LostQuotationQueryContext context)
        {
            return await AXClient.Instance.LostQuotationAsync(context)
                .ConfigureAwait(false);
        }

        public async Task<ApiResponseOfListOfKeyNameModelOfString> GetQuotationReasons()
        {
            return await AXClient.Instance.GetQuotationReasonsAsync();
        }
        #endregion

        #region PackingSlipProofOfDelivery

        public async Task<ApiResponseOfListOfProofOfDeliveryViewModel> GetOrderProofOfDeliveriesAsync(SalesOrderQueryContext context)
        {
            ApiResponseOfListOfProofOfDeliveryViewModel result = await AXClient.Instance.GetOrderProofOfDeliveriesAsync(context)
                .ConfigureAwait(false);
            return result;
        }
        public async Task<byte[]> GetProofOfDelivery(string barcode, SalesOrderQueryContext context)
        {
            var result = await AXClient.Instance.GetOrderProofOfDeliveryAsync(barcode, context)
                .ConfigureAwait(false);
            return result;
        }
        #endregion

        #region DrvManifestUpdateClock

        public async Task<ApiResponseOfBoolean> UpdateManifestClockInTime(ClockInTimeQueryContext context)
        {
            return await AXClient.Instance.UpdateManifestClockInTimeAsync(context)
                .ConfigureAwait(false);
        }
        public async Task<ApiResponseOfBoolean> UpdateManifestClockOutTime(ClockInTimeQueryContext context)
        {
            return await AXClient.Instance.UpdateManifestClockOutTimeAsync(context)
                .ConfigureAwait(false);
        }
        #endregion

        #region DriverPackingSlipClockInClockOut
        public Task<ApiResponseOfBoolean> PostDriverClockInOut(PostDriverClockInOutContext context)
        {
            return AXClient.Instance.PostDriverClockInOutAsync(context);

        }
        public Task<ApiResponseOfListOfDriverRouteClockInOutViewModel> GetDriverClockIns(GetDriverClockInsContext context)
        {
            return AXClient.Instance.GetDriverClockInsAsync(context);
        }


        #endregion

        #region DriverMarkManifestCompleted

        public Task<ApiResponseOfResponse> MarkManifestCompleted(string manifestId)
        {
            return AXClient.Instance.MarkManifestCompletedAsync(manifestId);
        }
        #endregion

        #region RegisterNewUser

        public Task<ApiResponseOfNewUserCreationResult> RegisterNewUser(NewUser newUser)
        {
            return AXClient.Instance.RegisterNewUserAsync(newUser);
        }
        #endregion


        #region NotifyUpcomingDeliveries

        public Task<ApiResponseOfResponse> NotifyUpcomingDeliveries(UpcomingDeliveriesQueryContext context)
        {
            return AXClient.Instance.NotifyUpcomingDeliveriesAsync(context);
        }

        #endregion

        #region ReturnOrders
        public Task<ApiResponseOfListOfReturnOrder> GetReturnOrders(ReturnOrderQueryContext context)
        {
            return AXClient.Instance.GetReturnOrdersAsync(context);
        }
        public Task<ApiResponseOfListOfReturnOrderLine> GetReturnOrderLines(ReturnOrderLineQueryContext context)
        {
            return AXClient.Instance.GetReturnOrderLinesAsync(context);
        }
        #endregion

        #region CreditCard Payment 
        public Task<ApiResponseOfNullableOfGuid> PrepareMobilePaymentAsync(MobilePaymentSSORequest context)
        {
            return AXClient.Instance.PrepareMobilePaymentAsync(context);
        }
        #endregion

        #region GetInvoiceReceipt
        public Task<ApiResponseOfReceiptModel> GetInvoiceReceipt(InvoiceReceiptContext context)
        {
            return AXClient.Instance.GetInvoiceReceiptAsync(context);
        }
        public Task<ApiResponseOfResponse> EmailReceipt(InvoiceReceiptContext context)
        {
            return AXClient.Instance.EmailRecieptAsync(context);
        }

        #endregion

        #region CustomerNotification
        public Task<ApiResponseOfNullableOfGuid> PrepareNotifyCustomer(MobileNotifyCustomerSSORequest context)
        {
            return AXClient.Instance.PrepareNotifyCustomerAsync(context);

        }

        public Task<ApiResponseOfNotifyCustomerViewModel> NotifyCustomerGet(string id, string accountNumber, string customerPoNumber)
        {
            return AXClient.Instance.NotifyCustomerGetAsync(id, accountNumber, customerPoNumber);

        }
        public Task<ApiResponseOfResponse> NotifyCustomerPost(NotifyCustomerViewModel context)
        {
            return AXClient.Instance.NotifyCustomerPostAsync(context);

        }
        #endregion
        #region Portal Terms
        public Task<ApiResponseOfAgreeToTermsViewModel> GetPortalTerms(Language language)
        {
            return AXClient.Instance.PortalTermsAsync(language);
        }
        #endregion
    }



    public class GetTokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string issued { get; set; }
        public string expires { get; set; }
    }

}
