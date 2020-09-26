namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Quote
    {
        private bool applyToProposal;
        private bool applyToSalesOrder;
        private ChartOfAccount arAccount;
        public static string Condition;
        private bool creditMemoType;
        private string cusNote;
        private Customer customer;
        private string customerPo;
        private bool dropShip;
        private ChartOfAccount freightAccount;
        private decimal freightAmount;
        private DateTime goodthruDate;
        private List<HRobItem> hRobItems;
        private string internalNote;
        private List<QuoteLineItem> lineItems;
        private bool notePrintsAfterLineItems;
        private bool progressBillingInvoice;
        private decimal quoteLineItemTotalAmount;
        private string quoteNo;
        private int recurFrequency;
        private int recurNumber;
        private SalesPerson salesRep;
        private decimal salesTaxAmount;
        private SalesTaxCode salestaxCode;
        private ShipAddress shipAddress;
        private ShipVia shipVia;
        private string statementNote;
        private bool statementNotePrintsBeforeRef;
        private decimal taxableItemAmount;
        private DateTime transactionDate;
        private string transactionGUID;
        private decimal transactionTotal;

        public Quote()
        {
            this.customer = new Customer();
            this.salestaxCode = new SalesTaxCode();
            this.lineItems = new List<QuoteLineItem>();
            this.arAccount = new ChartOfAccount();
            this.freightAccount = new ChartOfAccount();
            this.salesRep = new SalesPerson();
            this.shipVia = new ShipVia();
            this.shipAddress = new ShipAddress();
            this.hRobItems = new List<HRobItem>();
        }

        public Quote(string qtno, string guid) : this()
        {
            this.quoteNo = qtno;
            this.transactionGUID = guid;
        }

        public Quote(Customer customer, SalesTaxCode salestaxcode, List<QuoteLineItem> quotelineitems) : this()
        {
            this.customer = customer;
            this.salestaxCode = salestaxcode;
            this.lineItems = quotelineitems;
        }

        public bool AddLineItem(QuoteLineItem qli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<QuoteLineItem>();
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

        public void AssignToLineItem(Quote qt)
        {
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<QuoteLineItem>();
                }
                foreach (QuoteLineItem item in this.lineItems)
                {
                    item.Quote = qt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DelLineItem(QuoteLineItem qli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<QuoteLineItem>();
                }
                if (this.lineItems.Contains(qli))
                {
                    this.lineItems.RemoveAt(this.lineItems.IndexOf(qli));
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
            Quote quote = obj as Quote;
            if (quote == null)
            {
                return false;
            }
            return (this.quoteNo == quote.quoteNo);
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

        public QuoteLineItem GetLineItem(QuoteLineItem qli)
        {
            QuoteLineItem item;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<QuoteLineItem>();
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

        public decimal GetLineTotalAmount()
        {
            decimal num = Convert.ToDecimal((double) 0.0);
            foreach (QuoteLineItem item in this.lineItems)
            {
                num += item.Amount;
            }
            return num;
        }

        public decimal GetTaxableItemTotalAmount()
        {
            decimal num = Convert.ToDecimal((double) 0.0);
            foreach (QuoteLineItem item in this.lineItems)
            {
                if ((item.LineitemTax != null) && (item.LineitemTax.IsTaxable.ToString().ToUpper() == "TRUE"))
                {
                    num += item.Amount;
                }
            }
            return num;
        }

        public decimal GetTransactionTotalAmount()
        {
            return ((this.quoteLineItemTotalAmount + this.salesTaxAmount) + this.freightAmount);
        }

        public void HasEmptyGLAccount(ChartOfAccount chr)
        {
            foreach (QuoteLineItem item in this.lineItems)
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
            foreach (QuoteLineItem item in this.lineItems)
            {
                if (item.LineitemTax.Number == 0)
                {
                    item.LineitemTax = itt;
                }
            }
        }

        public bool HasSerialItemExist()
        {
            bool flag;
            try
            {
                foreach (QuoteLineItem item in this.lineItems)
                {
                    if ((item.Item.ItemClass == ItemClass.SerializedStock) || (item.Item.ItemClass == ItemClass.SerializedAssembly))
                    {
                        return true;
                    }
                }
                flag = false;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }

        public bool IsSameSerialStockLineItemExist(QuoteLineItem qli)
        {
            bool flag2;
            try
            {
                bool flag = false;
                foreach (QuoteLineItem item in this.lineItems)
                {
                    if ((qli.Item.ItemClass == ItemClass.SerializedStock) && (((((qli.Quantity == item.Quantity) && (qli.Item.ItemId == item.Item.ItemId)) && ((qli.Item.ItemClass == item.Item.ItemClass) && (qli.LineitemDescription == item.LineitemDescription))) && (((qli.LineitemAccount.AccountId == item.LineitemAccount.AccountId) && (qli.LineitemPrice == item.LineitemPrice)) && (qli.LineitemTax.Number == item.LineitemTax.Number))) && (qli.Job.Id == item.Job.Id)))
                    {
                        flag = true;
                    }
                }
                flag2 = flag;
            }
            catch (Exception)
            {
                throw;
            }
            return flag2;
        }

        public bool ApplyToProposal
        {
            get
            {
                return this.applyToProposal;
            }
            set
            {
                this.applyToProposal = value;
            }
        }

        public bool ApplyToSalesOrder
        {
            get
            {
                return this.applyToSalesOrder;
            }
            set
            {
                this.applyToSalesOrder = value;
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

        public bool CreditMemoType
        {
            get
            {
                return this.creditMemoType;
            }
            set
            {
                this.creditMemoType = value;
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

        public DateTime GoodthruDate
        {
            get
            {
                return this.goodthruDate;
            }
            set
            {
                this.goodthruDate = value;
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

        public List<QuoteLineItem> LineItems
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
                return this.quoteLineItemTotalAmount;
            }
            set
            {
                this.quoteLineItemTotalAmount = value;
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

        public bool ProgressBillingInvoice
        {
            get
            {
                return this.progressBillingInvoice;
            }
            set
            {
                this.progressBillingInvoice = value;
            }
        }

        public string QTDate
        {
            get
            {
                return this.transactionDate.ToShortDateString();
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

        public int RecurFrequency
        {
            get
            {
                return this.recurFrequency;
            }
            set
            {
                this.recurFrequency = value;
            }
        }

        public int RecurNumber
        {
            get
            {
                return this.recurNumber;
            }
            set
            {
                this.recurNumber = value;
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

