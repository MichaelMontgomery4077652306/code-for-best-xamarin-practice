using System;
using GalaSoft.MvvmLight;
using TruliteMobile.Services;

namespace TruliteMobile.Views.Quotes
{
    public class QuoteModel:ObservableObject
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

        private string _accountName;

        public string AccountName
        {
            get { return _accountName; }
            set
            {
                _accountName = value;
                RaisePropertyChanged();
            }

        }

        private string _quotation;

        public string Quotation
        {
            get { return _quotation; }
            set
            {
                _quotation = value;
                RaisePropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
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

        private StatusEnum _status;

        public StatusEnum Status
        {
            get { return _status; }
            set
            {
                _status = value;
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

        private DateTimeOffset? _expiryDate;

        public DateTimeOffset? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                _expiryDate = value;
                RaisePropertyChanged();
            }
        }

        private string _deliveryName;

        public string DeliveryName
        {
            get { return _deliveryName; }
            set
            {
                _deliveryName = value;
                RaisePropertyChanged();
            }
        }

        private string _deliveryAddress;

        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set
            {
                _deliveryAddress = value;
                RaisePropertyChanged();
            }
        }

        private DateTimeOffset? _confirmationDate;

        public DateTimeOffset? ConfirmationDate
        {
            get { return _confirmationDate; }
            set
            {
                _confirmationDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTimeOffset? _requestShipDate;

        public DateTimeOffset? RequestShipDate
        {
            get { return _requestShipDate; }
            set
            {
                _requestShipDate = value;
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

        public Quotation OriginalData { get; set; }
    }
}