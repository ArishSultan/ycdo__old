namespace DAL.SaleOrders
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using DAL.Items;
    using DAL.UpdateDB;

    //public class EditSaleOrderDAL
    //{
    //    private EditSaleOrder editSaleOrder;
    //    private PeachtreeSingleTon peachobj;
    //    private SaleInvForSO saiforso;
    //    private SaleInvoice saleinvoice;
    //    private SaleOrder saleOrder;
    //    private List<SaleOrder> saleOrders;

    //    public bool GetIsSaleOrderExist(SaleOrder so)
    //    {
    //        try
    //        {
    //            this.editSaleOrder = new EditSaleOrder();
    //            this.peachobj = new PeachtreeSingleTon();
    //            if (this.editSaleOrder.ExportSaleOrderGUIDAndNO(this.peachobj.GetFirstDay(), this.peachobj.GetLastDay(), so.SaleOrderNo))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editSaleOrder.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") && (so.TransactionGUID == element2.Element("GUID").Value))
    //                    {
    //                        return true;
    //                    }
    //                }
    //            }
    //            return false;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetIsSaleOrderExist");
    //            return false;
    //        }
    //    }

    //    public SaleOrder GetSaleOrder(SaleOrder so)
    //    {
    //        try
    //        {
    //            List<SaleOrderlineItem> soLnItmsDB = new TransactionLineItemsDAL().GetSaleOrderLineItems  (so);
    //            List<Item> itemsinDB = new LocalDBDAL().GetItems();
    //            this.editSaleOrder = new EditSaleOrder();
    //            this.peachobj = new PeachtreeSingleTon();
    //            if (this.editSaleOrder.ExportEditSaleOrder(so.SaleOrderNo, so.TransactionDate, so.TransactionDate))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editSaleOrder.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    string str = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") && (so.SaleOrderNo == str))
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.Customer.Name = (element2.Element("Customer_Name") == null) ? "" : element2.Element("Customer_Name").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.saleOrder.ShipbyDate = (element2.Element("Ship_By") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_By").Value);
    //                        this.saleOrder.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleOrder.ShipVia.ShippingMethod = (element2.Element("Ship_VIA") == null) ? "" : element2.Element("Ship_VIA").Value;
    //                        this.saleOrder.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleOrder.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleOrder.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleOrder.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        this.saleOrder.CloseSO = Convert.ToBoolean(element2.Element("Closed").Value);
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.saleOrder.TransactionTotal = Convert.ToDecimal((double) 0.0);
    //                        }
    //                        else
    //                        {
    //                            this.saleOrder.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.saleOrder.NotePrintsAfterLineItems = Convert.ToBoolean(element2.Element("Note_Prints_After_Line_Items").Value);
    //                        this.saleOrder.StatementNotePrintsBeforeRef = Convert.ToBoolean(element2.Element("Statement_Note_Prints_Before_Inv_Ref").Value);
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate (XElement shi) {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.saleOrder.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                            this.saleOrder.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.saleOrder.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.saleOrder.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.saleOrder.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.saleOrder.ShipAddress.Zip = (element3.Element("ZipCode") == null) ? "" : element3.Element("ZipCode").Value;
    //                            this.saleOrder.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            this.saleOrder.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SOLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });
    //                        short liNo = 0;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleOrder.SalesTaxAmount += Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleOrder.SalesTaxAmount -= Convert.ToDecimal((double) 1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                if (Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2) < 0M)
    //                                {
    //                                    this.saleOrder.FreightAmount = Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    this.saleOrder.FreightAmount = Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                                }
    //                            }
    //                            else
    //                            {
    //                                SaleOrderlineItem item = new SaleOrderlineItem(liNo);
    //                                if (Convert.ToDecimal(element4.Element("Amount").Value) < 0M)
    //                                {
    //                                    item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                }
    //                                else
    //                                {
    //                                    item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : (Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2));
    //                                }
    //                                item.DistributionNumber = element4.Element("DistributionNumber") == null ? 0 : Convert.ToInt32(element4.Element("DistributionNumber").Value);
    //                                item.QtyOrderd  = Math.Round(Convert.ToDecimal(element4.Element("Quantity").Value), 2);
    //                                item.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element4.Element("SO_Description") == null) ? "" : element4.Element("SO_Description").Value;
 
    //                                item.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round(Convert.ToDecimal(element4.Element("Unit_Price").Value), 2);
    //                                item.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                item.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                item.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;

    //                                if (itemsinDB.Contains(item.Item) == true)
    //                                {
    //                                    item.Item.PriceLevels = itemsinDB[itemsinDB.IndexOf(item.Item)].PriceLevels;
    //                                    item.Item.ItemClass = itemsinDB[itemsinDB.IndexOf(item.Item)].ItemClass;
    //                                    item.Item.PrimaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].PrimaryAttribute;
    //                                    item.Item.MasterStockGUID = itemsinDB[itemsinDB.IndexOf(item.Item)].MasterStockGUID;
    //                                    item.Item.SecondaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].SecondaryAttribute;
    //                                }
                                   
    //                                this.saleOrder.LineItemTotalAmount += item.ExtendedAmount;

    //                                if (soLnItmsDB.Contains(item) == true)
    //                                {
    //                                    item.DiscPct = soLnItmsDB[soLnItmsDB.IndexOf(item)].DiscPct;
    //                                    item.DiscUnitPrice = soLnItmsDB[soLnItmsDB.IndexOf(item)].DiscUnitPrice;
    //                                    item.LineitemPrice = soLnItmsDB[soLnItmsDB.IndexOf(item)].LineitemPrice;
    //                                    item.FrameColor.Description = soLnItmsDB[soLnItmsDB.IndexOf(item)].FrameColor.Description;
    //                                    item.FrameColor.Id = soLnItmsDB[soLnItmsDB.IndexOf(item)].FrameColor.Id;
    //                                    item.FrameColor.Type = AttributeType.Secondary;
    //                                    item.Amount = soLnItmsDB[soLnItmsDB.IndexOf(item)].Amount;
    //                                    item.ExtendedAmount = soLnItmsDB[soLnItmsDB.IndexOf(item)].ExtendedAmount;
    //                                }
    //                                else
    //                                {
    //                                    //if sale line items does not found data base then
    //                                    //set ExtAmt to amoutn and LinePrice to DiscUnitPrice
    //                                    item.DiscUnitPrice = item.LineitemPrice;
    //                                    item.Amount = item.ExtendedAmount;

    //                                }


    //                                this.saleOrder.LineItems.Add(item);
    //                                liNo = (short) (liNo + 1);
    //                            }
    //                        }
    //                        this.saleOrder.AssignToLineItem(this.saleOrder);
    //                    }
    //                }
    //            }
    //            return this.saleOrder;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleOrder");
    //            return this.saleOrder;
    //        }
    //    }

    //    public List<SaleOrder> GetSaleOrderShortList(DateTime startdate, DateTime enddate)
    //    {
    //        try
    //        {
    //            this.editSaleOrder = new EditSaleOrder();
    //            this.peachobj = new PeachtreeSingleTon();
    //            if (this.editSaleOrder.ExportEditSaleOrderShortList(startdate, enddate))
    //            {
    //                this.saleOrders = new List<SaleOrder>();
    //                IEnumerable<XElement> enumerable = XElement.Load(this.editSaleOrder.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if (element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE")
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        if (element2.Element("Accounts_Receivable_Amount") == null)
    //                        {
    //                            this.saleOrder.TransactionTotal = Convert.ToDecimal((double) 0.0);
    //                        }
    //                        else
    //                        {
    //                            this.saleOrder.TransactionTotal = Math.Round(Convert.ToDecimal(element2.Element("Accounts_Receivable_Amount").Value), 2);
    //                        }
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        this.saleOrders.Add(this.saleOrder);
    //                    }
    //                }
    //            }
    //            return this.saleOrders;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetSaleOrderShortList");
    //            return this.saleOrders;
    //        }
    //    }

    //    public bool HasSOShip(ref SaleOrder so)
    //    {
    //        try
    //        {
    //            this.saiforso = new SaleInvForSO();
    //            this.peachobj = new PeachtreeSingleTon();
    //            bool ret = false;
    //            if (this.saiforso.ExportSaleInv(so.Customer.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.saiforso.FileNameXML).Descendants("PAW_Invoice").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if (((element2.Element("isQuote").Value.ToString().ToUpper() == "FALSE") && (element2.Element("CreditMemoType").Value.ToString().ToUpper() == "FALSE")) && (element2.Element("ProgressBillingInvoice").Value.ToUpper() == "FALSE"))
    //                    {
    //                        this.saleinvoice = new SaleInvoice();
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("SalesLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            if ((this.saleinvoice.SaleOrderNo == null) || (this.saleinvoice.SaleOrderNo == ""))
    //                            {
    //                                this.saleinvoice.SaleOrderNo = (element3.Element("SalesOrderNumber") == null) ? "" : element3.Element("SalesOrderNumber").Value;
    //                            }
    //                            if ((this.saleinvoice.SaleOrderNo != "") && (this.saleinvoice.SaleOrderNo == so.SaleOrderNo))
    //                            {
    //                                ret= true;
    //                                int soDn = element3.Element("SalesOrderDistributionNumber") == null ? 0 : Convert.ToInt32(element3.Element("SalesOrderDistributionNumber").Value);
    //                                decimal qty = element3.Element("Quantity") == null ? 0.00M : Convert.ToDecimal(element3.Element("Quantity").Value);
    //                                if(qty >0)
    //                                foreach (SaleOrderlineItem  soLn in so.LineItems)
    //                                {
    //                                    if (soLn.DistributionNumber == soDn)
    //                                        soLn.QtyShipped += qty;
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //            return ret;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "HasSOShip");
    //            return false;
    //        }
    //    }
    //}
}

