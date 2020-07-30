using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditLimitView : ContentView
    {
        private readonly CreditLimitViewModel _vm;


        public CreditLimitView()
        {
            InitializeComponent();
            Children[0].BindingContext = _vm = new CreditLimitViewModel();
        }

        protected override async void OnBindingContextChanged()
        {

            await _vm.Load();

        }
    }



    public class CreditLimitViewModel : TruliteBaseViewModel
    {
       

        private ObservableCollection<CustomerCreditLimit> _creditList;

        public ObservableCollection<CustomerCreditLimit> CreditList
        {
            get { return _creditList; }
            set
            {
                _creditList = value;
                RaisePropertyChanged();
            }
        }


        public CreditLimitViewModel()
        {

        }


        public async Task Load()
        {

            try
            {
                IsBusy = true;
                var result = await Api.GetCustomerCreditLimits();

                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }

                CreditList= new ObservableCollection<CustomerCreditLimit>(result.Data);


            }
            catch (Exception e)
            {

               await Alert.DisplayError(e, "Could not load credit limits");

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}