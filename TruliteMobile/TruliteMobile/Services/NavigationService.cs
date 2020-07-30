using System.Threading.Tasks;
using TruliteMobile.Views.Pipeline;
using Xamarin.Forms;

namespace ExTrack.Services
{
    public class NavigationService
    {
        private static NavigationService _instance;
        private INavigation _nav;
        public static NavigationService Instance => _instance ?? (_instance = new NavigationService());

        public INavigation Nav =>Application.Current.MainPage.Navigation;

        public void Init(INavigation nav = null)
        {
            //if (_nav != null) return;
            //Nav = nav ?? App.Current.MainPage.Navigation;
        }

        public async Task NavigateTo(Page pg)
        {
            await Nav.PushAsync(pg);
        }

    }

    public interface INavigatedBack
    {
        void NavigatedBack();
    }
}
