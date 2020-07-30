using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;

namespace TruliteMobile.Droid
{
    
    [Activity(
        Theme = "@style/Splash",
         ScreenOrientation = ScreenOrientation.Portrait
        , ConfigurationChanges = ConfigChanges.Orientation
        , MainLauncher = true
        , NoHistory = true)]
    public class SplashActivity : Activity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);
        //}
        protected override void OnResume()
        {
            base.OnResume();

            Task.Factory.StartNew(() =>
            {
                StartActivity(typeof(MainActivity));

                Finish();
            });
        }
    }
}