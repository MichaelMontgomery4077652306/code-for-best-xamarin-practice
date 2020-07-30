using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionButtonView : ContentView
    {

        public static readonly BindableProperty IconTextProperty =
            BindableProperty.Create("IconText", typeof(string), typeof(ActionButtonView), default(ActionButtonView));

        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(ActionButtonView), default(string));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty ButtonColorProperty =
            BindableProperty.Create("ButtonColor", typeof(Color), typeof(ActionButtonView), default(Color));

        public Color ButtonColor
        {
            get { return (Color)GetValue(ButtonColorProperty); }
            set { SetValue(ButtonColorProperty, value); }
        }

        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create("TappedCommand", typeof(ICommand), typeof(ActionButtonView), default(ICommand));

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }


        public static readonly BindableProperty TappedCommandParameterProperty =
            BindableProperty.Create("TappedCommandParameter", typeof(object), typeof(ActionButtonView), default(object));

        public object TappedCommandParameter
        {
            get { return GetValue(TappedCommandParameterProperty); }
            set { SetValue(TappedCommandParameterProperty, value); }
        }


        public event EventHandler<object> TappedEvent;

        public ActionButtonView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;

        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            if (propertyName == "IsEnabled")
            {
                this.Opacity = IsEnabled ? 1 : 0.5;
            }
            base.OnPropertyChanged(propertyName);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TappedCommand?.Execute(TappedCommandParameter);
            TappedEvent?.Invoke(this,TappedCommandParameter);
        }
    }
}