using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using TruliteMobile.Interfaces;
using TruliteMobile.UWP.PlatformSpecific;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace TruliteMobile.UWP.PlatformSpecific
{
   public class FileHelper:IFileHelper
    {
        public async Task<string> GetDownloadFile(string file)
        {
            var localFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;

            return Path.Combine(localFolder.Path, file);
        }
    }
}
