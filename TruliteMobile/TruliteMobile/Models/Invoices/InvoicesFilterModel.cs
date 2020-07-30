using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using TruliteMobile.Enums;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Services;

namespace TruliteMobile.Models
{
    public class InvoicesFilterModel : ObservableObject
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

        private DateTime? _startDueDate;

        public DateTime? StartDueDate
        {
            get { return _startDueDate; }
            set
            {
                _startDueDate = value;
                RaisePropertyChanged();
            }
        }

        private DateTime? _endDueDate;

        public DateTime? EndDueDate
        {
            get { return _endDueDate; }
            set
            {
                _endDueDate = value;
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

        private KeyValuePair<InvoicesQueryContextStatus, string> _status;

        public KeyValuePair<InvoicesQueryContextStatus, string> Status
        {
            get { return _status; }
            set { _status = value; RaisePropertyChanged(); }
        }

        public InvoicesFilterModel()
        {
            Status = new KeyValuePair<InvoicesQueryContextStatus, string>(InvoicesQueryContextStatus.NotPaid,
                nameof(AppResources.NotPaid).Translate());
            SelectedQty = 50;
        }
    }
}