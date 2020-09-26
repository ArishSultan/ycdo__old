namespace BLL.SaleInvoices
{
    using Common;

    public interface ICalculationPolicy
    {
        SaleInvoiceLineItem GetLineItemTotal(SaleInvoiceLineItem siLi);
    }
}

