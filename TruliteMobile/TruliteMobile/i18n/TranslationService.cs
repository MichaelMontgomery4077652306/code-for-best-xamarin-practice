using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using TruliteMobile.Services;
using Xamarin.Forms;

namespace TruliteMobile.i18n
{
    public class TranslationService
    {
        CultureInfo ci = null;
        const string ResourceId = "TruliteMobile.i18n.AppResources";

        static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(
            () => new ResourceManager(ResourceId, IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly));


        private static TranslationService _instance;
        public static TranslationService Instance => _instance ?? (_instance = new TranslationService());

        public TranslationService()
        {
            Init();
        }

        public void Init()
        {
            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            {
                ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            else
            {
                var currentCulture = CultureInfo.CurrentUICulture;
                if (currentCulture.TwoLetterISOLanguageName == "en" ||
                    currentCulture.TwoLetterISOLanguageName == "fr" ||
                    currentCulture.TwoLetterISOLanguageName == "es")
                {
                    ci = currentCulture;
                }
                else
                {
                    ci = CultureInfo.GetCultureInfo("en-US");
                }
            }
        }


        public string Get(string key, string prefix ="", string suffix="")
        {
            if (key == null)
                return string.Empty;


            var translation = ResMgr.Value.GetString(key, ci);
            if (translation == null)
            {
#if DEBUG
                //AlertService.Instance
                //    .ShowMessage($"Key '{key}' was not found in resources '{ResourceId}' for culture '{ci.Name}'.")
                //    .Wait();

                Console.WriteLine($"Key '{key}' was not found in resources '{ResourceId}' for culture '{ci.Name}'.");

                //throw new ArgumentException(
                //    $"Key '{key}' was not found in resources '{ResourceId}' for culture '{ci.Name}'.",
                //    "Text");
                translation = $"{key}**";
#else
                translation = key; // HACK: returns the key, which GETS DISPLAYED TO THE USER
#endif
            }

            return $"{prefix}{translation}{suffix}";
        }
    }
}