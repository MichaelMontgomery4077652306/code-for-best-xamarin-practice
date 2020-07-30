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
    public partial class ExpanderButton : ContentView
    {


        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(ExpanderButton), default(string));

        public string Text
        {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }   

        public static readonly BindableProperty IsExpandedProperty =
            BindableProperty.Create("IsExpanded", typeof(bool), typeof(ExpanderButton), default(bool));

        public bool IsExpanded
        {
            get { return (bool) GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, value); }
        }

        public static readonly BindableProperty ChangeExpandCommandProperty =
            BindableProperty.Create("ChangeExpandCommand", typeof(ICommand), typeof(ExpanderButton), default(ICommand));

        public ICommand ChangeExpandCommand
        {
            get { return (ICommand) GetValue(ChangeExpandCommandProperty); }
            set { SetValue(ChangeExpandCommandProperty, value); }
        }

        public ExpanderButton()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            IsExpanded = !IsExpanded;
            ChangeExpandCommand?.Execute(IsExpanded);
        }
    }

   
}