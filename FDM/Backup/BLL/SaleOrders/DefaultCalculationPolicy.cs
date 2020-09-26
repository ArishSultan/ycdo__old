namespace BLL.SaleOrders
{
    using Common;
    using System;

    public class DefaultCalculationPolicy : ICalculationPolicy
    {
        public SaleOrderlineItem GetLineItemTotal(SaleOrderlineItem soli)
        {
            soli.Amount = Math.Round((decimal) (soli.LineitemPrice * Convert.ToDecimal(soli.Quantity  )), 2);
            return soli;
        }

        public override string ToString()
        {
            return "Default Calculation Policy";
        }
    }
}

