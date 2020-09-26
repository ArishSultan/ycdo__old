using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class Ticket

    {
        public string EmporVenId { get { return (this.EmpOrVen == 0 ? Employee.Id : Vendor.Id); } }
        public string EmporVenName { get { return (this.EmpOrVen == 0 ? Employee.Name : Vendor.Name); } }
        public string TicketId { get; set; }
        public DateTime TicketDate { get; set; }
        public Int16 EmpOrVen { get; set; }
        public SalesPerson Employee { get; set; }
        public Vendor Vendor { get; set; }
        public bool UsedInSaleInvoice { get; set; }
        public Item Item { get; set; }
        public AppliedOn AppliedOn { get; set; }
        public Customer Customer { get; set; }
        public Job Job { get; set; }
        public BillingStatus BillingStatus { get; set; }

        public Decimal BillingAmount { get; set; }
        public Decimal InvoiceAmount { get; set; }
        public String DescriptionForInvoice { get; set; }
        public bool IsTicketItemDes { get; set; }
        public bool Use { get; set; }
        public bool NoBill { get; set; }
        public bool IsShownonInvoice { get; set; }
        
        public Ticket()
        {
            this.Customer = new Customer();
            this.Employee = new SalesPerson();
            this.Item = new Item();
            this.Job = new Job();
            this.Vendor = new Vendor();
            
        }

        public override bool Equals(object obj)
        {
            Ticket tic = obj as Ticket;
            if (tic == null)
                return false;
            return (tic.TicketId == this.TicketId);
        }
        
        
    }
   
}
