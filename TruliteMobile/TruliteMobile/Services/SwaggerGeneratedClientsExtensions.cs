using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using TruliteMobile.Components;
using TruliteMobile.Enums;
using TruliteMobile.Models;
using TruliteMobile.Views.DrvPackingSlip;
using TruliteMobile.Views.Orders;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using QuoteLineModel = TruliteMobile.Models.QuoteLineModel;

namespace TruliteMobile.Services
{



    public partial class AXClient
    {
        private static AXClient _instance;
        public static AXClient Instance => _instance ?? (_instance = new AXClient());

        async Task ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response)
        {
#if !DEBUG
            return;
#endif
            Debug.WriteLine("---------------API CALL LOG - BEGIN -----------------------------------------------");

            Debug.WriteLine($"METHOD: {response.RequestMessage.Method} {response.RequestMessage.RequestUri}");

            if (response?.RequestMessage?.Headers?.Authorization != null)
            {
                Debug.WriteLine($"AUTHORIZATION: Bearer {response.RequestMessage.Headers.Authorization.Parameter}");
            }

            if (response?.RequestMessage?.Content != null)
            {
                Debug.WriteLine($"REQUEST BODY: {await response.RequestMessage.Content.ReadAsStringAsync()}");
            }

            if (response?.Content != null)
            {
                Debug.WriteLine($"RESPONSE STATUS: {(int)response.StatusCode}:{response.StatusCode}");
                Debug.WriteLine($"RESPONSE CONTENT:  {await response.Content.ReadAsStringAsync()}");
            }

            Debug.WriteLine(
                $"---------------API CALL LOG - END FOR {response.RequestMessage.Method} {response.RequestMessage.RequestUri}");
        }



