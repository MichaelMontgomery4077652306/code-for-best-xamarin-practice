using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;

namespace TruliteMobile.Models
{
    public class InvoiceLineModel : ObservableObject
    {
        private string itemId;

        private string lineNo;

        private string itemName;

        private string unitPrice;

        private string quantity;

        private string discount;

        private string type;

        private string deliveryDate;

        private string unit;

        private string listSqftLit;

        private string shippedQuantity;

        private string inventTransId;

        /// <remarks/>
        public string ItemId
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string LineNo
        {
            get
            {
                return this.lineNo;
            }
            set
            {
                this.lineNo = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string ItemName
        {
            get
            {
                return this.itemName;
            }
            set
            {
                this.itemName = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string DeliveryDate
        {
            get
            {
                return this.deliveryDate;
            }
            set
            {
                this.deliveryDate = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string ListSqftLit
        {
            get
            {
                return this.listSqftLit;
            }
            set
            {
                this.listSqftLit = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string ShippedQuantity
        {
            get
            {
                return this.shippedQuantity;
            }
            set
            {
                this.shippedQuantity = value; RaisePropertyChanged();
            }
        }

        /// <remarks/>
        public string InventTransId
        {
            get
            {
                return this.inventTransId;
            }
            set
            {
                this.inventTransId = value; RaisePropertyChanged();
            }
        }
    }
}
