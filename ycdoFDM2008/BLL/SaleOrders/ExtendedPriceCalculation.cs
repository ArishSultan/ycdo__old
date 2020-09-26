using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace BLL.SaleOrders
{
    public class ExtendedPriceCalculation : ICalculationPolicy
    {
        public SaleOrderlineItem GetLineItemTotal(SaleOrderlineItem soLi)
        {
            soLi.DiscUnitPrice = soLi.LineitemPrice - (soLi.LineitemPrice * soLi.DiscPct / 100);
            soLi.ExtendedAmount = Math.Round(soLi.QtyOrderd  * (soLi.DiscUnitPrice), 2);
            soLi.Amount = Math.Round((decimal)(soLi.LineitemPrice * Convert.ToDecimal(soLi.QtyOrderd)), 2);

            return soLi;
        }

        public override string ToString()
        {
            return "Extended Price Calculation Policy";
        }
    }
}
