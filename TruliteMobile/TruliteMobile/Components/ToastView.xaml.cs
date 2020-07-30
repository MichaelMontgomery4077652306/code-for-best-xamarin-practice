using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToastView : ContentView
    {

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(ToastView), default(string));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty ShowBadgeProperty =
            BindableProperty.Create("ShowBadge", typeof(bool), typeof(ToastView), default(bool), BindingMode.TwoWay);

        public bool ShowBadge
        {
            get { return (bool) GetValue(ShowBadgeProperty); }
            set { SetValue(ShowBadgeProperty, value); }
        }


        public ToastView()
        {
            InitializeComponent();
            this.IsVisible = false;
            Children[0].BindingContext = this;
        }

        private bool _isExecuting;
        public async Task Show()
        {

            try
            {
                if (_isExecuting) return;
                _isExecuting = true;
                this.IsVisible = true;
                await this.FadeTo(1, 200);
                await this.FadeTo(0, 3000, Easing.CubicIn);
                ShowBadge = false;

            }
            finally
            {
                _isExecuting = false;
                IsVisible = false;
            }


        }
    }
}