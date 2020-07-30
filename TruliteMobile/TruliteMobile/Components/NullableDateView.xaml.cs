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
    public partial class NullableDateView : ContentView
    {

        public static readonly BindableProperty DateProperty =
            BindableProperty.Create("Date", typeof(DateTime?), typeof(NullableDateView), default(DateTime?), BindingMode.TwoWay
            , null, DatePropertyChanged);

        private static void DatePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            ((NullableDateView)bindable).Update();
            
        }

        private Grid _rootGrid;
        private DatePicker _tp;

        public DateTime? Date
        {
            get { return (DateTime?) GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }   
        public NullableDateView()
        {
            InitializeComponent();
            _rootGrid = (Grid) Children[0];
            Children[0].BindingContext = this;
        }


        private void Update()
        {
            if(Date==null)
            {
                lb1.IsVisible = false;
                lbPlaceholder.IsVisible = true;
                clearIcon.IsVisible = false;
            }
            else
            {
                lb1.Text = Date.Value.ToShortDateString();
                lb1.IsVisible = true;
                clearIcon.IsVisible = true;
                lbPlaceholder.IsVisible = false;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (_tp != null)
            {
                _rootGrid.Children.Remove(_tp);
            }
            _tp = new DatePicker()
            {
                Date = Date ?? DateTime.Today
            };
            _rootGrid.Children.Insert(0,_tp);
            _tp.DateSelected += Tp_DateSelected;
            _tp.Focus();
            _tp.IsVisible = false;
        }


        private void Tp_DateSelected(object sender, DateChangedEventArgs e)
        {
            Date = _tp.Date;
        }

        private void Clear_Tapped(object sender, EventArgs e)
        {
            Date = null;
        }
    }
}