        /// <summary>Adds a support ticket for a branch.</summary>
        /// <param name="context">Query parameters for this endpoint.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ApiResponseOfBoolean> AddBranchTicketAsync(
            NewTruDeskItemQueryContext context)
        {
            return AddBranchTicketAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Adds a support ticket for a branch.</summary>
        /// <param name="context">Query parameters for this endpoint.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<ApiResponseOfBoolean> AddBranchTicketAsync(
            NewTruDeskItemQueryContext context, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/AddBranchTicket");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ApiResponseOfBoolean>(response_, headers_)
                                    .ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else if (status_ == "400")
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The query parameters have invalid properties. It may also return 400 status code if the branch was not found.",
                                (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ApiResponseOfBoolean);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url)
        {

            if (string.IsNullOrWhiteSpace(SettingsService.Instance.Token)) return;
            client.DefaultRequestHeaders.Add("Authorization",
                $"Bearer {SettingsService.Instance.Token}");
            client.Timeout = TimeSpan.FromSeconds(120);
        }

        #region QuotationCopy

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCopyQuotationAsync(QuotationsQueryContext context)
        {
            return GetCopyQuotationAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCopyQuotationAsync(QuotationsQueryContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCopyQuotation");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content?.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                client_.Dispose();
            }
        }

        #endregion

        #region InvoiceCopy

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCopyInvoiceAsync(InvoicesQueryContext context)
        {
            return GetCopyInvoiceAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCopyInvoiceAsync(InvoicesQueryContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCopyInvoice");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                client_.Dispose();
            }
        }

        #endregion

        #region PackingSlipCopy

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCopyPackingSlipAsync(PackingSlipsQueryContext context)
        {
            return GetCopyPackingSlipAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCopyPackingSlipAsync(PackingSlipsQueryContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCopyPackingSlip");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json);
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                client_.Dispose();
            }
        }

        #endregion

        #region DownloadDocument

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(DocumentDownloadQueryContext context)
        {
            return DownloadDocumentAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(DocumentDownloadQueryContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/DownloadDocument");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json);
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                client_.Dispose();
            }
        }

        #endregion


        #region PriceLetterDownload

        /// <summary>Gets a PDF copy of a customer's price letter.</summary>
        /// <param name="context">Information of the customer calling the API.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCopyPriceLetterAsync(CustomerContext context)
        {
            return GetCopyPriceLetterAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets a PDF copy of a customer's price letter.</summary>
        /// <param name="context">Information of the customer calling the API.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCopyPriceLetterAsync(CustomerContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCopyPriceLetter");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "400")
                        {
                            string responseText_ = (response_.Content == null)
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The passed query parameters are not valid.",
                                (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

        #endregion

        #region GetConfirmationCopy

        /// <summary>Gets a PDF copy for a sales order confirmation.</summary>
        /// <param name="context">Query parameters for this endpoint.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCopyConfirmationAsync(SalesOrderQueryContext context)
        {
            return GetCopyConfirmationAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets a PDF copy for a sales order confirmation.</summary>
        /// <param name="context">Query parameters for this endpoint.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCopyConfirmationAsync(SalesOrderQueryContext context,
            System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCopyConfirmation");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "400")
                        {
                            string responseText_ = (response_.Content == null)
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The passed query parameters are not valid.",
                                (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else if (status_ == "200")
                        {
                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        response_?.Dispose();
                    }
                }
            }
            finally
            {
                client_.Dispose();
            }
        }

        #endregion


        /// <summary>Gets a list of sales routes.</summary>
        /// <param name="inventSiteId">Inventory site ID.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ApiResponseOfListOfSalesPool> GetSalesRoutesAsync(string inventSiteId)
        {
            if (string.IsNullOrWhiteSpace(inventSiteId))
            {
                throw new Exception("InventSiteId cannot be null");
            }

            return GetSalesRoutesAsync(inventSiteId, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets a list of sales routes.</summary>
        /// <param name="inventSiteId">Inventory site ID.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<ApiResponseOfListOfSalesPool> GetSalesRoutesAsync(string inventSiteId,
            System.Threading.CancellationToken cancellationToken)
        {
            if (inventSiteId == null)
                throw new System.ArgumentNullException("inventSiteId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetSalesRoutes/{inventSiteId}");
            urlBuilder_.Replace("{inventSiteId}",
                System.Uri.EscapeDataString(ConvertToString(inventSiteId,
                    System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ApiResponseOfListOfSalesPool>(response_, headers_)
                                    .ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ApiResponseOfListOfSalesPool);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }


        //#region GetProofOfDelivery

        ///// <summary>Gets a PDF copy of the given sales order's proof of delivery</summary>
        ///// <param name="context">Query parameters for this endpoint.</param>
        ///// <exception cref="SwaggerException">A server side error occurred.</exception>
        //public System.Threading.Tasks.Task<byte[]> GetOderProofOfDeliveryAsync(SalesOrderQueryContext context)
        //{
        //    return GetOrderProofOfDeliveryAsync(barcode, context, System.Threading.CancellationToken.None);
        //}

        ///// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        ///// <summary>Gets a PDF copy of the given sales order's proof of delivery</summary>
        ///// <param name="context">Query parameters for this endpoint.</param>
        ///// <exception cref="SwaggerException">A server side error occurred.</exception>
        //public async System.Threading.Tasks.Task<byte[]> GetOrderProofOfDeliveryAsync(string barcode, SalesOrderQueryContext context,
        //    System.Threading.CancellationToken cancellationToken)
        //{
        //    var urlBuilder_ = new System.Text.StringBuilder();
        //    urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetOrderProofOfDelivery/{barcode}");
        //    urlBuilder_.Replace("{barcode}", System.Uri.EscapeDataString(ConvertToString(barcode, System.Globalization.CultureInfo.InvariantCulture)));

        //    var client_ = new System.Net.Http.HttpClient();
        //    try
        //    {
        //        using (var request_ = new System.Net.Http.HttpRequestMessage())
        //        {
        //            var content_ =
        //                new System.Net.Http.StringContent(
        //                    Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
        //            content_.Headers.ContentType =
        //                System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
        //            request_.Content = content_;
        //            request_.Method = new System.Net.Http.HttpMethod("POST");
        //            request_.Headers.Accept.Add(
        //                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

        //            PrepareRequest(client_, request_, urlBuilder_);
        //            var url_ = urlBuilder_.ToString();
        //            request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
        //            PrepareRequest(client_, request_, url_);

        //            var response_ = await client_.SendAsync(request_,
        //                    System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
        //                .ConfigureAwait(false);
        //            try
        //            {
        //                var headers_ =
        //                    System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
        //                if (response_.Content != null && response_.Content.Headers != null)
        //                {
        //                    foreach (var item_ in response_.Content.Headers)
        //                        headers_[item_.Key] = item_.Value;
        //                }

        //                await ProcessResponse(client_, response_);

        //                var status_ = ((int)response_.StatusCode).ToString();
        //                if (status_ == "400")
        //                {
        //                    string responseText_ = (response_.Content == null)
        //                        ? null
        //                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
        //                    throw new SwaggerException("The passed query parameters are not valid.",
        //                        (int)response_.StatusCode, responseText_, headers_, null);
        //                }
        //                else if (status_ == "200")
        //                {
        //                    return await response_.Content.ReadAsByteArrayAsync();
        //                }
        //                else if (status_ == "404") //Returns 404 when proof of delivery is not found
        //                {
        //                    return default;
        //                }
        //                else if (status_ != "200" && status_ != "204")
        //                {
        //                    var responseData_ = response_.Content == null
        //                        ? null
        //                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
        //                    throw new SwaggerException(
        //                        "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
        //                        ").", (int)response_.StatusCode, responseData_, headers_, null);
        //                }

        //                return default;
        //            }
        //            finally
        //            {
        //                if (response_ != null)
        //                    response_.Dispose();
        //            }
        //        }
        //    }
        //    finally
        //    {
        //        if (client_ != null)
        //            client_.Dispose();
        //    }
        //}

        //#endregion





        #region GetFinancialStatement

        /// <summary>Get the account statement of the given customer.</summary>
        /// <param name="context">Query parameters for this endpoint</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<byte[]> GetCustomerAccountStatementAsync(
            CustomerStatementQueryContext context)
        {
            return GetCustomerAccountStatementAsync(context, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get the account statement of the given customer.</summary>
        /// <param name="context">Query parameters for this endpoint</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<byte[]> GetCustomerAccountStatementAsync(
            CustomerStatementQueryContext context, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/AX/GetCustomerAccountStatement");

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ =
                        new System.Net.Http.StringContent(
                            Newtonsoft.Json.JsonConvert.SerializeObject(context, _settings.Value));
                    content_.Headers.ContentType =
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(
                        System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        await ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "206")
                        {

                            return await response_.Content.ReadAsByteArrayAsync();
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int)response_.StatusCode +
                                ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(byte[]);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

        #endregion



    }

    public partial class SalesPool
    {
        public string String => $"{_name} ({_key})";
    }

    public partial class PackingSlip
    {

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged();
            }
        }
    }

    public partial class PackingSlipsQueryContext
    {
        private int _selectedQty;

        [JsonIgnore]
        public int SelectedQty
        {
            get { return _selectedQty; }
            set
            {
                _selectedQty = value;
                RaisePropertyChanged();
            }
        }

        private SortColumnItem _sortColumn;

        [JsonIgnore]
        public SortColumnItem SortColumn
        {
            get { return _sortColumn; }
            set
            {
                _sortColumn = value;
                RaisePropertyChanged();
            }
        }
    }

    public partial class MyClient
    {
        private static MyClient _instance;
        public static MyClient Instance => _instance ?? (_instance = new MyClient());

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url)
        {

            if (string.IsNullOrWhiteSpace(SettingsService.Instance.Token)) return;
            client.DefaultRequestHeaders.Add("Authorization",
                $"Bearer {SettingsService.Instance.Token}");
        }
    }

    public static class SwaggerGeneratedClientsExtensions
    {
        public static PackingSlipsQueryContext ToQueryContext(this PackingSlipFilterModel filter)
        {

            var context = new PackingSlipsQueryContext
            {
                CustomerPurchaseOrderNo = filter.PurchaseOrder,
                FromShipDate = filter.DateFrom,
                Id = filter.PackingSlipId,
                InventLocationId = null,
                PackingSlipDate = null,
                SalesGroupId = null,
                ToShipDate = filter.DateTo,
                SalesOrderId = filter.SalesOrder,
                SelectedQty = filter.SelectedQty

            };
            return context;


        }

        public static QuotationsQueryContext ToQueryContext(this QuoteFilter filter)
        {
            return new QuotationsQueryContext
            {
                CustomerInfo = ApiService.Instance.GetCustomerContext(),
                FromExpiryDate = filter.StartDate,
                SalesOrderId = filter.SalesOrderNumber,
                Status = filter.SelectedStatus.Key,
                ToExpiryDate = filter.EndDate,
                Id = filter.Number
            };
        }

        public static InvoicesQueryContext ToInvoicesQueryContext(this InvoicesFilterModel filter)
        {
            var invoiceContext = new InvoicesQueryContext
            {
                CustomerInfo = ApiService.Instance.GetCustomerContext(),
                InvoiceId = filter.Number,
                SalesOrderId = filter.SalesOrderNumber,
                CustomerPurchaseOrderNo = filter.PONumber,
                FromDueDate = filter.StartDueDate,
                ToDueDate = filter.EndDueDate,
                FromInvoiceDate = filter.StartDate,
                ToInvoiceDate = filter.EndDate,

            };
            if (filter.Status.Key != InvoicesQueryContextStatus.None)
            {
                invoiceContext.Status = filter.Status.Key;
            }

            return invoiceContext;
        }

        public static SalesOrderQueryContext ToQueryContext(this OrderFilter filter)
        {
            return new SalesOrderQueryContext
            {
                CustomerInfo = ApiService.Instance.GetCustomerContext(),
                CustomerPurchaseOrderNo = filter.PONumber,
                StartDate = filter.StartDate,
                EndDate = filter.EndDate,
                //SalesGroupId = filter.Number,
                SalesOrderNo = filter.Number,
                Status = filter.SelectedStatus.Key,
            };
        }



        public static PackingSlipModel ToPackingSlipModel(this PackingSlip data)

        {
            return new PackingSlipModel
            {
                Account = data.Account.Name,
                AccountNumber = data.Account.Key,
                DateShipped = data.DateShipped,
                JobName = data.CustomerRef,
                Lines = data.LinesCount,
                OrderDate = data.OrderDate,
                OrderNumber = data.Order.Key,
                PackingSlip = data.Key,
                Plant = data.InventLocationName,
                ProofOfDelivery = null,
                RequestedDeliveryDate = data.DateWanted,
                PurchaseOrder = data.CustomerPurchaseOrderNo,
                Sqft = data.TotalSqft,
                Terms = data.Terms,
                Weight = data.TotalWeight,
                OriginalData = data,
                Voucher = data.Voucher

            };
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.28.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class NewTruDeskItemQueryContext : ObservableObject
    {
        private CustomerContext _customerInfo;
        private string _attachment;
        private string _attachmentName;
        private System.Guid? _branch;
        private string _emailAddress;
        private string _subject;
        private string _description;

        /// <summary>Information of the customer calling the API.</summary>
        [Newtonsoft.Json.JsonProperty("CustomerInfo", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerContext CustomerInfo
        {
            get { return _customerInfo; }
            set
            {
                if (_customerInfo != value)
                {
                    _customerInfo = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("Attachment", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Attachment
        {
            get { return _attachment; }
            set
            {
                if (_attachment != value)
                {
                    _attachment = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("AttachmentName", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AttachmentName
        {
            get { return _attachmentName; }
            set
            {
                if (_attachmentName != value)
                {
                    _attachmentName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Branch (plant) ID.</summary>
        [Newtonsoft.Json.JsonProperty("Branch", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>This field seems to be not used anywhere.</summary>
        [Newtonsoft.Json.JsonProperty("EmailAddress", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subject of the ticket.</summary>
        [Newtonsoft.Json.JsonProperty("Subject", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subject
        {
            get { return _subject; }
            set
            {
                if (_subject != value)
                {
                    _subject = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The ticket body / description.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }



    }

    public partial class PackingSlipLine
    {
        private ObservableCollection<PackReasonEventArgs> _packingReasonList;

        public ObservableCollection<PackReasonEventArgs> PackingReasonList
        {
            get { return _packingReasonList; }
            set
            {
                _packingReasonList = value;
                RaisePropertyChanged();
            }
        }
    }

    public partial class CustomerCreditCardTokenViewModel
    {
        public string Address
        {
            get { return $"{Street} \n {City} \n {State} {ZipCode}"; }
        }


        public string CardTypeIcon
        {
            get
            {
                switch (CardType)
                {
                    case "001":
                        return "\uf1f0";
                    case "002":
                        return "\uf1f1";
                    case "003":
                        return "\uf1f3";
                    case "004":
                        return "\uf1f2";
                    default:
                        return "\uf09d";
                }
            }
        }


        public string ReceiptEmailAddress
        {
            get { return _copyReceiptEmailAddresses?.FirstOrDefault(); }
            set
            {

                if (_copyReceiptEmailAddresses == null)
                {
                    _copyReceiptEmailAddresses = new ObservableCollection<string>();

                }
                _copyReceiptEmailAddresses.Clear();
                _copyReceiptEmailAddresses.Add(value);
                RaisePropertyChanged();
            }
        }
    }

    public partial class SalesOrder
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged();
            }
        }
    }
    public partial class ShipManifestDetail
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged();
            }
        }
    }
}
