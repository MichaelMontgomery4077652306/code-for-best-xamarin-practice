using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.Models;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.ReadMe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReadMePage : ContentPage
	{
        private readonly ReadMeViewModel _vm;

        public ReadMePage ()
		{
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = _vm = new ReadMeViewModel();
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }

    }

    public class ReadMeViewModel : TruliteBaseViewModel
    {
        private ObservableCollection<ReadMeModel> _list;

        public ObservableCollection<ReadMeModel> List
        {
            get { return _list; }
            set
            {
                _list = value;
                RaisePropertyChanged();
            }
        }

        private string _header;

        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                RaisePropertyChanged();
            }
        }

        public ReadMeViewModel()
        {
            Header = "ReadMe (Release on: Aug/2019)";
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var readMe = Api.GetReadme().OrderByDescending(p=>p.Number);
                List = new ObservableCollection<ReadMeModel>(readMe);

            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }


        }
    }
}