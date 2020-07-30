using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListSortView : ContentView
    {

        public static readonly BindableProperty FilterTriggerCommandProperty =
            BindableProperty.Create("FilterTriggerCommand", typeof(ICommand), typeof(ListSortView), default(ICommand));

        public ICommand FilterTriggerCommand
        {
            get { return (ICommand) GetValue(FilterTriggerCommandProperty); }
            set { SetValue(FilterTriggerCommandProperty, value); }
        }

        public static readonly BindableProperty SortColumnsProperty =
            BindableProperty.Create("SortColumns", typeof(ObservableCollection<SortColumnItem>), typeof(ListSortView), default(ObservableCollection<SortColumnItem>));

        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return (ObservableCollection<SortColumnItem>)GetValue(SortColumnsProperty); }
            set { SetValue(SortColumnsProperty, value); }
        }

        public static readonly BindableProperty AscendingProperty =
            BindableProperty.Create("Ascending", typeof(bool), typeof(ListSortView), default(bool), BindingMode.TwoWay);


        public static readonly BindableProperty SelectedSortColumnProperty =
            BindableProperty.Create("SelectedSortColumn", typeof(SortColumnItem), typeof(ListSortView), default(SortColumnItem), BindingMode.TwoWay);

        public SortColumnItem SelectedSortColumn
        {
            get { return (SortColumnItem)GetValue(SelectedSortColumnProperty); }
            set { SetValue(SelectedSortColumnProperty, value); OnPropertyChanged(); }
        }


        public bool Ascending
        {
            get { return (bool)GetValue(AscendingProperty); }
            set { SetValue(AscendingProperty, value); OnPropertyChanged(); }
        }



        public ListSortView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;

        }

        private void SortOrderTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Ascending = !Ascending;
            if (SelectedSortColumn != null)
            {
                SelectedSortColumn.Ascending = Ascending;
            }
            
            FilterTriggerCommand?.Execute(SelectedSortColumn);
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedSortColumn!=null)
            {
                SelectedSortColumn.Ascending = Ascending;
            }
            FilterTriggerCommand?.Execute(SelectedSortColumn);
        }
    }

    public class SortColumnItem
    {
        public object Key { get; set; }
        public string Value { get; set; }

        public bool Ascending { get; set; }

        public SortColumnItem()
        {
            
        }
        public SortColumnItem(object key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}