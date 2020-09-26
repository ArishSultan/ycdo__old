namespace BLL.Quotes
{
    using Common;
    using System;

    public class DefaultCalculationPolicy : ICalculationPolicy
    {
        public QuoteLineItem GetLineItemTotal(QuoteLineItem qli)
        {
            qli.Amount = Math.Round((decimal) (qli.LineitemPrice * Convert.ToDecimal(qli.Quantity)), 2);
            return qli;
        }

        public override string ToString()
        {
            return "Default Calculation Policy";
        }
    }
}

