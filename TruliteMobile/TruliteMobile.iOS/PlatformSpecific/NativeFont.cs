using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TruliteMobile.Interfaces;
using TruliteMobile.iOS.PlatformSpecific;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(NativeFont))]
namespace TruliteMobile.iOS.PlatformSpecific
{
    public class NativeFont : INativeFont
    {
        public float GetNativeSize(float size)
        {
            return size * (float)UIScreen.MainScreen.Scale;
        }
    }
}