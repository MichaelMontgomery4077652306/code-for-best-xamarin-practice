using System.IO;
using System.Threading.Tasks;
using Android.OS;
using TruliteMobile.Droid.PlatformSpecific;
using TruliteMobile.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace TruliteMobile.Droid.PlatformSpecific
{
   public class FileHelper:IFileHelper
    {
        public async Task<string> GetDownloadFile(string file)
        {
            //var path=(string)Android.OS.Environment.GetExternalStoragePublicDirectory("Documents");
            string fullPath = Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),
                file);
            return fullPath;
            var path = Environment.ExternalStorageDirectory.AbsolutePath;
            //`//path = "/sdcard/Download";
            return Path.Combine(path, "Download", file);
        }
    }
}
