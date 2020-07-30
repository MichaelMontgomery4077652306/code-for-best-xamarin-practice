using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace TruliteMobile.UWP
{
    public class WinRtResourceManager : ResourceManager
    {

        private ResourceLoader resourceLoader;
        private WinRtResourceManager(string baseName, Assembly assembly) : base(baseName, assembly)
        {
            this.resourceLoader = ResourceLoader.GetForViewIndependentUse(baseName);
        }

        public static void InjectIntoResxGeneratedApplicationResourcesClass(Type resxGeneratedApplicationResourcesClass)
        {
            resxGeneratedApplicationResourcesClass
                .GetRuntimeFields()
                .First(m => m.Name == "resourceMan")
                .SetValue(
                    null,
                    new WinRtResourceManager(
                        resxGeneratedApplicationResourcesClass.FullName,
                        resxGeneratedApplicationResourcesClass.GetTypeInfo().Assembly));
        }

        public override string GetString(string name, CultureInfo culture)
        {
            return this.resourceLoader.GetString(name);
        }
    }

}
