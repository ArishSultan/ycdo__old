using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class TimeTicket : Ticket
    {
        public bool PayLevelId { get; set; }
        public bool UsedInPayRoll { get; set; }
        public Int16  ManualorTimed { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Break { get; set; }
        public DateTime Duration { get; set; }
        
        public BillingType BillingType { get; set; }
        public Decimal BillingRate { get; set; }
        public Decimal UnitDuration { get; set; }
       



    }
}
