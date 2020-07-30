using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TruliteMobile.i18n
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
