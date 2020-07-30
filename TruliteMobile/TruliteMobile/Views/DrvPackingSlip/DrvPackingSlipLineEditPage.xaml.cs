using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.DrvPackingSlip
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvPackingSlipLineEditPage : ContentPage
    {
        private readonly DrvPackingSlipLineEditPageViewModel _vm;

        public DrvPackingSlipLineEditPage(PackingSlipLine line)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvPackingSlipLineEditPageViewModel(line);
        }

        protected override async void OnDisappearing()
        {
            await _vm.Back();
            base.OnDisappearing();
        }

      
    }

    public class DrvPackingSlipLineEditPageViewModel : TruliteBaseViewModel
    {

        private PackingSlipLine _line;

        public PackingSlipLine Line
        {
            get { return _line; }
            set
            {
                _line = value;
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


        private ObservableCollection<int> _quantityList;

        public ObservableCollection<int> QuantityList
        {
            get { return _quantityList; }
            set
            {
                _quantityList = value;
                RaisePropertyChanged();
            }
        }


        private int _selectedDeliveredQuantity;

        public int SelectedDeliveredQuantity
        {
            get { return _selectedDeliveredQuantity; }
            set
            {
                _selectedDeliveredQuantity = value;
                RaisePropertyChanged();
            }
        }


        private bool _showPopup;

        public bool ShowPopup
        {
            get { return _showPopup; }
            set
            {
                _showPopup = value;
                RaisePropertyChanged();
            }
        }



        public int AvailableQuantity
        {
            get
            {
                var result = (int)(_line.ShippedQuantity.GetValueOrDefault() -
                             _selectedDeliveredQuantity -
                             _packReasonList.Sum(p => p.Quantity));
                return result > 0 ? result : ((int) _line.ShippedQuantity.GetValueOrDefault());
            }
        }


        private ObservableCollection<PackReasonEventArgs> _packReasonList;

        public ObservableCollection<PackReasonEventArgs> PackReasonList
        {
            get { return _packReasonList; }
            set
            {
                _packReasonList = value;
                RaisePropertyChanged();
            }
        }


        public ICommand QuantityChangedCommand { get; }

        public ICommand ClosePopupCommand { get; }
        public ICommand SubmitPopupCommand { get; }
        public ICommand DeleteReasonCommand { get; }
        public ICommand AddReasonCommand { get; }

        public DrvPackingSlipLineEditPageViewModel(PackingSlipLine line)
        {

            ClosePopupCommand = new Command(() => ShowPopup = false);
            SubmitPopupCommand = new AsyncDelegateCommand<PackReasonEventArgs>(OnSubmit);
            AddReasonCommand= new AsyncDelegateCommand(OnAddReason);
            QuantityChangedCommand = new AsyncDelegateCommand(OnQuantityChanged);
            Line = line;
            Title = $"{nameof(AppResources.EditLine).Translate()} {_line.Key}";
            var qtdList = new List<int>();
            for (int i = 0; i <= line.ShippedQuantity; i++)
            {
                qtdList.Add(i);
            }
            PackReasonList = line.PackingReasonList.CloneJson() ?? new ObservableCollection<PackReasonEventArgs>();
            QuantityList = new ObservableCollection<int>(qtdList);
            DeleteReasonCommand = new Command<PackReasonEventArgs>(OnDeleteReason);
            SelectedDeliveredQuantity = qtdList.Last();
            RaisePropertyChanged(nameof(AvailableQuantity));
        }

      

        private void OnDeleteReason(PackReasonEventArgs obj)
        {
            PackReasonList.Remove(obj);
            RaisePropertyChanged(nameof(AvailableQuantity));
            _packingReasonsChanged = true;
        }



        private async Task OnSubmit(PackReasonEventArgs arg)
        {
            if (_packReasonList.Sum(p => p.Quantity)
                + arg.Quantity > _line.ShippedQuantity.GetValueOrDefault())
            {
                await Alert.ShowMessage(Translate.Get(AppResources.DrvPackingSlipError));
                return;
            }
            //TODO: implement call.
            //Api.RepackPackingSlip(new RepackRequestModel
            //{
            //    PackingSlip = _line.PackingSlip.Key,
            //    Account = _line.PackingSlip.Account.Key,
            //    Branch = _line.PackingSlip.Branch.Code,
            //    RecId = _line.PackingSlip.RecId.ToLong(),
            //    SalesOrder = _line.PackingSlip.Order.Key,
            //    Data = new List<RepackModel>
            //    {
            //        new RepackModel
            //        {
            //            LineItem = _line.Key,
            //            Reasons =  new List<PackReason>
            //            {
            //                arg.Reason.
            //            }
            //        }
            //    }
            //})
            PackReasonList.Add(arg);
            RaisePropertyChanged(nameof(AvailableQuantity));
            ShowPopup = false;
            _packingReasonsChanged = true;
        }


        private async Task OnAddReason()
        {
            RaisePropertyChanged(nameof(AvailableQuantity));
            ShowPopup = true;
        }

        private async Task OnQuantityChanged()
        {
            RaisePropertyChanged(nameof(AvailableQuantity));

            if (_selectedDeliveredQuantity == (int)_line.ShippedQuantity)
            {
                PackReasonList.Clear();
                return;
            }

            ShowPopup = true;
        }

        private bool _packingReasonsChanged;
        public new async Task Back()
        {
            if (!_packingReasonsChanged) return;
            //var result = await Alert.ShowMessageConfirmation("Save changes to packing reasons?", null, "Yes","No");
            //if (!result) return;
            _line.PackingReasonList = _packReasonList;
        }
    }


}