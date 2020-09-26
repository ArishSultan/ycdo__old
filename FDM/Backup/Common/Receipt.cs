using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Receipt
    {
        public Receipt()
        {
            this.CashAccount = new ChartOfAccount();
            this.Customer = new Customer();
            this.SalesRep = new SalesPerson();
            this.SalesTaxCode = new SalesTaxCode();
            this.LineItems = new List<ReceiptLine>();
        }

        public string DepositTicketId { get; set; }
        public Customer Customer { get; set; }
        public String RefNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public ChartOfAccount CashAccount { get; set; }
        public Decimal CashAmount { get; set; }
        public SalesTaxCode SalesTaxCode { get; set; }
        public Decimal TotalPaidonInvoices { get; set; }
        public SalesPerson SalesRep { get; set; }
        public List<ReceiptLine> LineItems { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
