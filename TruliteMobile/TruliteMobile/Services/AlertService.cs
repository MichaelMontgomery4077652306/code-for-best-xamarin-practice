using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Crashes;
using TruliteMobile.i18n;
using TruliteMobile.Misc;

namespace TruliteMobile.Services
{
    public class AlertService
    {
        private static AlertService _instance;
        public static AlertService Instance => _instance ?? (_instance = new AlertService());

        public async Task ShowMessage(string message, string title = "Trulite", string cancel = "OK")
        {
            await App.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> ShowMessageConfirmation(string message, string title = "Trulite",
            string accept = "OK", string cancel =null)
        {
            if (cancel == null)
            {
                cancel = nameof(AppResources.Cancel).Translate().ToUpper();
               
            }
            return await App.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        public async Task DisplayError(Exception exception, string friendlyMessage = null)
        {
#if DEBUG
            Debug.WriteLine(exception);
#endif
            switch (exception)
            {
                case WebException _:
                case OperationCanceledException _:
                case TimeoutException _:
                    return;
            }
            
            if(exception.Message.Contains("Socket closed"))
            {
                return;
            }
            Crashes.TrackError(exception);
            if (friendlyMessage == null)
            {
                await App.Current.MainPage.DisplayAlert(exception.Message, exception.StackTrace, "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert(nameof(AppResources.Error).Translate(), friendlyMessage, "OK");
            }

        }

        private bool _isShowingMessage;
        /// <summary>
        /// Process API exception
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="validationErrors">List of validation errors</param>
        /// <param name="friendlyMessage">Message to be show to the user</param>
        /// <param name="silent">Do not show Message popup, only output to debug</param>
        /// <returns></returns>
        public async Task DisplayApiCallError(string message, ICollection<ValiationError> validationErrors, string friendlyMessage=null, bool silent=false)
        {

            if(_isShowingMessage)return;
            var sb = new StringBuilder();
            foreach (var resultValidationError in validationErrors)
            {
                sb.AppendLine($"{resultValidationError.PropertyName}: {resultValidationError.ErrorMessage}");
            }
#if DEBUG
            Debug.WriteLine(message);
            Debug.WriteLine(sb.ToString());

#endif
            if(silent)return;
            
            _isShowingMessage = true;
            if (friendlyMessage == null)
            {
                await App.Current.MainPage.DisplayAlert(message, sb.ToString(), "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert(nameof(AppResources.Error).Translate(), friendlyMessage, "OK");
            }

            _isShowingMessage = false;
        }

        public async Task<string> DisplayActionSheet(string Title, string cancel, string o, string[] items)
        {
            return await App.Current.MainPage.DisplayActionSheet(Title, cancel, o, items);
        }
    }
}
