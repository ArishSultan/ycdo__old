using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
//// using ExportImport;
using System.Xml.Linq;

namespace DAL
{
    //public  class TimeTicketDAL
    //{
    //    TimeTicketRegister ttr;

    //    public List<TimeTicket> GetTimeTickets(Customer cus)
    //    {
    //        List<TimeTicket> tts = new List<TimeTicket>();
    //        try
    //        {
    //            ttr = new TimeTicketRegister();
    //            TimeTicket tt;

    //            if (ttr.ExportTicket(cus.Id) == true)
    //            {
    //                XElement xdoc = XElement.Load(ttr.FileNameXML);
    //                var xcost = from el in xdoc.Elements("PAW_TimeTicketRegister")
    //                            select el;
    //                foreach (var el in xcost)
    //                {
    //                    if (Convert.ToBoolean(el.Element("UsedInSalesInvoice").Value) == false)
    //                    {

    //                        tt = new TimeTicket();
    //                        tt.EmpOrVen = Convert.ToInt16 (el.Element("EmployeeOrVendor").Value);
    //                        if (tt.EmpOrVen == 0)
    //                            tt.Employee.Id = Convert.ToString(el.Element("RecordedById").Value);
    //                        else
    //                            tt.Vendor.Id = Convert.ToString(el.Element("RecordedById").Value);
    //                        tt.TicketId = Convert.ToString(el.Element("TicketNumber").Value);
    //                        tt.TicketDate = Convert.ToDateTime(el.Element("TicketDate").Value);
    //                        tt.UsedInSaleInvoice = Convert.ToBoolean(el.Element("UsedInSalesInvoice").Value);
    //                        tt.Item.ItemId = Convert.ToString(el.Element("ActivityItemId").Value);
    //                        if (Convert.ToInt16(el.Element("CustomerOrJobOrAdm").Value) == 1)
    //                        {
    //                            tt.AppliedOn = AppliedOn.Customer;
    //                            tt.Customer.Id = Convert.ToString(el.Element("CompletedForId").Value);
    //                        }
    //                        else if (Convert.ToInt16(el.Element("CustomerOrJobOrAdm").Value) == 2)
    //                        {
    //                            tt.AppliedOn = AppliedOn.Job;
    //                            tt.Job.Id = Convert.ToString(el.Element("CompletedForId").Value);
    //                        }
    //                        else if (Convert.ToInt16(el.Element("CustomerOrJobOrAdm").Value) == 3)
    //                        {

    //                            tt.AppliedOn = AppliedOn.Admin;
    //                            tt.Item.ItemId = Convert.ToString(el.Element("CompletedForId").Value);
    //                        }
    //                        tt.BillingType = (BillingType)Convert.ToInt16(el.Element("BillingType").Value);
    //                        tt.BillingRate = Convert.ToDecimal(el.Element("BillingRate").Value);
    //                        tt.BillingAmount = Convert.ToDecimal(el.Element("BillingAmount").Value);
    //                        tt.UnitDuration = Convert.ToDecimal(el.Element("UnitDuration").Value);
    //                        tt.DescriptionForInvoice = Convert.ToString(el.Element("TicketDescriptionForInvoice") == null ? "" : el.Element("TicketDescriptionForInvoice").Value);
    //                        tt.BillingStatus =(BillingStatus) Convert.ToInt16 (el.Element("BillingStatus").Value );
                            
    //                        tt.InvoiceAmount = tt.BillingAmount;

    //                        if (tt.BillingStatus != BillingStatus.Hold && tt.BillingStatus != BillingStatus.NonBillable)
    //                            tts.Add(tt);
    //                    }
    //                }

    //            }
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //        return tts;
    //    }
    //}
}
