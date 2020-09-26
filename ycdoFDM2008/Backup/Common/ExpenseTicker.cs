using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{

    public class ExpenseTicket : Ticket
    {
        public bool ReimbursableToEmployee { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal UnitPrice { get; set; }

    }
}
