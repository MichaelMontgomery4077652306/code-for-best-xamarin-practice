using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NullableDatePickerView : ContentView
    {

        public static readonly BindableProperty DateProperty =
            BindableProperty.Create("Date", typeof(DateTime?), typeof(NullableDatePickerView), default(DateTime?), BindingMode.TwoWay, null, DatePropertyChanged );

        private static void DatePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var ctr = (NullableDatePickerView) bindable;
            ctr.Update();

        }

        public DateTime? Date
        {
            get { return (DateTime?) GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

      

        public NullableDatePickerView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
        }

        private void Update()
        {
          
            if (Date == null)
            {
                dp1.IsVisible = false;
                box1.IsVisible = true;
                btnClear.IsVisible = false;
                return;
            }

            dp1.IsVisible = true;
            btnClear.IsVisible = true;
            box1.IsVisible = false;
            dp1.Date = Date.Value;
        }

        private void ClearBtn_Tapped(object sender, EventArgs e)
        {
            Date = null;
            Update();
        }

        private void Dp1_DateSelected(object sender, DateChangedEventArgs e)
        {
            Date = e.NewDate;
            Update();
        }

        private void Box_Tapped(object sender, EventArgs e)
        {
            Date=DateTime.Now;
            Update();
            dp1.Focus();
        }
    }
}