using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using TruliteMobile.Enums;
using TruliteMobile.Services;

namespace TruliteMobile.Models
{
    public class InvoiceModel : Invoice
    {

        private bool _isSelected;
         
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged();
            }
        }


        public bool IsPaymentPending
        {
            get { return InvoiceStatus != Services.InvoiceStatus.Paid && (IsPaymentPendingOrCompleted.HasValue ? IsPaymentPendingOrCompleted.Value : false); }
        }

        public bool IsPaid
        {
            get { return InvoiceStatus == Services.InvoiceStatus.Paid; }
        }

        public bool IsNotPaid
        {
            get
            {
                return InvoiceStatus != Services.InvoiceStatus.Paid &&
                  (IsPaymentPendingOrCompleted.HasValue ? !IsPaymentPendingOrCompleted.Value : true);
            }
        }

    }
}
