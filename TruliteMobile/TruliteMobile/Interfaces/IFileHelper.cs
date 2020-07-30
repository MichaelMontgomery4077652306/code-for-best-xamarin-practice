using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TruliteMobile.Interfaces
{
    public interface IFileHelper
    {

        Task<string> GetDownloadFile(string file);

    }
}
