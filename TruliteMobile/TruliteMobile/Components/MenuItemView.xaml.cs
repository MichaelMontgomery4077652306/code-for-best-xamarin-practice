using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuItemView : ContentView
    {

        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create("IsBusy", typeof(bool), typeof(MenuItemView), default(bool));

        public bool IsBusy
        {
            get { return (bool) GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        public static readonly BindableProperty ItemProperty =
            BindableProperty.Create("Item", typeof(MenuItemModel), typeof(MenuItemView), default(MenuItemModel)
            , BindingMode.OneWay, null, ItemPropertyChanged);

        private static void ItemPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {

        }
        
        public MenuItemModel Item
        {
            get { return (MenuItemModel) GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create("TappedCommand", typeof(ICommand), typeof(MenuItemView), default(ICommand));

        public ICommand TappedCommand
        {
            get { return (ICommand) GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }


        private bool _isExpanded;

        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                _isExpanded = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmenuSelectedCommand { get; }


        public MenuItemView()
        {
            InitializeComponent();
            SubmenuSelectedCommand= new Command<MenuItemModel>(OnSubmenuItemSelected);
            Children[0].BindingContext = this;

        }

        private void OnSubmenuItemSelected(MenuItemModel arg)
        {
            TappedCommand?.Execute(arg);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Item.HasSubMenu)
            {
                IsExpanded = !_isExpanded;
                return;
            }
            TappedCommand?.Execute(Item);
        }

    }
}