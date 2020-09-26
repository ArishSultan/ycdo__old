using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class ReceiptLine
    {
        public string InvoicePaid { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal Quantity { get; set; }
        public ChartOfAccount GLAccount { get; set; }
        public Item Item { get; set; }
        
        public decimal LineitemPrice { get; set; }
        public ItemTaxesType LineitemTax { get; set; }
        public decimal Amount { get; set; }

    }
}
