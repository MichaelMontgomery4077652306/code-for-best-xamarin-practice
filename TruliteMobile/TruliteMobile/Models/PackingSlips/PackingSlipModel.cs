using System;
using GalaSoft.MvvmLight;
using TruliteMobile.Services;

namespace TruliteMobile.Models
{
    public class PackingSlipModel : ObservableObject
    {
        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                _accountNumber = value;
                RaisePropertyChanged();
            }
        }

        private string _account;

        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
                RaisePropertyChanged();
            }
        }

        private string _pO;

        public string PurchaseOrder
        {
            get { return _pO; }
            set
            {
                _pO = value;
                RaisePropertyChanged();
            }
        }

        private string _jobName;

        public string JobName
        {
            get { return _jobName; }
            set
            {
                _jobName = value;
                RaisePropertyChanged();
            }
        }

        private string _orderNumber;

        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                _orderNumber = value;
                RaisePropertyChanged();
            }
        }

       

        private string _plant;

        public string Plant
        {
            get { return _plant; }
            set
            {
                _plant = value;
                RaisePropertyChanged();
            }
        }

        private string _packingSlip;

        public string PackingSlip
        {
            get { return _packingSlip; }
            set
            {
                _packingSlip = value;
                RaisePropertyChanged();
            }
        }


        private DateTimeOffset? _orderDate;

        public DateTimeOffset? OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTimeOffset? _dateShipped;

        public DateTimeOffset? DateShipped
        {
            get { return _dateShipped; }
            set
            {
                _dateShipped = value;
                RaisePropertyChanged();
            }
        }

        private DateTimeOffset? _requestedDeliveryDate;

        public DateTimeOffset? RequestedDeliveryDate
        {
            get { return _requestedDeliveryDate; }
            set
            {
                _requestedDeliveryDate = value;
                RaisePropertyChanged();
            }
        }

        private string _terms;

        public string Terms
        {
            get { return _terms; }
            set
            {
                _terms = value;
                RaisePropertyChanged();
            }
        }

        private double? _weight;

        public double? Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                RaisePropertyChanged();
            }
        }

        private double? _sqft;

        public double? Sqft
        {
            get { return _sqft; }
            set
            {
                _sqft = value;
                RaisePropertyChanged();
            }
        }

        private int? _lines;

        public int? Lines
        {
            get { return _lines; }
            set
            {
                _lines = value;
                RaisePropertyChanged();
            }
        }

        private string _proofOfDelivery;
        private string _voucher;

        public string ProofOfDelivery
        {
            get { return _proofOfDelivery; }
            set
            {
                _proofOfDelivery = value;
                RaisePropertyChanged();
            }
        }
        public string Voucher
        {
            get { return _voucher; }
            set { _voucher = value; RaisePropertyChanged(); }
        }

        public PackingSlip OriginalData { get; set; }

    
    }
}