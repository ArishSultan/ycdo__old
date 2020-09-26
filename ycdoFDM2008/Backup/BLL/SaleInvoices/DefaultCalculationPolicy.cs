namespace BLL.SaleInvoices
{
    using Common;
    using System;

    public class DefaultCalculationPolicy : ICalculationPolicy
    {
        public SaleInvoiceLineItem GetLineItemTotal(SaleInvoiceLineItem siLi)
        {
            siLi.Amount = Math.Round((decimal) (siLi.LineitemPrice * Convert.ToDecimal(siLi.Quantity)), 2);
            return siLi;
        }

        public override string ToString()
        {
            return "Default Calculation Policy";
        }
    }
}

