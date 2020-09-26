namespace Common
{
    using System;

    public class QuoteLineItem
    {
        private decimal amount;
        private decimal costofSalesAmount;
        private decimal discount;
        private int hBRLineNo;
        private Item item;
        private Job job;
        private ChartOfAccount lineitemAccount;
        private string lineitemDescription;
        private int  lineitemNo;
        private decimal lineitemPrice;
        private ItemTaxesType lineitemTax;
        private PriceLevel priceLevel;
        private decimal quantity;
        private Quote quote;
        private decimal retainagePercent;
        private string umStockingUnits;

        private Decimal newLastUnitCost;
        

        public QuoteLineItem()
        {
            this.item = new Item();
            this.job = new Job();
            this.lineitemTax = new ItemTaxesType();
            this.lineitemAccount = new ChartOfAccount();
            this.quote = new Quote();
            this.priceLevel = new PriceLevel();
        }

        public QuoteLineItem(int  liNo) : this()
        {
            this.lineitemNo = liNo;
        }

        public QuoteLineItem(int  lineitemno, decimal qunatity, Item item) : this()
        {
            this.lineitemNo = lineitemno;
            this.quantity = qunatity;
            this.item = item;
        }

        public override bool Equals(object obj)
        {
            QuoteLineItem item = obj as QuoteLineItem;
            if (obj == null)
            {
                return false;
            }
            return (obj.GetHashCode() == this.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.lineitemNo;
        }

        public decimal NewLastUnitCost
        {
            get { return this.newLastUnitCost; }
            set { this.newLastUnitCost = value; }
        }

        public decimal Amount
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

        public decimal CostofSalesAmount
        {
            get
            {
                return this.costofSalesAmount;
            }
            set
            {
                this.costofSalesAmount = value;
            }
        }

        public decimal Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }

        public int HRBLineNo
        {
            get
            {
                return this.hBRLineNo;
            }
            set
            {
                this.hBRLineNo = value;
            }
        }

        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public Job Job
        {
            get
            {
                return this.job;
            }
            set
            {
                this.job = value;
            }
        }

        public ChartOfAccount LineitemAccount
        {
            get
            {
                return this.lineitemAccount;
            }
            set
            {
                this.lineitemAccount = value;
            }
        }

        public string LineitemDescription
        {
            get
            {
                return this.lineitemDescription;
            }
            set
            {
                this.lineitemDescription = value;
            }
        }

        public int  LineitemNo
        {
            get
            {
                return this.lineitemNo;
            }
            set
            {
                this.lineitemNo = value;
            }
        }

        public decimal LineitemPrice
        {
            get
            {
                return this.lineitemPrice;
            }
            set
            {
                this.lineitemPrice = value;
            }
        }

        public ItemTaxesType LineitemTax
        {
            get
            {
                return this.lineitemTax;
            }
            set
            {
                this.lineitemTax = value;
            }
        }

        public PriceLevel PriceLevel
        {
            get
            {
                return this.priceLevel;
            }
            set
            {
                this.priceLevel = value;
            }
        }

        public decimal Quantity
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

        public Quote Quote
        {
            get
            {
                return this.quote;
            }
            set
            {
                this.quote = value;
            }
        }

        public decimal RetainagePercent
        {
            get
            {
                return this.retainagePercent;
            }
            set
            {
                this.retainagePercent = value;
            }
        }
    }
}

