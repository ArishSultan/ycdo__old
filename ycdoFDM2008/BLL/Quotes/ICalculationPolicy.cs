namespace BLL.Quotes
{
    using Common;

    public interface ICalculationPolicy
    {
        QuoteLineItem GetLineItemTotal(QuoteLineItem qli);
    }
}

