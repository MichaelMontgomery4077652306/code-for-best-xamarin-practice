using System;
using GalaSoft.MvvmLight;
using TruliteMobile.Services;

namespace TruliteMobile.Models
{
    public class PackingSlipFilterModel : ObservableObject
    {

        private int _selectedQty;

        public int SelectedQty
        {
            get { return _selectedQty; }
            set
            {
                _selectedQty = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _dateFrom;

        public DateTime? DateFrom
        {
            get { return _dateFrom; }
            set
            {
                _dateFrom = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _dateTo;

        public DateTime? DateTo
        {
            get { return _dateTo; }
            set
            {
                _dateTo = value;
                RaisePropertyChanged();
            }
        }

        private string _packingSlipId;

        public string PackingSlipId
        {
            get { return _packingSlipId; }
            set
            {
                _packingSlipId = value;
                RaisePropertyChanged();
            }
        }

        private string _purchaseOrder;

        public string PurchaseOrder
        {
            get { return _purchaseOrder; }
            set
            {
                _purchaseOrder = value;
                RaisePropertyChanged();
            }
        }

        private string _salesOrder;

        public string SalesOrder
        {
            get { return _salesOrder; }
            set
            {
                _salesOrder = value;
                RaisePropertyChanged();
            }
        }

        private string _accountNumber;
         //Account number?
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                _accountNumber = value;
                RaisePropertyChanged();
            }
        }


        private string _custAccount;

        public string CustAccount
        {
            get { return _custAccount; }
            set
            {
                _custAccount = value;
                RaisePropertyChanged();
            }
        }

        public PackingSlipFilterModel()
        {
            SelectedQty = 50;
        }

      

    }


}