using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace BLL.SaleInvoices
{
    public  class ExtendedPriceCalculation      : ICalculationPolicy
    {
        public SaleInvoiceLineItem GetLineItemTotal(SaleInvoiceLineItem siLi)
        {
            siLi.DiscUnitPrice = siLi.LineitemPrice - (siLi.LineitemPrice * siLi.DiscPct / 100);
            siLi.ExtendedAmount = Math.Round(siLi.Quantity * (siLi.DiscUnitPrice), 2);
            siLi.Amount = Math.Round((decimal)(siLi.LineitemPrice * Convert.ToDecimal(siLi.Quantity)), 2);

            return siLi;
        }

        public override string ToString()
        {
            return "Extended Price Calculation Policy";
        }
    }
}
