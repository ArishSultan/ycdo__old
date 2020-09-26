namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class SaleInvoice
    {
        private bool applyToProposal;
        private bool applyToSalesOrder;
        private ChartOfAccount arAccount;
        public static string Condition;
        private bool creditMemoType;
        private string cusNote;
        private Customer customer;
        private string customerPo;
        private decimal discountAmount;
        private DateTime discountDate;
        private bool dropShip;
        private DateTime dueDate;
        private ChartOfAccount freightAccount;
        private decimal freightAmount;
        private List<HRobItem> hRobItems;
        private string internalNote;
        private List<SaleInvoiceLineItem> lineItems;
        private bool notePrintsAfterLineItems;
        private bool progressBillingInvoice;
        private string quoteNo;
        private int recurFrequency;
        private int recurNumber;
        private decimal saleInvoiceLineItemTotalAmount;
        private string saleInvoiceNo;
        private string saleOrderNo;
        private SalesPerson salesRep;
         
        private decimal salesTaxAmount;
        private SalesTaxCode salestaxCode;
        private ShipAddress shipAddress;
        private DateTime shipDate;
        private ShipVia shipVia;
        private string statementNote;
        private bool statementNotePrintsBeforeRef;
        private decimal taxableItemAmount;
        private DateTime transactionDate;
        private string transactionGUID;
        private decimal transactionTotal;

        private decimal totalLineItemAmount;
        private bool isFinalized;

        private Decimal invAmountPaid;

        public Receipt Receipt { get; set; }

       public  List<TimeTicket> TimeTickets { get; set; }

        public Decimal TotalLineItemAmount
        {
            get { return this.totalLineItemAmount; }
            set { this.totalLineItemAmount = value; }
        }

        public Decimal InvAmountPaid
        {

            get { return this.invAmountPaid; }
            set { this.invAmountPaid = value; }
        }

        public SaleInvoice()
        {
            this.customer = new Customer();
            this.salestaxCode = new SalesTaxCode();
            this.lineItems = new List<SaleInvoiceLineItem>();
            this.arAccount = new ChartOfAccount();
            this.freightAccount = new ChartOfAccount();
            this.salesRep = new SalesPerson();
            this.shipVia = new ShipVia();
            this.shipAddress = new ShipAddress();
            this.hRobItems = new List<HRobItem>();
            this.Receipt = new Receipt();
            this.TimeTickets = new List<TimeTicket>();
        }

        public SaleInvoice(string sino, string guid) : this()
        {
            this.transactionGUID = guid;
            this.saleInvoiceNo = sino;
        }

        public SaleInvoice(Customer customer, SalesTaxCode salestaxcode, List<SaleInvoiceLineItem> saleInvoicelineItems) : this()
        {
            this.customer = customer;
            this.salestaxCode = salestaxcode;
            this.lineItems = saleInvoicelineItems;
        }

        public bool AddLineItem(SaleInvoiceLineItem sli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleInvoiceLineItem>();
                }
                if (!this.lineItems.Contains(sli))
                {
                    this.lineItems.Add(sli);
                }
                else
                {
                    this.lineItems[this.lineItems.IndexOf(sli)] = sli;
                }
                flag = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public void AssignToLineItem(SaleInvoice si)
        {
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleInvoiceLineItem>();
                }
                foreach (SaleInvoiceLineItem item in this.lineItems)
                {
                    item.SaleInvoice = si;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ClearAllLineItem(SaleInLineItemType type)
        {
            if ((type == SaleInLineItemType.SO) && (this.lineItems.Count > 0))
            {
                List<SaleInvoiceLineItem> list = new List<SaleInvoiceLineItem>();
                list.AddRange(this.lineItems);
                foreach (SaleInvoiceLineItem item in list)
                {
                    if (item.SaleInvoiceLineItemType == SaleInLineItemType.SO)
                    {
                        this.lineItems.Remove(item);
                    }
                }
            }
        }

        public bool DelLineItem(SaleInvoiceLineItem sli)
        {
            bool flag;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleInvoiceLineItem>();
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
            SaleInvoice invoice = obj as SaleInvoice;
            if (invoice == null)
            {
                return false;
            }
            return (invoice.saleInvoiceNo == this.saleInvoiceNo);
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
            //to handle 09877 invoice no. and should result 09878 by skipping first character
            if (sono.Length == str3.Length && sono[0] == '0')

                sono ='0'+ sono.Substring(0, (sono.Length - str3.Length) - str.Length) + Convert.ToInt32((int)(Convert.ToInt32(str3) + 1)) + str;
            else
                sono = sono.Substring(0, (sono.Length - str3.Length) - str.Length) + Convert.ToInt32((int)(Convert.ToInt32(str3) + 1)) + str;
            
            return sono;
        }

        public SaleInvoiceLineItem GetLineItem(SaleInvoiceLineItem sli)
        {
            SaleInvoiceLineItem item;
            try
            {
                if (this.lineItems == null)
                {
                    this.lineItems = new List<SaleInvoiceLineItem>();
                }
                if (this.lineItems.Contains(sli))
                {
                    return this.lineItems[this.lineItems.IndexOf(sli)];
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
            foreach (SaleInvoiceLineItem item in this.lineItems)
            {
                num += item.ExtendedAmount;
            }
            return num;
        }
        public decimal GetLineTotalAmount()
        {
            decimal num = Convert.ToDecimal((double)0.0);
            foreach (SaleInvoiceLineItem item in this.lineItems)
            {
                num += item.Amount;
            }
            return num;
        }


        public decimal GetTaxableItemTotalAmount()
        {
            decimal num = Convert.ToDecimal((double) 0.0);
            foreach (SaleInvoiceLineItem item in this.lineItems)
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
            return ((this.saleInvoiceLineItemTotalAmount + this.salesTaxAmount) + this.freightAmount);
        }

        public decimal GetTotalDiscountedAmount()
        {
            return this.GetLineTotalAmount() - this.GetLineTotalExtendedAmount();
        }
        public void HasEmptyGLAccount(ChartOfAccount chr)
        {
            foreach (SaleInvoiceLineItem item in this.lineItems)
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
            foreach (SaleInvoiceLineItem item in this.lineItems)
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
                foreach (SaleInvoiceLineItem item in this.lineItems)
                {
                    if (item.SaleInvoiceLineItemType == SaleInLineItemType.Sales)
                    {
                        if ((item.Item.ItemClass == ItemClass.SerializedStock) || (item.Item.ItemClass == ItemClass.SerializedAssembly))
                        {
                            return true;
                        }
                    }
                    else if ((item.SaleInvoiceLineItemType == SaleInLineItemType.SO) && ((item.Quantity > 0M) && ((item.Item.ItemClass == ItemClass.SerializedStock) || (item.Item.ItemClass == ItemClass.SerializedAssembly))))
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

        public bool IsSameSerialStockLineItemExist(SaleInvoiceLineItem qli)
        {
            bool flag2;
            try
            {
                bool flag = false;
                foreach (SaleInvoiceLineItem item in this.lineItems)
                {
                    if ((qli.Item.ItemClass == ItemClass.SerializedStock) && (((((qli.SaleInvoice.saleInvoiceNo == item.SaleInvoice.saleInvoiceNo) && (qli.Quantity == item.Quantity)) && ((qli.Item.ItemId == item.Item.ItemId) && (qli.Item.ItemClass == item.Item.ItemClass))) && (((qli.LineitemDescription == item.LineitemDescription) && (qli.LineitemAccount.AccountId == item.LineitemAccount.AccountId)) && ((qli.LineitemPrice == item.LineitemPrice) && (qli.LineitemTax.Number == item.LineitemTax.Number)))) && (qli.Job.Id == item.Job.Id)))
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


        public void  GenerateDiscountAmount(Term term, DateTime dtDate, decimal qtAmount)
        {
            Decimal amount = Convert.ToDecimal(0.00);
            DateTime duedate = dtDate, disdate = dtDate;
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;

            if (term.Cod == true)
            {
                amount = Convert.ToDecimal(0.00);
                duedate = dtDate.Date;
                disdate = dtDate.Date;
            }
            else if (term.Prepaid == true)
            {
                amount = Convert.ToDecimal(0.00);
                duedate = dtDate.Date;
                disdate = dtDate.Date;

            }
            else if (term.TermsType == false)
            {
                if (term.DuemonthendTerms == false)
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate = dtDate.Date.AddDays(term.DiscountDays);
                    duedate = dtDate.Date.AddDays(term.DueDays);
                }
                else
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate = dtDate.Date.AddDays(term.DiscountDays);
                    //if after addition it move to next month then 
                    //make it last day of the month.
                    if (disdate.Month != dtDate.Month)
                    {
                        disdate = dtDate;

                        disdate = disdate.AddDays(DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day);
                    }
                    duedate = dtDate.Date;
                    //make due date last day of the month.
                    Int32 Days = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                    if (Days > 0)
                    {
                        duedate = dtDate.AddDays(Days);
                    }
                }
            }
            else
            {
                if (term.DuemonthendTerms == false)
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate = dtDate.AddDays(term.DiscountDays);
                    duedate = dtDate.AddMonths(1);
                    duedate = duedate.AddDays(term.DueDays - duedate.Day);
                }
                else
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate = dtDate.AddDays(term.DiscountDays);
                    //make due date last day of the month.
                    Int32 Days = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                    if (Days > 0)
                    {
                        duedate = dtDate.AddDays(Days);
                    }
                }
            }
            //return (num.ToString() + "ƒ" + date.ToString() + "ƒ" + time2.ToString());
            discountAmount = amount;
            

        }

        public void GenerateDueandDiscountDateandAmount(Term term, DateTime dtDate, decimal qtAmount)
        {
            decimal num = Convert.ToDecimal((double)0.0);
            Decimal amount = Convert.ToDecimal(0.00);
            DateTime duedate1 = dtDate, disdate1 = dtDate;
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            if (term.Cod == true)
            {
                amount = Convert.ToDecimal(0.00);
                duedate1 = dtDate.Date;
                disdate1 = dtDate.Date;
            }
            else if (term.Prepaid == true)
            {
                amount = Convert.ToDecimal(0.00);
                duedate1 = dtDate.Date;
                disdate1 = dtDate.Date;

            }
            else if (term.TermsType == false)
            {
                if (term.DuemonthendTerms == false)
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate1 = dtDate.Date.AddDays(term.DiscountDays);
                    duedate1 = dtDate.Date.AddDays(term.DueDays);
                }
                else
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate1 = dtDate.Date.AddDays(term.DiscountDays);
                    //if after addition it move to next month then 
                    //make it last day of the month.
                    if (disdate1.Month != dtDate.Month)
                    {
                        disdate1 = dtDate;

                        disdate1 = disdate1.AddDays(DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day);
                    }
                    duedate1 = dtDate.Date;
                    //make due date last day of the month.
                    Int32 Days = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                    if (Days > 0)
                    {
                        duedate1 = dtDate.AddDays(Days);
                    }
                }
            }
            else
            {
                if (term.DuemonthendTerms == false)
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate1 = dtDate.AddDays(term.DiscountDays);
                    duedate1 = dtDate.AddMonths(1);
                    duedate1 = duedate1.AddDays(term.DueDays - duedate1.Day);
                }
                else
                {
                    amount = qtAmount * Convert.ToDecimal(term.DiscountPercent) / 100;
                    disdate1 = dtDate.AddDays(term.DiscountDays);
                    //make due date last day of the month.
                    Int32 Days = DateTime.DaysInMonth(dtDate.Year, dtDate.Month) - dtDate.Day;
                    if (Days > 0)
                    {
                        duedate1 = dtDate.AddDays(Days);
                    }
                }
            }
            //return (num.ToString() + "ƒ" + date.ToString() + "ƒ" + time2.ToString());
            discountAmount = amount;
            dueDate = duedate1;
            discountDate = disdate1;

        }

        public int GetMaxLineItemNo(SaleInLineItemType sLineType)
        {
            int MaxNo=-1;
            for (int i = 0; i < LineItems .Count ; i++)
            {
                if (LineItems[i].SaleInvoiceLineItemType == sLineType)
                    if (LineItems[i].LineitemNo > MaxNo)
                        MaxNo = LineItems[i].LineitemNo;

            }
            return MaxNo;
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

        public DateTime DiscountDate
        {
            get
            {
                return this.discountDate;
            }
            set
            {
                this.discountDate = value;
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

        public DateTime DueDate
        {
            get
            {
                return this.dueDate;
            }
            set
            {
                this.dueDate = value;
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

        public List<SaleInvoiceLineItem> LineItems
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
                return this.saleInvoiceLineItemTotalAmount;
            }
            set
            {
                this.saleInvoiceLineItemTotalAmount = value;
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

        public string SaleInvDate
        {
            get
            {
                return this.transactionDate.ToShortDateString();
            }
        }

        public string SaleInvoiceNo
        {
            get
            {
                return this.saleInvoiceNo;
            }
            set
            {
                this.saleInvoiceNo = value;
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

        public DateTime ShipDate
        {
            get
            {
                return this.shipDate;
            }
            set
            {
                this.shipDate = value;
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

