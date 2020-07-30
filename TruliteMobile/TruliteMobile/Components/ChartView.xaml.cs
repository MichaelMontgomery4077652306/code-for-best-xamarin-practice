using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microcharts;
using SkiaSharp;
using Syncfusion.SfChart.XForms;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;
using Entry = Xamarin.Forms.Entry;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartView : ContentView
    {

        public static readonly BindableProperty ChartTypeProperty =
            BindableProperty.Create("ChartType", typeof(ChartTypeEnum), typeof(ChartView), default(ChartTypeEnum), BindingMode.Default, null, TypePropertyChanged);

        private static async void TypePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var ctr = (ChartView)bindable;
            try
            {
                await ctr.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }


        public async Task Refresh()
        {
            if(!this.IsVisible)
            {
                cv1.IsVisible = false;
                return;
            }
            else
            {
                cv1.IsVisible = true;
            }
            var chartVm = new ChartViewModel
            {
                TypeEnum = ChartType
            };
            Children[0].BindingContext = chartVm;
            await chartVm.Load();

            //var chart = new SfChart();


            SKColor[] palette = new[]
            {
                SKColor.Parse("#2E71B6"),
                SKColor.Parse("#31C0BE"),
                SKColor.Parse("#2677b5"),
                SKColor.Parse("#8C8F90"),
                SKColor.Parse("#f0ad4e"),
                SKColor.Parse("#5CB85C"),
                SKColor.Parse("#d9534f"),

            };

            var bkColor = SettingsService.Instance.IsDarkTheme ? SKColor.Parse("#303030") : SKColors.White;


            Chart chart;
            switch (chartVm.DisplayChartType)
            {
                case ChartTypeDisplay.Line:
                    {
                        var entries = chartVm.ChartData.Select(p => new Microcharts.Entry((float)p.YValue)
                        {
                            Label = p.XValue.ToString(),
                            ValueLabel = p.YValue.ToString(),
                            Color = palette[0]
                        }).ToList();
                        var filteredEntries = new List<Microcharts.Entry>();
                        const double MAX_CHART_ENTRIES = 25;
                        if (entries.Count > MAX_CHART_ENTRIES)
                        {
                            int interval = (int)Math.Ceiling(entries.Count / MAX_CHART_ENTRIES);
                            for (int i = 0; i < entries.Count; i++)
                            {
                                if (i % interval == 0)
                                {
                                    filteredEntries.Add(entries[i]);
                                }
                            }
                        }
                        else
                        {
                            filteredEntries = entries;
                        }
                        chart = new LineChart()
                        {
                            Entries = filteredEntries,
                        };
                    }
                    break;
                case ChartTypeDisplay.Area:
                    {
                        //chart.Series.Add(new AreaSeries
                        //{
                        //    ItemsSource = chartVm.ChartData,
                        //    XBindingPath = "XValue",
                        //    YBindingPath = "YValue"
                        //});
                        ////chartArea.IsVisible = true;

                        chart = new LineChart()
                        {
                            Entries = chartVm.ChartData.Select(p => new Microcharts.Entry((float)p.YValue)
                            {
                                Label = p.XValue.ToString(),
                                ValueLabel = p.YValue.ToString(),
                                Color = palette[1]
                            })
                        };

                    }
                    break;
                case ChartTypeDisplay.Bar:
                    {
                        chart = new BarChart()
                        {
                            Entries = chartVm.ChartData.Select(p => new Microcharts.Entry((float)p.YValue)
                            {
                                Label = p.XValue.ToString(),
                                ValueLabel = p.YValue.ToString(),
                                Color = palette[3]
                            })
                        };
                        // chartBar.IsVisible = true;
                    }
                    break;
                case ChartTypeDisplay.Doughnut:
                    {
                        var entries = chartVm.ChartData.Select(p => new Microcharts.Entry((float)p.YValue)
                        {
                            Label = p.XValue.ToString(),
                            ValueLabel = p.YValue.ToString(),
                        }).ToArray();
                        var palleteCount = palette.Length;
                        for (int i = 0; i < entries.Count(); i++)
                        {
                            int paletteIndex = i;
                            if (paletteIndex > palleteCount)
                            {
                                paletteIndex = i % palleteCount;
                            }

                            entries[i].Color = palette[i];
                        }


                        chart = new DonutChart()
                        {
                            Entries = entries
                        };
                        //chartDoughnut.IsVisible = true;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            chart.BackgroundColor = bkColor;
            cv1.Chart = chart;

        }

        public ChartTypeEnum ChartType
        {
            get { return (ChartTypeEnum)GetValue(ChartTypeProperty); }
            set { SetValue(ChartTypeProperty, value); }
        }


        public ChartView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
        }


    }

    public class ChartViewModel : TruliteBaseViewModel
    {


        private bool _isExpanded;

        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                _isExpanded = value;
                RaisePropertyChanged();
            }
        }




        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private string _helpMessage;

        public string HelpMessage
        {
            get { return _helpMessage; }
            set
            {
                _helpMessage = value;
                RaisePropertyChanged();
            }
        }

        private ChartTypeDisplay _displayChartChartType;

        public ChartTypeDisplay DisplayChartType
        {
            get { return _displayChartChartType; }
            set
            {
                _displayChartChartType = value;
                RaisePropertyChanged();
            }
        }



        private ChartTypeEnum _typeEnum;

        public ChartTypeEnum TypeEnum
        {
            get { return _typeEnum; }
            set
            {
                _typeEnum = value;
                RaisePropertyChanged();

            }
        }


        private ObservableCollection<ChartDataPoint> _chartData;

        public ObservableCollection<ChartDataPoint> ChartData
        {
            get { return _chartData; }
            set
            {
                _chartData = value;
                RaisePropertyChanged();
            }
        }


        public ICommand RefreshCommand { get; }
        public ICommand ToggleCommand { get; }
        public ICommand ShowHelpMessageCommand { get; }



        public ChartViewModel()
        {
            IsExpanded = true;
            ShowHelpMessageCommand = new AsyncDelegateCommand(OnShowHelpMessage);
            ToggleCommand = new Command(() => IsExpanded = !_isExpanded);
            RefreshCommand = new AsyncDelegateCommand(Load);
        }

        private async Task OnShowHelpMessage()
        {
            await Alert.ShowMessage(_helpMessage, _title);
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                switch (_typeEnum)
                {
                    case ChartTypeEnum.NotSet:
                        return;
                        break;
                    case ChartTypeEnum.SalesOrderSummary:
                        {
                            Title = nameof(AppResources.SalesOrdersSummary).Translate();
                            HelpMessage = nameof(AppResources.SalesOrdersSummaryHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Doughnut;
                            var data = await Api.GetSalesOrdersSummaryByStatus(DateTimeOffset.Now.AddDays(-90), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Day);
                            data = data ?? new List<ChartDataPointOfString>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label, p.Value.GetValueOrDefault())));

                        }
                        break;
                    case ChartTypeEnum.OrdersDaily:
                        {
                            Title = nameof(AppResources.OrdersDaily).Translate();
                            HelpMessage = nameof(AppResources.OrdersDailyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Line;
                            var data = await Api.GetSalesOrdersSummary(DateTimeOffset.Now.AddDays(-90), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Day);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint($"{p.Label:d}", p.Value.GetValueOrDefault())));
                        }

                        break;
                    case ChartTypeEnum.OrdersMontly:
                        {
                            Title = nameof(AppResources.OrdersMonthly).Translate();
                            HelpMessage = nameof(AppResources.OrdersMonthlyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Bar;
                            var data = await Api.GetSalesOrdersSummary(DateTimeOffset.Now.AddMonths(-12), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Month);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("MM/yyyy"), p.Value.GetValueOrDefault())));
                        }
                        break;
                    case ChartTypeEnum.OrdersYearly:
                        {
                            Title = nameof(AppResources.OrdersYearly).Translate();
                            HelpMessage = nameof(AppResources.OrdersYearlyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Area;
                            var data = await Api.GetSalesOrdersSummary(new DateTimeOffset(new DateTime(DateTime.Now.Year - 1, 1, 1)), new DateTimeOffset(new DateTime(DateTime.Now.Year, 12, 31)), SalesOrderSummaryQueryContextSummaryPeriod.Year);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("yyyy"), p.Value.GetValueOrDefault())));

                        }
                        break;
                    case ChartTypeEnum.InvoicesDaily:
                        {
                            Title = nameof(AppResources.InvoicesDaily).Translate();
                            HelpMessage = nameof(AppResources.InvoicesDailyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Line;
                            var data = await Api.GetInvoicesSummary(DateTimeOffset.Now.AddDays(-90), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Day);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("d"), p.Value.GetValueOrDefault())));
                        }
                        break;
                    case ChartTypeEnum.InvoicesMonthly:
                        {
                            Title = nameof(AppResources.InvoicesMonthly).Translate();
                            HelpMessage = nameof(AppResources.InvoicesMonthlyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Bar;
                            var data = await Api.GetInvoicesSummary(DateTimeOffset.Now.AddMonths(-12), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Month);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("MM/yyyy"), p.Value.GetValueOrDefault())));
                        }
                        break;
                    case ChartTypeEnum.InvoicesQuarterly:
                        {
                            Title = nameof(AppResources.InvoicesQuarterly).Translate();
                            HelpMessage = nameof(AppResources.InvoicesQuarterlyHintText).Translate();

                            DisplayChartType = ChartTypeDisplay.Doughnut;
                            var data = await Api.GetInvoicesSummary(DateTimeOffset.Now.AddMonths(-12), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Quarter);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("MM/yyyy"), p.Value.GetValueOrDefault())));
                        }
                        break;
                    case ChartTypeEnum.ReturnsMontly:
                        {
                            Title = nameof(AppResources.ReturnsMonthly).Translate();
                            HelpMessage = nameof(AppResources.ReturnsMonthlyHintText).Translate();
                            DisplayChartType = ChartTypeDisplay.Bar;
                            var data = await Api.GetReturnOrderSummary(DateTimeOffset.Now.AddMonths(-12), DateTimeOffset.Now, SalesOrderSummaryQueryContextSummaryPeriod.Quarter);
                            data = data ?? new List<ChartDataPointOfDateTime>();
                            ChartData = new ObservableCollection<ChartDataPoint>(data.Select(p => new ChartDataPoint(p.Label.GetValueOrDefault().ToString("MM/yyyy"), p.Value.GetValueOrDefault())));

                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            finally
            {
                IsBusy = false;
            }

        }
    }

    public enum ChartTypeEnum
    {
        NotSet,
        SalesOrderSummary,
        OrdersYearly,
        InvoicesQuarterly,
        InvoicesMonthly,
        OrdersDaily,
        OrdersMontly,
        InvoicesDaily,
        ReturnsMontly

    }

    public enum ChartTypeDisplay
    {
        Line,
        Area,
        Bar,
        Doughnut,

    }

}