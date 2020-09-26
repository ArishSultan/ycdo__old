using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class RecieveLineItem
    {
        public RecieveLineItem()
        {
            this.LineItem = new LabTest();
        }
        public LabTest LineItem { get; set; }
        public decimal Quantity { get; set; }
        public double Price { get; set; }
        public double GrossAmount { get; set; }
        public double NetAmount { get; set; }
        public override bool Equals(object obj)
        {
            RecieveLineItem rli = obj as RecieveLineItem;
            if (rli == null) return false;

            return rli.LineItem.LabTestId == this.LineItem.LabTestId;
        }
    }
}
