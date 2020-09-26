namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SaleOrder
    {
        private bool closeSO;
        private ChartOfAccount arAccount;
        
        public static string Condition;
        private string cusNote;
        private Customer customer;
        private string customerPo;
        private decimal discountAmount;
        private bool dropShip;
        private ChartOfAccount freightAccount;
        private decimal freightAmount;
        private List<HRobItem> hRobItems;
        private string internalNote;
        private List<SaleOrderlineItem> lineItems;
        private bool notePrintsAfterLineItems;
        private string quoteNo;
        private decimal saleOrderLineItemTotalAmount;
        private string saleOrderNo;
        private SalesPerson salesRep;
        private decimal salesTaxAmount;
        private SalesTaxCode salestaxCode;
        private ShipAddress shipAddress;
        private DateTime shipbyDate;
        private ShipVia shipVia;
        private string statementNote;
        private bool statementNotePrintsBeforeRef;
        private decimal taxableItemAmount;
        private DateTime transactionDate;
        private string transactionGUID;
        private decimal transactionTotal;

        public SaleOrder()
        {
            this.lineItems = new List<SaleOrderlineItem>();
            this.customer = new Customer();
            this.salestaxCode = new SalesTaxCode();
            this.arAccount = new ChartOfAccount();
            this.freightAccount = new ChartOfAccount();
            this.salesRep = new SalesPerson();
            this.shipVia = new ShipVia();
            this.shipAddress = new ShipAddress();
            this.hRobItems = new List<HRobItem>();
        }

        public SaleOrder(List<SaleOrderlineItem> SaleOrderlineitems) : this()
        {
            this.lineItems = SaleOrderlineitems;
        }

        public SaleOrder(string sono) : this()
        {
            this.saleOrderNo = sono;
        }

        public SaleOrder(string sono, string guid) : this()
        {
            this.saleOrderNo = sono;
            this.transactionGUID = guid;
        }

        public bool AddLineItem(SaleOrderlineItem qli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleOrderlineItem>();
                }
                if (!this.lineItems.Contains(qli))
                {
                    this.lineItems.Add(qli);
                }
                else
                {
                    this.lineItems[this.lineItems.IndexOf(qli)] = qli;
                }
                flag = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public void AssignToLineItem(SaleOrder so)
        {
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleOrderlineItem>();
                }
                foreach (SaleOrderlineItem item in this.lineItems)
                {
                    item.Saleorder = so;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DelLineItem(SaleOrderlineItem sli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleOrderlineItem>();
                }
                if (this.lineItems.Contains(sli))
                {
                    this.lineItems.RemoveAt(this.lineItems.IndexOf(sli));
                    return true;
                }
                flag = false;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public override bool Equals(object obj)
        {
            SaleOrder order = obj as SaleOrder;
            if (order == null)
            {
                return false;
            }
            return (order.saleOrderNo == this.saleOrderNo);
        }

        public string GenerateNumber(string sono)
        {
            int num;
            string str = "";
            string str2 = "1234567890";
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            string str3 = "";
            for (num = 0; num < str2.Length; num++)
            {
                if (sono.Contains<char>(str2[num]))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (num = sono.Length - 1; num > -1; num--)
                {
                    if (!flag3)
                    {
                        if ((Convert.ToInt16(sono[num]) >= 0x30) && (Convert.ToInt16(sono[num]) <= 0x39))
                        {
                            if (!flag2)
                            {
                                flag2 = true;
                                str3 = Convert.ToString(sono[num]);
                            }
                            else
                            {
                                str3 = Convert.ToString(sono[num]) + str3;
                            }
                        }
                        else if (flag2)
                        {
                            flag3 = true;
                        }
                    }
                    if (!flag2)
                    {
                        str = Convert.ToString(sono[num]) + str;
                    }
                }
            }
            if (!flag)
            {
                sono = sono + "1";
                return sono;
            }
            sono = sono.Substring(0, (sono.Length - str3.Length) - str.Length) + Convert.ToInt32((int) (Convert.ToInt32(str3) + 1)) + str;
            return sono;
        }

        public SaleOrderlineItem GetLineItem(SaleOrderlineItem qli)
        {
            SaleOrderlineItem item;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleOrderlineItem>();
                }
                if (this.lineItems.Contains(qli))
                {
                    return this.lineItems[this.lineItems.IndexOf(qli)];
                }
                item = null;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return item;
        }

        public decimal GetLineTotalExtendedAmount()
        {
            decimal num = Convert.ToDecimal((double) 0.0);
            foreach (SaleOrderlineItem item in this.lineItems)
            {
                num += item.ExtendedAmount;
            }
            return num;
        }
        public decimal GetLineTotalAmount()
        {
            decimal num = Convert.ToDecimal((double)0.0);
            foreach (SaleOrderlineItem item in this.lineItems)
            {
                num += item.Amount;
            }
            return num;
        }

        public decimal GetTotalDiscountedAmount()
        {
            return this.GetLineTotalAmount() - this.GetLineTotalExtendedAmount();
        }
        public decimal GetTaxableItemTotalAmount()
        {
            decimal num = Convert.ToDecimal((double) 0.0);
            foreach (SaleOrderlineItem item in this.lineItems)
            {
                if ((item.LineitemTax != null) && (item.LineitemTax.IsTaxable.ToString().ToUpper() == "TRUE"))
                {
                    num += item.ExtendedAmount;
                }
            }
            return num;
        }

        public decimal GetTransactionTotalAmount()
        {
            return ((this.saleOrderLineItemTotalAmount + this.salesTaxAmount) + this.freightAmount);
        }

        public void HasEmptyGLAccount(ChartOfAccount chr)
        {
            foreach (SaleOrderlineItem item in this.lineItems)
            {
                if (item.LineitemAccount != null)
                {
                    if ((item.LineitemAccount.AccountId == null) || (item.LineitemAccount.AccountId == ""))
                    {
                        item.LineitemAccount = chr;
                    }
                }
                else if (item.LineitemAccount == null)
                {
                    item.LineitemAccount = chr;
                }
            }
        }

        public void HasEmptyTaxType(ItemTaxesType itt)
        {
            foreach (SaleOrderlineItem item in this.lineItems)
            {
                if (item.LineitemTax.Number == 0)
                {
                    item.LineitemTax = itt;
                }
            }
        }

        public override string ToString()
        {
            return this.saleOrderNo;
        }

       

        public bool CloseSO
        {
            get
            {
                return this.closeSO;
            }
            set
            {
                this.closeSO = value;
            }
        }
        public ChartOfAccount ARAccount
        {
            get
            {
                return this.arAccount;
            }
            set
            {
                this.arAccount = value;
            }
        }
        public string CusNote
        {
            get
            {
                return this.cusNote;
            }
            set
            {
                this.cusNote = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public string CustomerPO
        {
            get
            {
                return this.customerPo;
            }
            set
            {
                this.customerPo = value;
            }
        }

        public decimal DiscountAmount
        {
            get
            {
                return this.discountAmount;
            }
            set
            {
                this.discountAmount = value;
            }
        }

        public bool DropShip
        {
            get
            {
                return this.dropShip;
            }
            set
            {
                this.dropShip = value;
            }
        }

        public ChartOfAccount FreightAccount
        {
            get
            {
                return this.freightAccount;
            }
            set
            {
                this.freightAccount = value;
            }
        }

        public decimal FreightAmount
        {
            get
            {
                return this.freightAmount;
            }
            set
            {
                this.freightAmount = value;
            }
        }

        public List<HRobItem> HRobItems
        {
            get
            {
                return this.hRobItems;
            }
            set
            {
                this.hRobItems = value;
            }
        }

        public string InternalNote
        {
            get
            {
                return this.internalNote;
            }
            set
            {
                this.internalNote = value;
            }
        }

        public List<SaleOrderlineItem> LineItems
        {
            get
            {
                return this.lineItems;
            }
            set
            {
                this.lineItems = value;
            }
        }

        public decimal LineItemTotalAmount
        {
            get
            {
                return this.saleOrderLineItemTotalAmount;
            }
            set
            {
                this.saleOrderLineItemTotalAmount = value;
            }
        }

        public bool NotePrintsAfterLineItems
        {
            get
            {
                return this.notePrintsAfterLineItems;
            }
            set
            {
                this.notePrintsAfterLineItems = value;
            }
        }

        public string QuoteNo
        {
            get
            {
                return this.quoteNo;
            }
            set
            {
                this.quoteNo = value;
            }
        }

        public string SaleOrdDate
        {
            get
            {
                return this.transactionDate.ToShortDateString();
            }
        }

        public string SaleOrderNo
        {
            get
            {
                return this.saleOrderNo;
            }
            set
            {
                this.saleOrderNo = value;
            }
        }

        public SalesPerson SalesRep
        {
            get
            {
                return this.salesRep;
            }
            set
            {
                this.salesRep = value;
            }
        }

        public decimal SalesTaxAmount
        {
            get
            {
                return this.salesTaxAmount;
            }
            set
            {
                this.salesTaxAmount = value;
            }
        }

        public SalesTaxCode SalesTaxCode
        {
            get
            {
                return this.salestaxCode;
            }
            set
            {
                this.salestaxCode = value;
            }
        }

        public ShipAddress ShipAddress
        {
            get
            {
                return this.shipAddress;
            }
            set
            {
                this.shipAddress = value;
            }
        }

        public DateTime ShipbyDate
        {
            get
            {
                return this.shipbyDate;
            }
            set
            {
                this.shipbyDate = value;
            }
        }

        public ShipVia ShipVia
        {
            get
            {
                return this.shipVia;
            }
            set
            {
                this.shipVia = value;
            }
        }

        public string StatementNote
        {
            get
            {
                return this.statementNote;
            }
            set
            {
                this.statementNote = value;
            }
        }

        public bool StatementNotePrintsBeforeRef
        {
            get
            {
                return this.statementNotePrintsBeforeRef;
            }
            set
            {
                this.statementNotePrintsBeforeRef = value;
            }
        }

        public decimal TaxableItemAmount
        {
            get
            {
                return this.taxableItemAmount;
            }
            set
            {
                this.taxableItemAmount = value;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return this.transactionDate;
            }
            set
            {
                this.transactionDate = value;
            }
        }

        public string TransactionGUID
        {
            get
            {
                return this.transactionGUID;
            }
            set
            {
                this.transactionGUID = value;
            }
        }

        public decimal TransactionTotal
        {
            get
            {
                return this.transactionTotal;
            }
            set
            {
                this.transactionTotal = value;
            }
        }
    }
}

