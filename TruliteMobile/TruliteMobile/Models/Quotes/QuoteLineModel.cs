using System;
using System.Collections.Generic;
using System.Text;

namespace TruliteMobile.Models
{
    public class QuoteLineModel
    {

        private string itemId;

        private string itemName;

        private string lineNo;

        private string quantity;

        private string unit;

        private string unitPrice;

        private string discPercent;

        private string amount;

        private string currencyCode;

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
                this.itemId = value;
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
                this.itemName = value;
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
                this.lineNo = value;
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
                this.quantity = value;
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
                this.unit = value;
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
                this.unitPrice = value;
            }
        }

        /// <remarks/>
        public string DiscPercent
        {
            get
            {
                return this.discPercent;
            }
            set
            {
                this.discPercent = value;
            }
        }

        /// <remarks/>
        public string Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }
            set
            {
                this.currencyCode = value;
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
                this.inventTransId = value;
            }
        }
    }
}
