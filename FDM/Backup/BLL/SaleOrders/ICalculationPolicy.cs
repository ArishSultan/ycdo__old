namespace BLL.SaleOrders
{
    using Common;

    public interface ICalculationPolicy
    {
        SaleOrderlineItem GetLineItemTotal(SaleOrderlineItem soli);
    }
}

