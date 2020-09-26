namespace Common
{
    using System;
    using System.Collections.Generic;

    public class SaleInvoiceLineItem
    {
        
        private decimal costofSalesAmount;
        private decimal discount;
        private int hRBLineNo;
        private Item item;
        private Job job;
        private ChartOfAccount lineitemAccount;
        private string lineitemDescription;
        private int  lineitemNo;
        private decimal lineitemPrice;
        private ItemTaxesType lineitemTax;
        private PriceLevel priceLevel;
        private decimal quantity;
        private decimal remainingQuantity;
        private decimal retainagePercent;
        private SaleInvoice saleInvoice;
        private SaleInLineItemType saleInvoiceLineItemType;
        private int salesOrderDistributionNumber;
        private Decimal shippedquantity;
        private string umStockingUnits;

        private Decimal newLastUnitCost;
        private PriceLevel usedPriceLevel;
        

        private decimal qtyOrderd;
        private decimal discPct;
        private decimal discUnitPrice;
        
        public AttributeLineItem  FrameColor
        { get; set; }
    

        public decimal QtyOrderd
        {
            get {return  this.qtyOrderd; }
            set { this.qtyOrderd = value; }
        }

       

        public decimal DiscUnitPrice
        {
            get { return this.discUnitPrice; }
            set { this.discUnitPrice = value; }
        }

   

        public PriceLevel UsedPriceLevel
        {
            get { return this.usedPriceLevel; }
            set { this.usedPriceLevel = value; }
        }

        public SaleInvoiceLineItem(SaleInLineItemType lineItemType)
        {
            this.saleInvoiceLineItemType = lineItemType;
            this.item = new Item();
            this.job = new Job();
            this.lineitemTax = new ItemTaxesType();
            this.lineitemAccount = new ChartOfAccount();
            this.priceLevel = new PriceLevel();
            this.saleInvoice = new SaleInvoice();
            this.usedPriceLevel = new PriceLevel();
            this.FrameColor = new AttributeLineItem();
        }

        public SaleInvoiceLineItem(SaleInLineItemType lineItemType, int liNo) : this(lineItemType)
        {
            this.lineitemNo = liNo;
        }

        public SaleInvoiceLineItem(SaleInLineItemType lineItemType, int  lineitemno, decimal qunatity, Item item) : this(lineItemType)
        {
            this.lineitemNo = lineitemno;
            this.quantity = qunatity;
            this.item = item;
        }
        
        public override bool Equals(object obj)
        {
            SaleInvoiceLineItem item = obj as SaleInvoiceLineItem;
            if (obj == null)
            {
                return false;
            }
            return ((item.GetHashCode() == this.GetHashCode()) && (item.saleInvoiceLineItemType == this.saleInvoiceLineItemType));
        }

        public override int GetHashCode()
        {
            return this.lineitemNo;
        }

        public int GetNextLineItemNo(SaleInvoiceLineItem li, int oldLno, List<SaleInvoiceLineItem> lis)
        {
            for (int i = 0; i < lis.Count; i++)
            {



                if (li.SaleInvoiceLineItemType == lis[i].SaleInvoiceLineItemType && oldLno == lis[i].LineitemNo && oldLno != -1)
                {
                    if (lis.Count > i + 1)
                        return lis[i + 1].LineitemNo;
                }
                else if (oldLno == -1 && li.SaleInvoiceLineItemType == lis[i].SaleInvoiceLineItemType)
                {
                    return lis[i].LineitemNo;
                }


            }
            return -1;
        }
        public decimal DiscPct
        
        {get  ;             set ;}

        public decimal NewLastUnitCost
        {
            get { return this.newLastUnitCost; }
            set { this.newLastUnitCost = value; }
        }

        public decimal ExtendedAmount
        {
            get;
            set;
        }
        public Decimal Amount
        {
            get;
            set;
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
                return this.hRBLineNo;
            }
            set
            {
                this.hRBLineNo = value;
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

        public decimal RemainingQuantity
        {
            get
            {
                return this.remainingQuantity;
            }
            set
            {
                this.remainingQuantity = value;
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

        public SaleInvoice SaleInvoice
        {
            get
            {
                return this.saleInvoice;
            }
            set
            {
                this.saleInvoice = value;
            }
        }

        public SaleInLineItemType SaleInvoiceLineItemType
        {
            get
            {
                return this.saleInvoiceLineItemType;
            }
            set
            {
                this.saleInvoiceLineItemType = value;
            }
        }

        public int SalesOrderDistributionNumber
        {
            get
            {
                return this.salesOrderDistributionNumber;
            }
            set
            {
                this.salesOrderDistributionNumber = value;
            }
        }
    }
}

