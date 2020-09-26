namespace DAL.SaleInvoices
{
    using Common;
   // // using ExportImport;
    using DAL.UpdateDB;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class SaleOrderDAL
    //{
    //    private Dictionary<Customer, List<SaleOrder>> customerOrders;
    //    private PeachtreeSingleTon peachobj;
    //    private SaleOrder saleOrder;
    //    private List<SaleOrder> saleOrders;
    //    private SaleOrdersForInvoice SaleOrders;


    //    public List<SaleOrder> GetOpenSaleOrderNumbers(Customer cus)
    //    {
    //        if (this.customerOrders == null)
    //        {
    //            this.customerOrders = new Dictionary<Customer, List<SaleOrder>>();
    //        }
    //        try
    //        {
    //            this.SaleOrders = new SaleOrdersForInvoice();
    //            this.saleOrders = new List<SaleOrder>();
    //            this.saleOrder = new SaleOrder("<None Selected>");
    //            this.saleOrder.ShipAddress = new ShipAddress(new Address("", "", "", "", "", "", "", ""));
    //            this.saleOrders.Add(this.saleOrder);
    //            this.peachobj = new PeachtreeSingleTon();

    //            this.SaleOrders.ExportSaleOrderNumbers(cus.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay());
           
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.SaleOrders.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate(XElement el)
    //                {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") && (element2.Element("Closed").Value.ToString().ToUpper() == "FALSE"))
    //                    {
    //                        this.saleOrder = new SaleOrder();
                          
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
                           
    //                        if (this.saleOrder.SaleOrderNo != "")
    //                        {
    //                            this.saleOrder.TransactionGUID = element2.Element("GUID") == null ? "" : element2.Element("GUID").Value;
    //                            this.saleOrders.Add(this.saleOrder);
                                
    //                        }
    //                    }
    //                }
    //            }
    //            return this.saleOrders;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetOpenSaleOrderNumbers");
    //            return this.saleOrders;
    //        }
    //    }

    //    public List<SaleOrder> GetOpenSaleOrder(Customer cus)
    //    {
    //        if (this.customerOrders == null)
    //        {
    //            this.customerOrders = new Dictionary<Customer, List<SaleOrder>>();
    //        }
    //        try
    //        {
    //            this.SaleOrders = new SaleOrdersForInvoice();
    //            this.saleOrders = new List<SaleOrder>();
    //            this.saleOrder = new SaleOrder("<None Selected>");
    //            this.saleOrder.ShipAddress = new ShipAddress(new Address("", "", "", "", "", "", "", ""));
    //            this.saleOrders.Add(this.saleOrder);
    //            this.peachobj = new PeachtreeSingleTon();

                
    //            if (this.SaleOrders.ExportSaleOrder(cus.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay()))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.SaleOrders.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") && (element2.Element("Closed").Value.ToString().ToUpper() == "FALSE"))
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.CloseSO = Convert.ToBoolean(element2.Element("Closed").Value);
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.ShipbyDate = (element2.Element("Ship_By") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_By").Value);
    //                        this.saleOrder.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleOrder.ShipVia.ShippingMethod = (element2.Element("Ship_VIA") == null) ? "" : element2.Element("Ship_VIA").Value;
    //                        this.saleOrder.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleOrder.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleOrder.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleOrder.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        this.saleOrder.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate (XElement shi) {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.saleOrder.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            this.saleOrder.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.saleOrder.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.saleOrder.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.saleOrder.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.saleOrder.ShipAddress.Zip = (element3.Element("ZipCode") == null) ? "" : element3.Element("ZipCode").Value;
    //                            this.saleOrder.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            this.saleOrder.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SOLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });
    //                        short liNo = 0;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                this.saleOrder.SalesTaxAmount += Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                this.saleOrder.FreightAmount = Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                            }
    //                            else
    //                            {
    //                                SaleOrderlineItem item = new SaleOrderlineItem(liNo);
    //                                item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                 item.QtyOrderd  = Convert.ToDecimal(element4.Element("Quantity").Value);
    //                                 item.Quantity = item.QtyOrderd;
                                   

    //                                item.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element4.Element("SO_Description") == null) ? "" : element4.Element("SO_Description").Value;

                                   
    //                                item.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                item.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                item.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;
    //                                item.DistributionNumber = (element4.Element("DistributionNumber") == null) ? 0 : Convert.ToInt32(element4.Element("DistributionNumber").Value);
    //                                ItemPriceLevel level = new ItemPriceLevel();
    //                                if (level.ExportInventoryItemPrices(item.Item.ItemId))
    //                                {
    //                                    item.Item.PriceLevels = new ItemPriceLevelsDAL().GetItemPriceLevels(item.Item);
    //                                }
    //                                Item item2 = new Item();
    //                                item2 = new LocalDBDAL().GetItem(item.Item);
    //                                item.Item.CGSAccount = item2.CGSAccount;
    //                                item.Item.InventoryAccount = item2.InventoryAccount;
    //                                item.Item.ItemClass = item2.ItemClass;
                                    
    //                                item.Item.MasterStockGUID = item2.MasterStockGUID;
    //                                item.Item.PrimaryAttribute = item2.PrimaryAttribute;
    //                                item.Item.SecondaryAttribute = item2.SecondaryAttribute;

    //                                this.saleOrder.LineItemTotalAmount += item.ExtendedAmount;
    //                                this.saleOrder.LineItems.Add(item);
    //                                liNo = (short) (liNo + 1);
    //                            }
    //                        }
    //                        if (this.saleOrder.SaleOrderNo != "")
    //                        {
    //                            this.saleOrders.Add(this.saleOrder);
    //                            this.saleOrder.AssignToLineItem(this.saleOrder);
    //                        }
    //                    }
    //                }
    //            }
    //            return this.saleOrders;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetOpenSaleOrder");
    //            return this.saleOrders;
    //        }
    //    }


    //    public  SaleOrder  GetOpenSaleOrder(SaleOrder so,Customer cus)
    //    {
            
    //        try
    //        {

    //            List<SaleOrderlineItem> soLnItmsDB = new TransactionLineItemsDAL().GetSaleOrderLineItems(so);
    //            this.SaleOrders = new SaleOrdersForInvoice();
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.saleOrder = new SaleOrder();
    //            if (this.SaleOrders.ExportSaleOrder(cus.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay(),so.SaleOrderNo ))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.SaleOrders.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate(XElement el)
    //                {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") && (element2.Element("Closed").Value.ToString().ToUpper() == "FALSE"))
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.CloseSO = Convert.ToBoolean(element2.Element("Closed").Value);
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.ShipbyDate = (element2.Element("Ship_By") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_By").Value);
    //                        this.saleOrder.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleOrder.ShipVia.ShippingMethod = (element2.Element("Ship_VIA") == null) ? "" : element2.Element("Ship_VIA").Value;
    //                        this.saleOrder.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleOrder.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleOrder.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleOrder.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        this.saleOrder.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate(XElement shi)
    //                        {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.saleOrder.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            this.saleOrder.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.saleOrder.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.saleOrder.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.saleOrder.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.saleOrder.ShipAddress.Zip = (element3.Element("ZipCode") == null) ? "" : element3.Element("ZipCode").Value;
    //                            this.saleOrder.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            this.saleOrder.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SOLine").Select<XElement, XElement>(delegate(XElement saleline)
    //                        {
    //                            return saleline;
    //                        });
    //                        short liNo = 0;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                this.saleOrder.SalesTaxAmount += Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                this.saleOrder.FreightAmount = Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                            }
    //                            else
    //                            {
    //                                SaleOrderlineItem item = new SaleOrderlineItem(liNo);
    //                                item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                item.QtyOrderd = Convert.ToDecimal(element4.Element("Quantity").Value);
    //                                item.Quantity = item.QtyOrderd;


    //                                item.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element4.Element("SO_Description") == null) ? "" : element4.Element("SO_Description").Value;


    //                                item.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element4.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                item.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                item.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;
    //                                item.DistributionNumber = (element4.Element("DistributionNumber") == null) ? 0 : Convert.ToInt32(element4.Element("DistributionNumber").Value);
    //                                //ItemPriceLevel level = new ItemPriceLevel();
    //                                //if (level.ExportInventoryItemPrices(item.Item.ItemId))
    //                                //{
    //                                //    item.Item.PriceLevels = new ItemPriceLevelsDAL().GetItemPriceLevels(item.Item);
    //                                //}
    //                                Item item2 = new Item();
    //                                item2 = new LocalDBDAL().GetItem(item.Item);
    //                                item.Item.CGSAccount = item2.CGSAccount;
    //                                item.Item.InventoryAccount = item2.InventoryAccount;
    //                                item.Item.ItemClass = item2.ItemClass;
    //                                item.Item.PriceLevels  = item2.PriceLevels;

                                    

    //                                item.Item.MasterStockGUID = item2.MasterStockGUID;
    //                                item.Item.PrimaryAttribute = item2.PrimaryAttribute;
    //                                item.Item.SecondaryAttribute = item2.SecondaryAttribute;


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


                                    
    //                                this.saleOrder.LineItemTotalAmount += item.ExtendedAmount;
    //                                this.saleOrder.LineItems.Add(item);
    //                                liNo = (short)(liNo + 1);
    //                            }
    //                        }
    //                        if (this.saleOrder.SaleOrderNo != "")
    //                        {
                                 
    //                            this.saleOrder.AssignToLineItem(this.saleOrder);
    //                            return this.saleOrder;
    //                        }
    //                    }
    //                }
    //            }
    //            return this.saleOrder;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetOpenSaleOrder");
    //            return this.saleOrder;
    //        }
    //    }

    //    public SaleOrder GetOriginalSaleOrder(SaleOrder so, Customer cus)
    //    {

    //        try
    //        {

    //            List<SaleOrderlineItem> soLnItmsDB = new TransactionLineItemsDAL().GetSaleOrderLineItems(so);
    //            this.SaleOrders = new SaleOrdersForInvoice();
    //            this.peachobj = new PeachtreeSingleTon();
    //            this.saleOrder = new SaleOrder();
    //            if (this.SaleOrders.ExportSaleOrder(cus.Id, this.peachobj.GetFirstDay(), this.peachobj.GetLastDay(), so.SaleOrderNo))
    //            {
    //                IEnumerable<XElement> enumerable = XElement.Load(this.SaleOrders.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate(XElement el)
    //                {
    //                    return el;
    //                });
    //                foreach (XElement element2 in enumerable)
    //                {
    //                    if ((element2.Element("Proposal").Value.ToString().ToUpper() == "FALSE") )
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.CloseSO = Convert.ToBoolean(element2.Element("Closed").Value);
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.ShipbyDate = (element2.Element("Ship_By") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_By").Value);
    //                        this.saleOrder.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleOrder.ShipVia.ShippingMethod = (element2.Element("Ship_VIA") == null) ? "" : element2.Element("Ship_VIA").Value;
    //                        this.saleOrder.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleOrder.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleOrder.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleOrder.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        this.saleOrder.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate(XElement shi)
    //                        {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.saleOrder.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            this.saleOrder.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.saleOrder.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.saleOrder.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.saleOrder.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.saleOrder.ShipAddress.Zip = (element3.Element("ZipCode") == null) ? "" : element3.Element("ZipCode").Value;
    //                            this.saleOrder.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            this.saleOrder.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SOLine").Select<XElement, XElement>(delegate(XElement saleline)
    //                        {
    //                            return saleline;
    //                        });
    //                        short liNo = 0;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                this.saleOrder.SalesTaxAmount += Convert.ToDecimal((double)-1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                this.saleOrder.FreightAmount = Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                            }
    //                            else
    //                            {
    //                                SaleOrderlineItem item = new SaleOrderlineItem(liNo);
    //                                item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double)0.0) : Math.Round((decimal)(Convert.ToDecimal((double)-1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                item.QtyOrderd = Convert.ToDecimal(element4.Element("Quantity").Value);
    //                                item.Quantity = item.QtyOrderd;


    //                                item.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element4.Element("SO_Description") == null) ? "" : element4.Element("SO_Description").Value;


    //                                item.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element4.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                item.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                item.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;
    //                                item.DistributionNumber = (element4.Element("DistributionNumber") == null) ? 0 : Convert.ToInt32(element4.Element("DistributionNumber").Value);
    //                                //ItemPriceLevel level = new ItemPriceLevel();
    //                                //if (level.ExportInventoryItemPrices(item.Item.ItemId))
    //                                //{
    //                                //    item.Item.PriceLevels = new ItemPriceLevelsDAL().GetItemPriceLevels(item.Item);
    //                                //}
    //                                Item item2 = new Item();
    //                                item2 = new LocalDBDAL().GetItem(item.Item);
    //                                item.Item.CGSAccount = item2.CGSAccount;
    //                                item.Item.InventoryAccount = item2.InventoryAccount;
    //                                item.Item.ItemClass = item2.ItemClass;
    //                                item.Item.PriceLevels = item2.PriceLevels;



    //                                item.Item.MasterStockGUID = item2.MasterStockGUID;
    //                                item.Item.PrimaryAttribute = item2.PrimaryAttribute;
    //                                item.Item.SecondaryAttribute = item2.SecondaryAttribute;


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



    //                                this.saleOrder.LineItemTotalAmount += item.ExtendedAmount;
    //                                this.saleOrder.LineItems.Add(item);
    //                                liNo = (short)(liNo + 1);
    //                            }
    //                        }
    //                        if (this.saleOrder.SaleOrderNo != "")
    //                        {

    //                            this.saleOrder.AssignToLineItem(this.saleOrder);
    //                            return this.saleOrder;
    //                        }
    //                    }
    //                }
    //            }
    //            return this.saleOrder;
    //        }
    //        catch (Exception exception)
    //        {
    //            MessageBox.Show(exception.Message, "GetOriginalSaleOrder");
    //            return this.saleOrder;
    //        }
    //    }


    //    public SaleOrder GetSaleOrder(SaleInvoice so)
    //    {
    //        try
    //        {
    //            this.SaleOrders = new SaleOrdersForInvoice();
    //            this.peachobj = new PeachtreeSingleTon();
    //            if (this.SaleOrders.ExportSaleOrder(this.peachobj.GetFirstDay(), this.peachobj.GetLastDay(), so.SaleOrderNo))
    //            {



    //                List<Item> itemsinDB = new LocalDBDAL().GetItems();

    //                IEnumerable<XElement> enumerable = XElement.Load(this.SaleOrders.FileNameXML).Descendants("PAW_SalesOrder").Select<XElement, XElement>(delegate (XElement el) {
    //                    return el;
    //                });


    //                foreach (XElement element2 in enumerable)
    //                {
    //                    string str = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                    if ((str != "") && (str == so.SaleOrderNo))
    //                    {
    //                        this.saleOrder = new SaleOrder();
    //                        this.saleOrder.Customer.Id = element2.Element("Customer_ID").Value;
    //                        this.saleOrder.Customer.Name = (element2.Element("Customer_Name") == null) ? "" : element2.Element("Customer_Name").Value;
    //                        this.saleOrder.SaleOrderNo = (element2.Element("Sales_Order_Number") == null) ? "" : element2.Element("Sales_Order_Number").Value;
    //                        this.saleOrder.CloseSO = Convert.ToBoolean(element2.Element("Closed").Value);
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.TransactionDate = Convert.ToDateTime(element2.Element("Date").Value);
    //                        this.saleOrder.ShipbyDate = (element2.Element("Ship_By") == null) ? DateTime.MinValue : Convert.ToDateTime(element2.Element("Ship_By").Value);
    //                        this.saleOrder.DropShip = Convert.ToBoolean(element2.Element("Drop_Ship").Value);
    //                        this.saleOrder.ShipVia.ShippingMethod = (element2.Element("Ship_VIA") == null) ? "" : element2.Element("Ship_VIA").Value;
    //                        this.saleOrder.QuoteNo = (element2.Element("Quote_Number") == null) ? "" : element2.Element("Quote_Number").Value;
    //                        this.saleOrder.Customer.Term.TermsString = (element2.Element("Displayed_Terms") == null) ? "" : element2.Element("Displayed_Terms").Value;
    //                        this.saleOrder.ARAccount.AccountId = (element2.Element("Accounts_Receivable_Account") == null) ? "" : element2.Element("Accounts_Receivable_Account").Value;
    //                        this.saleOrder.SalesRep.Id = (element2.Element("Sales_Representative_ID") == null) ? "" : element2.Element("Sales_Representative_ID").Value;
    //                        this.saleOrder.DiscountAmount = Convert.ToDecimal(element2.Element("Discount_Amount").Value);
    //                        this.saleOrder.CustomerPO = (element2.Element("Customer_PO") == null) ? "" : element2.Element("Customer_PO").Value;
    //                        this.saleOrder.TransactionGUID = element2.Element("GUID").Value;
    //                        IEnumerable<XElement> enumerable2 = element2.Descendants("ShipToAddress").Select<XElement, XElement>(delegate (XElement shi) {
    //                            return shi;
    //                        });
    //                        foreach (XElement element3 in enumerable2)
    //                        {
    //                            this.saleOrder.ShipAddress.Receipent = (element3.Element("Name") == null) ? "" : element3.Element("Name").Value;
    //                            this.saleOrder.ShipAddress.AddressLine1 = (element3.Element("Line1") == null) ? "" : element3.Element("Line1").Value;
    //                            this.saleOrder.ShipAddress.AddressLine2 = (element3.Element("Line2") == null) ? "" : element3.Element("Line2").Value;
    //                            this.saleOrder.ShipAddress.City = (element3.Element("City") == null) ? "" : element3.Element("City").Value;
    //                            this.saleOrder.ShipAddress.State = (element3.Element("State") == null) ? "" : element3.Element("State").Value;
    //                            this.saleOrder.ShipAddress.Zip = (element3.Element("ZipCode") == null) ? "" : element3.Element("ZipCode").Value;
    //                            this.saleOrder.ShipAddress.Country = (element3.Element("Country") == null) ? "" : element3.Element("Country").Value;
    //                            this.saleOrder.SalesTaxCode.SalestaxId = (element3.Element("Sales_Tax_Code") == null) ? "" : element3.Element("Sales_Tax_Code").Value;
    //                        }
    //                        IEnumerable<XElement> enumerable3 = element2.Descendants("SOLine").Select<XElement, XElement>(delegate (XElement saleline) {
    //                            return saleline;
    //                        });
    //                        short liNo = 1;
    //                        foreach (XElement element4 in enumerable3)
    //                        {
    //                            if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0)
    //                            {
    //                                this.saleOrder.SalesTaxAmount += Convert.ToDecimal((double) -1.0) * Math.Round(Convert.ToDecimal(element4.Element("Amount").Value), 2);
    //                            }
    //                            else if (Convert.ToInt32(element4.Element("Tax_Type").Value) == 0x1a)
    //                            {
    //                                this.saleOrder.FreightAmount = Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                            }
    //                            else
    //                            {
    //                                SaleOrderlineItem item = new SaleOrderlineItem(liNo);
                                    
    //                                item.ExtendedAmount = (element4.Element("Amount") == null) ? Convert.ToDecimal((double) 0.0) : Math.Round((decimal) (Convert.ToDecimal((double) -1.0) * Convert.ToDecimal(element4.Element("Amount").Value)), 2);
    //                                item.Quantity = Convert.ToDecimal(element4.Element("Quantity").Value);

    //                                item.QtyOrderd = item.Quantity;

    //                                item.Item.ItemId = (element4.Element("Item_ID") == null) ? "" : element4.Element("Item_ID").Value;
    //                                item.LineitemDescription = (element4.Element("SO_Description") == null) ? "" : element4.Element("SO_Description").Value;
                                   
    //                                item.Item.GuId = (element4.Element("Item_GUID") == null) ? "" : element4.Element("Item_GUID").Value;
    //                                item.LineitemAccount.AccountId = (element4.Element("GL_Account") == null) ? "" : element4.Element("GL_Account").Value;
    //                                item.LineitemAccount.GuId = (element4.Element("GL_Account_GUID") == null) ? "" : element4.Element("GL_Account_GUID").Value;
    //                                item.LineitemPrice = (element4.Element("Unit_Price") == null) ? Convert.ToDecimal((double) 0.0) : Convert.ToDecimal(element4.Element("Unit_Price").Value);
    //                                item.LineitemTax.Number = (element4.Element("Tax_Type") == null) ? Convert.ToInt16(1) : Convert.ToInt16(element4.Element("Tax_Type").Value);
    //                                item.Item.Weight = (element4.Element("Weight") == null) ? Convert.ToDecimal((double)0.0) : Convert.ToDecimal(element4.Element("Weight").Value);
    //                                item.Item.StockingUMID = (element4.Element("UM_ID") == null) ? "" : element4.Element("UM_ID").Value;
    //                                item.Job.Id = (element4.Element("Job_ID") == null) ? "" : element4.Element("Job_ID").Value;
    //                                item.Job.GuId = (element4.Element("Job_GUID") == null) ? "" : element4.Element("Job_GUID").Value;
    //                                //ItemPriceLevel level = new ItemPriceLevel();
    //                                //if (level.ExportInventoryItemPrices(item.Item.ItemId))
    //                                //{
    //                                //    item.Item.PriceLevels = new ItemPriceLevelsDAL().GetItemPriceLevels(item.Item);
    //                                //}

    //                                if (itemsinDB.Contains(item.Item) == true)
    //                                {
    //                                    item.Item.PriceLevels = itemsinDB[itemsinDB.IndexOf(item.Item)].PriceLevels;
    //                                    item.Item.ItemClass = itemsinDB[itemsinDB.IndexOf(item.Item)].ItemClass;
    //                                    item.Item.PrimaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].PrimaryAttribute;
    //                                    item.Item.MasterStockGUID = itemsinDB[itemsinDB.IndexOf(item.Item)].MasterStockGUID;
    //                                    item.Item.SecondaryAttribute = itemsinDB[itemsinDB.IndexOf(item.Item)].SecondaryAttribute;
    //                                }

    //                                this.saleOrder.LineItemTotalAmount += item.ExtendedAmount;
    //                                this.saleOrder.LineItems.Add(item);
    //                                liNo = (short) (liNo + 1);
    //                            }
    //                        }
    //                        this.saleOrder.AssignToLineItem(this.saleOrder);
    //                        return this.saleOrder;
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
    //}
}

