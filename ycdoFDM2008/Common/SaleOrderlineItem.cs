namespace Common
{
    using System;

    public class SaleOrderlineItem
    {
        //private decimal amount;
        private decimal costofSalesAmount;
        private int distributionNumber;
        private int hBRLineNo;
        private Item item;
        private Job job;
        private ChartOfAccount lineitemAccount;
        private string lineitemDescription;
        private int lineitemNo;
        private decimal lineitemPrice;
        private ItemTaxesType lineitemTax;
        private PriceLevel priceLevel;
        private decimal quantity;
        private decimal retainagePercent;
        private SaleOrder saleorder;
        private Decimal shipped;
        private string umStockingUnits;

        private Decimal newLastUnitCost;

        public SaleOrderlineItem()
        {
            this.item = new Item();
            this.job = new Job();
            this.lineitemTax = new ItemTaxesType();
            this.lineitemAccount = new ChartOfAccount();
            this.saleorder = new SaleOrder();
            this.priceLevel = new PriceLevel();
            this.FrameColor = new AttributeLineItem();
        }

        public SaleOrderlineItem(int  liNo) : this()
        {
            this.lineitemNo = liNo;
        }

        public SaleOrderlineItem(int lineitemno, decimal qunatity, Item item) : this()
        {
            this.lineitemNo = lineitemno;
            this.quantity = qunatity;
            this.item = item;
        }

        public override bool Equals(object obj)
        {
            SaleOrderlineItem item = obj as SaleOrderlineItem;
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

        public decimal DiscPct
        { get; set; }
        public AttributeLineItem FrameColor
        { get; set; }


        public decimal QtyOrderd
        {
            get;
            set;
        }



        public decimal DiscUnitPrice
        {
            get;
            set;
        }


        public decimal ExtendedAmount
        { get; set; }
        public decimal Amount
        { get; set; }

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

        public int DistributionNumber
        {
            get
            {
                return this.distributionNumber;
            }
            set
            {
                this.distributionNumber = value;
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

        public int LineitemNo
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

        public SaleOrder Saleorder
        {
            get
            {
                return this.saleorder;
            }
            set
            {
                this.saleorder = value;
            }
        }

        public Decimal QtyShipped
        { 
            get;
            set; 
        }
        public decimal QtyBO
        {
            get;
            set;
        }
    }
}

