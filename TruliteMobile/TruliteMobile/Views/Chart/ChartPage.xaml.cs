using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Syncfusion.SfChart.XForms;
using TruliteMobile.Components;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace TruliteMobile.Views.Chart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartPage : ContentPage
    {
        private readonly ChartViewModel _vm;

        public ChartPage()
        {
            InitializeComponent();
            BindingContext =_vm= new ChartViewModel();
        }

        protected override async void OnAppearing()
        {
            _vm.TypeEnum = ChartTypeEnum.OrdersYearly;
            await _vm.Load();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //var entries = new[]
            //{
            //    new Entry()
            //    {
            //        Label = "UWP",
            //        ValueLabel = "212",
            //        Color = SKColor.Parse("#2c3e50")
            //    },
            //};


            var chart = new LineChart() { Entries = _vm.ChartData.Select(p=>new Entry((float)p.YValue)
            {
                Label=p.XValue.ToString(),
                ValueLabel = p.YValue.ToString(),
                Color =SKColor.Parse("#23b7e5") 
            }) };


            chartView.Chart = chart;
            //var chart = new SfChart {HeightRequest = 300, WidthRequest = 300};
            //chart.Series.Add(new AreaSeries
            //{
            //    ItemsSource = _vm.ChartData,
            //    XBindingPath = "XValue",
            //    YBindingPath = "YValue"
            //});
            //grd1.Children.Clear();
            //grd1.Children.Add(chart);
        }
    }


}