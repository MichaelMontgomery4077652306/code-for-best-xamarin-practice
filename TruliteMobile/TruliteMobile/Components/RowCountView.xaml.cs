using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RowCountView : ContentView
    {

        public static readonly BindableProperty ListProperty =
            BindableProperty.Create("List", typeof(IList), typeof(RowCountView),
                default(IList), BindingMode.OneWay, null, ListPropertyChanged);

        private static void ListPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            string count = string.Empty;
            if (newvalue != null)
            {
                count = ((IList)newvalue).Count.ToString();

            }

            ((RowCountView) bindable).rowCountSpan.Text = count;
        }

        public IList List
        {
            get { return (IList) GetValue(ListProperty); }
            set { SetValue(ListProperty, value); }
        }

        public RowCountView()
        {
            InitializeComponent();
            
        }
    }
}