using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruliteMobile.Views.DrvPackingSlip
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvPackingSlipIssueView : ContentView
    {
        public static readonly BindableProperty QuantityProperty =
            BindableProperty.Create("Quantity", typeof(int),
                typeof(DrvPackingSlipIssueView), -1, BindingMode.Default, null, QuantityPropertyChanged);

        private static void QuantityPropertyChanged(BindableObject bindable, object oldvalue, 
            object newvalue)
        {
            ((DrvPackingSlipIssueView)bindable).Init();
        }


        private void Init()
        {

            var list = new List<int>();
            for (int i = 0; i <= Quantity; i++)
            {
                list.Add(i);
            }
            QuantityList = new ObservableCollection<int>(list);
            if(!list.Any())return;
            SelectedQuantity = Quantity > 0 ? Quantity : list.FirstOrDefault();

        }

        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }


        public static readonly BindableProperty ClosePopupCommandProperty =
            BindableProperty.Create("ClosePopupCommand", 
                typeof(ICommand), typeof(DrvPackingSlipIssueView),
                default(ICommand));

        public ICommand ClosePopupCommand
        {
            get { return (ICommand)GetValue(ClosePopupCommandProperty); }
            set { SetValue(ClosePopupCommandProperty, value); }
        }


        public static readonly BindableProperty SubmitCommandProperty =
            BindableProperty.Create("SubmitCommand", typeof(ICommand), 
                typeof(DrvPackingSlipIssueView), default(ICommand));

        public ICommand SubmitCommand
        {
            get { return (ICommand)GetValue(SubmitCommandProperty); }
            set { SetValue(SubmitCommandProperty, value); }
        }


        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<KeyNameModelOfString> _reasonList;

        public ObservableCollection<KeyNameModelOfString> ReasonList
        {
            get { return _reasonList; }
            set
            {
                _reasonList = value;
                OnPropertyChanged();
            }
        }

        private KeyNameModelOfString _selectedReason;

        public KeyNameModelOfString SelectedReason
        {
            get { return _selectedReason; }
            set
            {
                _selectedReason = value;
                OnPropertyChanged();
            }
        }


        private KeyNameModelOfString _selectedAction;

        public KeyNameModelOfString SelectedAction
        {
            get { return _selectedAction; }
            set
            {
                _selectedAction = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<KeyNameModelOfString> _actionList;

        public ObservableCollection<KeyNameModelOfString> ActionList
        {
            get { return _actionList; }
            set
            {
                _actionList = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<int> _quantityList;

        public ObservableCollection<int> QuantityList
        {
            get { return _quantityList; }
            set
            {
                _quantityList = value;
                OnPropertyChanged();
            }
        }

        private int _selectedQuantity;

        public int SelectedQuantity
        {
            get { return _selectedQuantity; }
            set
            {
                _selectedQuantity = value;
                OnPropertyChanged();
            }
        }


        public DrvPackingSlipIssueView()
        {
            InitializeComponent();
            Children[0].BindingContext = this;
        }

        protected override async void OnBindingContextChanged()
        {
            await Load();
        }

        public async Task Load()
        {

            try
            {
                IsBusy = true;
                var reasonsResponse = await ApiService.Instance.GetRepackReasons();
                if (!reasonsResponse.Successful.GetValueOrDefault())
                {
                    await AlertService.Instance.DisplayApiCallError(reasonsResponse.ExceptionMessage,
                        reasonsResponse.ValidationErrors, TranslationService.Instance.Get(nameof(AppResources.CouldNotGetBranchList)));
                    return;
                }
                ReasonList = new ObservableCollection<KeyNameModelOfString>(reasonsResponse.Data);
                SelectedReason = _reasonList.FirstOrDefault();

                var actionsResponse = await ApiService.Instance.GetRepackActions();
                if (!actionsResponse.Successful.GetValueOrDefault())
                {
                    await AlertService.Instance.DisplayApiCallError(actionsResponse.ExceptionMessage,
                        actionsResponse.ValidationErrors, TranslationService.Instance.Get(nameof(AppResources.CouldNotGetActionList)));
                    return;
                }
                ActionList = new ObservableCollection<KeyNameModelOfString>(actionsResponse.Data);
                SelectedAction = _actionList.FirstOrDefault();
            }
            catch (Exception e)
            {
                await AlertService.Instance.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }

        }

        private void ActionButtonView_TappedEvent(object sender, object e)
        {

            var packReason = new PackReasonEventArgs
            {
                Action = _selectedAction,
                Reason = _selectedReason,
                Quantity = _selectedQuantity
            };

            SubmitCommand?.Execute(packReason);
        }
    }

    public class PackReasonEventArgs
    {
        public KeyNameModelOfString Action { get; set; }

        public KeyNameModelOfString Reason { get; set; }

        public int Quantity { get; set; }
    }
}