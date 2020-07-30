using System;
using System.IO;
using System.Threading.Tasks;
using TruliteMobile.Interfaces;
using TruliteMobile.iOS.PlatformSpecific;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace TruliteMobile.iOS.PlatformSpecific
{
   public class FileHelper:IFileHelper
    {
        public async Task<string> GetDownloadFile(string file)
        {

            string filename = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "..", "Library", file);
            return filename;
            
        }
    }
}
