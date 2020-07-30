using System;
using System.Collections.Generic;
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
    public partial class DrvPackingSlipSubmitPage : ContentPage
    {
        private readonly DrvPackingSlipSubmitPageViewModel _vm;

        public DrvPackingSlipSubmitPage(PackingSlip packingSlip)
        {
            InitializeComponent();
            BindingContext = _vm = new DrvPackingSlipSubmitPageViewModel(packingSlip);
        }


    }

    public class DrvPackingSlipSubmitPageViewModel : TruliteBaseViewModel
    {

        private PackingSlip _packingSlip;

        public PackingSlip PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                _packingSlip = value;
                RaisePropertyChanged();
            }
        }


        private string _note;

        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand SubmitCommand { get; }

        public DrvPackingSlipSubmitPageViewModel(PackingSlip packingSlip)
        {
            PackingSlip = packingSlip;
            CloseCommand= new AsyncDelegateCommand(OnClose);
            SubmitCommand= new AsyncDelegateCommand(OnSubmit);

        }

        private async Task OnSubmit()
        {
            try
            {
                IsBusy = true;

                RepackRequestModel context = new RepackRequestModel
                {
                    Account = _packingSlip.Account.Key,
                    Note = _note,
                    PackingSlip = _packingSlip.Key,
                    RecId = _packingSlip.RecId.ToLong(),
                    SalesOrder = _packingSlip.Order.Key,

                };

                var modelList = new List<RepackModel>();
                foreach (var packingSlipWithRePacking in _packingSlip.Lines.Where(p => p.PackingReasonList?.Any() ?? false))
                {
                    var rpackModel = new RepackModel
                    {
                        LineItem = packingSlipWithRePacking.Key,
                        Reasons = packingSlipWithRePacking.PackingReasonList.Select(p => new PackReason
                        {
                            Action = p.Action.Key,
                            InventTransId = (int) packingSlipWithRePacking.InventTransId.ToLong(),
                            Quantity = p.Quantity,
                            Reason = p.Reason.Key
                        }).ToList()
                    };
                    modelList.Add(rpackModel);
                }

                context.Data = modelList;
                var submitResponse = await Api.RepackPackingSlip(context);
                if (!submitResponse.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(submitResponse.ExceptionMessage, submitResponse.ValidationErrors,
                        Translate.Get(nameof(AppResources.CouldNotSubmitRepacking)));
                    return;
                }

                await Nav.Nav.PopAsync();

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

        private async Task OnClose()
        {
            await Nav.Nav.PopAsync();
        }
    }
}