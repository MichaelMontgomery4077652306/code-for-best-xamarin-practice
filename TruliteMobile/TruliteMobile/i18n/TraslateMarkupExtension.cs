using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.i18n
{
    // You exclude the 'Extension' suffix when using in XAML
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public TextCapitalization TextCapitalization { get; set; }
        public string Text { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var text = TranslationService.Instance.Get(Text, Prefix, Suffix);
            switch (TextCapitalization)
            {
                case TextCapitalization.Uppercase:
                    return text.ToUpper();
                    break;
                case TextCapitalization.Lowercase:
                    return text.ToLower();
                    break;
                default:
                    return text;
                    break;
            }

            return null;
        }

    }


    public enum TextCapitalization
    {
        Default,
        Uppercase,
        Lowercase,
    }
}

