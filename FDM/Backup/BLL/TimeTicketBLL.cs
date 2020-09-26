using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Common;

namespace BLL
{
    public  class TimeTicketBLL
    {

        public TimeTicketBLL() { }

        public List<TimeTicket> GetTimeTickets(Customer cus)
        {
          //  return new TimeTicketDAL().GetTimeTickets(cus);
            return new List<TimeTicket>();
        }

    }
}
