using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using TruliteMobile.Services;

namespace TruliteMobile.Views.Quotes
{
    public class QuoteFilter:ObservableObject
    {
        private KeyValuePair<QuotationsQueryContextStatus, string> _selectedStatus;

        public KeyValuePair<QuotationsQueryContextStatus, string> SelectedStatus
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
         
        private string _salesOrderNumber;

        public string SalesOrderNumber
        {
            get { return _salesOrderNumber; }
            set
            {
                _salesOrderNumber = value;
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

        public QuoteFilter()
        {
            StartDate= DateTime.Today.AddDays(-120);
            EndDate=DateTime.Today;
            SelectedQty = 50;
        }

    }
}