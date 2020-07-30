using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using TruliteMobile.Enums;
using TruliteMobile.Services;
using TruliteMobile.Views.Quotes;

namespace TruliteMobile.Models
{
    public class OrderFilter : ObservableObject
    {
        private KeyValuePair<SalesOrderQueryContextStatus, string> _selectedStatus;

        public KeyValuePair<SalesOrderQueryContextStatus, string> SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                RaisePropertyChanged();
            }
        }
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

        private DateTime? _startDate;

        public DateTime? StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _endDate;

        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                RaisePropertyChanged();
            }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                RaisePropertyChanged();
            }
        }

        private string _poNumber;

        public string PONumber
        {
            get { return _poNumber; }
            set
            {
                _poNumber = value;
                RaisePropertyChanged();
            }
        }


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

        public OrderFilter()
        {
            SelectedQty = 50;
        }
    }
}