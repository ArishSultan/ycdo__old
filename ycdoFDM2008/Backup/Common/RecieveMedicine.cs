using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class RecieveMedicine
    {
        public RecieveMedicine()
        {
            if (this.Lines == null)
                this.Lines = new List<RecieveLineItem>();
            RefRec = new RecieveLineItem();
            RefBranch = new Branch();
        }
        public DateTime RecieveDate { get; set; }
        public long RecieveNumber { get; set; }
        public List<RecieveLineItem> Lines { get; set; }
        public RecieveLineItem RefRec { get; set; }
        public string Name { get { return RefRec.LineItem.TestName; } }
        public decimal Quantity { get { return RefRec.Quantity; } }
        public Branch RefBranch { get; set; }
    }
}
