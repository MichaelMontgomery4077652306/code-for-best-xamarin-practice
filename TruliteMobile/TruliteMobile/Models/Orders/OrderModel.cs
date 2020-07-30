using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using TruliteMobile.Enums;
using TruliteMobile.Services;

namespace TruliteMobile.Views.Orders
{
    public class OrderModel : ObservableObject
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

        private ObservableCollection<string> _invoices;

        public ObservableCollection<string> Invoices
        {
            get { return _invoices; }
            set
            {
                _invoices = value;
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

        private ObservableCollection<string> _packingSlips;

        public ObservableCollection<string> PackingSlips
        {
            get { return _packingSlips; }
            set
            {
                _packingSlips = value;
                RaisePropertyChanged();
            }
        }

        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                RaisePropertyChanged();
            }
        }

        private SalesOrderQueryContextStatus _status;

        public SalesOrderQueryContextStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
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

        public string ProofOfDelivery
        {
            get { return _proofOfDelivery; }
            set
            {
                _proofOfDelivery = value;
                RaisePropertyChanged();
            }
        }

        private string _confirmation;

        public string Confirmation
        {
            get { return _confirmation; }
            set
            {
                _confirmation = value;
                RaisePropertyChanged();
            }
        }

        private string _trackingCode;

        public string TrackingCode
        {
            get { return _trackingCode; }
            set
            {
                _trackingCode = value;
                RaisePropertyChanged();
            }
        }

        public SalesOrder Source { get; set; }
    }
}