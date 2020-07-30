using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TruliteMobile.Services
{
    
    public class LoggingHandler : DelegatingHandler
    {
        public LoggingHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            StringBuilder myStringBuilder = new StringBuilder("Start--------------");
            myStringBuilder.Append("\n");
            myStringBuilder.Append("--- Request");
            myStringBuilder.Append("\n");
            myStringBuilder.Append(request.ToString());
            myStringBuilder.Append("\n");
            if (request.Content != null)
            {
                myStringBuilder.Append(await request.Content.ReadAsStringAsync());
            }
            myStringBuilder.Append("\n");

#if DEBUG
            HttpResponseMessage response = null;
            try
            {
                //Debug.WriteLine("--- Request SendAsync Started:" + request.RequestUri.ToString());
                response = await base.SendAsync(request, cancellationToken);
            }
            catch (Exception e)
            {
                Debug.WriteLine("--- Request SendAsync Ended with exception:" + request.RequestUri.ToString() + " " + e.Message);
                throw e;
            }
            finally
            {
                //Debug.WriteLine("--- Request SendAsync Ended:" + request.RequestUri.ToString());
            }

#else
                HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
#endif

            myStringBuilder.Append("--- Response:");
            myStringBuilder.Append("\n");
            myStringBuilder.Append(response.ToString());
            myStringBuilder.Append("\n");
            if (response.Content != null)
            {
                myStringBuilder.Append(await response.Content.ReadAsStringAsync());
            }
            myStringBuilder.Append("\n");
            myStringBuilder.Append("End----------------");

            Debug.WriteLine(myStringBuilder.ToString());

            return response;
        }


        public static HttpClient GetAnHttpClient()
        {
            HttpClient httpClient = null;
#if DEBUG
            httpClient = new HttpClient(new LoggingHandler(new HttpClientHandler()))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
#else
        httpClient = new HttpClient() { 
            Timeout = TimeSpan.FromSeconds(30)
        };
            
#endif
            return httpClient;
        }
    }
}
